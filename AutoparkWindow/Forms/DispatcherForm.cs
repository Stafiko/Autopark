using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoparkWindow.Forms
{
    public partial class DispatcherForm : Form
    {
        public DispatcherForm()
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
