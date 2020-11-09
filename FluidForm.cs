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
    public partial class FluidForm : Form
    {
        public FluidForm()
        {
            InitializeComponent();
        }
        readonly CalculateFluid calculateFluid = new CalculateFluid();

        private void ToolStripMenuItemBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonCalculateVolumeFluid_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Объём теплоносителя в системе отопления равен " + calculateFluid.CalculateVolumeFluid() + " л.";
        }

        private void ButtonInfo1_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void ShowInfo()
        {
            MessageBox.Show("Объем теплоносителя в оборудовании каждый производитель указывает в паспортных данных на оборудование", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonInfo2_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void ButtonInfo3_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void ButtonEnterDataVolumePipe_Click(object sender, EventArgs e)
        {
            VolumePipeForm volumePipeForm = new VolumePipeForm();
            volumePipeForm.Show();
        }
    }
}
