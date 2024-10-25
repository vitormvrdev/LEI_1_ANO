using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static bool Obter(int codigoFornecedor, ref string nomeFornecedor, out string erro)
    {
        bool resultado = false;
        erro = string.Empty;


        return false;
    }

    public class Fornecedor
    {
        public static DataTable ObterCodigoFornecedor(int codigoFornecedor)
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
                sqlCommand.CommandText = "Fornecedor_Obter";

                SqlParameter sqlParameter = new SqlParameter("CodigoFornecedor", SqlDbType.Int);

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