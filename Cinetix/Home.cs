using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Cinetix
{
    public partial class Home : Form
    {
        public static string EmailAddress;        

        List<PictureBox> pictures = new List<PictureBox>();
        List<Label> labels = new List<Label>();

        public Home(string email)
        {
            InitializeComponent();

            EmailAddress = email;            
        }

        public void ChangeForm(object sender, EventArgs e)
        {
            this.Hide();

            Control control = (Control)sender;
            int id = int.Parse(control.Name);

            MovieDetail detailMovie = new MovieDetail(id);
            detailMovie.ShowDialog();
        }

        public void ShowAllMovies()
        {
            int widthMovie = 320;
            int heightMovie = 460;
            int locX = 16;
            int locY = 460;

            void createBox(int id, string title, string src, string rating)
            {
                var moviePic = new PictureBox
                {
                    Name = id.ToString(),
                    Size = new Size(widthMovie, heightMovie),
                    Location = new Point(locX, locY),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand,
                };

                moviePic.ImageLocation = src;

                moviePic.Click += new EventHandler(ChangeForm);

                Random rnd = new Random();

                var label = new Label
                {
                    Text = title + "\n" + rating + "/10",
                    Size = new Size(moviePic.Size.Width, 72),
                    BackColor = Color.White,
                    Font = new Font("Ubuntu", 14),
                    Padding = new Padding(10, 10, 10, 10)
                };

                label.Location = new Point(moviePic.Left, moviePic.Bottom - label.Size.Height);
                label.BringToFront();

                pictures.Add(moviePic);
                labels.Add(label);
            }

            string connectionString = Login.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, title, rating, image FROM Movie";
                SqlCommand command = new SqlCommand(query, connection); 
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) {
                    int id = reader.GetInt32(0);
                    string title = reader.GetString(1);
                    string rating = reader.GetString(2);
                    string image = reader.GetString(3);
                    

                    if (id % 5 == 0)
                    {
                        locX = 16;
                        locY += 470;
                        createBox(id, title, image, rating);
                    }
                    else
                    {
                        createBox(id, title, image, rating);
                        locX += 346;
                    }
                }

                this.Controls.AddRange(labels.ToArray());
                this.Controls.AddRange(pictures.ToArray());

                connection.Close();
            }            
        }

        private void Home_Load(object sender, EventArgs e)
        {         
            this.pictureBox1.ImageLocation = @"d:\college\3rd semester\object-oriented programming\CinetixBookApp\hero.png";
            ShowAllMovies();
        }
       
        private void ShowReservedMovie_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReservedMovie form = new ReservedMovie();
            form.ShowDialog();
        }
    }
}
