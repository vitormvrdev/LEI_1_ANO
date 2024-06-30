using System;
using System.Data;
using System.Windows.Forms;

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
            DialogResult respostaForm = MessageBox.Show("Queres mesmo sair?", "!!ATEN��O!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respostaForm == DialogResult.Yes)
                Application.Exit();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            AtualizaListaVenda();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Cria uma nova inst�ncia do formul�rio
            AddVenda addVendaForm = new AddVenda();

            // Inscreve-se no evento de FormClosed do formul�rio AddVenda
            addVendaForm.FormClosed += new FormClosedEventHandler(AddVendaForm_FormClosed);

            // Exibe o formul�rio
            addVendaForm.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Cria uma nova inst�ncia do formul�rio
            RemoveVenda removeVendaForm = new RemoveVenda();

            // Exibe o formul�rio 
            removeVendaForm.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Cria uma nova inst�ncia do formul�rio
            AlterarVenda alterarVendaForm = new AlterarVenda();
            // Exibe o formul�rio 
            alterarVendaForm.Show();
        }

        private void btnAtualizaListaVenda_Click(object sender, EventArgs e)
        {
            AtualizaListaVenda();
        }

        private void AddVendaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AtualizaListaVenda();
        }

        public void AtualizaListaVenda()
        {
            lstVendas.View = View.Details;
            lstVendas.Items.Clear();
            lstVendas.Columns.Clear();

            lstVendas.Columns.Add("C�digo", 50);
            lstVendas.Columns.Add("C�digo do Vendedor", 150);
            lstVendas.Columns.Add("Zona", 50);
            lstVendas.Columns.Add("Data Venda", 100);
            lstVendas.Columns.Add("Quantidade", 80);
            lstVendas.Columns.Add("C�digo do Produto", 150);
            lstVendas.Columns.Add("Valor da Venda", 100);

            lstVendas.Refresh();

            DatabaseManager db = new DatabaseManager();
            DataTable dbVendas = db.SelectDataTable("SELECT Codigo, CodigoVendedor, Zona, DataVenda, Quantidade, CodigoProduto, Valor FROM Vendas");

            foreach (DataRow dr in dbVendas.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Codigo"].ToString());
                item.SubItems.Add(dr["CodigoVendedor"].ToString());
                item.SubItems.Add(dr["Zona"].ToString());
                item.SubItems.Add(dr["DataVenda"].ToString());
                item.SubItems.Add(dr["Quantidade"].ToString());
                item.SubItems.Add(dr["CodigoProduto"].ToString());
                item.SubItems.Add(dr["Valor"].ToString());

                lstVendas.Items.Add(item);
            }
        }
    }
}
