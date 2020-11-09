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

        private void ButtonAddPipe_Click(object sender, EventArgs e)
        {
            TextBox start = (TextBox)textBox1;

            TextBox newTextBox = new TextBox();
            newTextBox.Text = "";
            newTextBox.Width = start.Width;
            newTextBox.Location = new Point(start.Location.Y, start.Location.X + 10);

            this.Controls.Add(newTextBox);
        }
    }
}
