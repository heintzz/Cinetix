namespace Cinetix
{
    partial class ReservedMovie
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
            this.BackToHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToHome
            // 
            this.BackToHome.AutoSize = true;
            this.BackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToHome.Font = new System.Drawing.Font("Poppins", 16F);
            this.BackToHome.Location = new System.Drawing.Point(1308, 29);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(83, 39);
            this.BackToHome.TabIndex = 0;
            this.BackToHome.Text = "Home";
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // ReservedMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 40);
            this.ClientSize = new System.Drawing.Size(1422, 1041);
            this.Controls.Add(this.BackToHome);
            this.Name = "ReservedMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinetix";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackToHome;
    }
}