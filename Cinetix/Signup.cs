using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cinetix
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void MoveToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login form = new Login();
            form.ShowDialog();
        }

        public bool IsEmailInUse(string email)
        {
            string connectionString = Login.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectEmail = "SELECT COUNT(*) FROM dbo.Users WHERE email = @email";
                SqlCommand command = new SqlCommand(selectEmail, connection);
                command.Parameters.AddWithValue("@email", email);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public bool IsFormEmpty(string name, string email, string pass, string confirmPass)
        {
            return string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(confirmPass);
        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            return Regex.IsMatch(email, pattern);
        }

        public bool PasswordIsMatch(string pass, string confirmPass)
        {
            return pass == confirmPass;
        }

        public bool IsValidPasswordLength(string pass, int minLength)
        {
            return pass.Length > minLength;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {               
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);             
                byte[] hash = sha256.ComputeHash(passwordBytes);              
                return Convert.ToBase64String(hash);
            }
        }

        private bool InsertUser(string name, string email, string password, int balance)
        {

            string connectionString = Login.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (name, email, password, balance) VALUES (@name, @email, @password, @balance)";

                SqlCommand insert  = new SqlCommand(query, connection);

                insert.Parameters.AddWithValue("email", email);
                insert.Parameters.AddWithValue("name", name);
                insert.Parameters.AddWithValue("password", password);
                insert.Parameters.AddWithValue("balance", balance);

                insert.ExecuteNonQuery();

                MessageBox.Show("Your account has been set up successfully.");
            }

            return true;
        }

        public void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (IsFormEmpty(fullName.Text, email.Text, password.Text, confirmPass.Text)) 
            {
                MessageBox.Show("Please complete the form.");
                return;
            }

            if (IsEmailInUse(email.Text))
            {
                MessageBox.Show("The email address is already in use.");
            }
            
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Email is not valid");
                return;
            }

            if (!PasswordIsMatch(password.Text, confirmPass.Text))
            {
                MessageBox.Show("The password did not match. Please check again.");
                return;
            }

            if (!IsValidPasswordLength(password.Text, 8))
            {
                MessageBox.Show("Password length should be at least 8 characters.");
                return;
            }

            string hashedPassword = HashPassword(password.Text);

            InsertUser(fullName.Text, email.Text, hashedPassword, 500000);            
        }
    }
} 
