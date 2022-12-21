using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Cinetix
{
    public partial class Home : Form
    {
        public static string EmailAddress;

        List<MovieReserved> students = new List<MovieReserved>()
        {
                new MovieReserved(){ IdMovie = 1, Username="Harry Potter", Src=@"d:\\college\\3rd semester\\object-oriented programming\\CinetixBookApp\\gambar1.jpg"},
                new MovieReserved(){ IdMovie = 2, Username="Bridge to Terabithia", Src= @"d:\\college\\3rd semester\\object-oriented programming\\CinetixBookApp\\gambar2.jpg"},
                new MovieReserved(){ IdMovie = 3, Username="Blue Lock", Src = @"d:\\college\\3rd semester\\object-oriented programming\\CinetixBookApp\\gambar3.jpg"},
                new MovieReserved(){ IdMovie = 4, Username="Haikyuu", Src = @"d:\\college\\3rd semester\\object-oriented programming\\CinetixBookApp\\gambar4.jpg"},
                new MovieReserved(){ IdMovie = 5, Username="Wednesday", Src = @"d:\\college\\3rd semester\\object-oriented programming\\CinetixBookApp\\gambar5.jpg"},
                new MovieReserved(){ IdMovie = 6, Username="Enola Holmes", Src = @"d:\\college\\3rd semester\\object-oriented programming\\CinetixBookApp\\gambar5.jpg"},
                new MovieReserved(){ IdMovie = 7, Username="Kenji", Src = @"d:\\college\\3rd semester\\object-oriented programming\\CinetixBookApp\\gambar5.jpg"}
        };

        public Home(string email)
        {
            InitializeComponent();

            EmailAddress = email;            
        }

        public void changeForm(object sender, EventArgs e)
        {
            this.Hide();

            Control control = (Control)sender;
            string[] name = control.Name.ToString().Split('_');

            MovieDetail detailMovie = new MovieDetail(name[1]);
            detailMovie.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {         
            this.pictureBox1.ImageLocation = @"d:\college\3rd semester\object-oriented programming\CinetixBookApp\hero.png";

            List<PictureBox> pictures = new List<PictureBox>();
            List<Label> labels = new List<Label>();

            int widthMovie = 320;
            int heightMovie = 440;
            int locX = 16;
            int locY = 460;

            void createBox(string name, string src)
            {
                var moviePic = new PictureBox
                {
                    Name = "pictureBox_" + name,
                    Size = new Size(widthMovie, heightMovie),
                    Location = new Point(locX, locY),
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Cursor = Cursors.Hand,
                    ImageLocation = src
                };
                moviePic.Click += new EventHandler(changeForm);

                Random rnd = new Random();

                var label = new Label
                {
                    Text = name + "\n" + Math.Round((rnd.NextDouble() + 4) * 2, 1) + "/10",
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

            foreach (MovieReserved student in students)
            {
                if (student.IdMovie % 5 == 0)
                {
                    locX = 16;
                    locY += 470;

                    createBox(student.Username, student.Src);                    
                }
                else
                {
                    createBox(student.Username, student.Src);
                    locX += 346;
                }

            }

            this.Controls.AddRange(labels.ToArray());
            this.Controls.AddRange(pictures.ToArray());
        }
       
        private void showReservedMovie_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReservedMovie form = new ReservedMovie();
            form.ShowDialog();
        }
    }
}
