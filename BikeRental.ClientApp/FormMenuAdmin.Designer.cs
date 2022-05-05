namespace BikeRental.ClientApp
{
    partial class FormMenuAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFixes = new System.Windows.Forms.Button();
            this.buttonBorrowedBikesAdmin = new System.Windows.Forms.Button();
            this.buttonCatalogAdmin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.userControlCatalogAdmin1 = new BikeRental.ClientApp.UserControlCatalogAdmin();
            this.userControlBorrowedAdmin1 = new BikeRental.ClientApp.UserControlBorrowedAdmin();
            this.userControlFixesAdmin1 = new BikeRental.ClientApp.UserControlFixesAdmin();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonFixes);
            this.panel1.Controls.Add(this.buttonBorrowedBikesAdmin);
            this.panel1.Controls.Add(this.buttonCatalogAdmin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 462);
            this.panel1.TabIndex = 0;
            // 
            // buttonFixes
            // 
            this.buttonFixes.Location = new System.Drawing.Point(12, 259);
            this.buttonFixes.Name = "buttonFixes";
            this.buttonFixes.Size = new System.Drawing.Size(178, 75);
            this.buttonFixes.TabIndex = 2;
            this.buttonFixes.Text = "Naprawy";
            this.buttonFixes.UseVisualStyleBackColor = true;
            this.buttonFixes.Click += new System.EventHandler(this.buttonFixes_Click);
            // 
            // buttonBorrowedBikesAdmin
            // 
            this.buttonBorrowedBikesAdmin.Location = new System.Drawing.Point(12, 181);
            this.buttonBorrowedBikesAdmin.Name = "buttonBorrowedBikesAdmin";
            this.buttonBorrowedBikesAdmin.Size = new System.Drawing.Size(178, 72);
            this.buttonBorrowedBikesAdmin.TabIndex = 1;
            this.buttonBorrowedBikesAdmin.Text = "Wypożyczenia";
            this.buttonBorrowedBikesAdmin.UseVisualStyleBackColor = true;
            this.buttonBorrowedBikesAdmin.Click += new System.EventHandler(this.buttonBorrowedBikesAdmin_Click);
            // 
            // buttonCatalogAdmin
            // 
            this.buttonCatalogAdmin.Location = new System.Drawing.Point(12, 105);
            this.buttonCatalogAdmin.Name = "buttonCatalogAdmin";
            this.buttonCatalogAdmin.Size = new System.Drawing.Size(178, 70);
            this.buttonCatalogAdmin.TabIndex = 0;
            this.buttonCatalogAdmin.Text = "Katalog";
            this.buttonCatalogAdmin.UseVisualStyleBackColor = true;
            this.buttonCatalogAdmin.Click += new System.EventHandler(this.buttonCatalogAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 50);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonLogOut);
            this.panel3.Location = new System.Drawing.Point(200, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 50);
            this.panel3.TabIndex = 2;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(497, 14);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Wyloguj";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // userControlCatalogAdmin1
            // 
            this.userControlCatalogAdmin1.Location = new System.Drawing.Point(200, 50);
            this.userControlCatalogAdmin1.Name = "userControlCatalogAdmin1";
            this.userControlCatalogAdmin1.Size = new System.Drawing.Size(584, 370);
            this.userControlCatalogAdmin1.TabIndex = 3;
            // 
            // userControlBorrowedAdmin1
            // 
            this.userControlBorrowedAdmin1.Location = new System.Drawing.Point(200, 50);
            this.userControlBorrowedAdmin1.Name = "userControlBorrowedAdmin1";
            this.userControlBorrowedAdmin1.Size = new System.Drawing.Size(584, 370);
            this.userControlBorrowedAdmin1.TabIndex = 4;
            // 
            // userControlFixesAdmin1
            // 
            this.userControlFixesAdmin1.Location = new System.Drawing.Point(200, 50);
            this.userControlFixesAdmin1.Name = "userControlFixesAdmin1";
            this.userControlFixesAdmin1.Size = new System.Drawing.Size(584, 370);
            this.userControlFixesAdmin1.TabIndex = 5;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.userControlFixesAdmin1);
            this.Controls.Add(this.userControlBorrowedAdmin1);
            this.Controls.Add(this.userControlCatalogAdmin1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuAdmin";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonBorrowedBikesAdmin;
        private System.Windows.Forms.Button buttonCatalogAdmin;
        private System.Windows.Forms.Button buttonFixes;
        private System.Windows.Forms.Button buttonLogOut;
        private UserControlCatalogAdmin userControlCatalogAdmin1;
        private UserControlBorrowedAdmin userControlBorrowedAdmin1;
        private UserControlFixesAdmin userControlFixesAdmin1;
    }
}