using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToObjectOrientedProgramming.Venda
{
    public class Produto
    {
        #region Construtores

        public Produto()
        {
            this.id = 0;
            this.nome = string.Empty;
            this.dataCompra = new DateTime(2000, 1, 1);
            this.dataVenda = new DateTime(9999, 12, 31);
        }
        public Produto(long id, string nome)
            : this()
        {
            this.ID = id;
            this.Nome = nome;
        }
        public Produto(long id,string nome, DateTime datacompra, DateTime datavenda)
            : this(id, nome)
        {
            this.DataCompra = datacompra;
            this.DataVenda = datavenda;
        }

        #endregion

        #region Propriedades

        private long id;

        public long ID
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private DateTime dataCompra;

        public DateTime DataCompra
        {
            get { return dataCompra; }
            set { dataCompra = value; }
        }
        private DateTime dataVenda;

        public DateTime DataVenda //Nullable faz com que possa ser nulo
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            return this.DescricaoProduto();
        }

        public string DescricaoProduto()
        {
            return $"ID = {this.ID.ToString()} [ {this.Nome} ]";
        }

        #endregion
    }
}