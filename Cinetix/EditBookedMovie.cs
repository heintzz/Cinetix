using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Cinetix
{
    public partial class EditBookedMovie : Form
    {
        private readonly string id;
        private int numOrder;
        public void GetAllInfo()
        {            
            string connectionString = Login.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();               
                string getData = "SELECT title, amountOfOrder, date, image FROM Reservation WHERE id = @id AND email = @email";
                using (SqlCommand getDataCommand = new SqlCommand(getData, connection))
                {
                    getDataCommand.Parameters.AddWithValue("id", id);
                    getDataCommand.Parameters.AddWithValue("email", Home.EmailAddress);

                    using (SqlDataReader reader = getDataCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string title = reader.GetString(0);
                            numOrder = reader.GetInt32(1);                            
                            string date = reader.GetString(2);
                            string src_img = reader.GetString(3);

                            MovieTitle.Text = title;
                            AmountOfOrder.Text = numOrder.ToString();
                            MoviePoster.ImageLocation = src_img;                            
                        }
                    }
                }
                
                connection.Close();
            }           
        }
        public EditBookedMovie(string ID)
        {
            InitializeComponent();
            ReservationDate.MinDate = DateTime.Now;
            this.id = ID;

            GetAllInfo();                        
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change the date reservation?", "Confirm Date Change", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string connectionString = Login.GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE Reservation SET date = @date WHERE id = @id AND email = @email";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        connection.Open();

                        updateCommand.Parameters.AddWithValue("id", id);
                        updateCommand.Parameters.AddWithValue("email", Home.EmailAddress);
                        updateCommand.Parameters.AddWithValue("date", ReservationDate.Text);

                        updateCommand.ExecuteNonQuery();

                        connection.Close();
                    }
                }
           }                            
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home form = new Home(Home.EmailAddress);
            form.ShowDialog();
        }        
    }
}
