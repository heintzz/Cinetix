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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.movieTitle = new System.Windows.Forms.Label();
            this.descMovie = new System.Windows.Forms.Label();
            this.dateReleaseLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSize = true;
            this.movieTitle.Font = new System.Drawing.Font("Poppins", 32F);
            this.movieTitle.Location = new System.Drawing.Point(492, 36);
            this.movieTitle.Margin = new System.Windows.Forms.Padding(0);
            this.movieTitle.MaximumSize = new System.Drawing.Size(800, 300);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(311, 76);
            this.movieTitle.TabIndex = 3;
            this.movieTitle.Text = "Lorem Ipsum";
            // 
            // descMovie
            // 
            this.descMovie.AutoSize = true;
            this.descMovie.Font = new System.Drawing.Font("Poppins", 14F);
            this.descMovie.ForeColor = System.Drawing.Color.Silver;
            this.descMovie.Location = new System.Drawing.Point(498, 123);
            this.descMovie.MaximumSize = new System.Drawing.Size(800, 0);
            this.descMovie.Name = "descMovie";
            this.descMovie.Size = new System.Drawing.Size(797, 204);
            this.descMovie.TabIndex = 4;
            this.descMovie.Text = resources.GetString("descMovie.Text");
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(958, 895);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 111);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 16F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(664, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "12 April 2019";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 16F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(666, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "7.5/10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 16F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(666, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "romantic, horror, comedy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 16F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(666, 607);
            this.label4.MaximumSize = new System.Drawing.Size(700, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(695, 273);
            this.label4.TabIndex = 13;
            this.label4.Text = resources.GetString("label4.Text");
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.ClientSize = new System.Drawing.Size(1422, 1041);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.dateReleaseLabel);
            this.Controls.Add(this.descMovie);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinetix";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label movieTitle;
        private System.Windows.Forms.Label descMovie;
        private System.Windows.Forms.Label dateReleaseLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}