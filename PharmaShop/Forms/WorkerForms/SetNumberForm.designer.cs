namespace PharmaShop
{
    partial class SetNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetNumberForm));
            this.numericUpDownCurrentNumber = new System.Windows.Forms.NumericUpDown();
            this.labelValidNumber = new System.Windows.Forms.Label();
            this.buttonPush = new System.Windows.Forms.Button();
            this.labelValidNumberBetween = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCurrentNumber
            // 
            this.numericUpDownCurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCurrentNumber.Location = new System.Drawing.Point(40, 43);
            this.numericUpDownCurrentNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCurrentNumber.Name = "numericUpDownCurrentNumber";
            this.numericUpDownCurrentNumber.Size = new System.Drawing.Size(121, 26);
            this.numericUpDownCurrentNumber.TabIndex = 0;
            this.numericUpDownCurrentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCurrentNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelValidNumber
            // 
            this.labelValidNumber.Location = new System.Drawing.Point(7, 8);
            this.labelValidNumber.Name = "labelValidNumber";
            this.labelValidNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelValidNumber.Size = new System.Drawing.Size(182, 16);
            this.labelValidNumber.TabIndex = 1;
            this.labelValidNumber.Text = "Enter valid number:";
            this.labelValidNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(40, 75);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(121, 34);
            this.buttonPush.TabIndex = 2;
            this.buttonPush.Text = "Push";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // labelValidNumberBetween
            // 
            this.labelValidNumberBetween.Location = new System.Drawing.Point(7, 24);
            this.labelValidNumberBetween.Name = "labelValidNumberBetween";
            this.labelValidNumberBetween.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelValidNumberBetween.Size = new System.Drawing.Size(182, 16);
            this.labelValidNumberBetween.TabIndex = 3;
            this.labelValidNumberBetween.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SetNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 122);
            this.Controls.Add(this.labelValidNumberBetween);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.labelValidNumber);
            this.Controls.Add(this.numericUpDownCurrentNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(220, 160);
            this.MinimumSize = new System.Drawing.Size(220, 160);
            this.Name = "SetNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Number";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCurrentNumber;
        private System.Windows.Forms.Label labelValidNumber;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Label labelValidNumberBetween;
    }
}