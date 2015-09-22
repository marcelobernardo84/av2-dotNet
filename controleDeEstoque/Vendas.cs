using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeEstoque
{
    class Vendas
    {
        private int id;
        private Produto[] produtos;
        private decimal preco;
        private Operador cod;
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        

        public Operador Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        

        public Produto[] Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
    }
}
