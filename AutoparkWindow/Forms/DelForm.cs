using System;
using System.Windows.Forms;

namespace AutoparkWindow
{
    public partial class DelForm : Form
    {
        public DelForm()
        {
            InitializeComponent();
        }

        private void YesButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void NoButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
