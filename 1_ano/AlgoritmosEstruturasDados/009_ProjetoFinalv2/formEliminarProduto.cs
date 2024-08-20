using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009___Projeto_Final
{
    public partial class formEliminarProduto : Form
    {
        public formEliminarProduto()
        {
            InitializeComponent();
        }
        private void RemoveProduct_Load(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();

            try
            {
                // Selecionar todos os nomes de produtos da tabela "Produtos"
                DataTable dtProdutos = db.SelectDataTable("SELECT Codigo FROM Produtos");

                // Preencher a ComboBox com os nomes dos produtos
                foreach (DataRow row in dtProdutos.Rows)
                {
                    cboxNomeEliminar.Items.Add(row["Codigo"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os codigos dos produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarDados_Click(object sender, EventArgs e)
        {
            // Obter o nome selecionado na ComboBox
            string codigoProduto = cboxNomeEliminar.SelectedItem?.ToString();

            // Validação básica
            if (string.IsNullOrEmpty(codigoProduto))
            {
                MessageBox.Show("Por favor, selecione um nome de produto para eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Instância do gerenciador da base de dados
            DatabaseManager db = new DatabaseManager();

            try
            {
                // Verificar se o produto existe
                string querySelect = "SELECT * FROM Produtos WHERE Codigo = @Codigo";
                DataTable dtProduto = db.SelectDataTableWArgs(querySelect, new SqlParameter("@codigo", codigoProduto));

                if (dtProduto.Rows.Count > 0)
                {
                    // Produto encontrado, realizar a exclusão
                    string queryDelete = "DELETE FROM Produtos WHERE Codigo = @Codigo";
                    db.NonQueryWArgs(queryDelete, new SqlParameter("@Codigo", codigoProduto));
                    MessageBox.Show("Produto eliminado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fechar o formulário RemoveProduct
                    this.Close();
                }
                else
                {
                    // Produto não encontrado
                    MessageBox.Show("Produto não encontrado. Verifique o código e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult respostaForm;
            respostaForm = MessageBox.Show("Queres mesmo sair?", "!!ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respostaForm == DialogResult.Yes)
                Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
