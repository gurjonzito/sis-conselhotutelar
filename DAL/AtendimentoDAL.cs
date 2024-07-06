using Dapper;
using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AtendimentoDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void InserirAtendimento(Atendimento atendimento, string emailUsuarioLogado)
        {

            sql = "INSERT INTO tb_atendimentos(Codigo, IdCliente, IdAtendente) VALUES " +
                    "(@Codigo, @IdCliente, @IdAtendente)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@codigo", atendimento.Codigo);
            cmd.Parameters.AddWithValue("@idCliente", atendimento.idCliente);
            cmd.Parameters.AddWithValue("@idAtendente", atendimento.idAtendente);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();

            //Obtem o ID do equipamento cadastrado por último
            int novoAtendimentoID = Convert.ToInt32(cmd.LastInsertedId);
            // Inserir o registro de log na tabela tb_logs
            /*DateTime dataHoraAcao = DateTime.Now;
            string tipoOperacao = "Cadastro do atendimento";
            string mensagem = $"{tipoOperacao}: {atendimento.Codigo}";

            sql = "INSERT INTO tb_logs(IDUsuario, EmailUsuario, DataHoraAcao, TipoOperacao, Mensagem) VALUES (@IDUsuario, @EmailUsuario, @DataHoraAcao, @TipoOperacao, @Mensagem)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@IDUsuario", novoAtendimentoID);
            cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
            cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
            cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);
            cmd.Parameters.AddWithValue("@Mensagem", mensagem);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();*/
        }

        public bool VerificarCodigo(String verifcodigo)
        {
            bool codigoExists = false;
            string sql = "SELECT COUNT(*) FROM tb_atendimentos WHERE Codigo = @codigo";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@codigo", verifcodigo);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        codigoExists = true;
                    }
                }
            }
            return codigoExists;
        }

        public List<Atendimento> GetAtendimentos()
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                return dbConnection.Query<Atendimento>("SELECT Id, Codigo, IdCliente, IdAtendente FROM tb_atendimentos").ToList();
            }
        }

        /*public void UpdateAtendimentos(Atendimento atendimento, string emailUsuarioLogado)
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {

                string query = "UPDATE tb_equipamentos SET Nome_Equipamento = @Nome, Valor = @Valor, Descricao = @Descricao  WHERE ID_equipamento = @ID_equipamento";
                dbConnection.Execute(query, atendimento);

                // Inserção de log
                /*DateTime dataHoraAcao = DateTime.Now;
                string tipoOperacao = "atualização de equipamento"; // Defina o tipo de operação conforme necessário

                string sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
                MySqlCommand cmd = new MySqlCommand(sql, mConn.AbrirConexao());

                cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
                cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
                cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

                cmd.ExecuteNonQuery();
                mConn.FecharConexao();
            }*/

    public List<Atendimento> GetAtendimentosRelatorio()
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {

                return dbConnection.Query<Atendimento>("SELECT Codigo FROM tb_atendimentos").ToList();
            }
        }

        public List<Atendimento> ObterAtendimentosPorColaborador(int idColaborador)
        {
            List<Atendimento> atendimentos = new List<Atendimento>();

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                string query = "SELECT * FROM tb_atendimentos WHERE idAtendente = @idColaborador";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idColaborador", idColaborador);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Atendimento atendimento = new Atendimento
                        {
                            idAtendimento = Convert.ToInt32(reader["Id"]),
                            codigo = reader["Codigo"].ToString(),
                            idCliente = reader["idCliente"].ToString(),
                            idAtendente = reader["idAtendente"].ToString(),
                            // Adicione outros campos conforme necessário
                        };
                        atendimentos.Add(atendimento);
                    }
                }
            }

            return atendimentos;
        }
    }
}