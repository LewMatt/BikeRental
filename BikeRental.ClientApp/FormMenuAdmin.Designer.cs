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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCatalogAdmin = new System.Windows.Forms.Button();
            this.buttonBorrowedBikesAdmin = new System.Windows.Forms.Button();
            this.buttonFixes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 50);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(200, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 50);
            this.panel3.TabIndex = 2;
            // 
            // buttonCatalogAdmin
            // 
            this.buttonCatalogAdmin.Location = new System.Drawing.Point(12, 105);
            this.buttonCatalogAdmin.Name = "buttonCatalogAdmin";
            this.buttonCatalogAdmin.Size = new System.Drawing.Size(178, 70);
            this.buttonCatalogAdmin.TabIndex = 0;
            this.buttonCatalogAdmin.Text = "Katalog";
            this.buttonCatalogAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonBorrowedBikesAdmin
            // 
            this.buttonBorrowedBikesAdmin.Location = new System.Drawing.Point(12, 181);
            this.buttonBorrowedBikesAdmin.Name = "buttonBorrowedBikesAdmin";
            this.buttonBorrowedBikesAdmin.Size = new System.Drawing.Size(178, 72);
            this.buttonBorrowedBikesAdmin.TabIndex = 1;
            this.buttonBorrowedBikesAdmin.Text = "Wypożyczenia";
            this.buttonBorrowedBikesAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonFixes
            // 
            this.buttonFixes.Location = new System.Drawing.Point(12, 259);
            this.buttonFixes.Name = "buttonFixes";
            this.buttonFixes.Size = new System.Drawing.Size(178, 75);
            this.buttonFixes.TabIndex = 2;
            this.buttonFixes.Text = "Naprawy";
            this.buttonFixes.UseVisualStyleBackColor = true;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenuAdmin";
            this.Text = "FormMenuAdmin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonBorrowedBikesAdmin;
        private System.Windows.Forms.Button buttonCatalogAdmin;
        private System.Windows.Forms.Button buttonFixes;
    }
}