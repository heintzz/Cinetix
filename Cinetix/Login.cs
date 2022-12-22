using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cinetix
{
    public partial class Login : Form
    {
        public static string GetConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\3rd semester\object-oriented programming\CinetixBookApp\Cinetix\CinetixDB.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public Login()
        {
            InitializeComponent();
        }

        private void RegisterToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Signup form = new Signup();
            form.ShowDialog();
        }

        public bool IsFormFilled(string email, string pass)
        {
            return string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(email);
        }

        public bool IsUserExist(string email, string pass)
        {
            int count;
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {               
                connection.Open();
                string getUser = "SELECT Count(*) from dbo.Users WHERE email = @email AND password = @password";

                using (SqlCommand command = new SqlCommand(getUser, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(pass);
                        byte[] hash = sha256.ComputeHash(passwordBytes);
                        string hashString = Convert.ToBase64String(hash);

                        command.Parameters.AddWithValue("@password", hashString);
                    }

                    count = (int)command.ExecuteScalar();                    
                }
            }
            
            return count > 0;
        }
        
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IsFormFilled(email.Text, password.Text))
            {
                MessageBox.Show("please complete the form");
                return;
            }

            if (IsUserExist(email.Text, password.Text))
            {
                this.Hide();                

                Home form = new Home(email.Text);
                form.ShowDialog();
            }

            else
            {
                MessageBox.Show("email/password is incorrect");
            }
        }     
    }
}