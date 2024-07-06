using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;

namespace DAL
{
    public class ConexaoDB
    {
        public MySqlConnection mConn;

        public string conec = "server=localhost;database=bd_conselho;user=root;password=1234;";

        public MySqlConnection AbrirConexao()
        { 
            mConn = new MySqlConnection(conec);
            mConn.Open();

            return mConn;
        }
        public void FecharConexao()
        {
            mConn = new MySqlConnection(conec);
            mConn.Clone();
            mConn.Dispose();
            mConn.ClearAllPoolsAsync();
        }
    }
}
