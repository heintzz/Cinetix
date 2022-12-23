using System.Windows.Forms;

namespace Cinetix
{
    partial class MakeReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeReservation));
            this.titleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.BookBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumOrder = new System.Windows.Forms.TextBox();
            this.ReservationDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Poppins", 24F);
            this.titleLabel.Location = new System.Drawing.Point(8, 35);
            this.titleLabel.MaximumSize = new System.Drawing.Size(1100, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(120, 56);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Judul ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 107);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(121, 56);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // InputName
            // 
            this.InputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputName.Font = new System.Drawing.Font("Ubuntu", 20F);
            this.InputName.Location = new System.Drawing.Point(23, 157);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(716, 31);
            this.InputName.TabIndex = 1;
            // 
            // BookBtn
            // 
            this.BookBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookBtn.BackgroundImage")));
            this.BookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookBtn.FlatAppearance.BorderSize = 0;
            this.BookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookBtn.Location = new System.Drawing.Point(958, 895);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(405, 116);
            this.BookBtn.TabIndex = 11;
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount of Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 56);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Price";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Ubuntu", 24F);
            this.totalPrice.Location = new System.Drawing.Point(22, 473);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(154, 39);
            this.totalPrice.TabIndex = 15;
            this.totalPrice.Text = "Rp35.000";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Ubuntu", 24F);
            this.balanceLabel.Location = new System.Drawing.Point(22, 653);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(0, 39);
            this.balanceLabel.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 56);
            this.label5.TabIndex = 16;
            this.label5.Text = "Your Balance";
            // 
            // NumOrder
            // 
            this.NumOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumOrder.Font = new System.Drawing.Font("Ubuntu", 20F);
            this.NumOrder.Location = new System.Drawing.Point(25, 361);
            this.NumOrder.MaxLength = 2;
            this.NumOrder.Name = "NumOrder";
            this.NumOrder.Size = new System.Drawing.Size(59, 31);
            this.NumOrder.TabIndex = 2;
            this.NumOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumOrder_KeyDown);
            // 
            // ReservationDate
            // 
            this.ReservationDate.CalendarFont = new System.Drawing.Font("Ubuntu", 20F);
            this.ReservationDate.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationDate.Location = new System.Drawing.Point(25, 257);
            this.ReservationDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.ReservationDate.MinDate = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            this.ReservationDate.Name = "ReservationDate";
            this.ReservationDate.Size = new System.Drawing.Size(333, 39);
            this.ReservationDate.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 56);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Poppins", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1327, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 39);
            this.label4.TabIndex = 23;
            this.label4.Text = "Home";
            this.label4.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // MakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 1041);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReservationDate);
            this.Controls.Add(this.NumOrder);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MakeReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinetix";
            this.Load += new System.EventHandler(this.MakeReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Button BookBtn;
        private Label label1;
        private Label label2;
        private Label totalPrice;
        private Label balanceLabel;
        private Label label5;
        private TextBox NumOrder;
        private DateTimePicker ReservationDate;
        private Label label3;
        private Label label4;
    }
}