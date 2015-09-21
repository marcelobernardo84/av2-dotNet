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
    public partial class FormLogin : Form
    {
        Operador login;
                
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn = new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    if ((textBoxLogin.Text != "") && (textBoxPass.Text != ""))
                    {
                        sqlCommand.Parameters.AddWithValue("Log", textBoxLogin.Text);
                        sqlCommand.Parameters.AddWithValue("Pass", textBoxPass.Text);
                        sqlCommand.CommandText = "SELECT ID, login, secret, tipo FROM Employees WHERE Login= @Log AND Secret= @Pass";
                        sqlCommand.Connection = sqlConn;
                        sqlConn.Open();
                        SqlDataReader dataReader;
                        dataReader = sqlCommand.ExecuteReader();

                        if (dataReader.Read())
                        {
                            login = new Operador();
                            login.Login = dataReader["Login"].ToString();
                            login.Id = Int32.Parse(dataReader["ID"].ToString());
                            login.Senha = Int32.Parse(dataReader["Secret"].ToString());
                            login.Tipo = Int32.Parse(dataReader["Tipo"].ToString());
                            FormMenu frm = new FormMenu();
                            frm.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Login não encontrado");
                        }
                        sqlConn.Close();                        
                    }
                }
            }
        }

    }
}
