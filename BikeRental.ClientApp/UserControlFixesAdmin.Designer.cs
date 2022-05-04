namespace BikeRental.ClientApp
{
    partial class UserControlFixesAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderRepairOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBikeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naprawy Admin";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRepairOrderID,
            this.columnHeaderBikeID,
            this.columnHeaderDescription});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(524, 298);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRepairOrderID
            // 
            this.columnHeaderRepairOrderID.Text = "Numer zlecenia";
            this.columnHeaderRepairOrderID.Width = 105;
            // 
            // columnHeaderBikeID
            // 
            this.columnHeaderBikeID.Text = "Nr Roweru";
            this.columnHeaderBikeID.Width = 244;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Opis Usterki";
            this.columnHeaderDescription.Width = 242;
            // 
            // UserControlFixesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlFixesAdmin";
            this.Size = new System.Drawing.Size(584, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderRepairOrderID;
        private System.Windows.Forms.ColumnHeader columnHeaderBikeID;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
    }
}
