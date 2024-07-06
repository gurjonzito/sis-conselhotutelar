using BCrypt.Net;
using DAL;
using MySql.Data.MySqlClient;

public class LoginDAL
{
    ConexaoDB mConn = new ConexaoDB();
    string sql;
    MySqlCommand cmd;

    public string ObterSenhaHash(string username)
    {
        string senhaHash = null;

        using (MySqlConnection conn = mConn.AbrirConexao())
        {
            string query = "SELECT Senha FROM tb_colaborador WHERE Username = @Username";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        senhaHash = reader["Senha"].ToString();
                    }
                }
            }

            conn.Close();
        }

        return senhaHash;
    }
}
