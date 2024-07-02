using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _009___Projeto_Final
{
    public partial class formAlterarVenda : Form
    {
        public formAlterarVenda()
        {
            InitializeComponent();
        }

        private void formAlterarVenda_Load(object sender, EventArgs e)
        {
            // Preencher a ComboBox da Zona
            cboxAlterarZona.Items.Add("N");
            cboxAlterarZona.Items.Add("C");
            cboxAlterarZona.Items.Add("S");

            // SELECT Codigo FROM Vendas
            try
            {
                DatabaseManager db = new DatabaseManager();
                DataTable dtVenda = db.SelectDataTable("SELECT Codigo FROM Vendas");

                // Verificar se a DataTable contém dados
                Console.WriteLine($"Número de linhas retornadas: {dtVenda.Rows.Count}");

                cboxAlterarCodVenda.Items.Clear();

                foreach (DataRow row in dtVenda.Rows)
                {
                    cboxAlterarCodVenda.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboxAlterarCodVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoVenda = cboxAlterarCodVenda.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(codigoVenda))
            {
                DatabaseManager db = new DatabaseManager();

                try
                {
                    // Selecionar os dados do produto
                    string query = "SELECT Zona, CodigoVendador, CodigoProduto, Quantidade, Valor FROM Produtos WHERE Codigo = @Codigo";
                    DataTable dtVenda = db.SelectDataTableWArgs(query, new SqlParameter("@Codigo", codigoVenda));

                    if (dtVenda.Rows.Count > 0)
                    {
                        DataRow row = dtVenda.Rows[0];
                        cboxAlterarZona.Text = row["Zona"].ToString();
                        txtBoxAlterarCodVendedor.Text = row["CodigoVendedor"].ToString();
                        txtBoxAlterarCodProdVenda.Text = row["CodigoProduto"].ToString();
                        txtBoxAlterarQuantidadeVenda.Text = row["Quantidade"].ToString();
                        txtBoxAlterarValorVenda.Text = row["Valor"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar dados do produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterarVenda_Click(object sender, EventArgs e)
        {
            string codigoVenda = cboxAlterarCodVenda.SelectedItem?.ToString();
            string zona = cboxAlterarZona.SelectedItem?.ToString();
            string codigoVendedor = txtBoxAlterarCodVendedor.Text;
            string codigoProduto = txtBoxAlterarCodProdVenda.Text;
            int quantidade;
            decimal valorVenda;

            // Validação básica
            if (string.IsNullOrEmpty(codigoVenda))
            {
                MessageBox.Show("Por favor, selecione um código de venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(zona))
            {
                MessageBox.Show("Por favor, selecione uma zona.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBoxAlterarQuantidadeVenda.Text, out quantidade))
            {
                MessageBox.Show("Quantidade inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtBoxAlterarValorVenda.Text, out valorVenda))
            {
                MessageBox.Show("Valor da venda inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatabaseManager db = new DatabaseManager();

            try
            {
                // Atualizar os dados da venda
                string queryUpdate = "UPDATE Vendas SET Zona = @Zona, CodigoVendedor = @CodigoVendedor, CodigoProduto = @CodigoProduto, Quantidade = @Quantidade, Valor = @Valor WHERE Codigo = @Codigo";
                SqlParameter[] parameters = {
                    new SqlParameter("@Zona", zona),
                    new SqlParameter("@CodigoVendedor", codigoVendedor),
                    new SqlParameter("@CodigoProduto", codigoProduto),
                    new SqlParameter("@Quantidade", quantidade),
                    new SqlParameter("@Valor", valorVenda),
                    new SqlParameter("@Codigo", codigoVenda)
                };

                db.NonQueryWArgs(queryUpdate, parameters);
                MessageBox.Show("Venda alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
