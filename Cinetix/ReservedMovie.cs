using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace Cinetix
{
    public partial class ReservedMovie : Form
    {
        public ReservedMovie()
        {
            InitializeComponent();
        }

        private void EditClickHandler(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            FlowLayoutPanel container = (FlowLayoutPanel)button.Parent;

            this.Hide();
            EditBookedMovie form = new EditBookedMovie(container.Name);
            form.ShowDialog();
        }
        private void DeleteClickHandler(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to cancel the reservation? We won't be able to refund your money.",
            "Confirm Cancel",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Button button = (Button)sender;
                FlowLayoutPanel container = (FlowLayoutPanel)button.Parent;

                string connectionString = Login.GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM dbo.Reservation WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", container.Name);

                        int deleted = 0;
                        try
                        {
                            deleted = command.ExecuteNonQuery();

                        }
                        catch (SqlException err)
                        {
                            MessageBox.Show("error: ", err.Message);
                        }

                        if (deleted == 0)
                        {
                            MessageBox.Show("Gagal menghapus");
                        }
                        else
                        {
                            container.Dispose();
                            this.Hide();
                            
                            ReservedMovie form = new ReservedMovie();
                            form.ShowDialog();
                        }
                    }

                    connection.Close();
                }
            }                       
        }

        private void ReservedMovie_Load(object sender, EventArgs e)
        {
            string connectionString = Login.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = "SELECT * FROM Reservation WHERE email = @email";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("email", Home.EmailAddress);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                List<FlowLayoutPanel> panels = new List<FlowLayoutPanel>();

                int panelWidth = 1360;
                int panelHeight = 425;

                int xLocation = 22;
                int yLocation = 90;

                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string title = reader.GetString(1);
                    string date = reader.GetString(2);
                    int numOrder = reader.GetInt32(4);
                    string src_img = reader.GetString(5);

                    FlowLayoutPanel panel = new FlowLayoutPanel
                    {
                        Name = id,
                        Size = new Size(panelWidth, panelHeight),
                        Location = new Point(xLocation, yLocation),
                        BackColor = Color.White,
                        FlowDirection = FlowDirection.LeftToRight,
                    };

                    PictureBox picture = new PictureBox
                    {
                        Size = new Size(300, 420),
                        SizeMode = PictureBoxSizeMode.StretchImage,                        
                    };

                    picture.ImageLocation = src_img;

                    FlowLayoutPanel descPanel = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.TopDown,
                        Size = new Size(950, panel.Height),
                        Margin = new Padding(20, 0, 0, 0),                        
                    };

                    Label movieTitle = new Label
                    {
                        Text = title,
                        AutoSize = true,               
                        Font = new Font("Ubuntu", 20),
                        Margin = new Padding(0, 10, 0, 20),
                    };

                    Label cinemaPlace = new Label
                    {
                        Text = "Tubes Cinema XXI",
                        AutoSize = true,
                        Font = new Font("Ubuntu", 16),
                        Margin = new Padding(0, 0, 0, 20),
                    };

                    Label dateOfReservation = new Label
                    {
                        Text = date,
                        AutoSize = true,
                        Font = new Font("Ubuntu", 16),
                        Margin = new Padding(0, 0, 0, 20),
                    };

                    Label numOfOrder = new Label
                    {
                        Text = numOrder > 1 ? numOrder.ToString() + " seats" : numOrder.ToString() + " seat",
                        AutoSize = true,
                        Font = new Font("Ubuntu", 16),
                        Margin = new Padding(0, 0, 0, 20),
                    };

                    Button buttonDel = new Button
                    { 
                        Size = new Size(30, 30),
                        FlatStyle = FlatStyle.Flat,
                        BackgroundImage = new Bitmap("D:/college/3rd semester/object-oriented programming/CinetixBookApp/delete.png"),                                          
                        BackgroundImageLayout = ImageLayout.Center,
                        FlatAppearance =
                        {
                            BorderSize = 0,
                        },
                        Margin = new Padding(0, panel.Height - 45, 0, 0),
                        Cursor = Cursors.Hand,
                    };

                    Button buttonEdit = new Button
                    {
                        Size = new Size(30, 30),
                        FlatStyle = FlatStyle.Flat,
                        BackgroundImage = new Bitmap("D:/college/3rd semester/object-oriented programming/CinetixBookApp/edit.png"),
                        BackgroundImageLayout = ImageLayout.Center,
                        FlatAppearance =
                        {
                            BorderSize = 0,
                        },
                        Margin = new Padding(15, panel.Height - 45, 0, 0),
                        Cursor = Cursors.Hand,
                    };

                    descPanel.Controls.Add(movieTitle);
                    descPanel.Controls.Add(cinemaPlace);
                    descPanel.Controls.Add(dateOfReservation);
                    descPanel.Controls.Add(numOfOrder);
                    
                    panel.Controls.Add(picture);                 
                    panel.Controls.Add(descPanel);
                    panel.Controls.Add(buttonDel);
                    panel.Controls.Add(buttonEdit);

                    panels.Add(panel);

                    yLocation += panelHeight + 20;
                    
                    buttonDel.Click += DeleteClickHandler;
                    buttonEdit.Click += EditClickHandler;
                }

                this.Controls.AddRange(panels.ToArray());
            }

            connection.Close();
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home(Home.EmailAddress);
            home.ShowDialog();
        }
    }
}
