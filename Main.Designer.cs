namespace CalculateTheHeat
{
    partial class Main
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
            this.SelectionBoiler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectionBoiler
            // 
            this.SelectionBoiler.Location = new System.Drawing.Point(12, 54);
            this.SelectionBoiler.Name = "SelectionBoiler";
            this.SelectionBoiler.Size = new System.Drawing.Size(121, 34);
            this.SelectionBoiler.TabIndex = 0;
            this.SelectionBoiler.Text = "Подбор котла ";
            this.SelectionBoiler.UseVisualStyleBackColor = true;
            this.SelectionBoiler.Click += new System.EventHandler(this.SelectionBoiler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectionBoiler);
            this.Name = "Form1";
            this.Text = "Расчёт отопления";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectionBoiler;
    }
}

