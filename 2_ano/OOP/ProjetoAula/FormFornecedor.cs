using System;
using BusinessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void listaFornecedorButton_Click(object sender, EventArgs e)
        {
            //obter lista de fornecedores
            //
            //lista = ObterLista()
            //
            FornecedorCollection fornecedores = new FornecedorCollection();

            //Para cada elemento da lista
            //      Inserir na lista
            //      objeto.Propriedade = elemento

            if (fornecedores != null)
            {
                foreach (Fornecedor fornecedor in fornecedores)
                {
                    this.fornecedoresListBox.Items.Add(fornecedor.NomeFornecedor);
                }
            }
        }

        private void codigoFornecedorTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int codigoFornecedor = 0;
                string codigoFornecedorString = this.codigoFornecedorTextBox.Text;

                if (int.TryParse(codigoFornecedorString, out codigoFornecedor))
                {
                    Fornecedor fornecedor = Fornecedor.ObterCodigoFornecedor(codigoFornecedor);

                    if (fornecedor != null)
                    {
                        this.nomeFornecedorTextBox.Text = codigoFornecedorString;
                    }
                }
            }
        }
    }
}
