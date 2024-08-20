using System;
using System.Data;
using System.Windows.Forms;

namespace _009___Projeto_Final
{
    public partial class formVendas : Form
    {
        public formVendas()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult respostaForm = MessageBox.Show("Queres mesmo sair?", "!!ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respostaForm == DialogResult.Yes)
                Application.Exit();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            AtualizaListaVenda();

            DatabaseManager db = new DatabaseManager();

            //Ver se o utilizador é Administrador para saber se tem acesso aos botoes de inserir/alterar/eliminar
            string username = VariaveisGlobais.Username; //Valor do Username que está guardado nas variaveis globais
            string queryAdmin = $"SELECT Administrador FROM Login_Info WHERE Username = '{username}'";
            bool isAdmin = Convert.ToBoolean(db.SelectDataTable(queryAdmin).Rows[0][0]);

            if (isAdmin)
            {
                btnInserir.Enabled = true;
                btnAlterar.Enabled = true;
                btnRemover.Enabled = true;
            }
            else
            {
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnRemover.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new formMenu();
            form.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário
            formInserirVenda addVendaForm = new formInserirVenda();

            // Inscreve-se no evento de FormClosed do formulário AddVenda
            addVendaForm.FormClosed += new FormClosedEventHandler(AddVendaForm_FormClosed);

            // Exibe o formulário
            addVendaForm.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário
            formEliminarVenda removeVendaForm = new formEliminarVenda();

            // Exibe o formulário 
            removeVendaForm.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário
            formAlterarVenda alterarVendaForm = new formAlterarVenda();
            // Exibe o formulário 
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

            lstVendas.Columns.Add("Código", 50);
            lstVendas.Columns.Add("Código do Vendedor", 150);
            lstVendas.Columns.Add("Zona", 50);
            lstVendas.Columns.Add("Data Venda", 100);
            lstVendas.Columns.Add("Quantidade", 80);
            lstVendas.Columns.Add("Código do Produto", 150);
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
