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

        private void AlterarVenda_Load(object sender, EventArgs e)
        {
            // Preencher a ComboBox da Zona
            cboxAlterarZona.Items.Add("N");
            cboxAlterarZona.Items.Add("C");
            cboxAlterarZona.Items.Add("S");

            
            DatabaseManager db = new DatabaseManager();

            try
            {
                // Selecionar todos os códigos de venda da tabela "Vendas"
                DataTable dtVendas = db.SelectDataTable("SELECT Codigo FROM Vendas");

                // Preencher a ComboBox com os códigos de venda
                foreach (DataRow row in dtVendas.Rows)
                {
                    cboxAlterarCodVenda.Items.Add(row["Codigo"].ToString());
                }

                // Verificação para garantir que há itens na ComboBox
                if (cboxAlterarCodVenda.Items.Count == 0)
                {
                    MessageBox.Show("Nenhuma venda encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar códigos das vendas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboxAlterarCodVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoVenda = cboxAlterarCodVenda.SelectedItem.ToString();

            DatabaseManager db = new DatabaseManager();

            try
            {
                // Selecionar os dados da venda pelo código
                string querySelect = "SELECT Zona, CodigoVendedor, CodigoProduto, Quantidade, Valor FROM Vendas WHERE Codigo = @Codigo";
                DataTable dtVenda = db.SelectDataTableWArgs(querySelect, new SqlParameter("@Codigo", codigoVenda));

                if (dtVenda.Rows.Count > 0)
                {
                    DataRow row = dtVenda.Rows[0];
                    cboxAlterarZona.SelectedItem = row["Zona"].ToString();
                    txtBoxAlterarCodVendedor.Text = row["CodigoVendedor"].ToString();
                    txtBoxAlterarCodProdVenda.Text = row["CodigoProduto"].ToString();
                    txtBoxAlterarQuantidadeVenda.Text = row["Quantidade"].ToString();
                    txtBoxAlterarValorVenda.Text = row["Valor"].ToString();
                }
                else
                {
                    MessageBox.Show("Venda não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados da venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
