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
        Login login;

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

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn = new SqlConnection("Data Source=(localdb)\\Estoque;Initial Catalog=northwind;Integrated Security=True"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Parameters.AddWithValue("PId", textBoxPass.Text);
                    sqlCommand.CommandText = "SELECT EmployeeID, FirstName FROM Employees WHERE EmployeeID= @PId";
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader();
                    if (dataReader.Read())
                    {
                        login = new Login();
                        login.Nome = dataReader["FirstName"].ToString();
                        login.Id = Int32.Parse(dataReader["EmployeeID"].ToString());
                        MessageBox.Show("Nome: " + login.Nome + " Senha: " + login.Id);
                    }
                }
            }
        }
    }
}
