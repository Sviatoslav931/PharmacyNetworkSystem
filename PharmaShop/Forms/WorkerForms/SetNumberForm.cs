using System;
using System.Windows.Forms;

namespace PharmaShop
{
    public partial class SetNumberForm : Form
    {
        public int returnNumber = 0;
        public SetNumberForm(string maxNumber)
        {
            InitializeComponent();
            SetDefaultValue(maxNumber);
        }

        private void SetDefaultValue(string maxNumber)
        {
            labelValidNumberBetween.Text = String.Format("between 1 and {0}.", maxNumber);
            int maximum;
            Int32.TryParse(maxNumber, out maximum);
            numericUpDownCurrentNumber.Maximum = maximum;
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            returnNumber = (int) numericUpDownCurrentNumber.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
