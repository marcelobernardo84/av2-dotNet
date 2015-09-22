using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleDeEstoque
{
    public partial class FormVendas : Form
    {
        Produto prod;
        List<Produto> listProdutos = new List<Produto>();

        public FormVendas()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillBy(this.northwindDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBoxCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            using (SqlConnection sqlConn =
                    new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Parameters.AddWithValue("PId", textBoxCodigo.Text);
                    sqlCommand.CommandText = "SELECT ProductID, ProductName," +
                    "SupplierID, UnitPrice, UnitsInStock FROM Products WHERE ProductID= @PId";
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader(); //para caso que retorna registros
                    if (dataReader.Read()) //encontrou registro
                    {
                        prod = new Produto(Int32.Parse(dataReader["ProductID"].ToString()),
                        dataReader[1].ToString(),
                        Int32.Parse(dataReader[2].ToString()),
                        Decimal.Parse(dataReader[3].ToString()),
                        Double.Parse(textBoxQuantidade.Text));
                        //colocando os dados no formulario
                        textBoxDescricao.Text = prod.Nome;
                    }
                    else
                    {
                        textBoxDescricao.Text = "";
                        prod = null;
                    }
                    sqlConn.Close();
                }
            }
        }

        private void textBoxCodigo_Enter(object sender, EventArgs e)
        {
            textBoxCodigo.SelectionStart = 0;
            textBoxCodigo.SelectionLength = textBoxCodigo.TextLength;
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxQuantidade.Text))
            {
                textBoxQuantidade.Text = "1";
                textBoxQuantidade.SelectionStart = 0;
                textBoxQuantidade.SelectionLength = textBoxCodigo.TextLength;
            }
        }

        private void textBoxQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdicionarCarrinho();
            }
        }

        public void AdicionarCarrinho()
        {
            if (prod != null)
            {
                prod.Quantidade = Double.Parse(textBoxQuantidade.Text);
                listProdutos.Add(prod);                
                listCarrinho.Items.Add(String.Format("{0,-40} {1,-12} {2,3}", prod.Nome, prod.PrecoUnitarioVenda, prod.Quantidade));
            }

        }

        private void buttonListEstoque_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            try
            {
                SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT ProductID, ProductName," +
                "SupplierID, UnitPrice, UnitsInStock FROM Products", sqlConn);
                DataTable table = new DataTable();
                dAdapter.Fill(table);
                gridEstoque.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Acesso ao banco falhou!\n" + ex.ToString());
            }
            finally
            {
                sqlConn.Close();                
            }
        }

        private void buttonAdCarrinho_Click(object sender, EventArgs e)
        {
            AdicionarCarrinho();
        }

        private void buttonFimVenda_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                        new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlConn.Open();
                    //atualizando o estoque dos produtos na tabela
                    string resposta = ""; 
                    foreach (var item in listProdutos)
                    {
                        sqlCommand.CommandText = "UPDATE Products SET UnitsInStock= UnitsInStock-'" + item.Quantidade + "' WHERE ProductID= '" + item.Id + "'";
                        sqlCommand.Connection = sqlConn;
                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            resposta += item.Nome + "\n";                            
                        }
                        else
                        {
                            resposta = null;
                            MessageBox.Show("Erro ao atualizar estoque Produto:{0}", item.Nome);
                        }
                    }
                    if (String.IsNullOrEmpty(resposta))
                        MessageBox.Show("0(zero) item vendido\n");
                    else
                        MessageBox.Show(resposta + "vendido(s) com Sucesso!\n");
                    
                    listProdutos.Clear();
                    listCarrinho.Items.Clear();
                    sqlConn.Close();
                }
            }
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillBy(this.northwindDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            listProdutos.Clear();
            listCarrinho.Items.Clear();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin l = new FormLogin();
            l.Show();
            this.Visible = false;
        }
    }
}
