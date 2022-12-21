using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using GenerateUniqueId;

namespace Cinetix
{
    public partial class MakeReservation : Form
    {        
        private int Balance { get; set; }
        private int TotalPrice { get; set; }

        private readonly string connectionString = Login.GetConnectionString();
        public MakeReservation(string title)
        {
            InitializeComponent();
            titleLabel.Text = title;
            TotalPrice = 35000;                   
        }

        private void BookBtn_click(object sender, EventArgs e)
        {
            try
            {                
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                if (this.InputName.Text.ToString().Length > 0)
                {
                    string query = "INSERT INTO dbo.Reservation (id, title, date, email, amountOfOrder) VALUES (@id, @title, @date, @email, @amount)";
                    SqlCommand command = new SqlCommand(query, connection);

                    IDGenerator number = new IDGenerator();
                    string date = number.getUniqueId();

                    int remainder = Balance - TotalPrice;
                    if (remainder >= 0)
                    {
                        command.Parameters.AddWithValue("id", date);
                        command.Parameters.AddWithValue("title", titleLabel.Text);
                        command.Parameters.AddWithValue("date", reservationDate.Text);
                        command.Parameters.AddWithValue("email", Home.EmailAddress);
                        command.Parameters.AddWithValue("amount", int.Parse(NumOrder.Text));

                        string updateBalanceQuery = "UPDATE dbo.Users SET balance = @balance WHERE email = @email";
                        SqlCommand updateCommand = new SqlCommand(updateBalanceQuery, connection);                       

                        updateCommand.Parameters.AddWithValue("email", Home.EmailAddress);
                        updateCommand.Parameters.AddWithValue("balance", remainder.ToString());

                        command.ExecuteNonQuery();
                        updateCommand.ExecuteNonQuery();

                        MessageBox.Show("success");

                        this.Hide();

                        ReservedMovie listBooked = new ReservedMovie();
                        listBooked.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("payment failed. insufficient balance");
                    }

                }
                else
                {
                    MessageBox.Show("failed");
                }

                connection.Close();
            } catch (SqlException ex)
            {
                MessageBox.Show("Gagal menghubungkan");
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void NumOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(NumOrder.Text, out _))
                {                    
                    MessageBox.Show("Please enter a valid integer.");
                }
                else
                {
                    int numPeople = int.Parse(this.NumOrder.Text);

                    if (numPeople > 0)
                    {
                        // Calculate the total price
                        int pricePerPerson = 35000;
                        TotalPrice = numPeople * pricePerPerson;

                        // Update the label or TextBox that displays the total price
                        this.totalPrice.Text = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp{0:N}", TotalPrice).Split(',')[0];                                                
                    } else
                    {
                        MessageBox.Show("The minimum number is 1");
                    }
                }
            }
        }

        private void MakeReservation_Load(object sender, EventArgs e)
        {
            NumOrder.Text = "1";            

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = "SELECT balance FROM dbo.Users WHERE email = @email";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@email", Home.EmailAddress);
            Balance = (int)command.ExecuteScalar();
            balanceLabel.Text = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp{0:N}", Balance).Split(',')[0];

            connection.Close();
        }

        private void InputName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.NumOrder.Focus();
            }
        }        
    }
}
