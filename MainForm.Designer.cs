namespace CalculateTheHeat
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSelectionBoiler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelectionFluid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSelectionBoiler
            // 
            this.ButtonSelectionBoiler.Location = new System.Drawing.Point(11, 104);
            this.ButtonSelectionBoiler.Name = "ButtonSelectionBoiler";
            this.ButtonSelectionBoiler.Size = new System.Drawing.Size(314, 34);
            this.ButtonSelectionBoiler.TabIndex = 0;
            this.ButtonSelectionBoiler.Text = "Выбор отопительного котла ";
            this.ButtonSelectionBoiler.UseVisualStyleBackColor = true;
            this.ButtonSelectionBoiler.Click += new System.EventHandler(this.ButtonSelectionBoiler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подбор и расчёт оборудования\r\nдля мотажа системы отопления";
            // 
            // buttonSelectionFluid
            // 
            this.buttonSelectionFluid.Location = new System.Drawing.Point(12, 144);
            this.buttonSelectionFluid.Name = "ButtonSelectionFluid";
            this.buttonSelectionFluid.Size = new System.Drawing.Size(313, 34);
            this.buttonSelectionFluid.TabIndex = 2;
            this.buttonSelectionFluid.Text = "Расчёт объёма теплоносителя в системе отопления";
            this.buttonSelectionFluid.UseVisualStyleBackColor = true;
            this.buttonSelectionFluid.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.buttonSelectionFluid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSelectionBoiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт отопления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSelectionBoiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectionFluid;
    }
}

