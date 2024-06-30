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
                DataTable dtProdutos = db.SelectDataTable("SELECT Nome FROM Produtos");

                // Preencher a ComboBox com os nomes dos produtos
                foreach (DataRow row in dtProdutos.Rows)
                {
                    cboxNomeEliminar.Items.Add(row["Nome"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar nomes dos produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarDados_Click(object sender, EventArgs e)
        {
            // Obter o nome selecionado na ComboBox
            string nomeProduto = cboxNomeEliminar.SelectedItem?.ToString();

            // Validação básica
            if (string.IsNullOrEmpty(nomeProduto))
            {
                MessageBox.Show("Por favor, selecione um nome de produto para eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Instância do gerenciador da base de dados
            DatabaseManager db = new DatabaseManager();

            try
            {
                // Verificar se o produto existe
                string querySelect = "SELECT * FROM Produtos WHERE Nome = @Nome";
                DataTable dtProduto = db.SelectDataTableWArgs(querySelect, new SqlParameter("@Nome", nomeProduto));

                if (dtProduto.Rows.Count > 0)
                {
                    // Produto encontrado, realizar a exclusão
                    string queryDelete = "DELETE FROM Produtos WHERE Nome = @Nome";
                    db.NonQueryWArgs(queryDelete, new SqlParameter("@Nome", nomeProduto));
                    MessageBox.Show("Produto eliminado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fechar o formulário RemoveProduct
                    this.Close();
                }
                else
                {
                    // Produto não encontrado
                    MessageBox.Show("Produto não encontrado. Verifique o nome e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
