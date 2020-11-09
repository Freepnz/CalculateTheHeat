namespace CalculateTheHeat
{
    partial class VolumePipeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Меню = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonAddPipe = new System.Windows.Forms.Button();
            this.RadioButtonPlastik = new System.Windows.Forms.RadioButton();
            this.RadioButtonMetall = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Меню});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(85, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Диаметр , мм.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(224, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Протяжённость, м.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(354, 50);
            this.label7.TabIndex = 15;
            this.label7.Text = "Расчёт объёма теплоносителя \r\nв трубах";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonAddPipe
            // 
            this.ButtonAddPipe.Location = new System.Drawing.Point(12, 98);
            this.ButtonAddPipe.Name = "ButtonAddPipe";
            this.ButtonAddPipe.Size = new System.Drawing.Size(118, 23);
            this.ButtonAddPipe.TabIndex = 16;
            this.ButtonAddPipe.Text = "Добавить трубу";
            this.ButtonAddPipe.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPlastik
            // 
            this.RadioButtonPlastik.AutoSize = true;
            this.RadioButtonPlastik.Location = new System.Drawing.Point(201, 101);
            this.RadioButtonPlastik.Name = "RadioButtonPlastik";
            this.RadioButtonPlastik.Size = new System.Drawing.Size(99, 17);
            this.RadioButtonPlastik.TabIndex = 17;
            this.RadioButtonPlastik.TabStop = true;
            this.RadioButtonPlastik.Text = "Полипропилен";
            this.RadioButtonPlastik.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMetall
            // 
            this.RadioButtonMetall.AutoSize = true;
            this.RadioButtonMetall.Location = new System.Drawing.Point(308, 101);
            this.RadioButtonMetall.Name = "RadioButtonMetall";
            this.RadioButtonMetall.Size = new System.Drawing.Size(55, 17);
            this.RadioButtonMetall.TabIndex = 18;
            this.RadioButtonMetall.TabStop = true;
            this.RadioButtonMetall.Text = "Сталь";
            this.RadioButtonMetall.UseVisualStyleBackColor = true;
            // 
            // VolumePipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 537);
            this.Controls.Add(this.RadioButtonMetall);
            this.Controls.Add(this.RadioButtonPlastik);
            this.Controls.Add(this.ButtonAddPipe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VolumePipeForm";
            this.Text = "Объём теплоносителя в трубах";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Меню;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBack;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonAddPipe;
        private System.Windows.Forms.RadioButton RadioButtonPlastik;
        private System.Windows.Forms.RadioButton RadioButtonMetall;
    }
}