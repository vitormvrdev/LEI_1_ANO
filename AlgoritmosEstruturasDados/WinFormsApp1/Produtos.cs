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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            // Instância do gerenciador da base de dados
            DatabaseManager db = new DatabaseManager();

            // Selecionar todos os produtos da tabela "Produtos"
            DataTable dtProdutos = db.SelectDataTable("SELECT Codigo, Nome, Categoria, Preco FROM Produtos");

            // Limpa itens existentes no ComboBox e na ListView
            cboxCategoria.Items.Clear();
            lstProdutos.Items.Clear();

            // Verifica se a coluna "Categoria" existe
            if (!dtProdutos.Columns.Contains("Categoria"))
            {
                MessageBox.Show("A coluna 'Categoria' não existe na tabela 'Produtos'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Adicionar categorias ao ComboBox (evitar duplicados usando HashSet)
            HashSet<string> categorias = new HashSet<string>();

            foreach (DataRow row in dtProdutos.Rows)
            {
                string categoria = row["Categoria"].ToString();
                if (!categorias.Contains(categoria))
                {
                    categorias.Add(categoria);
                    cboxCategoria.Items.Add(categoria);
                }
            }

            // Configuração da ListView
            lstProdutos.View = View.Details;
            lstProdutos.Columns.Clear();
            lstProdutos.Columns.Add("Código", 50, HorizontalAlignment.Left);
            lstProdutos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstProdutos.Columns.Add("Categoria", 100, HorizontalAlignment.Left);
            lstProdutos.Columns.Add("Preço", 70, HorizontalAlignment.Right);

            // Adicionar dados à ListView
            foreach (DataRow row in dtProdutos.Rows)
            {
                ListViewItem item = new ListViewItem(row["Codigo"].ToString());
                item.SubItems.Add(row["Nome"].ToString());
                item.SubItems.Add(row["Categoria"].ToString());
                item.SubItems.Add(row["Preco"].ToString());

                lstProdutos.Items.Add(item);
            }

            // Atualizar ComboBox e ListView para exibir os novos itens
            cboxCategoria.Refresh();
            lstProdutos.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void cboxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Combo box that shows every Category in the database
            // limpa 
            // Obtém a categoria selecionada
            string selectedCategory = cboxCategoria.SelectedItem.ToString();

            // Filtra os produtos pela categoria selecionada
            FilterProductsByCategory(selectedCategory);
        }

        private void FilterProductsByCategory(string category)
        {
            // Limpa os itens existentes na ListView
            lstProdutos.Items.Clear();

            // Instância do gerenciador da base de dados
            DatabaseManager db = new DatabaseManager();

            // Consulta para buscar produtos da categoria selecionada
            string query = "SELECT Codigo, Nome, Categoria, Preco FROM Produtos WHERE Categoria = @Categoria";
            DataTable dtProdutos = db.SelectDataTableWArgs(query, new SqlParameter("@Categoria", category));

            // Adicionar dados filtrados à ListView
            foreach (DataRow row in dtProdutos.Rows)
            {
                ListViewItem item = new ListViewItem(row["Codigo"].ToString());
                item.SubItems.Add(row["Nome"].ToString());
                item.SubItems.Add(row["Categoria"].ToString());
                item.SubItems.Add(row["Preco"].ToString());

                lstProdutos.Items.Add(item);
            }

            lstProdutos.Refresh();
        }


        private void btnAtualizaLista_Click(object sender, EventArgs e)
        {
            // Limpa os itens existentes na ListView e no ComboBox
            cboxCategoria.Items.Clear();
            lstProdutos.Items.Clear();

            // Instância do gerenciador da base de dados
            DatabaseManager db = new DatabaseManager();

            // Selecionar todos os produtos da tabela "Produtos"
            DataTable dtProdutos = db.SelectDataTable("SELECT Codigo, Nome, Categoria, Preco FROM Produtos");

            // Adicionar categorias ao ComboBox (evita duplicação de dados com HashSet) -> não percebi bem como funciona mas funciona :)
            HashSet<string> categorias = new HashSet<string>();
            foreach (DataRow row in dtProdutos.Rows)
            {
                string categoria = row["Categoria"].ToString();
                if (!categorias.Contains(categoria))
                {
                    categorias.Add(categoria);
                    cboxCategoria.Items.Add(categoria);
                }

                // Adicionar produtos à ListView
                ListViewItem item = new ListViewItem(row["Codigo"].ToString());
                item.SubItems.Add(row["Nome"].ToString());
                item.SubItems.Add(row["Categoria"].ToString());
                item.SubItems.Add(row["Preco"].ToString());

                lstProdutos.Items.Add(item);
            }

            // Atualizar ComboBox e ListView para exibir os novos itens
            cboxCategoria.Refresh();
            lstProdutos.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário RemoveProduct
            RemoveProduct removeProductForm = new RemoveProduct();

            // Exibe o formulário RemoveProduct
            removeProductForm.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário AddProduct
            AddProduct addProductForm = new AddProduct();

            // Exibe o formulário AddProduct
            addProductForm.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obter a categoria selecionada na ComboBox
            string categoriaSelecionada = cboxCategoria.SelectedItem?.ToString();

            // Validação básica
            if (string.IsNullOrEmpty(categoriaSelecionada))
            {
                MessageBox.Show("Por favor, selecione uma categoria para calcular.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Instância do gerenciador da base de dados
            DatabaseManager db = new DatabaseManager();

            try
            {
                // Consulta para buscar os preços dos produtos da categoria selecionada
                string query = "SELECT Preco FROM Produtos WHERE Categoria = @Categoria";
                DataTable dtProdutos = db.SelectDataTableWArgs(query, new SqlParameter("@Categoria", categoriaSelecionada));

                // Calcular a soma dos preços
                decimal somaPrecos = 0;
                foreach (DataRow row in dtProdutos.Rows)
                {
                    somaPrecos += Convert.ToDecimal(row["Preco"]);
                }

                // Exibir a soma no TextBox de resultado com símbolo do euro
                txtBoxResultado.Text = somaPrecos.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("pt-PT"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular soma dos preços: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
