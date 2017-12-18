using System;
using System.Windows.Forms;

namespace AutoparkWindow
{
    public partial class BusForm : Form
    {
        public BusForm()
        {
            InitializeComponent();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void NoButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }
    }
}
