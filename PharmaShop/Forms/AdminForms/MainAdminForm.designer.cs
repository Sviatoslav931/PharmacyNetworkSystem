namespace PharmaShop
{ 
    partial class MainAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminForm));
            this.groupBoxEmployees = new System.Windows.Forms.GroupBox();
            this.labelCalcSalaryFrom = new System.Windows.Forms.Label();
            this.labelCalcSalaryTo = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.dateTimePickerCalcSalaryFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonShowEmployees = new System.Windows.Forms.Button();
            this.dateTimePickerCalcSalaryTo = new System.Windows.Forms.DateTimePicker();
            this.buttonCalcSalary = new System.Windows.Forms.Button();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEmployees
            // 
            this.groupBoxEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEmployees.Controls.Add(this.labelCalcSalaryFrom);
            this.groupBoxEmployees.Controls.Add(this.labelCalcSalaryTo);
            this.groupBoxEmployees.Controls.Add(this.dataGridViewEmployees);
            this.groupBoxEmployees.Controls.Add(this.dateTimePickerCalcSalaryFrom);
            this.groupBoxEmployees.Controls.Add(this.buttonShowEmployees);
            this.groupBoxEmployees.Controls.Add(this.dateTimePickerCalcSalaryTo);
            this.groupBoxEmployees.Controls.Add(this.buttonCalcSalary);
            this.groupBoxEmployees.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEmployees.Name = "groupBoxEmployees";
            this.groupBoxEmployees.Size = new System.Drawing.Size(463, 510);
            this.groupBoxEmployees.TabIndex = 20;
            this.groupBoxEmployees.TabStop = false;
            this.groupBoxEmployees.Text = "Employees";
            // 
            // labelCalcSalaryFrom
            // 
            this.labelCalcSalaryFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCalcSalaryFrom.AutoSize = true;
            this.labelCalcSalaryFrom.Location = new System.Drawing.Point(363, 382);
            this.labelCalcSalaryFrom.Name = "labelCalcSalaryFrom";
            this.labelCalcSalaryFrom.Size = new System.Drawing.Size(30, 13);
            this.labelCalcSalaryFrom.TabIndex = 25;
            this.labelCalcSalaryFrom.Text = "From";
            // 
            // labelCalcSalaryTo
            // 
            this.labelCalcSalaryTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCalcSalaryTo.AutoSize = true;
            this.labelCalcSalaryTo.Location = new System.Drawing.Point(363, 421);
            this.labelCalcSalaryTo.Name = "labelCalcSalaryTo";
            this.labelCalcSalaryTo.Size = new System.Drawing.Size(20, 13);
            this.labelCalcSalaryTo.TabIndex = 19;
            this.labelCalcSalaryTo.Text = "To";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeId,
            this.employeeFirstName,
            this.employeeLastName});
            this.dataGridViewEmployees.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(351, 485);
            this.dataGridViewEmployees.TabIndex = 19;
            // 
            // dateTimePickerCalcSalaryFrom
            // 
            this.dateTimePickerCalcSalaryFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerCalcSalaryFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerCalcSalaryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCalcSalaryFrom.Location = new System.Drawing.Point(363, 398);
            this.dateTimePickerCalcSalaryFrom.Name = "dateTimePickerCalcSalaryFrom";
            this.dateTimePickerCalcSalaryFrom.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerCalcSalaryFrom.TabIndex = 24;
            // 
            // buttonShowEmployees
            // 
            this.buttonShowEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowEmployees.Location = new System.Drawing.Point(363, 16);
            this.buttonShowEmployees.Name = "buttonShowEmployees";
            this.buttonShowEmployees.Size = new System.Drawing.Size(94, 41);
            this.buttonShowEmployees.TabIndex = 21;
            this.buttonShowEmployees.Text = "Show employees";
            this.buttonShowEmployees.UseVisualStyleBackColor = true;
            this.buttonShowEmployees.Click += new System.EventHandler(this.buttonShowEmployees_Click);
            // 
            // dateTimePickerCalcSalaryTo
            // 
            this.dateTimePickerCalcSalaryTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerCalcSalaryTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerCalcSalaryTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCalcSalaryTo.Location = new System.Drawing.Point(363, 437);
            this.dateTimePickerCalcSalaryTo.Name = "dateTimePickerCalcSalaryTo";
            this.dateTimePickerCalcSalaryTo.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerCalcSalaryTo.TabIndex = 23;
            // 
            // buttonCalcSalary
            // 
            this.buttonCalcSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalcSalary.Location = new System.Drawing.Point(363, 463);
            this.buttonCalcSalary.Name = "buttonCalcSalary";
            this.buttonCalcSalary.Size = new System.Drawing.Size(94, 41);
            this.buttonCalcSalary.TabIndex = 22;
            this.buttonCalcSalary.Text = "Calculate salary";
            this.buttonCalcSalary.UseVisualStyleBackColor = true;
            this.buttonCalcSalary.Click += new System.EventHandler(this.buttonCalcSalary_Click);
            // 
            // employeeId
            // 
            this.employeeId.HeaderText = "ID";
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            this.employeeId.Visible = false;
            this.employeeId.Width = 5;
            // 
            // employeeFirstName
            // 
            this.employeeFirstName.HeaderText = "First Name";
            this.employeeFirstName.Name = "employeeFirstName";
            this.employeeFirstName.ReadOnly = true;
            this.employeeFirstName.Width = 150;
            // 
            // employeeLastName
            // 
            this.employeeLastName.HeaderText = "Last Name";
            this.employeeLastName.Name = "employeeLastName";
            this.employeeLastName.ReadOnly = true;
            this.employeeLastName.Width = 150;
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 529);
            this.Controls.Add(this.groupBoxEmployees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Form";
            this.groupBoxEmployees.ResumeLayout(false);
            this.groupBoxEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxEmployees;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonShowEmployees;
        private System.Windows.Forms.DateTimePicker dateTimePickerCalcSalaryTo;
        private System.Windows.Forms.Button buttonCalcSalary;
        private System.Windows.Forms.Label labelCalcSalaryFrom;
        private System.Windows.Forms.Label labelCalcSalaryTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerCalcSalaryFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastName;
    }
}