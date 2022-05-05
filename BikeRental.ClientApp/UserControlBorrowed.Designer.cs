namespace BikeRental.ClientApp
{
    partial class UserControlBorrowed
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBorrowed = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderExp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonOddaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBorrowed
            // 
            this.labelBorrowed.AutoSize = true;
            this.labelBorrowed.Location = new System.Drawing.Point(228, 39);
            this.labelBorrowed.Name = "labelBorrowed";
            this.labelBorrowed.Size = new System.Drawing.Size(102, 13);
            this.labelBorrowed.TabIndex = 0;
            this.labelBorrowed.Text = "Moje Wypożyczenia";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderPrice,
            this.columnHeaderExp});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 228);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Cena";
            // 
            // columnHeaderExp
            // 
            this.columnHeaderExp.Text = "Data zakonczenia";
            this.columnHeaderExp.Width = 103;
            // 
            // buttonOddaj
            // 
            this.buttonOddaj.Location = new System.Drawing.Point(472, 178);
            this.buttonOddaj.Name = "buttonOddaj";
            this.buttonOddaj.Size = new System.Drawing.Size(75, 41);
            this.buttonOddaj.TabIndex = 2;
            this.buttonOddaj.Text = "Oddaj";
            this.buttonOddaj.UseVisualStyleBackColor = true;
            this.buttonOddaj.Click += new System.EventHandler(this.buttonOddaj_Click);
            // 
            // UserControlBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOddaj);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelBorrowed);
            this.Name = "UserControlBorrowed";
            this.Size = new System.Drawing.Size(584, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBorrowed;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderExp;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonOddaj;
    }
}
