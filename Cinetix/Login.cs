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

        public void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IsFormFilled(email.Text, password.Text))
            {
                MessageBox.Show("please complete the form");
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\3rd semester\object-oriented programming\CinetixBookApp\Cinetix\CinetixDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getUser = "SELECT Count(*) from dbo.Users WHERE email = @email AND password = @password";

                using (SqlCommand command = new SqlCommand(getUser, connection))
                {
                    command.Parameters.AddWithValue("@email", email.Text);

                    using (SHA256 sha256 = SHA256.Create())
                    {                        
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(password.Text);                     
                        byte[] hash = sha256.ComputeHash(passwordBytes);                       
                        string hashString = Convert.ToBase64String(hash);

                        command.Parameters.AddWithValue("@password", hashString);
                    }

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        this.Hide();
                        MessageBox.Show("berhasil");

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
    }
}
