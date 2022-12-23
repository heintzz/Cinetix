namespace Cinetix
{
    partial class EditBookedMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookedMovie));
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.MovieTitle = new System.Windows.Forms.Label();
            this.CinemaLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReservationDate = new System.Windows.Forms.DateTimePicker();
            this.NumOrderLabel = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BackToHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountOfOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePoster
            // 
            this.MoviePoster.Location = new System.Drawing.Point(22, 29);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(440, 702);
            this.MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePoster.TabIndex = 1;
            this.MoviePoster.TabStop = false;
            // 
            // MovieTitle
            // 
            this.MovieTitle.AutoSize = true;
            this.MovieTitle.Font = new System.Drawing.Font("Ubuntu", 26F);
            this.MovieTitle.Location = new System.Drawing.Point(494, 29);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(92, 41);
            this.MovieTitle.TabIndex = 2;
            this.MovieTitle.Text = "Title";
            // 
            // CinemaLabel
            // 
            this.CinemaLabel.AutoSize = true;
            this.CinemaLabel.Font = new System.Drawing.Font("Poppins", 24F);
            this.CinemaLabel.Location = new System.Drawing.Point(492, 103);
            this.CinemaLabel.Name = "CinemaLabel";
            this.CinemaLabel.Size = new System.Drawing.Size(152, 56);
            this.CinemaLabel.TabIndex = 4;
            this.CinemaLabel.Text = "Cinema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 24F);
            this.label4.Location = new System.Drawing.Point(493, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 56);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // ReservationDate
            // 
            this.ReservationDate.Font = new System.Drawing.Font("Ubuntu", 20F);
            this.ReservationDate.Location = new System.Drawing.Point(501, 270);
            this.ReservationDate.MinDate = new System.DateTime(2022, 12, 21, 0, 0, 0, 0);
            this.ReservationDate.Name = "ReservationDate";
            this.ReservationDate.Size = new System.Drawing.Size(259, 38);
            this.ReservationDate.TabIndex = 6;
            // 
            // NumOrderLabel
            // 
            this.NumOrderLabel.AutoSize = true;
            this.NumOrderLabel.Font = new System.Drawing.Font("Poppins", 24F);
            this.NumOrderLabel.Location = new System.Drawing.Point(493, 330);
            this.NumOrderLabel.Name = "NumOrderLabel";
            this.NumOrderLabel.Size = new System.Drawing.Size(296, 56);
            this.NumOrderLabel.TabIndex = 9;
            this.NumOrderLabel.Text = "Amount Of Order";
            // 
            // EditBtn
            // 
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Location = new System.Drawing.Point(958, 895);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(405, 116);
            this.EditBtn.TabIndex = 12;
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BackToHome
            // 
            this.BackToHome.AutoSize = true;
            this.BackToHome.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToHome.Font = new System.Drawing.Font("Poppins", 16F);
            this.BackToHome.ForeColor = System.Drawing.Color.White;
            this.BackToHome.Location = new System.Drawing.Point(1327, 9);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(83, 39);
            this.BackToHome.TabIndex = 23;
            this.BackToHome.Text = "Home";
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 20F);
            this.label1.Location = new System.Drawing.Point(497, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tubes Cinema XXI";
            // 
            // AmountOfOrder
            // 
            this.AmountOfOrder.AutoSize = true;
            this.AmountOfOrder.Font = new System.Drawing.Font("Ubuntu", 20F);
            this.AmountOfOrder.Location = new System.Drawing.Point(497, 381);
            this.AmountOfOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountOfOrder.Name = "AmountOfOrder";
            this.AmountOfOrder.Size = new System.Drawing.Size(30, 33);
            this.AmountOfOrder.TabIndex = 25;
            this.AmountOfOrder.Text = "1";
            // 
            // EditBookedMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 1041);
            this.Controls.Add(this.AmountOfOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToHome);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.NumOrderLabel);
            this.Controls.Add(this.ReservationDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CinemaLabel);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MoviePoster);
            this.Name = "EditBookedMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBookedMovie";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.Label CinemaLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ReservationDate;
        private System.Windows.Forms.Label NumOrderLabel;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label BackToHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AmountOfOrder;
    }
}