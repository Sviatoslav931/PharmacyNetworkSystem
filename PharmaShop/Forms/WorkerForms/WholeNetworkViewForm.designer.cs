namespace PharmaShop
{
    partial class WholeNetworkViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WholeNetworkViewForm));
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelNumberOfMedicament = new System.Windows.Forms.Label();
            this.productsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productsID,
            this.productsName,
            this.productsDose,
            this.productsAddress,
            this.productsPrice,
            this.productsNumber,
            this.productsDestination});
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(516, 279);
            this.dataGridViewProducts.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(198, 328);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 47);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelNumberOfMedicament
            // 
            this.labelNumberOfMedicament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberOfMedicament.Location = new System.Drawing.Point(158, 9);
            this.labelNumberOfMedicament.Name = "labelNumberOfMedicament";
            this.labelNumberOfMedicament.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNumberOfMedicament.Size = new System.Drawing.Size(224, 31);
            this.labelNumberOfMedicament.TabIndex = 3;
            this.labelNumberOfMedicament.Text = "Number of current medicament in whole network.";
            this.labelNumberOfMedicament.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // productsID
            // 
            this.productsID.HeaderText = "ID";
            this.productsID.Name = "productsID";
            this.productsID.ReadOnly = true;
            this.productsID.Visible = false;
            this.productsID.Width = 5;
            // 
            // productsName
            // 
            this.productsName.HeaderText = "Name";
            this.productsName.Name = "productsName";
            this.productsName.ReadOnly = true;
            // 
            // productsDose
            // 
            this.productsDose.HeaderText = "Dose";
            this.productsDose.Name = "productsDose";
            this.productsDose.ReadOnly = true;
            this.productsDose.Width = 60;
            // 
            // productsAddress
            // 
            this.productsAddress.HeaderText = "Address";
            this.productsAddress.Name = "productsAddress";
            this.productsAddress.ReadOnly = true;
            // 
            // productsPrice
            // 
            this.productsPrice.HeaderText = "Price";
            this.productsPrice.Name = "productsPrice";
            this.productsPrice.ReadOnly = true;
            this.productsPrice.Width = 50;
            // 
            // productsNumber
            // 
            this.productsNumber.HeaderText = "Number";
            this.productsNumber.Name = "productsNumber";
            this.productsNumber.ReadOnly = true;
            this.productsNumber.Width = 50;
            // 
            // productsDestination
            // 
            this.productsDestination.HeaderText = "Destination, km";
            this.productsDestination.Name = "productsDestination";
            this.productsDestination.ReadOnly = true;
            this.productsDestination.Width = 110;
            // 
            // WholeNetworkViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 382);
            this.Controls.Add(this.labelNumberOfMedicament);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 420);
            this.Name = "WholeNetworkViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Whole network";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelNumberOfMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDose;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDestination;
    }
}