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
        #region
        public string NomeFornecedor { get; set; }

        public int CodigoFornecedor { get; set; }

        public static Fornecedor ObterCodigoFornecedor(int codigoFornecedor)
        {
            DataTable dataTable = DataLayer.Fornecedor.ObterCodigoFornecedor(codigoFornecedor);

            Fornecedor fornecedor = null;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];

                if (dataRow != null)
                {
                    Fornecedor fornecedor1 = new Fornecedor();

                    fornecedor.CodigoFornecedor = dataRow.Field<int>("CodigoFornecedor");
                    fornecedor.NomeFornecedor = dataRow.Field<string>("NomeFornecedor");
                }
            }
        }
        #endregion


    }
}
