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
    public partial class FormCadastroProduto : Form
    {
        Produto p;
        public FormCadastroProduto()
        {
            InitializeComponent();
        }
        
        private void bloquearTextBox()
        {
            textCod.Enabled = false;
            textName.Enabled = false;
            textIdFor.Enabled = false;
            textValorUni.Enabled = false;
            textQuantidade.Enabled = false;            
        }

        private void desBloquearTextBox()
        {
            textName.Enabled = true;
            textIdFor.Enabled = true;
            textValorUni.Enabled = true;
            textQuantidade.Enabled = true;
        }

        private void limparTextBox()
        {
            textCod.Text = "";
            textName.Text = "";
            textIdFor.Text = "";
            textValorUni.Text = "";
            textQuantidade.Text = "";
        }


        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                    new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Parameters.AddWithValue("PName", textPesquisa.Text);
                    sqlCommand.CommandText = "SELECT ProductID, ProductName," +
                    "SupplierID, UnitPrice, UnitsInStock FROM Products WHERE ProductName= @PName";
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader(); //para caso que retorna registros
                    if (dataReader.Read()) //encontrou registro
                    {
                        textCod.Text = dataReader["ProductID"].ToString();
                        textName.Text = dataReader["ProductName"].ToString();
                        textIdFor.Text = dataReader["SupplierID"].ToString();
                        textValorUni.Text = dataReader["UnitPrice"].ToString();
                        textQuantidade.Text = dataReader["UnitsInStock"].ToString();                        
                    }
                    else
                    {
                        textCod.Text = "";
                        textName.Text = "";
                        textIdFor.Text = "";
                        textValorUni.Text = "";
                        textQuantidade.Text = "";
                    }
                    sqlConn.Close();
                }
            }

        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            bloquearTextBox();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            desBloquearTextBox();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                    new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Parameters.AddWithValue("PId", textCod.Text);
                    sqlCommand.CommandText = "SELECT count(ProductID)" +
                        "FROM Products WHERE ProductID= @PId";
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader(); //para caso que retorna registros
                    if (dataReader.Read()) //encontrou registro
                    {
                        if(Int32.Parse(dataReader[0].ToString()) == 1)
                        {
                            sqlConn.Close();
                            p = new Produto(Int32.Parse(textCod.Text.ToString()),
                                textName.Text.ToString(),
                                Int32.Parse(textIdFor.Text.ToString()),
                                Decimal.Parse(textValorUni.Text.ToString()),
                                Double.Parse(textQuantidade.Text));
                            sqlCommand.CommandText = "UPDATE Products SET ProductName = '" + p.Nome +"'," +
                                "SupplierID = '" + p.IdFornecedor + "', UnitPrice = '" + p.PrecoUnitarioVenda + "'," +
                                "UnitsInStock = '" + p.Quantidade + "' where ProductID = '" + p.Id + "'";
                            sqlConn.Open();
                            if (sqlCommand.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Produto atualizado com sucesso!");
                            } 
                            else
                            {
                                MessageBox.Show("Falha ao atualizar");
                            }
                            sqlConn.Close();
                        }
                        else
                        {
                            sqlConn.Close();
                            p = new Produto(Int32.Parse(textCod.Text.ToString()),
                                textName.Text.ToString(),
                                Int32.Parse(textIdFor.Text.ToString()),
                                Decimal.Parse(textValorUni.Text.ToString()),
                                Double.Parse(textQuantidade.Text));
                            sqlCommand.CommandText = "INSERT into Products (ProductName,SupplierID," +
                                "UnitPrice,UnitsInStock) values ('" + p.Nome+ "', '" + p.IdFornecedor +
                                "', '" + p.PrecoUnitarioVenda + "', '" + p.Quantidade +"')";                            
                            sqlConn.Open();
                            if (sqlCommand.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Produto adicionado com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Produto nao adicionado");
                            }
                            sqlConn.Close();                            
                        }
                    }
                    else
                    {
                        textCod.Text = "";
                        textName.Text = "";
                        textIdFor.Text = "";
                        textValorUni.Text = "";
                        textQuantidade.Text = "";
                    }
                    sqlConn.Close();
                    bloquearTextBox();
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormMenu fm = new FormMenu();
            fm.Show();
            this.Visible = false;
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            limparTextBox();
            desBloquearTextBox();
            textCod.Text = "-1";
        }
    }
}
