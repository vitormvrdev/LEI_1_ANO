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
            respostaForm = MessageBox.Show("Queres mesmo sair?", "!!ATEN��O!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respostaForm == DialogResult.Yes)
                Application.Exit();
        }
    }
}
