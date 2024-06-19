using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lstProdutos.View = View.Details;

            lstProdutos.Columns.Add("#", 50);
            lstProdutos.Columns.Add("Categoria", 200);
            lstProdutos.Columns.Add("Marca", 200);
            lstProdutos.Columns.Add("Modelo", 200);
            lstProdutos.Columns.Add("Preço", 85);
            lstProdutos.Columns.Add("Iva", 80);

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
    }
}
