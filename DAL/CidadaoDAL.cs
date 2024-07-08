using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using model;

namespace DAL
{
    public class CidadaoDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void InserirCidadao(Cidadao cidadao)
        {
            // Inserir o novo cidadão na tabela tb_clientes
            sql = "INSERT INTO tb_clientes (Nome, Idade, Telefone, Email, IdFamilia) VALUES (@NomeCidadao, @IdadeCidadao, @TelefoneCidadao, @EmailCidadao, @IdFamiliaCidadao)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@NomeCidadao", cidadao.nomeCidadao);
            cmd.Parameters.AddWithValue("@IdadeCidadao", cidadao.IdadeCidadao);
            cmd.Parameters.AddWithValue("@TelefoneCidadao", cidadao.telefoneCidadao);

            // Verifica se o e-mail foi fornecido
            if (string.IsNullOrEmpty(cidadao.emailCidadao))
            {
                cmd.Parameters.AddWithValue("@EmailCidadao", DBNull.Value); // Define como DBNull se for nulo
            }
            else
            {
                cmd.Parameters.AddWithValue("@EmailCidadao", cidadao.emailCidadao);
            }

            cmd.Parameters.AddWithValue("@IdFamiliaCidadao", cidadao.IdFamiliaCidadao);

            cmd.ExecuteNonQuery();

            // Fechar a conexão após a execução
            mConn.FecharConexao();
        }


        public bool VerificarCidadao(int idCidadao)
        {
            string sql = "SELECT COUNT(*) FROM tb_clientes WHERE Id = @IdCidadao";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                int count = connection.ExecuteScalar<int>(sql, new { idCidadao });
                return count > 0;
            }
        }

        public bool VerificarEmail(string email)
        {
            string sql = "SELECT COUNT(*) FROM tb_clientes WHERE Email = @EmailCidadao";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                int count = connection.ExecuteScalar<int>(sql, new { email });
                return count > 0;
            }
        }

        public Cidadao ObterCidadao(int idCidadao)
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                string query = "SELECT * FROM tb_clientes WHERE Id = @IdCidadao";
                return dbConnection.QueryFirstOrDefault<Cidadao>(query, new { idCidadao });
            }
        }

        public int ObterIdFamiliaPorNome(string nomeFamilia)
        {
            int idFamilia = 0;

            using (MySqlConnection conn = mConn.AbrirConexao())
            {
                string query = "SELECT Id FROM tb_familias WHERE Nome = @Nome";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeFamilia);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idFamilia = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }

                conn.Close();
            }

            return idFamilia;
        }

        public List<Cidadao> GetCidadaosComFamilia()
        {
            List<Cidadao> cidadaos = new List<Cidadao>();

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                string query = "SELECT c.Id, c.Nome, c.Idade, c.Telefone, c.Email, f.Sobrenome AS NomeFamilia " +
                               "FROM tb_clientes c " +
                               "INNER JOIN tb_familias f ON c.IdFamilia = f.Id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cidadao cidadao = new Cidadao
                            {
                                IdCidadao = reader.GetInt32("Id"),
                                NomeCidadao = reader["Nome"].ToString(),
                                IdadeCidadao = reader.GetInt32("Idade"),
                                TelefoneCidadao = reader["Telefone"].ToString(),
                                EmailCidadao = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader["Email"].ToString(),
                                NomeFamilia = reader["NomeFamilia"].ToString()
                            };

                            cidadaos.Add(cidadao);
                        }
                    }
                }
            }

            return cidadaos;
        }


        public void AtualizarCidadao(Cidadao cidadao)
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                string query = "UPDATE tb_clientes SET Nome = @NomeCidadao, Idade = @IdadeCidadao, Telefone = @TelefoneCidadao, Email = @EmailCidadao WHERE Id = @IdCidadao";
                dbConnection.Execute(query, cidadao);
            }
        }

        public List<Cidadao> GetCidadaos()
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                string query = "SELECT Id, Nome, Idade, Telefone, Email, IdFamilia FROM tb_clientes";
                return dbConnection.Query<Cidadao>(query).AsList();
            }
        }
    }
}
