using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cinetix
{
    public partial class MovieDetail : Form
    {
        public static string src_img;
        public MovieDetail(int id)
        {
            InitializeComponent();
            
            string connectionString = Login.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Movie WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string title = reader.GetString(1);
                    string description = reader.GetString(2);
                    string rating = reader.GetString(3);
                    string genre = reader.GetString(4);
                    string review = reader.GetString(5);
                    string src = reader.GetString(6);
                    string release_date = reader.GetString(8);

                    src_img = src;

                    MoviePoster.ImageLocation = src_img;
                    MovieTitle.Text = title;
                    DescMovie.Text = description;
                    Rating.Text = rating + "/10";
                    Genre.Text = genre;
                    ReleaseDate.Text = release_date;
                    Review.Text = review;
                }

                connection.Close();
            }                     
        }

        private void BookNowBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            string title = this.MovieTitle.Text;
            
            MakeReservation bookForm = new MakeReservation(title);
            bookForm.ShowDialog();
        }
      
    }
}
