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
            CalculateBoiler calculateBoiler = new CalculateBoiler();

            labelCaclulateAreaResult.Text = "Для отопления дома площадью " + textBoxAreaHouse.Text + " кв.м., необходим котёл мощностью " + 
                calculateBoiler.CalculateBoilerArea(textBoxAreaHouse.Text, comboBoxReservePower.Text) + " кВт/ч";
        }

        private void textBoxAreaHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBoxAreaHouse_Click(object sender, EventArgs e)
        {
            textBoxAreaHouse.Text = "";
        }

        private void textBoxAreaHouse_Leave(object sender, EventArgs e)
        {
            if (textBoxAreaHouse.Text == "")
            {
                textBoxAreaHouse.Text = "0";
            }
        }
    }
}
