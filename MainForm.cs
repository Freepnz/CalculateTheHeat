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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //readonly BoilerForm calculateBoiler = new BoilerForm();

        private void ButtonSelectionBoiler_Click(object sender, EventArgs e)
        {
            BoilerForm calculateBoiler = new BoilerForm();
            calculateBoiler.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FluidForm fluidForm = new FluidForm();
            fluidForm.Show();
            this.Hide();
        }
    }
}
