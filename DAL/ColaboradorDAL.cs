using Dapper;
using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class ColaboradorDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void InserirColaborador(Colaborador colaborador, string emailUsuarioLogado)
        {
            string senhaNaoCriptografada = colaborador.SenhaColaborador;
            string senhaCriptografada = HashPassword(senhaNaoCriptografada);
            colaborador.SenhaHash = senhaCriptografada;

            sql = "INSERT INTO tb_colaborador(Nome, Email, Telefone, Senha, IdCargo) VALUES " +
                  "(@NomeColaborador, @EmailColaborador, @TelefoneColaborador, @SenhaHash, @IdCargo)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@NomeColaborador", colaborador.NomeColaborador);
            cmd.Parameters.AddWithValue("@EmailColaborador", colaborador.EmailColaborador);
            cmd.Parameters.AddWithValue("@TelefoneColaborador", colaborador.TelefoneColaborador);
            cmd.Parameters.AddWithValue("@SenhaHash", colaborador.SenhaHash);
            cmd.Parameters.AddWithValue("@IdCargo", colaborador.IdCargo);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();

            // Inserir o registro de log na tabela tb_logs
            DateTime dataHoraAcao = DateTime.Now;
            string tipoOperacao = "Cadastro de colaborador";

            sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
            cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
            cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }

        public bool VerificarEmailColaborador(string email)
        {
            bool emailExists = false;
            string sql = "SELECT COUNT(*) FROM tb_colaborador WHERE Email = @Email";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    emailExists = count > 0;
                }
            }
            return emailExists;
        }

        public void UpdateColaborador(Colaborador colaborador)
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                string query = "UPDATE tb_colaborador SET Nome = @NomeColaborador, Email = @EmailColaborador, Telefone = @TelefoneColaborador WHERE Id = @IdColaborador";
                dbConnection.Execute(query, colaborador);
            }
        }

        private string HashPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password), "A senha não pode ser nula.");
            }

            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            return hashedPassword;
        }

        public int ObterIdColaboradorPorNome(string nomeColaborador)
        {
            int idColaborador = -1;

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                string query = "SELECT Id FROM tb_colaborador WHERE Nome = @NomeColaborador";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NomeColaborador", nomeColaborador);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idColaborador = Convert.ToInt32(result);
                }
            }
            return idColaborador;
        }

        public List<Colaborador> GetColaboradoresAtivosComSetor()
        {
            List<Colaborador> colaboradores = new List<Colaborador>();

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                string query = "SELECT c.Id, c.Nome, c.Email, c.Telefone, ca.Cargo AS NomeCargo " +
                               "FROM tb_colaborador c " +
                               "INNER JOIN tb_cargo ca ON c.IdCargo = ca.Id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Colaborador colaborador = new Colaborador
                            {
                                IdColaborador = (int)reader["Id"],
                                NomeColaborador = reader["Nome"].ToString(),
                                EmailColaborador = reader["Email"].ToString(),
                                TelefoneColaborador = reader["Telefone"].ToString(),
                                NomeCargo = reader["NomeCargo"].ToString() // Adicione esta linha
                            };

                            colaboradores.Add(colaborador);
                        }
                    }
                }
            }
            return colaboradores;
        }

        public bool VerificarNome(string nomeColab)
        {
            bool nomeExists = false;
            string sql = "SELECT COUNT(*) FROM tb_colaborador WHERE Nome = @NomeColaborador";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@NomeColaborador", nomeColab);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    nomeExists = count > 0;
                }
            }
            return nomeExists;
        }

        public Colaborador ObterColaboradorPorID(int idColaborador)
        {
            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                string query = "SELECT * FROM tb_colaborador WHERE Id = @IdColaborador";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdColaborador", idColaborador);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Colaborador colaborador = new Colaborador
                        {
                            IdColaborador = Convert.ToInt32(reader["Id"]),
                            NomeColaborador = reader["Nome"].ToString(),
                            EmailColaborador = reader["Email"].ToString(),
                            TelefoneColaborador = reader["Telefone"].ToString(),
                            IdCargo = Convert.ToInt32(reader["IdCargo"])
                        };
                        return colaborador;
                    }
                    return null; // Se não encontrou o colaborador
                }
            }
        }

        public DataTable ConsultarColaborador()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Id, Nome FROM tb_colaborador";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
    }
}
