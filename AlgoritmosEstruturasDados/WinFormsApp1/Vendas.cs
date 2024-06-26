using System.Data;   

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
            lstVendas.Columns.Add("Código", 150);
            lstVendas.Columns.Add("Zona", 100);
            lstVendas.Columns.Add("Código", 100);
            lstVendas.Columns.Add("Quantidade", 50);
            lstVendas.Columns.Add("Código do Produto", 100);
            lstVendas.Columns.Add("Valor da Venda", 80);

            lstVendas.Refresh();

            DatabaseManager db = new DatabaseManager();
            DataTable dbVendas = db.SelectDataTable("SELECT * FROM Vendas");

            foreach (DataRow dr in dbVendas.Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());

                for (int i = 0;  i < dbVendas.Rows.Count -1 ; i ++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstVendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
