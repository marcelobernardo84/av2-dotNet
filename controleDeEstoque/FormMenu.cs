using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleDeEstoque
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            FormVendas v = new FormVendas();
            v.Show();
            this.Visible = false;
            
        }

        private void buttonOperador_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            if (Operador.type == 0)
            {
                MessageBox.Show("OK");
            }
            else
                MessageBox.Show("O seu Login não tem para esta Opção!");
        }        
    }
}
