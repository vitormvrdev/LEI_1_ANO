namespace WinFormsApp1
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult respostaForm;
            respostaForm = MessageBox.Show("Queres mesmo sair?", "!!ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respostaForm == DialogResult.Yes)
                Application.Exit();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {

            lstVendas.View = View.Details;

            lstVendas.Columns.Add("#", 50);
            lstVendas.Columns.Add("Código", 200);
            lstVendas.Columns.Add("Zona", 200);
            lstVendas.Columns.Add("Código", 200);
            lstVendas.Columns.Add("Quantidade", 200);
            lstVendas.Columns.Add("Código do Produto", 85);
            lstVendas.Columns.Add("Valor da Venda", 80);

            lstVendas.Refresh();
        }
    }
}
