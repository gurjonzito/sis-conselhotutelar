using model;

public class LoginBLL
{
    private LoginDAL loginDAL;

    public LoginBLL()
    {
        loginDAL = new LoginDAL();
    }

    public bool ValidarUsuarioSenha(Login login)
    {
        if (string.IsNullOrEmpty(login.Username) || string.IsNullOrEmpty(login.Senha))
        {
            return false;
        }

        string senhaHash = loginDAL.ObterSenhaHash(login.Username);

        if (senhaHash == null)
        {
            return false;
        }

        return BCrypt.Net.BCrypt.Verify(login.Senha, senhaHash);
    }
}
