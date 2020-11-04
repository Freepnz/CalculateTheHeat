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
            labelCalculateVolumeResult.Text = "";
            comboBoxHeightHouse.Text = "до 2,7";
            comboBoxHeightHouse.Enabled = false;
            comboBoxWallMaterial.Text = "Кирпичный дом";
            labelVolumeAttention.Text = "";
        }

        #region Расчёт по площади дома
        private void buttonCalculateArea_Click(object sender, EventArgs e)
        {
            CalculateBoiler calculateBoilerArea = new CalculateBoiler();

            labelCaclulateAreaResult.Text = "Для отопления дома площадью " + textBoxAreaHouse.Text + " кв.м., необходим котёл мощностью " + 
                calculateBoilerArea.CalculateBoilerArea(textBoxAreaHouse.Text, comboBoxReservePower.Text) + " кВт/ч";
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
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                comboBoxHeightHouse.Enabled = false;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                comboBoxHeightHouse.Enabled = true;
            }
        }

        private void buttonCalculateVolume_Click(object sender, EventArgs e)
        {
            CalculateBoiler calculateBoilerVolume = new CalculateBoiler();
            labelCalculateVolumeResult.Text = "Для отопления квартиры площадью " + textBoxAreaHouse.Text + " кв.м., высотой потолков " + 
                comboBoxHeightHouse.Text + " м, необходим котёл мощностью " +
                calculateBoilerVolume.CalculateBoilerHeightWall(textBoxAreaHouse.Text, comboBoxHeightHouse.Text, comboBoxWallMaterial.Text) + " кВт/ч";

            //Убрать управление элементом из кнопки
            if (calculateBoilerVolume.HeightWall > 3)
            {
                labelVolumeAttention.Text = "Внимание! При высоте потолков свыше 3 м, значения сильно усредняются...";
            }
            else
                labelVolumeAttention.Text = "";
        }
    }
}
