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
    public partial class FormOperador : Form
    {
        Operador operador;
        bool operadorNovo;

        public FormOperador()
        {
            InitializeComponent();
        }

        private void limparForm()
        {
            textBoxCod.Text = "";
            textBoxNome.Text = "";
            textBoxSobreNome.Text = "";
            textBoxEndereco.Text = "";
            textBoxTelefone.Text = "";
            textBoxLogin.Text = "";
            textBoxSenha.Text = "";
            comboBoxTipo.Text = "";
        }

        private void bloquearTextBox()
        {
            textBoxCod.Enabled = false;
            textBoxNome.Enabled = false;
            textBoxSobreNome.Enabled = false;
            textBoxEndereco.Enabled = false;
            textBoxTelefone.Enabled = false;
            textBoxLogin.Enabled = false;
            textBoxSenha.Enabled = false;
            comboBoxTipo.Enabled = false;
        }

        private void desBloquearTextBox()
        {
            textBoxCod.Enabled = true;
            textBoxNome.Enabled = true;
            textBoxSobreNome.Enabled = true;
            textBoxEndereco.Enabled = true;
            textBoxTelefone.Enabled = true;
            textBoxLogin.Enabled = true;
            textBoxSenha.Enabled = true;
            comboBoxTipo.Enabled = true;
        }


        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            desBloquearTextBox();
            operadorNovo = false;
        }

        private void FormOperador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            bloquearTextBox();

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                    new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Parameters.AddWithValue("PId", comboBoxNome.SelectedValue);
                    sqlCommand.CommandText = "SELECT ID, FirstName,LastName," +
                    "Address, HomePhone, login, secret, tipo FROM Employees WHERE id= @PId";
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader(); //para caso que retorna registros
                    if (dataReader.Read()) //encontrou registro
                    {
                        operador = new Operador(Int32.Parse(dataReader[0].ToString()),
                                                dataReader[1].ToString(), dataReader[2].ToString(),
                                                dataReader[3].ToString(), dataReader[4].ToString(),
                                                dataReader[5].ToString(), 
                                                Int32.Parse(dataReader[6].ToString()),
                                                Int32.Parse(dataReader[7].ToString()));

                        textBoxCod.Text = operador.Id.ToString();
                        textBoxNome.Text = operador.Nome;
                        textBoxSobreNome.Text = operador.Sobrenome;
                        textBoxEndereco.Text = operador.Endereco;
                        textBoxTelefone.Text = operador.Telefone;
                        textBoxLogin.Text = operador.Login;
                        textBoxSenha.Text = operador.Senha.ToString();
                        comboBoxTipo.Text = operador.Tipo.ToString();
                    }
                    else
                    {
                        limparForm();
                    }
                    sqlConn.Close();
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (operadorNovo)
            {
                using (SqlConnection sqlConn =
                    new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True"))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        operador = new Operador(Int32.Parse(textBoxCod.Text.ToString()),
                                                    textBoxNome.Text.ToString(),
                                                    textBoxSobreNome.Text.ToString(),
                                                    textBoxEndereco.Text.ToString(),
                                                    textBoxTelefone.Text.ToString(), textBoxLogin.Text.ToString(),
                                                    Int32.Parse(textBoxSenha.Text.ToString()),
                                                    Int32.Parse(comboBoxTipo.SelectedIndex.ToString()));
                        sqlCommand.CommandText = "INSERT into Employees (FirstName,LastName," +
                                    "Address,HomePhone,Login,Secret,Tipo) values ('" + operador.Nome +
                                    "','" + operador.Sobrenome + "', '" + operador.Endereco + "', '" + operador.Telefone + "','" +
                                    operador.Login + "', '" + operador.Senha + "', '" + operador.Tipo + "')";
                        sqlCommand.Connection = sqlConn;
                        sqlConn.Open();
                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            comboBoxNome.Refresh();
                            bloquearTextBox();
                            MessageBox.Show("Operador adicionado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Operador nao adicionado");
                        }
                        sqlConn.Close();
                    }
                }
            }
            else
            {
                using (SqlConnection sqlConn =
                        new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True"))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandText = "UPDATE Employees SET FirstName = '" + operador.Nome + "',LastName = '" + operador.Sobrenome + "',"+ 
                            "Address = '" + operador.Endereco + "'," +
                            "HomePhone = '" + operador.Telefone + "', Login = '" + operador.Login + "'," +
                             "Secret = '" + operador.Senha + "', Tipo = '" + operador.Tipo + "' where ID = '" + operador.Id + "'";
                        sqlCommand.Connection = sqlConn;
                        sqlConn.Open();
                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Oeprador atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao atualizar");
                        }
                        sqlConn.Close();
                        bloquearTextBox();
                    }
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
            limparForm();
            desBloquearTextBox();
            textBoxCod.Text = "-1";
            operadorNovo = true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                        new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True"))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandText = "DELETE FROM Employees where ID = '" + operador.Id + "'";
                        sqlCommand.Connection = sqlConn;
                        sqlConn.Open();
                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Oeprador atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao atualizar");
                        }
                        comboBoxNome.Update();
                        sqlConn.Close();
                        bloquearTextBox();
                    }
                }
            }
        }
    }

