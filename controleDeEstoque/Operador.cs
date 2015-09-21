using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeEstoque
{
    class Operador
    {
        public static int type;
        private int id;
        private string nome;
        private int senha;
        private int tipo;
        private string endereco;
        private string telefone;
        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        
	    public string Telefone
	    {
		    get { return telefone;}
		    set { telefone = value;}
	    }
	

	    public string Endereco
	    {
		    get { return endereco;}
		    set { endereco = value;}
	    }
	

	    public int Tipo
	    {
		    get { return tipo;}
            set
            {
                type = value; 
                tipo = value;}
	    }
	
	    public int Senha
	    {
		    get { return senha;}
		    set { senha = value;}
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
