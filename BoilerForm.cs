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
    public partial class BoilerForm : Form
    {

        public BoilerForm()
        {
            InitializeComponent();
            comboBoxReservePower.Text = "20";
            textBoxAreaHouse.Text = "0";
            labelCaclulateAreaResult.Text = "";
        }



        private void buttonCalculateArea_Click(object sender, EventArgs e)
        {
            CalculateBoiler calculateBoiler = new CalculateBoiler(Convert.ToDecimal(textBoxAreaHouse.Text), Convert.ToInt32(comboBoxReservePower.Text));
            labelCaclulateAreaResult.Text = "Для отопления дома площадью " + textBoxAreaHouse.Text + " кв.м., необходим котёл мощностью " + 
                calculateBoiler.CalculateBoilerArea(Convert.ToDecimal(textBoxAreaHouse.Text), Convert.ToInt32(comboBoxReservePower.Text)) + " кВт/ч";
        }
    }
}
