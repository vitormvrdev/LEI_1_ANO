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
    public partial class Menu : Form
    {
        public Menu()
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

        private void goToVendedores_Click(object sender, EventArgs e)
        {
            formVendedores formVendedores = new formVendedores();

            formVendedores.Show();
        }

        private void goToProdutos_Click(object sender, EventArgs e)
        {
            Produtos produtosForm = new Produtos();

            produtosForm.Show();
        }

        private void goToVendas_Click(object sender, EventArgs e)
        {
            Vendas vendasForm = new Vendas();

            vendasForm.Show();
        }

        private void goToAnalises_Click(object sender, EventArgs e)
        {
            formAnalises formAnalises = new formAnalises();

            formAnalises.Show();
        }
    }
}
