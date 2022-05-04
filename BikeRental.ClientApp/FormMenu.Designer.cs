
namespace BikeRental.ClientApp
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBikeCatalog = new System.Windows.Forms.Button();
            this.buttonBorrowedBikes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControlCatalog1 = new BikeRental.ClientApp.UserControlCatalog();
            this.userControlBorrowed1 = new BikeRental.ClientApp.UserControlBorrowed();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(467, 14);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "Wyloguj";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonBikeCatalog
            // 
            this.buttonBikeCatalog.Location = new System.Drawing.Point(14, 44);
            this.buttonBikeCatalog.Name = "buttonBikeCatalog";
            this.buttonBikeCatalog.Size = new System.Drawing.Size(180, 76);
            this.buttonBikeCatalog.TabIndex = 2;
            this.buttonBikeCatalog.Text = "Katalog Rowerów";
            this.buttonBikeCatalog.UseVisualStyleBackColor = true;
            // 
            // buttonBorrowedBikes
            // 
            this.buttonBorrowedBikes.Location = new System.Drawing.Point(14, 137);
            this.buttonBorrowedBikes.Name = "buttonBorrowedBikes";
            this.buttonBorrowedBikes.Size = new System.Drawing.Size(180, 76);
            this.buttonBorrowedBikes.TabIndex = 3;
            this.buttonBorrowedBikes.Text = "Moje Wypożyczenia";
            this.buttonBorrowedBikes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBikeCatalog);
            this.panel1.Controls.Add(this.buttonBorrowedBikes);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 462);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLogOut);
            this.panel2.Location = new System.Drawing.Point(200, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 50);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 50);
            this.panel3.TabIndex = 6;
            // 
            // userControlCatalog1
            // 
            this.userControlCatalog1.Location = new System.Drawing.Point(200, 44);
            this.userControlCatalog1.Name = "userControlCatalog1";
            this.userControlCatalog1.Size = new System.Drawing.Size(584, 370);
            this.userControlCatalog1.TabIndex = 7;
            // 
            // userControlBorrowed1
            // 
            this.userControlBorrowed1.Location = new System.Drawing.Point(200, 41);
            this.userControlBorrowed1.Name = "userControlBorrowed1";
            this.userControlBorrowed1.Size = new System.Drawing.Size(584, 370);
            this.userControlBorrowed1.TabIndex = 8;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.userControlBorrowed1);
            this.Controls.Add(this.userControlCatalog1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBikeCatalog;
        private System.Windows.Forms.Button buttonBorrowedBikes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private UserControlCatalog userControlCatalog1;
        private UserControlBorrowed userControlBorrowed1;
    }
}