namespace Rental_Form_App
{
    partial class Form2
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
            this.Show_Available_Copies_Btn = new System.Windows.Forms.Button();
            this.Rent_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.copy_IDS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.MaskedTextBox();
            this.Date_Due_Back = new System.Windows.Forms.MaskedTextBox();
            this.Date_Rented = new System.Windows.Forms.MaskedTextBox();
            this.Member_ID = new System.Windows.Forms.MaskedTextBox();
            this.Film_Title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Show_Available_Copies_Btn
            // 
            this.Show_Available_Copies_Btn.Location = new System.Drawing.Point(411, 107);
            this.Show_Available_Copies_Btn.Name = "Show_Available_Copies_Btn";
            this.Show_Available_Copies_Btn.Size = new System.Drawing.Size(244, 42);
            this.Show_Available_Copies_Btn.TabIndex = 33;
            this.Show_Available_Copies_Btn.Text = "Show Available Copies";
            this.Show_Available_Copies_Btn.UseVisualStyleBackColor = true;
            this.Show_Available_Copies_Btn.Click += new System.EventHandler(this.Show_Available_Copies_Btn_Click);
            // 
            // Rent_Btn
            // 
            this.Rent_Btn.Location = new System.Drawing.Point(222, 352);
            this.Rent_Btn.Name = "Rent_Btn";
            this.Rent_Btn.Size = new System.Drawing.Size(121, 37);
            this.Rent_Btn.TabIndex = 32;
            this.Rent_Btn.Text = "Rent";
            this.Rent_Btn.UseVisualStyleBackColor = true;
            this.Rent_Btn.Click += new System.EventHandler(this.Rent_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Rental Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Date Due Back";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date Rented";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Member ID";
            // 
            // copy_IDS
            // 
            this.copy_IDS.FormattingEnabled = true;
            this.copy_IDS.Location = new System.Drawing.Point(222, 107);
            this.copy_IDS.Name = "copy_IDS";
            this.copy_IDS.Size = new System.Drawing.Size(121, 28);
            this.copy_IDS.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Available copy IDs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Film Title";
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(222, 302);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(100, 26);
            this.Cost.TabIndex = 24;
            // 
            // Date_Due_Back
            // 
            this.Date_Due_Back.Location = new System.Drawing.Point(222, 254);
            this.Date_Due_Back.Name = "Date_Due_Back";
            this.Date_Due_Back.Size = new System.Drawing.Size(170, 26);
            this.Date_Due_Back.TabIndex = 23;
            // 
            // Date_Rented
            // 
            this.Date_Rented.Location = new System.Drawing.Point(222, 199);
            this.Date_Rented.Name = "Date_Rented";
            this.Date_Rented.Size = new System.Drawing.Size(170, 26);
            this.Date_Rented.TabIndex = 22;
            // 
            // Member_ID
            // 
            this.Member_ID.Location = new System.Drawing.Point(222, 157);
            this.Member_ID.Name = "Member_ID";
            this.Member_ID.Size = new System.Drawing.Size(170, 26);
            this.Member_ID.TabIndex = 21;
            // 
            // Film_Title
            // 
            this.Film_Title.Location = new System.Drawing.Point(222, 61);
            this.Film_Title.Name = "Film_Title";
            this.Film_Title.Size = new System.Drawing.Size(186, 26);
            this.Film_Title.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Show_Available_Copies_Btn);
            this.Controls.Add(this.Rent_Btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copy_IDS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Date_Due_Back);
            this.Controls.Add(this.Date_Rented);
            this.Controls.Add(this.Member_ID);
            this.Controls.Add(this.Film_Title);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Show_Available_Copies_Btn;
        private System.Windows.Forms.Button Rent_Btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox copy_IDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Cost;
        private System.Windows.Forms.MaskedTextBox Date_Due_Back;
        private System.Windows.Forms.MaskedTextBox Date_Rented;
        private System.Windows.Forms.MaskedTextBox Member_ID;
        private System.Windows.Forms.TextBox Film_Title;
    }
}