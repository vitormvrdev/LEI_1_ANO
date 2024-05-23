using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multibanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSaldo.Text = "500";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindos ao Multibanco");

            lstMovimentos.View = View.Details;
            lstMovimentos.Columns.Add("#", 30);
            lstMovimentos.Columns.Add("Data", 130);
            lstMovimentos.Columns.Add("Movimento", 80);
            lstMovimentos.Columns.Add("Valor", 60);
            lstMovimentos.Columns.Add("Saldo", 60);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            try
            {
                txtSaldo.Text = Convert.ToString(Convert.ToSingle(txtSaldo.Text) + Convert.ToSingle(txtValor.Text));
                double saldo = Convert.ToDouble(txtSaldo.Text);

                AdicionarTransacao(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "Deposito", valor, saldo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"!Erro! {ex}");
            }
        }

        private void btnLevantar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            if (Convert.ToDouble(txtValor.Text) > Convert.ToDouble(txtSaldo.Text))
            {
                MessageBox.Show($"Não pode levantar mais que {txtSaldo.Text}");
            }
            else
            {
                try
                {
                    txtSaldo.Text = Convert.ToString(Convert.ToSingle(txtSaldo.Text) - Convert.ToSingle(txtValor.Text));
                    double saldo = Convert.ToDouble(txtSaldo.Text);

                    AdicionarTransacao(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "Levantamento", valor, saldo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"!Erro! {ex}");
                }
            }
        }

        private void lstMovimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult respostaForm;
            respostaForm = MessageBox.Show("Queres mesmo sair?", "!!ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respostaForm == DialogResult.Yes)
                Application.Exit();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            /*if(txtValor.Text == "")
            {
                btnDepositar.Enabled = false;
                btnLevantar.Enabled = false;
            }
            else
            {
                btnDepositar.Enabled = true;
                btnLevantar.Enabled = true;
            }*/

            btnDepositar.Enabled = txtValor.Text.Length > 0;
            btnLevantar.Enabled = txtValor.Text.Length > 0;

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarTransacao(string data, string movimento, double valor, double  saldo)
        {
            ListViewItem item = new ListViewItem(new[] 
            {
                (lstMovimentos.Items.Count + 1).ToString(),
                data,
                movimento,
                valor.ToString("C"),
                saldo.ToString("C")}
            );
            lstMovimentos.Items.Add(item);
        }
    }
}
