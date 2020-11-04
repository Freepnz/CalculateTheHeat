namespace CalculateTheHeat
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
            this.buttonCalculateArea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxReservePower = new System.Windows.Forms.ComboBox();
            this.labelPowerReserve = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelVolumeAttention = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCalculateVolumeResult = new System.Windows.Forms.Label();
            this.buttonCalculateVolume = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxWallMaterial = new System.Windows.Forms.ComboBox();
            this.labelWallMaterial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxAreaHouse = new System.Windows.Forms.TextBox();
            this.labelAreaHouse = new System.Windows.Forms.Label();
            this.comboBoxHeightHouse = new System.Windows.Forms.ComboBox();
            this.labelHeightHouse = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 366);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.labelCaclulateAreaResult);
            this.tabPage1.Controls.Add(this.buttonCalculateArea);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.comboBoxReservePower);
            this.tabPage1.Controls.Add(this.labelPowerReserve);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчёт по площади дома";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(174, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Расчёт котла по площади дома";
            // 
            // labelCaclulateAreaResult
            // 
            this.labelCaclulateAreaResult.AutoSize = true;
            this.labelCaclulateAreaResult.Location = new System.Drawing.Point(88, 287);
            this.labelCaclulateAreaResult.Name = "labelCaclulateAreaResult";
            this.labelCaclulateAreaResult.Size = new System.Drawing.Size(37, 13);
            this.labelCaclulateAreaResult.TabIndex = 8;
            this.labelCaclulateAreaResult.Text = "Result";
            // 
            // buttonCalculateArea
            // 
            this.buttonCalculateArea.Location = new System.Drawing.Point(333, 239);
            this.buttonCalculateArea.Name = "buttonCalculateArea";
            this.buttonCalculateArea.Size = new System.Drawing.Size(122, 37);
            this.buttonCalculateArea.TabIndex = 8;
            this.buttonCalculateArea.Text = "Расчитать";
            this.buttonCalculateArea.UseVisualStyleBackColor = true;
            this.buttonCalculateArea.Click += new System.EventHandler(this.buttonCalculateArea_Click);
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
            "15",
            "20",
            "25"});
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
            this.tabPage2.Controls.Add(this.labelVolumeAttention);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.labelCalculateVolumeResult);
            this.tabPage2.Controls.Add(this.buttonCalculateVolume);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.comboBoxWallMaterial);
            this.tabPage2.Controls.Add(this.labelWallMaterial);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расчёт по объёму помещений";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelVolumeAttention
            // 
            this.labelVolumeAttention.AutoSize = true;
            this.labelVolumeAttention.ForeColor = System.Drawing.Color.Red;
            this.labelVolumeAttention.Location = new System.Drawing.Point(118, 319);
            this.labelVolumeAttention.Name = "labelVolumeAttention";
            this.labelVolumeAttention.Size = new System.Drawing.Size(49, 13);
            this.labelVolumeAttention.TabIndex = 17;
            this.labelVolumeAttention.Text = "Attention";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(169, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(410, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Расчёт котла по объёму помещений";
            // 
            // labelCalculateVolumeResult
            // 
            this.labelCalculateVolumeResult.AutoSize = true;
            this.labelCalculateVolumeResult.Location = new System.Drawing.Point(118, 289);
            this.labelCalculateVolumeResult.Name = "labelCalculateVolumeResult";
            this.labelCalculateVolumeResult.Size = new System.Drawing.Size(37, 13);
            this.labelCalculateVolumeResult.TabIndex = 14;
            this.labelCalculateVolumeResult.Text = "Result";
            // 
            // buttonCalculateVolume
            // 
            this.buttonCalculateVolume.Location = new System.Drawing.Point(457, 246);
            this.buttonCalculateVolume.Name = "buttonCalculateVolume";
            this.buttonCalculateVolume.Size = new System.Drawing.Size(122, 37);
            this.buttonCalculateVolume.TabIndex = 15;
            this.buttonCalculateVolume.Text = "Расчитать";
            this.buttonCalculateVolume.UseVisualStyleBackColor = true;
            this.buttonCalculateVolume.Click += new System.EventHandler(this.buttonCalculateVolume_Click);
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
            "Кирпичный дом",
            "Панельный дом"});
            this.comboBoxWallMaterial.Location = new System.Drawing.Point(263, 255);
            this.comboBoxWallMaterial.Name = "comboBoxWallMaterial";
            this.comboBoxWallMaterial.Size = new System.Drawing.Size(153, 21);
            this.comboBoxWallMaterial.TabIndex = 12;
            // 
            // labelWallMaterial
            // 
            this.labelWallMaterial.AutoSize = true;
            this.labelWallMaterial.Location = new System.Drawing.Point(160, 258);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(796, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Расчёт с учётом всех особенностей";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxAreaHouse
            // 
            this.textBoxAreaHouse.Location = new System.Drawing.Point(141, 12);
            this.textBoxAreaHouse.Name = "textBoxAreaHouse";
            this.textBoxAreaHouse.Size = new System.Drawing.Size(100, 20);
            this.textBoxAreaHouse.TabIndex = 4;
            this.textBoxAreaHouse.Click += new System.EventHandler(this.textBoxAreaHouse_Click);
            this.textBoxAreaHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAreaHouse_KeyPress);
            this.textBoxAreaHouse.Leave += new System.EventHandler(this.textBoxAreaHouse_Leave);
            // 
            // labelAreaHouse
            // 
            this.labelAreaHouse.AutoSize = true;
            this.labelAreaHouse.Location = new System.Drawing.Point(15, 15);
            this.labelAreaHouse.Name = "labelAreaHouse";
            this.labelAreaHouse.Size = new System.Drawing.Size(103, 13);
            this.labelAreaHouse.TabIndex = 3;
            this.labelAreaHouse.Text = "Площадь дома, м2";
            // 
            // comboBoxHeightHouse
            // 
            this.comboBoxHeightHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHeightHouse.FormattingEnabled = true;
            this.comboBoxHeightHouse.Items.AddRange(new object[] {
            "до 2,7",
            "2,8",
            "2,9",
            "3,0",
            "3,1 — 3,9",
            "4 м и более"});
            this.comboBoxHeightHouse.Location = new System.Drawing.Point(141, 44);
            this.comboBoxHeightHouse.Name = "comboBoxHeightHouse";
            this.comboBoxHeightHouse.Size = new System.Drawing.Size(100, 21);
            this.comboBoxHeightHouse.TabIndex = 14;
            // 
            // labelHeightHouse
            // 
            this.labelHeightHouse.AutoSize = true;
            this.labelHeightHouse.Location = new System.Drawing.Point(15, 47);
            this.labelHeightHouse.Name = "labelHeightHouse";
            this.labelHeightHouse.Size = new System.Drawing.Size(109, 13);
            this.labelHeightHouse.TabIndex = 13;
            this.labelHeightHouse.Text = "Высота потолков, м";
            // 
            // BoilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxHeightHouse);
            this.Controls.Add(this.labelHeightHouse);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxAreaHouse);
            this.Controls.Add(this.labelAreaHouse);
            this.Name = "BoilerForm";
            this.Text = "Расчёт бойлера";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button buttonCalculateArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCalculateVolumeResult;
        private System.Windows.Forms.Button buttonCalculateVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxWallMaterial;
        private System.Windows.Forms.Label labelWallMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxHeightHouse;
        private System.Windows.Forms.Label labelHeightHouse;
        public System.Windows.Forms.Label labelVolumeAttention;
    }
}