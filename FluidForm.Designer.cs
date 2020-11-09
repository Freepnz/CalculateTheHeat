namespace CalculateTheHeat
{
    partial class FluidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FluidForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Меню = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ButtonEnterDataVolumePipe = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCalculateVolumeFluid = new System.Windows.Forms.Button();
            this.buttonInfo1 = new System.Windows.Forms.Button();
            this.ButtonInfo2 = new System.Windows.Forms.Button();
            this.ButtonInfo3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объём тепноносителя в котле, л.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Объём теплоносителя в радиаторах отопления, л.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Объём теплоносителя в расширительном баке, л.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Объём теплоносителя в трубах, л.\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(92, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(584, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Расчёт объёма теплоносителя в системе отопления\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Меню});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
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
            this.ToolStripMenuItemBack.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItemBack.Text = "Назад";
            this.ToolStripMenuItemBack.Click += new System.EventHandler(this.ToolStripMenuItemBack_Click);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItemClose.Text = "Выход";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(332, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // ButtonEnterDataVolumePipe
            // 
            this.ButtonEnterDataVolumePipe.Location = new System.Drawing.Point(377, 238);
            this.ButtonEnterDataVolumePipe.Name = "ButtonEnterDataVolumePipe";
            this.ButtonEnterDataVolumePipe.Size = new System.Drawing.Size(100, 23);
            this.ButtonEnterDataVolumePipe.TabIndex = 18;
            this.ButtonEnterDataVolumePipe.Text = "Ввести данные";
            this.ButtonEnterDataVolumePipe.UseVisualStyleBackColor = true;
            this.ButtonEnterDataVolumePipe.Click += new System.EventHandler(this.ButtonEnterDataVolumePipe_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(111, 350);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 19;
            this.labelResult.Text = "Result";
            // 
            // buttonCalculateVolumeFluid
            // 
            this.buttonCalculateVolumeFluid.Location = new System.Drawing.Point(164, 304);
            this.buttonCalculateVolumeFluid.Name = "buttonCalculateVolumeFluid";
            this.buttonCalculateVolumeFluid.Size = new System.Drawing.Size(145, 23);
            this.buttonCalculateVolumeFluid.TabIndex = 20;
            this.buttonCalculateVolumeFluid.Text = "Расчитать";
            this.buttonCalculateVolumeFluid.UseVisualStyleBackColor = true;
            this.buttonCalculateVolumeFluid.Click += new System.EventHandler(this.ButtonCalculateVolumeFluid_Click);
            // 
            // buttonInfo1
            // 
            this.buttonInfo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo1.BackgroundImage")));
            this.buttonInfo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo1.Location = new System.Drawing.Point(445, 116);
            this.buttonInfo1.Name = "buttonInfo1";
            this.buttonInfo1.Size = new System.Drawing.Size(32, 32);
            this.buttonInfo1.TabIndex = 21;
            this.buttonInfo1.UseVisualStyleBackColor = true;
            this.buttonInfo1.Click += new System.EventHandler(this.ButtonInfo1_Click);
            // 
            // ButtonInfo2
            // 
            this.ButtonInfo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonInfo2.BackgroundImage")));
            this.ButtonInfo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfo2.Location = new System.Drawing.Point(445, 155);
            this.ButtonInfo2.Name = "ButtonInfo2";
            this.ButtonInfo2.Size = new System.Drawing.Size(32, 32);
            this.ButtonInfo2.TabIndex = 22;
            this.ButtonInfo2.UseVisualStyleBackColor = true;
            this.ButtonInfo2.Click += new System.EventHandler(this.ButtonInfo2_Click);
            // 
            // ButtonInfo3
            // 
            this.ButtonInfo3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonInfo3.BackgroundImage")));
            this.ButtonInfo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfo3.Location = new System.Drawing.Point(445, 194);
            this.ButtonInfo3.Name = "ButtonInfo3";
            this.ButtonInfo3.Size = new System.Drawing.Size(32, 32);
            this.ButtonInfo3.TabIndex = 23;
            this.ButtonInfo3.UseVisualStyleBackColor = true;
            this.ButtonInfo3.Click += new System.EventHandler(this.ButtonInfo3_Click);
            // 
            // FluidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonInfo3);
            this.Controls.Add(this.ButtonInfo2);
            this.Controls.Add(this.buttonInfo1);
            this.Controls.Add(this.buttonCalculateVolumeFluid);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.ButtonEnterDataVolumePipe);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FluidForm";
            this.Text = "Объём теплоносителя";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Меню;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBack;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ButtonEnterDataVolumePipe;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculateVolumeFluid;
        private System.Windows.Forms.Button buttonInfo1;
        private System.Windows.Forms.Button ButtonInfo2;
        private System.Windows.Forms.Button ButtonInfo3;
    }
}