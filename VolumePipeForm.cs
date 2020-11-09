using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateTheHeat
{
    public partial class VolumePipeForm : Form
    {
        public VolumePipeForm()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItemBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
