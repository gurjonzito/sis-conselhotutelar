using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using model;

namespace DAL
{
    public class UserDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void InserirUsuario(Usuario usuario)
        {
            string senhaNaoCriptografada = usuario.Senha;
            string senhaCriptografada = HashPassword(senhaNaoCriptografada);
            usuario.Senha = senhaCriptografada;

            // Inserir o novo usuário na tabela tb_colaborador
            sql = "INSERT INTO tb_colaborador (Nome, Username, Email, Telefone, Senha, IdCargo) VALUES (@Nome, @Username, @Email, @Telefone, @Senha, @IdCargo)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@Username", usuario.User);
            cmd.Parameters.AddWithValue("@Email", usuario.Email);
            cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@IdCargo", usuario.Cargo);

            cmd.ExecuteNonQuery();

            // Fechar a conexão após a execução
            mConn.FecharConexao();
        }

        public string HashPassword(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            return BCrypt.Net.BCrypt.HashPassword(password, salt);
        }

        public bool VerificarUser(string usuario)
        {
            string sql = "SELECT COUNT(*) FROM tb_colaborador WHERE Username = @usuario";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                int count = connection.ExecuteScalar<int>(sql, new { usuario });
                return count > 0;
            }
        }

        public bool VerificarEmail(string email)
        {
            string sql = "SELECT COUNT(*) FROM tb_colaborador WHERE Email = @Email";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                int count = connection.ExecuteScalar<int>(sql, new { email });
                return count > 0;
            }
        }

        public Usuario ObterUsuario(string usuario)
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                string query = "SELECT * FROM tb_colaborador WHERE Username = @usuario";
                return dbConnection.QueryFirstOrDefault<Usuario>(query, new { usuario });
            }
        }

        public int ObterUserChamado(string usuario)
        {
            sql = "SELECT Id FROM tb_colaborador WHERE Username = @usuario";

            cmd = new MySqlCommand(sql, mConn.AbrirConexao());
            cmd.Parameters.AddWithValue("@usuario", usuario);
            var result = cmd.ExecuteScalar();
            mConn.FecharConexao();

            return result == DBNull.Value ? -1 : Convert.ToInt32(result);
        }

        public string ObterSenhaCriptografada(string usuario)
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                string query = "SELECT Senha FROM tb_colaborador WHERE Username = @usuario";
                return dbConnection.ExecuteScalar<string>(query, new { usuario });
            }
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                string query = "UPDATE tb_colaborador SET Nome = @Nome, Username = @Username, Email = @Email, Telefone = @Telefone, IdCargo = @IdCargo WHERE Id = @Id";
                dbConnection.Execute(query, usuario);
            }
        }

        public List<Usuario> GetUsuarios()
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                string query = "SELECT Id, Nome, Username, Email, Telefone, Senha, IdCargo FROM tb_colaborador";
                return dbConnection.Query<Usuario>(query).AsList();
            }
        }
    }
}
