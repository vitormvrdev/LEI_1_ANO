using IntroToObjectOrientedProgramming.Venda;

namespace IntroToObjectOrientedProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            #region lista
            int a = 0;
            string x = string.Empty;
            DateTime data = new DateTime(2024, 1, 10);
            DateTime hoje = DateTime.Today;

            Produto p1 = new Produto();
            Produto p2 = new Produto(1, "ABC");
            Produto p3 = new Produto(2, "XYZ", new DateTime(2024, 10, 1), new DateTime(2024, 10, 5));

            long id = 2;
            string nome = "X";
            DateTime dataCompra = new DateTime(2024, 09, 3);
            DateTime dataVenda = new DateTime(2024, 08, 2);

            Produto p4 = new Produto(id, nome, dataCompra, dataVenda);

            ProdutoCollection produtos = new ProdutoCollection();

            produtos.Add(p1);
            produtos.Add(p2);
            produtos.Add(p3);
            produtos.Add(p4);


            this.listBox1.Items.Add(p1);
            this.listBox1.Items.Add(p2);
            this.listBox1.Items.Add(p3);
            this.listBox1.Items.Add(p4);
            #endregion

            int contador = 0;

            foreach (Produto item in produtos)
            {
                if (item.DataVenda <= DateTime.UtcNow)
                {
                    contador++;
                }
            }
        }
    }
}
