using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddVenda : Form
    {
        public AddVenda()
        {
            InitializeComponent();
            // Preencher a ComboBox com os valores "N", "C" e "S"
            cboxZona.Items.Add("N");
            cboxZona.Items.Add("C");
            cboxZona.Items.Add("S");

            // Selecionar o primeiro item por padrão
            if (cboxZona.Items.Count > 0)
            {
                cboxZona.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string zona = cboxZona.SelectedItem.ToString();
            string codigoVendedor = txtBoxCodVendedor.Text;
            string codigoProduto = txtBoxCodProdVenda.Text;
            int quantidade;
            decimal valorVenda;
            DateTime dataVenda = DateTime.Now;

            if (int.TryParse(txtQuantidadeVenda.Text, out quantidade) && decimal.TryParse(txtValorVenda.Text, out valorVenda))
            {
                DatabaseManager db = new DatabaseManager();

                // Verificar se o código do vendedor existe
                string queryVendedor = "SELECT COUNT(1) FROM Vendedores WHERE Codigo = @CodigoVendedor";
                SqlParameter paramVendedor = new SqlParameter("@CodigoVendedor", codigoVendedor);
                bool vendedorExiste = (int)db.SelectDataTableWArgs(queryVendedor, paramVendedor).Rows[0][0] > 0;

                // Verificar se o código do produto existe
                string queryProduto = "SELECT COUNT(1) FROM Produtos WHERE Codigo = @CodigoProduto";
                SqlParameter paramProduto = new SqlParameter("@CodigoProduto", codigoProduto);
                bool produtoExiste = (int)db.SelectDataTableWArgs(queryProduto, paramProduto).Rows[0][0] > 0;

                if (vendedorExiste && produtoExiste)
                {
                    // Inserir os dados da venda
                    string queryInsert = "INSERT INTO Vendas (Zona, CodigoVendedor, CodigoProduto, Quantidade, Valor, DataVenda) " +
                                         "VALUES (@Zona, @CodigoVendedor, @CodigoProduto, @Quantidade, @Valor, @DataVenda)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@Zona", zona),
                        new SqlParameter("@CodigoVendedor", codigoVendedor),
                        new SqlParameter("@CodigoProduto", codigoProduto),
                        new SqlParameter("@Quantidade", quantidade),
                        new SqlParameter("@Valor", valorVenda),
                        new SqlParameter("@DataVenda", dataVenda)
                    };
                    db.NonQueryWArgs(queryInsert, parameters);

                    MessageBox.Show("Dados da venda inseridos com sucesso!");
                    this.Close(); // Fechar o formulário após salvar
                }
                else
                {
                    if (!vendedorExiste)
                        MessageBox.Show("Código do Vendedor não existe!");

                    if (!produtoExiste)
                        MessageBox.Show("Código do Produto não existe!");
                }
            }
            else
            {
                MessageBox.Show("Quantidade ou Valor da Venda inválidos!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
