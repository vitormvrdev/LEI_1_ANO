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
    public partial class formAlterarProduto : Form
    {
        public formAlterarProduto()
        {
            InitializeComponent();

            // Adiciona os eventos aos controles
            btnVoltar.Click += new EventHandler(btnVoltar_Click);
            btnAlterar.Click += new EventHandler(btnAlterar_Click);
            cboxNomeAlterar.SelectedIndexChanged += new EventHandler(cboxNomeAlterar_SelectedIndexChanged);

            // Carrega os nomes dos produtos ao iniciar o formulário
            this.Load += new EventHandler(AlterarProduto_Load);
        }

        private void AlterarProduto_Load(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();

            try
            {
                // Selecionar todos os nomes de produtos da tabela "Produtos"
                DataTable dtProdutos = db.SelectDataTable("SELECT Nome FROM Produtos");

                // Preencher a ComboBox com os nomes dos produtos
                foreach (DataRow row in dtProdutos.Rows)
                {
                    cboxNomeAlterar.Items.Add(row["Nome"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar nomes dos produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboxNomeAlterar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obter o nome selecionado na ComboBox
            string nomeProduto = cboxNomeAlterar.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(nomeProduto))
            {
                DatabaseManager db = new DatabaseManager();

                try
                {
                    // Selecionar os dados do produto
                    string query = "SELECT Codigo, Nome, Categoria, Preco FROM Produtos WHERE Nome = @Nome";
                    DataTable dtProduto = db.SelectDataTableWArgs(query, new SqlParameter("@Nome", nomeProduto));

                    if (dtProduto.Rows.Count > 0)
                    {
                        DataRow row = dtProduto.Rows[0];
                        txtBoxCodigo.Text = row["Codigo"].ToString();
                        txtBoxCategoria.Text = row["Categoria"].ToString();
                        txtBoxPreco.Text = row["Preco"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar dados do produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário AlterarProduto
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Obter os valores dos TextBoxes
            string nomeProduto = cboxNomeAlterar.SelectedItem?.ToString();
            string codigo = txtBoxCodigo.Text;
            string categoria = txtBoxCategoria.Text;
            string precoTexto = txtBoxPreco.Text;
            decimal preco;

            // Validação básica
            if (string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(precoTexto))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(precoTexto, out preco))
            {
                MessageBox.Show("Preço inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatabaseManager db = new DatabaseManager();

            try
            {
                // Atualizar o produto no banco de dados
                string query = "UPDATE Produtos SET Codigo = @Codigo, Categoria = @Categoria, Preco = @Preco WHERE Nome = @Nome";
                SqlParameter[] parameters = {
                new SqlParameter("@Codigo", codigo),
                new SqlParameter("@Categoria", categoria),
                new SqlParameter("@Preco", preco),
                new SqlParameter("@Nome", nomeProduto)
            };
                db.NonQueryWArgs(query, parameters);

                MessageBox.Show("Produto atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            // Obter os valores dos TextBoxes
            string nomeProduto = cboxNomeAlterar.SelectedItem?.ToString();
            string codigo = txtBoxCodigo.Text;
            string categoria = txtBoxCategoria.Text;
            string precoTexto = txtBoxPreco.Text;
            decimal preco;

            // Validação básica
            if (string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(precoTexto))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(precoTexto, out preco))
            {
                MessageBox.Show("Preço inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatabaseManager db = new DatabaseManager();

            try
            {
                // Atualizar o produto no banco de dados
                string query = "UPDATE Produtos SET Codigo = @Codigo, Categoria = @Categoria, Preco = @Preco WHERE Nome = @Nome";
                SqlParameter[] parameters = {
                new SqlParameter("@Codigo", codigo),
                new SqlParameter("@Categoria", categoria),
                new SqlParameter("@Preco", preco),
                new SqlParameter("@Nome", nomeProduto)};

                db.NonQueryWArgs(query, parameters);

                MessageBox.Show("Produto atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
