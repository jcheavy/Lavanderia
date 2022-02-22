using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Lavanderia
{
    class Connection
    {

        private const string server = "localhost";
        private const string user = "jean";
        private const string password = "jean";
        private const string database = "lavanderia";

        private MySqlConnection con;
        private MySqlDataAdapter dtadatper;
        private MySqlDataReader dtreader;
        private MySqlCommandBuilder comandbuilder;
        private DataTable data;

        public void Connectar()
        {
            if(con != null)
            {
                string connStr = String.Format("server={0}; user id={1}; password={2}; database=[{3}; pooling=false", server, user, password, database);

                try
                {
                    con = new MySqlConnection(connStr);
                    con.Open();
                }
                catch(MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void excuQuery(string strigSql)
        {
            MySqlCommand commad = new MySqlCommand(strigSql, con);
            commad.ExecuteNonQuery();
            con.Close();
        }

        public System.Data.DataTable getDataTable(string sqlDatatabe)
        {
            data = new DataTable();
            dtadatper = new MySqlDataAdapter(sqlDatatabe, con);
            comandbuilder = new  MySqlCommandBuilder(dtadatper);
            dtadatper.Fill(data);
            return data;
        }

        public MySqlDataReader getDataReader(string stingDtReader)
        {
            MySqlCommand commad = new MySqlCommand(stingDtReader, con);
            MySqlDataReader dtReader = commad.ExecuteReader();
            dtReader.Read();
            return dtReader;
        }
  
    }
}
