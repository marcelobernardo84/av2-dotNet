using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeEstoque
{
    class Produto
    {

        private int id;
        private string nome;
        private int idFornecedor;
        private decimal precoUnitarioVenda;
        private double quantidade;
        private decimal precoUnitarioCompra;
        private string dataValidade;

        public string DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }


        public decimal PrecoUnitarioCompra
        {
            get { return precoUnitarioCompra; }
            set { precoUnitarioCompra = value; }
        }


        public Produto(int id, string nome, int idFornecedor, decimal precoUnitario, double quantidade)
        {
            this.Id = id;
            this.Nome = nome;
            this.IdFornecedor = idFornecedor;
            this.PrecoUnitarioVenda = precoUnitario;
            this.Quantidade = quantidade;
        }

        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }


        public decimal PrecoUnitarioVenda
        {
            get { return precoUnitarioVenda; }
            set { precoUnitarioVenda = value; }
        }

        public int IdFornecedor
        {
            get { return idFornecedor; }
            set { idFornecedor = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}

