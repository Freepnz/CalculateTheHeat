﻿namespace CalculateTheHeat
{
    partial class BoilerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoilerForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCaclulateAreaResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxReservePower = new System.Windows.Forms.ComboBox();
            this.labelPowerReserve = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxHeightWall = new System.Windows.Forms.ComboBox();
            this.labelHeightWall = new System.Windows.Forms.Label();
            this.labelVolumeAttention = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCalculateVolumeResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxWallMaterial = new System.Windows.Forms.ComboBox();
            this.labelWallMaterial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxAreaWindows = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelK5 = new System.Windows.Forms.Label();
            this.comboBoxK5 = new System.Windows.Forms.ComboBox();
            this.comboBoxK10 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelK10 = new System.Windows.Forms.Label();
            this.labelCalculateAllFeaturesResult = new System.Windows.Forms.Label();
            this.comboBoxK9 = new System.Windows.Forms.ComboBox();
            this.labelK9 = new System.Windows.Forms.Label();
            this.labelK1 = new System.Windows.Forms.Label();
            this.comboBoxK1 = new System.Windows.Forms.ComboBox();
            this.comboBoxK7 = new System.Windows.Forms.ComboBox();
            this.labelK2 = new System.Windows.Forms.Label();
            this.labelK7 = new System.Windows.Forms.Label();
            this.comboBoxK2 = new System.Windows.Forms.ComboBox();
            this.comboBoxK6 = new System.Windows.Forms.ComboBox();
            this.labelK3 = new System.Windows.Forms.Label();
            this.labelK6 = new System.Windows.Forms.Label();
            this.comboBoxK3 = new System.Windows.Forms.ComboBox();
            this.labelK4 = new System.Windows.Forms.Label();
            this.comboBoxK4 = new System.Windows.Forms.ComboBox();
            this.ButtonSaveResult = new System.Windows.Forms.Button();
            this.textBoxAreaHouse = new System.Windows.Forms.TextBox();
            this.labelAreaHouse = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Меню = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonCalculateResult = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 383);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.labelCaclulateAreaResult);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.comboBoxReservePower);
            this.tabPage1.Controls.Add(this.labelPowerReserve);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчёт по площади дома";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(174, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Расчёт котла по площади дома";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCaclulateAreaResult
            // 
            this.labelCaclulateAreaResult.AutoSize = true;
            this.labelCaclulateAreaResult.Location = new System.Drawing.Point(44, 275);
            this.labelCaclulateAreaResult.Name = "labelCaclulateAreaResult";
            this.labelCaclulateAreaResult.Size = new System.Drawing.Size(37, 13);
            this.labelCaclulateAreaResult.TabIndex = 8;
            this.labelCaclulateAreaResult.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(92, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Если ваш случай отличается от среднестатистичекого дома, \r\nстоит рассчитать мощно" +
    "сть котла более точным методом с учетом всех особенностей.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxReservePower
            // 
            this.comboBoxReservePower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReservePower.FormattingEnabled = true;
            this.comboBoxReservePower.Items.AddRange(new object[] {
            "10",
            "20"});
            this.comboBoxReservePower.Location = new System.Drawing.Point(218, 217);
            this.comboBoxReservePower.Name = "comboBoxReservePower";
            this.comboBoxReservePower.Size = new System.Drawing.Size(99, 21);
            this.comboBoxReservePower.TabIndex = 6;
            // 
            // labelPowerReserve
            // 
            this.labelPowerReserve.AutoSize = true;
            this.labelPowerReserve.Location = new System.Drawing.Point(92, 220);
            this.labelPowerReserve.Name = "labelPowerReserve";
            this.labelPowerReserve.Size = new System.Drawing.Size(107, 13);
            this.labelPowerReserve.TabIndex = 5;
            this.labelPowerReserve.Text = "Запас мощности, %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наиболее простой и распространенный способ. \r\nИсходя из практики, для среднестати" +
    "стического частного дома в \r\nклиматической зоне Подмосковья, с кладкой в 2 кирпи" +
    "ча и высотой \r\nпотолков 2,7 м.\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxHeightWall);
            this.tabPage2.Controls.Add(this.labelHeightWall);
            this.tabPage2.Controls.Add(this.labelVolumeAttention);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.labelCalculateVolumeResult);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.comboBoxWallMaterial);
            this.tabPage2.Controls.Add(this.labelWallMaterial);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расчёт по объёму помещений";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxHeightWall
            // 
            this.comboBoxHeightWall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHeightWall.FormattingEnabled = true;
            this.comboBoxHeightWall.Items.AddRange(new object[] {
            "2,7",
            "2,8",
            "2,9",
            "3,0",
            "3,1"});
            this.comboBoxHeightWall.Location = new System.Drawing.Point(271, 262);
            this.comboBoxHeightWall.Name = "comboBoxHeightWall";
            this.comboBoxHeightWall.Size = new System.Drawing.Size(153, 21);
            this.comboBoxHeightWall.TabIndex = 24;
            // 
            // labelHeightWall
            // 
            this.labelHeightWall.AutoSize = true;
            this.labelHeightWall.Location = new System.Drawing.Point(142, 265);
            this.labelHeightWall.Name = "labelHeightWall";
            this.labelHeightWall.Size = new System.Drawing.Size(109, 13);
            this.labelHeightWall.TabIndex = 23;
            this.labelHeightWall.Text = "Высота потолков, м\r\n";
            // 
            // labelVolumeAttention
            // 
            this.labelVolumeAttention.AutoSize = true;
            this.labelVolumeAttention.ForeColor = System.Drawing.Color.Red;
            this.labelVolumeAttention.Location = new System.Drawing.Point(30, 293);
            this.labelVolumeAttention.Name = "labelVolumeAttention";
            this.labelVolumeAttention.Size = new System.Drawing.Size(49, 13);
            this.labelVolumeAttention.TabIndex = 17;
            this.labelVolumeAttention.Text = "Attention";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(169, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(410, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Расчёт котла по объёму помещений";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCalculateVolumeResult
            // 
            this.labelCalculateVolumeResult.AutoSize = true;
            this.labelCalculateVolumeResult.Location = new System.Drawing.Point(30, 316);
            this.labelCalculateVolumeResult.Name = "labelCalculateVolumeResult";
            this.labelCalculateVolumeResult.Size = new System.Drawing.Size(37, 13);
            this.labelCalculateVolumeResult.TabIndex = 14;
            this.labelCalculateVolumeResult.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(118, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Если ваш случай отличается от среднестатистичекого дома, \r\nстоит рассчитать мощно" +
    "сть котла более точным методом с учетом всех особенностей.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(92, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // comboBoxWallMaterial
            // 
            this.comboBoxWallMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWallMaterial.FormattingEnabled = true;
            this.comboBoxWallMaterial.Items.AddRange(new object[] {
            "Кирпич",
            "Бетонные панели"});
            this.comboBoxWallMaterial.Location = new System.Drawing.Point(271, 230);
            this.comboBoxWallMaterial.Name = "comboBoxWallMaterial";
            this.comboBoxWallMaterial.Size = new System.Drawing.Size(153, 21);
            this.comboBoxWallMaterial.TabIndex = 12;
            // 
            // labelWallMaterial
            // 
            this.labelWallMaterial.AutoSize = true;
            this.labelWallMaterial.Location = new System.Drawing.Point(168, 233);
            this.labelWallMaterial.Name = "labelWallMaterial";
            this.labelWallMaterial.Size = new System.Drawing.Size(83, 13);
            this.labelWallMaterial.TabIndex = 11;
            this.labelWallMaterial.Text = "Материал стен";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(228, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(458, 112);
            this.label6.TabIndex = 9;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxAreaWindows);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.labelK5);
            this.tabPage3.Controls.Add(this.comboBoxK5);
            this.tabPage3.Controls.Add(this.comboBoxK10);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.labelK10);
            this.tabPage3.Controls.Add(this.labelCalculateAllFeaturesResult);
            this.tabPage3.Controls.Add(this.comboBoxK9);
            this.tabPage3.Controls.Add(this.labelK9);
            this.tabPage3.Controls.Add(this.labelK1);
            this.tabPage3.Controls.Add(this.comboBoxK1);
            this.tabPage3.Controls.Add(this.comboBoxK7);
            this.tabPage3.Controls.Add(this.labelK2);
            this.tabPage3.Controls.Add(this.labelK7);
            this.tabPage3.Controls.Add(this.comboBoxK2);
            this.tabPage3.Controls.Add(this.comboBoxK6);
            this.tabPage3.Controls.Add(this.labelK3);
            this.tabPage3.Controls.Add(this.labelK6);
            this.tabPage3.Controls.Add(this.comboBoxK3);
            this.tabPage3.Controls.Add(this.labelK4);
            this.tabPage3.Controls.Add(this.comboBoxK4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 357);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Расчёт с учётом всех особенностей";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxAreaWindows
            // 
            this.textBoxAreaWindows.Location = new System.Drawing.Point(582, 249);
            this.textBoxAreaWindows.Name = "textBoxAreaWindows";
            this.textBoxAreaWindows.Size = new System.Drawing.Size(100, 20);
            this.textBoxAreaWindows.TabIndex = 38;
            this.textBoxAreaWindows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAreaWindows_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Общая площадь остекления, м2";
            // 
            // labelK5
            // 
            this.labelK5.AutoSize = true;
            this.labelK5.Location = new System.Drawing.Point(26, 183);
            this.labelK5.Name = "labelK5";
            this.labelK5.Size = new System.Drawing.Size(193, 13);
            this.labelK5.TabIndex = 35;
            this.labelK5.Text = "Коэф. учитывающий высоту потолка\r\n";
            // 
            // comboBoxK5
            // 
            this.comboBoxK5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxK5.FormattingEnabled = true;
            this.comboBoxK5.Items.AddRange(new object[] {
            "до 2,7 м",
            "2,8 — 3,0 м",
            "3,1 — 3,9 м",
            "4 м и более"});
            this.comboBoxK5.Location = new System.Drawing.Point(29, 202);
            this.comboBoxK5.Name = "comboBoxK5";
            this.comboBoxK5.Size = new System.Drawing.Size(348, 21);
            this.comboBoxK5.TabIndex = 36;
            // 
            // comboBoxK10
            // 
            this.comboBoxK10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxK10.FormattingEnabled = true;
            this.comboBoxK10.Items.AddRange(new object[] {
            "Диагональный, где подача сверху, обратка снизу",
            "Односторонний, где подача сверху, обратка снизу",
            "Двухсторонний нижний, где и подача, и обратка снизу",
            "Диагональный, где подача снизу, обратка сверху",
            "Односторонний, где подача снизу, обратка сверху",
            "Односторонний нижний, где и подача, и обратка снизу"});
            this.comboBoxK10.Location = new System.Drawing.Point(29, 248);
            this.comboBoxK10.Name = "comboBoxK10";
            this.comboBoxK10.Size = new System.Drawing.Size(348, 21);
            this.comboBoxK10.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(161, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(475, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Расчёт котла с учётом всех особенностей";
            // 
            // labelK10
            // 
            this.labelK10.AutoSize = true;
            this.labelK10.Location = new System.Drawing.Point(26, 229);
            this.labelK10.Name = "labelK10";
            this.labelK10.Size = new System.Drawing.Size(176, 13);
            this.labelK10.TabIndex = 33;
            this.labelK10.Text = "Cпособ подключения радиаторов";
            // 
            // labelCalculateAllFeaturesResult
            // 
            this.labelCalculateAllFeaturesResult.AutoSize = true;
            this.labelCalculateAllFeaturesResult.Location = new System.Drawing.Point(26, 302);
            this.labelCalculateAllFeaturesResult.Name = "labelCalculateAllFeaturesResult";
            this.labelCalculateAllFeaturesResult.Size = new System.Drawing.Size(37, 13);
            this.labelCalculateAllFeaturesResult.TabIndex = 22;
            this.labelCalculateAllFeaturesResult.Text = "Result";
            // 
            // comboBoxK9
            // 
            this.comboBoxK9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxK9.FormattingEnabled = true;
            this.comboBoxK9.Items.AddRange(new object[] {
            "Практически не прикрыт подоконником, не прикрыт экраном",
            "Прикрыт подоконником или выступом стены",
            "Прикрыт декоративным кожухом только снаружи",
            "Полностью закрыт экраном"});
            this.comboBoxK9.Location = new System.Drawing.Point(407, 104);
            this.comboBoxK9.Name = "comboBoxK9";
            this.comboBoxK9.Size = new System.Drawing.Size(350, 21);
            this.comboBoxK9.TabIndex = 32;
            // 
            // labelK9
            // 
            this.labelK9.AutoSize = true;
            this.labelK9.Location = new System.Drawing.Point(404, 87);
            this.labelK9.Name = "labelK9";
            this.labelK9.Size = new System.Drawing.Size(244, 13);
            this.labelK9.TabIndex = 31;
            this.labelK9.Text = "Учет расположения батареи и наличия экрана\r\n";
            // 
            // labelK1
            // 
            this.labelK1.AutoSize = true;
            this.labelK1.Location = new System.Drawing.Point(26, 45);
            this.labelK1.Name = "labelK1";
            this.labelK1.Size = new System.Drawing.Size(184, 13);
            this.labelK1.TabIndex = 13;
            this.labelK1.Text = "Кол-во внешних стен в помещении";
            // 
            // comboBoxK1
            // 
            this.comboBoxK1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxK1.FormattingEnabled = true;
            this.comboBoxK1.Items.AddRange(new object[] {
            "Одна",
            "Две",
            "Три"});
            this.comboBoxK1.Location = new System.Drawing.Point(29, 64);
            this.comboBoxK1.Name = "comboBoxK1";
            this.comboBoxK1.Size = new System.Drawing.Size(350, 21);
            this.comboBoxK1.TabIndex = 14;
            // 
            // comboBoxK7
            // 
            this.comboBoxK7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxK7.FormattingEnabled = true;
            this.comboBoxK7.Items.AddRange(new object[] {
            "Стеклопакеты обычные (деревянные) двойные окна",
            "Окна с двойным стеклопакетом (2 воздушные камеры)",
            "Стеклопакет с аргоновым заполнением, тройной стеклопакет "});
            this.comboBoxK7.Location = new System.Drawing.Point(407, 62);
            this.comboBoxK7.Name = "comboBoxK7";
            this.comboBoxK7.Size = new System.Drawing.Size(348, 21);
            this.comboBoxK7.TabIndex = 28;
            // 
            // labelK2
            // 
            this.labelK2.AutoSize = true;
            this.labelK2.Location = new System.Drawing.Point(26, 91);
            this.labelK2.Name = "labelK2";
            this.labelK2.Size = new System.Drawing.Size(130, 13);
            this.labelK2.TabIndex = 15;
            this.labelK2.Text = "Ориентация помещения";
            // 
            // labelK7
            // 
            this.labelK7.AutoSize = true;
            this.labelK7.Location = new System.Drawing.Point(404, 45);
            this.labelK7.Name = "labelK7";
            this.labelK7.Size = new System.Drawing.Size(263, 13);
            this.labelK7.TabIndex = 27;
            this.labelK7.Text = "Учет теплопотерь окон (тип и к-во стеклопакетов)\r\n";
            // 
            // comboBoxK2
            // 
            this.comboBoxK2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxK2.FormattingEnabled = true;
            this.comboBoxK2.Items.AddRange(new object[] {
            "Север, северо-восток или восток",
            "Юг, юго-запад или запад"});
            this.comboBoxK2.Location = new System.Drawing.Point(29, 110);
            this.comboBoxK2.Name = "comboBoxK2";
            this.comboBoxK2.Size = new System.Drawing.Size(348, 21);
            this.comboBoxK2.TabIndex = 16;
            // 
            // comboBoxK6
            // 
            this.comboBoxK6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxK6.FormattingEnabled = true;
            this.comboBoxK6.Items.AddRange(new object[] {
            "Холодное, неотапливаемое помещение/чердак",
            "Утепленный чердак/мансарда",
            "Отапливаемое жилое помещение"});
            this.comboBoxK6.Location = new System.Drawing.Point(407, 146);
            this.comboBoxK6.Name = "comboBoxK6";
            this.comboBoxK6.Size = new System.Drawing.Size(350, 21);
            this.comboBoxK6.TabIndex = 26;
            // 
            // labelK3
            // 
            this.labelK3.AutoSize = true;
            this.labelK3.Location = new System.Drawing.Point(26, 137);
            this.labelK3.Name = "labelK3";
            this.labelK3.Size = new System.Drawing.Size(143, 13);
            this.labelK3.TabIndex = 17;
            this.labelK3.Text = "Kоэф. теплоизоляции стен\r\n";
            // 
            // labelK6
            // 
            this.labelK6.AutoSize = true;
            this.labelK6.Location = new System.Drawing.Point(404, 129);
            this.labelK6.Name = "labelK6";
            this.labelK6.Size = new System.Drawing.Size(221, 13);
            this.labelK6.TabIndex = 25;
            this.labelK6.Text = "Kоэф. учитывающий теплопотери потолка\r\n";
            // 
            // comboBoxK3
            // 
            this.comboBoxK3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxK3.FormattingEnabled = true;
            this.comboBoxK3.Items.AddRange(new object[] {
            "Простые, не утепленные стены",
            "Кладка в 2 кирпича или легкое утепление",
            "Высококачественная расчетная теплоизоляция"});
            this.comboBoxK3.Location = new System.Drawing.Point(29, 156);
            this.comboBoxK3.Name = "comboBoxK3";
            this.comboBoxK3.Size = new System.Drawing.Size(348, 21);
            this.comboBoxK3.TabIndex = 18;
            // 
            // labelK4
            // 
            this.labelK4.AutoSize = true;
            this.labelK4.Location = new System.Drawing.Point(404, 171);
            this.labelK4.Name = "labelK4";
            this.labelK4.Size = new System.Drawing.Size(332, 26);
            this.labelK4.TabIndex = 19;
            this.labelK4.Text = "Подробный учет климатических условий локации \r\n(уличная температура воздуха в сам" +
    "ую холодную неделю зимы)";
            // 
            // comboBoxK4
            // 
            this.comboBoxK4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxK4.FormattingEnabled = true;
            this.comboBoxK4.Items.AddRange(new object[] {
            "-35°С и менее",
            "от -25°С до -34°С",
            "от -20°С до -24°С",
            "от -15°С до -19°С",
            "от -10°С до -14°С",
            "не холоднее, чем -10°С"});
            this.comboBoxK4.Location = new System.Drawing.Point(407, 201);
            this.comboBoxK4.Name = "comboBoxK4";
            this.comboBoxK4.Size = new System.Drawing.Size(350, 21);
            this.comboBoxK4.TabIndex = 20;
            // 
            // ButtonSaveResult
            // 
            this.ButtonSaveResult.Location = new System.Drawing.Point(666, 452);
            this.ButtonSaveResult.Name = "ButtonSaveResult";
            this.ButtonSaveResult.Size = new System.Drawing.Size(122, 37);
            this.ButtonSaveResult.TabIndex = 41;
            this.ButtonSaveResult.Text = "Сохранить результат";
            this.ButtonSaveResult.UseVisualStyleBackColor = true;
            this.ButtonSaveResult.Click += new System.EventHandler(this.ButtonSaveResult_Click);
            // 
            // textBoxAreaHouse
            // 
            this.textBoxAreaHouse.Location = new System.Drawing.Point(189, 37);
            this.textBoxAreaHouse.Name = "textBoxAreaHouse";
            this.textBoxAreaHouse.Size = new System.Drawing.Size(100, 20);
            this.textBoxAreaHouse.TabIndex = 4;
            this.textBoxAreaHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAreaHouse_KeyPress);
            // 
            // labelAreaHouse
            // 
            this.labelAreaHouse.AutoSize = true;
            this.labelAreaHouse.Location = new System.Drawing.Point(11, 40);
            this.labelAreaHouse.Name = "labelAreaHouse";
            this.labelAreaHouse.Size = new System.Drawing.Size(103, 13);
            this.labelAreaHouse.TabIndex = 3;
            this.labelAreaHouse.Text = "Площадь дома, м2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Меню});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Меню
            // 
            this.Меню.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBack,
            this.ToolStripMenuItemClose});
            this.Меню.Name = "Меню";
            this.Меню.Size = new System.Drawing.Size(53, 20);
            this.Меню.Text = "Меню";
            // 
            // ToolStripMenuItemBack
            // 
            this.ToolStripMenuItemBack.Name = "ToolStripMenuItemBack";
            this.ToolStripMenuItemBack.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemBack.Text = "Назад";
            this.ToolStripMenuItemBack.Click += new System.EventHandler(this.ToolStripMenuItemBack_Click);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemClose.Text = "Выход";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
            // 
            // ButtonCalculateResult
            // 
            this.ButtonCalculateResult.Location = new System.Drawing.Point(254, 452);
            this.ButtonCalculateResult.Name = "ButtonCalculateResult";
            this.ButtonCalculateResult.Size = new System.Drawing.Size(122, 37);
            this.ButtonCalculateResult.TabIndex = 42;
            this.ButtonCalculateResult.Text = "Расчитать";
            this.ButtonCalculateResult.UseVisualStyleBackColor = true;
            this.ButtonCalculateResult.Click += new System.EventHandler(this.ButtonCalculateResult_Click);
            // 
            // BoilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.ButtonCalculateResult);
            this.Controls.Add(this.ButtonSaveResult);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxAreaHouse);
            this.Controls.Add(this.labelAreaHouse);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BoilerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт бойлера";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelCaclulateAreaResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxReservePower;
        private System.Windows.Forms.Label labelPowerReserve;
        private System.Windows.Forms.TextBox textBoxAreaHouse;
        private System.Windows.Forms.Label labelAreaHouse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCalculateVolumeResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxWallMaterial;
        private System.Windows.Forms.Label labelWallMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxK1;
        private System.Windows.Forms.Label labelK1;
        public System.Windows.Forms.Label labelVolumeAttention;
        private System.Windows.Forms.ComboBox comboBoxK2;
        private System.Windows.Forms.Label labelK2;
        private System.Windows.Forms.ComboBox comboBoxK3;
        private System.Windows.Forms.Label labelK3;
        private System.Windows.Forms.ComboBox comboBoxK4;
        private System.Windows.Forms.Label labelK4;
        private System.Windows.Forms.ComboBox comboBoxK6;
        private System.Windows.Forms.Label labelK6;
        private System.Windows.Forms.ComboBox comboBoxK7;
        private System.Windows.Forms.Label labelK7;
        private System.Windows.Forms.ComboBox comboBoxK9;
        private System.Windows.Forms.Label labelK9;
        private System.Windows.Forms.ComboBox comboBoxK10;
        private System.Windows.Forms.Label labelK10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCalculateAllFeaturesResult;
        private System.Windows.Forms.ComboBox comboBoxHeightWall;
        private System.Windows.Forms.Label labelHeightWall;
        private System.Windows.Forms.Label labelK5;
        private System.Windows.Forms.ComboBox comboBoxK5;
        private System.Windows.Forms.TextBox textBoxAreaWindows;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Меню;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBack;
        private System.Windows.Forms.Button ButtonSaveResult;
        private System.Windows.Forms.Button ButtonCalculateResult;
    }
}