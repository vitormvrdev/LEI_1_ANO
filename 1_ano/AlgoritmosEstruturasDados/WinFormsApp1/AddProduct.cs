using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Obter os valores dos TextBoxes
            string codigo = txtBoxCodigo.Text;
            string nome = txtBoxNome.Text;
            string categoria = txtBoxCategoria.Text;
            string precoTexto = txtBoxPreco.Text;
            decimal preco;

            // Validação básica
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(precoTexto))
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
                // Inserir o produto na base de dados
                string query = $"INSERT INTO Produtos (Codigo, Nome, Categoria, Preco) VALUES ('{codigo.Replace("'", "''")}', '{nome.Replace("'", "''")}', '{categoria.Replace("'", "''")}', {preco})";
                db.NonQuery(query);

                MessageBox.Show("Produto inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
