using Lavanderia.Exceptions;
using Lavanderia.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavanderia.DAO
{
    class EnderecoDAO
    {
        Connection conn = new Connection();
        public void inserir(Endereco endereco)
        {
            try
            {
                string  strsql = "INSERT INTO()VALUES()";
                conn.Connectar();
                conn.excuQuery(strsql);
            }
            catch(MySqlException e)
            {               
                MessageBox.Show(e.Message);
            }
           
        }
    }
}
