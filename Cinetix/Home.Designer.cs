namespace Cinetix
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showReservedMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1386, 325);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cinetix";
            // 
            // showReservedMovie
            // 
            this.showReservedMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showReservedMovie.FlatAppearance.BorderSize = 0;
            this.showReservedMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.showReservedMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.showReservedMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showReservedMovie.Image = ((System.Drawing.Image)(resources.GetObject("showReservedMovie.Image")));
            this.showReservedMovie.Location = new System.Drawing.Point(1331, 43);
            this.showReservedMovie.Name = "showReservedMovie";
            this.showReservedMovie.Size = new System.Drawing.Size(39, 49);
            this.showReservedMovie.TabIndex = 3;
            this.showReservedMovie.Text = "/";
            this.showReservedMovie.UseVisualStyleBackColor = true;
            this.showReservedMovie.Click += new System.EventHandler(this.showReservedMovie_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 40);
            this.ClientSize = new System.Drawing.Size(1422, 1041);
            this.Controls.Add(this.showReservedMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinetix";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showReservedMovie;
    }
}

