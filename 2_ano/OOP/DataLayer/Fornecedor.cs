using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Fornecedor
    {
        public static DataTable ObterCodigoFornecedor(int codigoFornecedor)
        {
            throw new NotImplementedException();
        }

        public static DataTable ObterLista()
        {
            DataTable dataTable = null;

			try
			{
				string connectionString = Properties.Settings.Default.ConnectionString;
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				sqlConnection.Open();

				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = sqlConnection;
				sqlCommand.CommandType = CommandType.StoredProcedure;

				SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);

				dataTable = new DataTable();
				dataTable.Load(dataReader);

				sqlCommand.Dispose();
				sqlConnection.Close();

			}
			catch (Exception)
			{

				throw;
			}
			return dataTable;
        }
	}
}