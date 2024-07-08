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
            sql = "INSERT INTO tb_clientes (Nome, Idade, Telefone, Email) VALUES (@NomeCidadao, @IdadeCidadao, @TelefoneCidadao, @EmailCidadao)";
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
                string query = "SELECT Id, Nome, Idade, Telefone, Email FROM tb_clientes";
                return dbConnection.Query<Cidadao>(query).AsList();
            }
        }
    }
}
