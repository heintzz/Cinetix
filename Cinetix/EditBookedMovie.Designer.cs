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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NumOrderLabel = new System.Windows.Forms.Label();
            this.NumOrder = new System.Windows.Forms.NumericUpDown();
            this.EditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePoster
            // 
            this.MoviePoster.Location = new System.Drawing.Point(22, 29);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(440, 640);
            this.MoviePoster.TabIndex = 1;
            this.MoviePoster.TabStop = false;
            // 
            // MovieTitle
            // 
            this.MovieTitle.AutoSize = true;
            this.MovieTitle.Font = new System.Drawing.Font("Ubuntu", 32F);
            this.MovieTitle.Location = new System.Drawing.Point(482, 29);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(0, 51);
            this.MovieTitle.TabIndex = 2;
            // 
            // CinemaLabel
            // 
            this.CinemaLabel.AutoSize = true;
            this.CinemaLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinemaLabel.Location = new System.Drawing.Point(489, 104);
            this.CinemaLabel.Name = "CinemaLabel";
            this.CinemaLabel.Size = new System.Drawing.Size(100, 37);
            this.CinemaLabel.TabIndex = 4;
            this.CinemaLabel.Text = "Cinema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // ReservationDate
            // 
            this.ReservationDate.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationDate.Location = new System.Drawing.Point(496, 241);
            this.ReservationDate.MinDate = new System.DateTime(2022, 12, 21, 0, 0, 0, 0);
            this.ReservationDate.Name = "ReservationDate";
            this.ReservationDate.Size = new System.Drawing.Size(259, 32);
            this.ReservationDate.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(496, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(259, 25);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Tubes Cinema XXI";
            // 
            // NumOrderLabel
            // 
            this.NumOrderLabel.AutoSize = true;
            this.NumOrderLabel.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOrderLabel.Location = new System.Drawing.Point(491, 295);
            this.NumOrderLabel.Name = "NumOrderLabel";
            this.NumOrderLabel.Size = new System.Drawing.Size(196, 37);
            this.NumOrderLabel.TabIndex = 9;
            this.NumOrderLabel.Text = "Amount Of Order";
            // 
            // NumOrder
            // 
            this.NumOrder.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOrder.Location = new System.Drawing.Point(498, 335);
            this.NumOrder.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumOrder.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumOrder.Name = "NumOrder";
            this.NumOrder.ReadOnly = true;
            this.NumOrder.Size = new System.Drawing.Size(53, 32);
            this.NumOrder.TabIndex = 10;
            this.NumOrder.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
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
            // EditBookedMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 1041);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.NumOrder);
            this.Controls.Add(this.NumOrderLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ReservationDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CinemaLabel);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MoviePoster);
            this.Name = "EditBookedMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBookedMovie";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.Label CinemaLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ReservationDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NumOrderLabel;
        private System.Windows.Forms.NumericUpDown NumOrder;
        private System.Windows.Forms.Button EditBtn;
    }
}