using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KarMun_ShitApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string Country = "";

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            string connectionString = string.Empty;
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\1234\Desktop\KarMun ShitApp\KarMun ShitApp\KarmunAppDatabase.mdf""; Integrated Security = True; Connect Timeout = 30");
            SqlCommand command = new SqlCommand();            
            connection.Open();            
            command.CommandText = "SELECT Id From CountryLogin WHERE country =@username AND password =@password";
            command.Parameters.AddWithValue("@username", txtLoginCountry.Text);
            command.Parameters.AddWithValue("@password", txtLoginPassword.Text);
            command.Connection = connection;
            object obj = command.ExecuteScalar();
            if (obj != null)
            {
                if (obj.ToString() == "0")
                {
                    Form admin = new Form1();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    Country = txtLoginCountry.Text;
                    Form publicForm = new PublicForm();
                    publicForm.Show();
                    this.Hide();

                }
                connection.Close();
            }
            else
            {

                connection.Close();
                MessageBox.Show("Invalid credentials!\nPlease enter a valid country and password to continue.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
