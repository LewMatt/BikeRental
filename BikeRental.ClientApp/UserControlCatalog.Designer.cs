﻿namespace BikeRental.ClientApp
{
    partial class UserControlCatalog
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
            this.labelCatalog = new System.Windows.Forms.Label();
            this.listViewCatalog = new System.Windows.Forms.ListView();
            this.columnHeaderBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAvailable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelCatalog
            // 
            this.labelCatalog.AutoSize = true;
            this.labelCatalog.Location = new System.Drawing.Point(262, 11);
            this.labelCatalog.Name = "labelCatalog";
            this.labelCatalog.Size = new System.Drawing.Size(43, 13);
            this.labelCatalog.TabIndex = 0;
            this.labelCatalog.Text = "Katalog";
            // 
            // listViewCatalog
            // 
            this.listViewCatalog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderBrand,
            this.columnHeaderModel,
            this.columnHeaderType,
            this.columnHeaderColor,
            this.columnHeaderPrice,
            this.columnHeaderAvailable});
            this.listViewCatalog.HideSelection = false;
            this.listViewCatalog.Location = new System.Drawing.Point(30, 43);
            this.listViewCatalog.Name = "listViewCatalog";
            this.listViewCatalog.Size = new System.Drawing.Size(525, 293);
            this.listViewCatalog.TabIndex = 1;
            this.listViewCatalog.UseCompatibleStateImageBehavior = false;
            this.listViewCatalog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBrand
            // 
            this.columnHeaderBrand.DisplayIndex = 0;
            this.columnHeaderBrand.Text = "Marka ";
            this.columnHeaderBrand.Width = 87;
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.DisplayIndex = 1;
            this.columnHeaderModel.Text = "Model";
            this.columnHeaderModel.Width = 75;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.DisplayIndex = 2;
            this.columnHeaderType.Text = "Typ";
            this.columnHeaderType.Width = 74;
            // 
            // columnHeaderColor
            // 
            this.columnHeaderColor.DisplayIndex = 3;
            this.columnHeaderColor.Text = "Kolor";
            this.columnHeaderColor.Width = 86;
            // 
            // columnHeaderAvailable
            // 
            this.columnHeaderAvailable.DisplayIndex = 4;
            this.columnHeaderAvailable.Text = "Dostępność";
            this.columnHeaderAvailable.Width = 81;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Cena";
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.DisplayIndex = 6;
            this.columnHeaderID.Text = "ID";
            // 
            // UserControlCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewCatalog);
            this.Controls.Add(this.labelCatalog);
            this.Name = "UserControlCatalog";
            this.Size = new System.Drawing.Size(584, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCatalog;
        private System.Windows.Forms.ColumnHeader columnHeaderBrand;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderColor;
        private System.Windows.Forms.ColumnHeader columnHeaderAvailable;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        public System.Windows.Forms.ListView listViewCatalog;
    }
}
