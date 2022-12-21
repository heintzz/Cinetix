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
        public MakeReservation(string title = "")
        {
            InitializeComponent();
            titleLabel.Text = title;

            // Total price equal to price per person on first initiation
            TotalPrice = 35000;                   
        }

        public bool IsFormEmpty(string name, string date, string amount)
        {
            return string.IsNullOrEmpty(name) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(amount); 
        }

        public void UpdateBalance(int remainder)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO dbo.Reservation (id, title, date, email, amountOfOrder) VALUES (@id, @title, @date, @email, @amount)";
            SqlCommand command = new SqlCommand(query, connection);
            IDGenerator number = new IDGenerator();
            string date = number.getUniqueId();
            command.Parameters.AddWithValue("id", date);
            command.Parameters.AddWithValue("title", titleLabel.Text);
            command.Parameters.AddWithValue("date", ReservationDate.Text);
            command.Parameters.AddWithValue("email", Home.EmailAddress);
            command.Parameters.AddWithValue("amount", int.Parse(NumOrder.Text));
            command.ExecuteNonQuery();

            string updateBalanceQuery = "UPDATE Users SET balance = @balance WHERE email = @email";
            SqlCommand updateCommand = new SqlCommand(updateBalanceQuery, connection);
            updateCommand.Parameters.AddWithValue("email", Home.EmailAddress);
            updateCommand.Parameters.AddWithValue("balance", remainder.ToString());
            updateCommand.ExecuteNonQuery();

            connection.Close();
        }

        public bool IsNaturalNumber(int orderNum)
        {            
            return orderNum > 0;
        }
        
        public int CalculateTotalPrice(int orderNum, int pricePerPerson)
        {            
            TotalPrice = orderNum * pricePerPerson;
            totalPrice.Text = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp{0:N}", TotalPrice).Split(',')[0];

            return TotalPrice;
        }        
        private void BookBtn_click(object sender, EventArgs e)
        {
            int remainder = Balance - TotalPrice;

            if (IsFormEmpty(InputName.Text, ReservationDate.Text, NumOrder.Text))
            {
                MessageBox.Show("Please fill out the form");
                return;
            }            

            if (remainder >= 0)
            {               
                UpdateBalance(remainder);

                this.Hide();
                ReservedMovie listBooked = new ReservedMovie();
                listBooked.ShowDialog();
            }
            else
            {
                MessageBox.Show("payment failed. insufficient balance");
            }                      
        }

        private void NumOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(NumOrder.Text, out _))
                {
                    int orderNum = int.Parse(this.NumOrder.Text);
                    if (IsNaturalNumber(orderNum))
                    {
                        CalculateTotalPrice(orderNum, 35000);
                    }
                    else
                    {
                        MessageBox.Show("The minimum number is 1");
                    }
                    this.BookBtn.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.");
                }
            }
        }

        private void MakeReservation_Load(object sender, EventArgs e)
        {
            NumOrder.Text = "1";            
            ReservationDate.MinDate = DateTime.Now;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT balance FROM Users WHERE email = @email";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@email", Home.EmailAddress);

            Balance = (int)command.ExecuteScalar();
            balanceLabel.Text = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp{0:N}", Balance).Split(',')[0];

            connection.Close();
        }
    }
}
