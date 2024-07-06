using System;
using System.Collections.Generic;
using DAL;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class PermissaoDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public List<KeyValuePair<int, string>> ObterTodasPermissoes()
        {
            var permissoes = new List<KeyValuePair<int, string>>();
            try
            {
                mConn.AbrirConexao();
                string query = "SELECT Id, NomePermissao FROM tb_permissoes";
                using (var cmd = new MySqlCommand(query, mConn.AbrirConexao()))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            permissoes.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
            }
            finally
            {
                mConn.FecharConexao();
            }
            return permissoes;
        }

        public List<KeyValuePair<int, string>> ObterPermissoesUsuario(int userId)
        {
            var permissoes = new List<KeyValuePair<int, string>>();
            try
            {
                mConn.AbrirConexao();
                string query = @"SELECT p.Id, p.NomePermissao FROM tb_permissoes p
                                 JOIN tb_cargo_permissao cp ON p.Id = cp.PermissaoId
                                 JOIN tb_usuarios u ON cp.Cargo = u.Cargo
                                 WHERE u.Id = @userId";
                using (var cmd = new MySqlCommand(query, mConn.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            permissoes.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
            }
            finally
            {
                mConn.FecharConexao();
            }
            return permissoes;
        }

        public void AtribuirPermissao(int userId, int permissaoId)
        {
            try
            {
                mConn.AbrirConexao();
                string query = @"INSERT INTO tb_cargo_permissao (Cargo, PermissaoId)
                                 SELECT Cargo, @permissaoId FROM tb_usuarios WHERE Id = @userId";
                using (var cmd = new MySqlCommand(query, mConn.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@permissaoId", permissaoId);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                mConn.FecharConexao();
            }
        }

        public void RemoverPermissao(int userId, int permissaoId)
        {
            try
            {
                mConn.AbrirConexao();
                string query = @"DELETE FROM tb_cargo_permissao 
                                 WHERE Cargo = (SELECT Cargo FROM tb_usuarios WHERE Id = @userId)
                                 AND PermissaoId = @permissaoId";
                using (var cmd = new MySqlCommand(query, mConn.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@permissaoId", permissaoId);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                mConn.FecharConexao();
            }
        }
    }
}
