using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalculateTheHeat
{
    public partial class BoilerForm : Form
    {

        readonly CalculateBoiler calculateBoiler = new CalculateBoiler();


        public BoilerForm()
        {
            InitializeComponent();
            comboBoxReservePower.SelectedIndex = 1;
            labelCaclulateAreaResult.Text = "";
            labelCalculateVolumeResult.Text = "";
            comboBoxHeightWall.SelectedIndex = 0;
            comboBoxWallMaterial.SelectedIndex = 0;
            labelCalculateAllFeaturesResult.Text = "";
            labelVolumeAttention.Text = "";
            comboBoxK1.SelectedIndex = 0;
            comboBoxK2.SelectedIndex = 0;
            comboBoxK3.SelectedIndex = 0;
            comboBoxK4.SelectedIndex = 0;
            comboBoxK5.SelectedIndex = 0;
            comboBoxK6.SelectedIndex = 0;
            comboBoxK7.SelectedIndex = 0;
            comboBoxK9.SelectedIndex = 0;
            comboBoxK10.SelectedIndex = 0;
            ButtonSaveResult.Visible = false;

        }
        #region Пояснения коэфициентов
        /*k1 – к-во внешних стен в помещения (стен, граничащих с улицей):
        одна – k1=1,0;
        две – k1=1,2;
        три – k1-1,3.

        k2 – ориентация помещения (солнечная или теневая сторона):
        север, северо-восток или восток – k2=1,1;
        юг, юго-запад или запад – k2=1,0.
        
        k3 – коэффициент теплоизоляции стен помещения:
        простые, не утепленные стены – 1,17;
        кладка в 2 кирпича или легкое утепление – 1,0;
        высококачественная расчетная теплоизоляция – 0,85.
        
        k4 – подробный учет климатических условий локации (уличная температура воздуха в самую холодную неделю зимы):
        -35°С и менее – 1,4;
        от -25°С до -34°С – 1,25;
        от -20°С до -24°С – 1,2;
        от -15°С до -19°С – 1,1;
        от -10°С до -14°С – 0,9;
        не холоднее, чем -10°С – 0,7.
        
        k5 – коэффициент, учитывающий высоту потолка:
        до 2,7 м – 1,0;
        2,8 — 3,0 м – 1,02;
        3,1 — 3,9 м – 1,08;
        4 м и более – 1,15.
       
        k6 – коэффициент, учитывающий теплопотери потолка (что находится над потолком):
        холодное, неотапливаемое помещение/чердак – 1,0;
        утепленный чердак/мансарда – 0,9;
        отапливаемое жилое помещение – 0,8.
        
        k7 – учет теплопотерь окон (тип и к-во стеклопакетов):
        Стеклопакетыобычные (в том числе и деревянные) двойные окна – 1,17;
        окна с двойным стеклопакетом (2 воздушные камеры) – 1,0;
        двойной стеклопакет с аргоновым заполнением или тройной стеклопакет (3 воздушные камеры) – 0,85.
        
        k8 – учет суммарной площади остекления (суммарная площадь окон : площадь помещения):
        менее 0,1 – k8 = 0,8;
        0,11-0,2 – k8 = 0,9;
        0,21-0,3 – k8 = 1,0;
        0,31-0,4 – k8 = 1,05;
        0,41-0,5 – k8 = 1,15.
        
        k9 – учет расположения батареи и наличия экрана:
        практически не прикрыт подоконником, не прикрыт экраном – 0,9;
        прикрыт подоконником или выступом стены – 1,0;
        прикрыт декоративным кожухом только снаружи – 1,05;
        полностью закрыт экраном – 1,15.
        
        k10 – учет способа подключения радиаторов:
        диагональный, где подача сверху, обратка снизу – 1,0;
        односторонний, где подача сверху, обратка снизу – 1,03;
        двухсторонний нижний, где и подача, и обратка снизу – 1,1;
        диагональный, где подача снизу, обратка сверху – 1,2;
        односторонний, где подача снизу, обратка сверху – 1,28;
        односторонний нижний, где и подача, и обратка снизу – 1,28.
         */
        #endregion

        private void TextBoxAreaHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckText(sender, e);
        }

        private void CheckText(object sender, KeyPressEventArgs e)
        {
            //проверка, содержит ли текст ,
            string checkText = textBoxAreaHouse.Text;
            int z = 0;

            for (int i = 0; i < checkText.Length; i++)
            {
                if (checkText[i] == ',')
                {
                    z++;
                }
            }

            if (z < 1 || e.KeyChar != ',')
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // цифры, клавиша BackSpace
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBoxAreaWindows_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckText(sender, e);
        }

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

        public void ButtonCalculateResult_Click(object sender, EventArgs e)    //Общая кнопка Расчитать
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (textBoxAreaHouse.Text != "")
                {
                    labelCaclulateAreaResult.Text = "Для отопления дома площадью " + textBoxAreaHouse.Text + " кв.м., необходим котёл мощностью " +
                        calculateBoiler.CalcBoiler(textBoxAreaHouse.Text, comboBoxReservePower.SelectedIndex) + " кВт/ч";
                }
                else
                    MessageBox.Show("Введите полощадь отапливаемого помещения", "Внимание");
            }

            if (tabControl1.SelectedTab == tabPage2)
            {

                if (textBoxAreaHouse.Text != "")
                {
                    labelCalculateVolumeResult.Text = "Для отопления квартиры площадью " + textBoxAreaHouse.Text + " кв.м., высотой потолков " +
                        comboBoxK1.Text + " м, необходим котёл мощностью " +
                        calculateBoiler.CalcBoiler(textBoxAreaHouse.Text, Convert.ToDecimal(comboBoxHeightWall.Text), comboBoxWallMaterial.Text) + " кВт/ч";
                }
                else
                    MessageBox.Show("Введите полощадь отапливаемого помещения", "Внимание");

                //Убрать управление элементом из кнопки
                if (calculateBoiler.HeightWall > 3)
                {
                    labelVolumeAttention.Text = "Внимание! При высоте потолков свыше 3 м, значения сильно усредняются...";
                }
                else
                    labelVolumeAttention.Text = "";
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                if (textBoxAreaHouse.Text != "")
                {
                    labelCalculateAllFeaturesResult.Text = "Для отопления дома площадью " + textBoxAreaHouse.Text + " кв.м., необходим котёл мощностью " +
                        calculateBoiler.CalcBoiler(textBoxAreaHouse.Text,
                        comboBoxK1.SelectedIndex, comboBoxK2.SelectedIndex, comboBoxK3.SelectedIndex,
                        comboBoxK4.SelectedIndex, comboBoxK5.SelectedIndex, comboBoxK6.SelectedIndex,
                        comboBoxK7.SelectedIndex, textBoxAreaWindows.Text, comboBoxK9.SelectedIndex,
                        comboBoxK10.SelectedIndex) + " кВт/ч";
                }
                else
                    MessageBox.Show("Введите полощадь отапливаемого помещения", "Внимание");
                /*                Решить вопрос реализации через Switch
                                switch (tabControl1.SelectedTab)
                                {
                                    case tabPage1:
                                        MessageBox.Show("");

                                    default:
                                        break;
                                }*/

            }
            ButtonSaveResult.Visible = true;
        }

        private void ButtonSaveResult_Click(object sender, EventArgs e)
        {
            //SaveResult
            if (tabControl1.SelectedTab == tabPage1)
            {
                calculateBoiler.SaveResultInFile(labelCaclulateAreaResult.Text, comboBoxReservePower.Text);
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                calculateBoiler.SaveResultInFile(labelCalculateVolumeResult.Text, comboBoxWallMaterial.Text, comboBoxHeightWall.Text);
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                calculateBoiler.SaveResultInFile(labelCalculateAllFeaturesResult.Text, comboBoxK1.Text,
                    comboBoxK2.Text, comboBoxK3.Text, comboBoxK5.Text, comboBoxK10.Text,
                    comboBoxK7.Text, comboBoxK9.Text, comboBoxK6.Text, comboBoxK4.Text,
                    textBoxAreaWindows.Text);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonSaveResult.Visible = false;
        }
        //Тест работы второй ветки для Гитхаба
    }
}
