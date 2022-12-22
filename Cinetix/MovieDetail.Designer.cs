namespace Cinetix
{
    partial class MovieDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetail));
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.MovieTitle = new System.Windows.Forms.Label();
            this.DescMovie = new System.Windows.Forms.Label();
            this.dateReleaseLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.BookNowBtn = new System.Windows.Forms.Button();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.Review = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BackToHome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePoster
            // 
            this.MoviePoster.Location = new System.Drawing.Point(26, 36);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(440, 640);
            this.MoviePoster.TabIndex = 0;
            this.MoviePoster.TabStop = false;
            // 
            // MovieTitle
            // 
            this.MovieTitle.AutoSize = true;
            this.MovieTitle.Font = new System.Drawing.Font("Poppins", 32F);
            this.MovieTitle.Location = new System.Drawing.Point(492, 36);
            this.MovieTitle.Margin = new System.Windows.Forms.Padding(0);
            this.MovieTitle.MaximumSize = new System.Drawing.Size(800, 300);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(311, 76);
            this.MovieTitle.TabIndex = 3;
            this.MovieTitle.Text = "Lorem Ipsum";
            // 
            // DescMovie
            // 
            this.DescMovie.AutoSize = true;
            this.DescMovie.Font = new System.Drawing.Font("Poppins", 14F);
            this.DescMovie.ForeColor = System.Drawing.Color.Silver;
            this.DescMovie.Location = new System.Drawing.Point(498, 123);
            this.DescMovie.MaximumSize = new System.Drawing.Size(800, 0);
            this.DescMovie.Name = "DescMovie";
            this.DescMovie.Size = new System.Drawing.Size(797, 204);
            this.DescMovie.TabIndex = 4;
            this.DescMovie.Text = resources.GetString("DescMovie.Text");
            // 
            // dateReleaseLabel
            // 
            this.dateReleaseLabel.AutoSize = true;
            this.dateReleaseLabel.Font = new System.Drawing.Font("Poppins", 24F);
            this.dateReleaseLabel.Location = new System.Drawing.Point(496, 358);
            this.dateReleaseLabel.Name = "dateReleaseLabel";
            this.dateReleaseLabel.Size = new System.Drawing.Size(150, 56);
            this.dateReleaseLabel.TabIndex = 5;
            this.dateReleaseLabel.Text = "Release";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Poppins", 24F);
            this.ratingLabel.Location = new System.Drawing.Point(496, 438);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(127, 56);
            this.ratingLabel.TabIndex = 6;
            this.ratingLabel.Text = "Rating";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Poppins", 24F);
            this.genreLabel.Location = new System.Drawing.Point(496, 518);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(121, 56);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre";
            // 
            // BookNowBtn
            // 
            this.BookNowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookNowBtn.FlatAppearance.BorderSize = 0;
            this.BookNowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BookNowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BookNowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookNowBtn.Image = ((System.Drawing.Image)(resources.GetObject("BookNowBtn.Image")));
            this.BookNowBtn.Location = new System.Drawing.Point(958, 895);
            this.BookNowBtn.Name = "BookNowBtn";
            this.BookNowBtn.Size = new System.Drawing.Size(403, 111);
            this.BookNowBtn.TabIndex = 8;
            this.BookNowBtn.UseVisualStyleBackColor = true;
            this.BookNowBtn.Click += new System.EventHandler(this.BookNowBtn_Click);
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Font = new System.Drawing.Font("Poppins", 16F);
            this.ReleaseDate.ForeColor = System.Drawing.Color.DimGray;
            this.ReleaseDate.Location = new System.Drawing.Point(664, 367);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(145, 39);
            this.ReleaseDate.TabIndex = 9;
            this.ReleaseDate.Text = "12 April 2019";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Font = new System.Drawing.Font("Poppins", 16F);
            this.Rating.ForeColor = System.Drawing.Color.DimGray;
            this.Rating.Location = new System.Drawing.Point(666, 447);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(79, 39);
            this.Rating.TabIndex = 10;
            this.Rating.Text = "7.5/10";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Font = new System.Drawing.Font("Poppins", 16F);
            this.Genre.ForeColor = System.Drawing.Color.DimGray;
            this.Genre.Location = new System.Drawing.Point(666, 527);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(294, 39);
            this.Genre.TabIndex = 11;
            this.Genre.Text = "romantic, horror, comedy";
            // 
            // Review
            // 
            this.Review.AutoSize = true;
            this.Review.Font = new System.Drawing.Font("Poppins", 16F);
            this.Review.ForeColor = System.Drawing.Color.DimGray;
            this.Review.Location = new System.Drawing.Point(666, 607);
            this.Review.MaximumSize = new System.Drawing.Size(700, 0);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(695, 273);
            this.Review.TabIndex = 13;
            this.Review.Text = resources.GetString("Review.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 24F);
            this.label5.Location = new System.Drawing.Point(496, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 56);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reviews";
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
            this.BackToHome.TabIndex = 22;
            this.BackToHome.Text = "Home";
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // MovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.ClientSize = new System.Drawing.Size(1422, 1041);
            this.Controls.Add(this.BackToHome);
            this.Controls.Add(this.Review);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.BookNowBtn);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.dateReleaseLabel);
            this.Controls.Add(this.DescMovie);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MoviePoster);
            this.Name = "MovieDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinetix";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.Label DescMovie;
        private System.Windows.Forms.Label dateReleaseLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Button BookNowBtn;
        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Review;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BackToHome;
    }
}