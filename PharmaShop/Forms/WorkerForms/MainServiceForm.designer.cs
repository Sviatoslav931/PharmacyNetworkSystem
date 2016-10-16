namespace PharmaShop
{
    partial class MainServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainServiceForm));
            this.textBoxMedicamentName = new System.Windows.Forms.TextBox();
            this.buttonShowCatalog = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelResults = new System.Windows.Forms.Panel();
            this.buttonConfirmSelling = new System.Windows.Forms.Button();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.cartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartDose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonWholeSearch = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.productsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCart = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxClientCard = new System.Windows.Forms.TextBox();
            this.labelClientCard = new System.Windows.Forms.Label();
            this.labelMedicamentName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMedicamentName
            // 
            this.textBoxMedicamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMedicamentName.Location = new System.Drawing.Point(17, 28);
            this.textBoxMedicamentName.MaxLength = 50;
            this.textBoxMedicamentName.Name = "textBoxMedicamentName";
            this.textBoxMedicamentName.Size = new System.Drawing.Size(156, 29);
            this.textBoxMedicamentName.TabIndex = 3;
            // 
            // buttonShowCatalog
            // 
            this.buttonShowCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowCatalog.Location = new System.Drawing.Point(228, 63);
            this.buttonShowCatalog.Name = "buttonShowCatalog";
            this.buttonShowCatalog.Size = new System.Drawing.Size(97, 50);
            this.buttonShowCatalog.TabIndex = 6;
            this.buttonShowCatalog.Text = "Show whole own catalog";
            this.buttonShowCatalog.UseVisualStyleBackColor = true;
            this.buttonShowCatalog.Click += new System.EventHandler(this.buttonShowOwnCatalog_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(17, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(156, 50);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearchMedicament_Click);
            // 
            // panelResults
            // 
            this.panelResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResults.Controls.Add(this.buttonConfirmSelling);
            this.panelResults.Controls.Add(this.buttonClearCart);
            this.panelResults.Controls.Add(this.dataGridViewCart);
            this.panelResults.Controls.Add(this.buttonClearAll);
            this.panelResults.Controls.Add(this.buttonSell);
            this.panelResults.Controls.Add(this.buttonWholeSearch);
            this.panelResults.Controls.Add(this.dataGridViewProducts);
            this.panelResults.Location = new System.Drawing.Point(17, 119);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(755, 331);
            this.panelResults.TabIndex = 8;
            // 
            // buttonConfirmSelling
            // 
            this.buttonConfirmSelling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirmSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirmSelling.Location = new System.Drawing.Point(407, 284);
            this.buttonConfirmSelling.Name = "buttonConfirmSelling";
            this.buttonConfirmSelling.Size = new System.Drawing.Size(182, 36);
            this.buttonConfirmSelling.TabIndex = 11;
            this.buttonConfirmSelling.Text = "Confirm selling";
            this.buttonConfirmSelling.UseVisualStyleBackColor = true;
            this.buttonConfirmSelling.Click += new System.EventHandler(this.buttonConfirmSelling_Click);
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearCart.Location = new System.Drawing.Point(676, 284);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(75, 36);
            this.buttonClearCart.TabIndex = 11;
            this.buttonClearCart.Text = "Clear all cart";
            this.buttonClearCart.UseVisualStyleBackColor = true;
            this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartID,
            this.cartName,
            this.cartDose,
            this.cartPrice,
            this.cartNumber,
            this.cartTotalPrice,
            this.cartDelete});
            this.dataGridViewCart.Location = new System.Drawing.Point(406, 3);
            this.dataGridViewCart.MultiSelect = false;
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.Size = new System.Drawing.Size(346, 257);
            this.dataGridViewCart.TabIndex = 0;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            this.dataGridViewCart.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCartChangeNumber);
            // 
            // cartID
            // 
            this.cartID.HeaderText = "ID";
            this.cartID.Name = "cartID";
            this.cartID.ReadOnly = true;
            this.cartID.Visible = false;
            this.cartID.Width = 5;
            // 
            // cartName
            // 
            this.cartName.HeaderText = "Name";
            this.cartName.Name = "cartName";
            this.cartName.ReadOnly = true;
            this.cartName.Width = 120;
            // 
            // cartDose
            // 
            this.cartDose.HeaderText = "Dose";
            this.cartDose.Name = "cartDose";
            this.cartDose.ReadOnly = true;
            this.cartDose.Width = 70;
            // 
            // cartPrice
            // 
            this.cartPrice.HeaderText = "Price";
            this.cartPrice.Name = "cartPrice";
            this.cartPrice.ReadOnly = true;
            this.cartPrice.Width = 50;
            // 
            // cartNumber
            // 
            this.cartNumber.HeaderText = "Number";
            this.cartNumber.Name = "cartNumber";
            this.cartNumber.Width = 50;
            // 
            // cartTotalPrice
            // 
            this.cartTotalPrice.HeaderText = "Total Price";
            this.cartTotalPrice.Name = "cartTotalPrice";
            this.cartTotalPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cartTotalPrice.Width = 60;
            // 
            // cartDelete
            // 
            this.cartDelete.HeaderText = "Delete";
            this.cartDelete.Name = "cartDelete";
            this.cartDelete.Text = "Delete";
            this.cartDelete.UseColumnTextForButtonValue = true;
            this.cartDelete.Width = 50;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearAll.Location = new System.Drawing.Point(3, 264);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(133, 56);
            this.buttonClearAll.TabIndex = 9;
            this.buttonClearAll.Text = "Clear all\r\n(next client)";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSell.Location = new System.Drawing.Point(314, 3);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(86, 92);
            this.buttonSell.TabIndex = 2;
            this.buttonSell.Text = "PUT IN CART\r\n  ->";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonWholeSearch
            // 
            this.buttonWholeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWholeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWholeSearch.Location = new System.Drawing.Point(315, 189);
            this.buttonWholeSearch.Name = "buttonWholeSearch";
            this.buttonWholeSearch.Size = new System.Drawing.Size(86, 71);
            this.buttonWholeSearch.TabIndex = 1;
            this.buttonWholeSearch.Text = "Show current medicament in whole network";
            this.buttonWholeSearch.UseVisualStyleBackColor = true;
            this.buttonWholeSearch.Click += new System.EventHandler(this.buttonWholeSearch_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productsID,
            this.MedicamentId,
            this.productsName,
            this.productsDose,
            this.productsPrice,
            this.productsNumber});
            this.dataGridViewProducts.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(305, 257);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewProducts_CellMouseDoubleClick);
            // 
            // productsID
            // 
            this.productsID.HeaderText = "ID";
            this.productsID.Name = "productsID";
            this.productsID.ReadOnly = true;
            this.productsID.Visible = false;
            this.productsID.Width = 5;
            // 
            // MedicamentId
            // 
            this.MedicamentId.HeaderText = "MedicamentID";
            this.MedicamentId.Name = "MedicamentId";
            this.MedicamentId.ReadOnly = true;
            this.MedicamentId.Visible = false;
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
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.Location = new System.Drawing.Point(522, 100);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(94, 13);
            this.labelCart.TabIndex = 10;
            this.labelCart.Text = "Your cart is empty.";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPrice.Location = new System.Drawing.Point(655, 87);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalPrice.Size = new System.Drawing.Size(114, 26);
            this.labelTotalPrice.TabIndex = 11;
            this.labelTotalPrice.Text = "0.00";
            this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxClientCard
            // 
            this.textBoxClientCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientCard.Location = new System.Drawing.Point(610, 63);
            this.textBoxClientCard.Name = "textBoxClientCard";
            this.textBoxClientCard.Size = new System.Drawing.Size(158, 20);
            this.textBoxClientCard.TabIndex = 12;
            // 
            // labelClientCard
            // 
            this.labelClientCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClientCard.AutoSize = true;
            this.labelClientCard.Location = new System.Drawing.Point(490, 66);
            this.labelClientCard.Name = "labelClientCard";
            this.labelClientCard.Size = new System.Drawing.Size(114, 13);
            this.labelClientCard.TabIndex = 13;
            this.labelClientCard.Text = "Enter client card here :";
            // 
            // labelMedicamentName
            // 
            this.labelMedicamentName.AutoSize = true;
            this.labelMedicamentName.Location = new System.Drawing.Point(17, 12);
            this.labelMedicamentName.Name = "labelMedicamentName";
            this.labelMedicamentName.Size = new System.Drawing.Size(151, 13);
            this.labelMedicamentName.TabIndex = 14;
            this.labelMedicamentName.Text = "Enter medicament name here :";
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(490, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(84, 13);
            this.labelUserName.TabIndex = 15;
            this.labelUserName.Text = "User : Unknown";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelMedicamentName);
            this.Controls.Add(this.labelClientCard);
            this.Controls.Add(this.textBoxClientCard);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelCart);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonShowCatalog);
            this.Controls.Add(this.textBoxMedicamentName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Service Form";
            this.panelResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion
        private System.Windows.Forms.TextBox textBoxMedicamentName;
        private System.Windows.Forms.Button buttonShowCatalog;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonWholeSearch;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Button buttonClearCart;
        private System.Windows.Forms.Button buttonConfirmSelling;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.TextBox textBoxClientCard;
        private System.Windows.Forms.Label labelClientCard;
        private System.Windows.Forms.Label labelMedicamentName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartDose;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartTotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn cartDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDose;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsNumber;
    }
}

