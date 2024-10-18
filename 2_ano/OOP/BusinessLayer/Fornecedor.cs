using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Fornecedor
    {
        public static FornecedorCollection ObterLista()
        {
            string connectionString = Properties.Settings.Default.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = new SqlCommand();
        }
    }
}
