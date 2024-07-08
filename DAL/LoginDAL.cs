using BCrypt.Net;
using DAL;
using MySql.Data.MySqlClient;

public class LoginDAL
{
    ConexaoDB mConn = new ConexaoDB();
    string sql;
    MySqlCommand cmd;

    public bool ValidarUserLogin(String user)
    {
        bool userExists = false;
        string sql = "SELECT COUNT(*) FROM tb_colaborador WHERE Username = @Username";

        using (MySqlConnection conn = mConn.AbrirConexao())
        {
            using (MySqlCommand command = new MySqlCommand(sql, conn))
            {
                command.Parameters.AddWithValue("@Username", user);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    userExists = true;
                }
            }

            conn.Close();
        }
        return userExists;
    }

    public bool ValidarSenhaLogin(String senha)
    {
        bool senhaExists = false;
        string sql = "SELECT COUNT(*) FROM tb_colaborador WHERE Senha = @Senha";

        using (MySqlConnection conn = mConn.AbrirConexao())
        {
            using (MySqlCommand command = new MySqlCommand(sql, conn))
            {
                command.Parameters.AddWithValue("Senha", senha);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    senhaExists = true;
                }
            }

            conn.Close();
        }
        return senhaExists;
    }
}
