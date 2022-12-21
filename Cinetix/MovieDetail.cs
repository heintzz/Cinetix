using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinetix
{
    public partial class MovieDetail : Form
    {       
        public MovieDetail(string title)
        {
            InitializeComponent();
            
            this.movieTitle.Text = title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            string title = this.movieTitle.Text;
            
            MakeReservation bookForm = new MakeReservation(title);
            bookForm.ShowDialog();
        }
    }
}
