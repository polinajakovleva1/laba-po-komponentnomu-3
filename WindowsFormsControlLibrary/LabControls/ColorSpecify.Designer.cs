namespace LabControls
{
    partial class ColorSpecify
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbDec = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.nbBlue = new LabControls.NumberBox(this.components);
            this.nbGreen = new LabControls.NumberBox(this.components);
            this.nbRed = new LabControls.NumberBox(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зеленый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Синий";
            // 
            // rbDec
            // 
            this.rbDec.AutoSize = true;
            this.rbDec.Location = new System.Drawing.Point(19, 140);
            this.rbDec.Name = "rbDec";
            this.rbDec.Size = new System.Drawing.Size(54, 21);
            this.rbDec.TabIndex = 6;
            this.rbDec.TabStop = true;
            this.rbDec.Text = "Dec";
            this.rbDec.UseVisualStyleBackColor = true;
            this.rbDec.CheckedChanged += new System.EventHandler(this.rbDec_CheckedChanged);
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(79, 140);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(53, 21);
            this.rbHex.TabIndex = 7;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "Hex";
            this.rbHex.UseVisualStyleBackColor = true;
            // 
            // nbBlue
            // 
            this.nbBlue.ForeColor = System.Drawing.Color.Black;
            this.nbBlue.IsDec = false;
            this.nbBlue.Location = new System.Drawing.Point(88, 95);
            this.nbBlue.Name = "nbBlue";
            this.nbBlue.Size = new System.Drawing.Size(63, 22);
            this.nbBlue.TabIndex = 5;
            this.nbBlue.Text = "0";
            this.nbBlue.TextChanged += new System.EventHandler(this.nbBlue_TextChanged);
            // 
            // nbGreen
            // 
            this.nbGreen.ForeColor = System.Drawing.Color.Black;
            this.nbGreen.IsDec = false;
            this.nbGreen.Location = new System.Drawing.Point(88, 62);
            this.nbGreen.Name = "nbGreen";
            this.nbGreen.Size = new System.Drawing.Size(63, 22);
            this.nbGreen.TabIndex = 4;
            this.nbGreen.Text = "0";
            this.nbGreen.TextChanged += new System.EventHandler(this.nbGreen_TextChanged);
            // 
            // nbRed
            // 
            this.nbRed.ForeColor = System.Drawing.Color.Black;
            this.nbRed.IsDec = false;
            this.nbRed.Location = new System.Drawing.Point(88, 30);
            this.nbRed.Name = "nbRed";
            this.nbRed.Size = new System.Drawing.Size(63, 22);
            this.nbRed.TabIndex = 3;
            this.nbRed.Text = "0";
            this.nbRed.TextChanged += new System.EventHandler(this.nbRed_TextChanged);
            // 
            // ColorSpecify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbHex);
            this.Controls.Add(this.rbDec);
            this.Controls.Add(this.nbBlue);
            this.Controls.Add(this.nbGreen);
            this.Controls.Add(this.nbRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ColorSpecify";
            this.Size = new System.Drawing.Size(344, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private NumberBox nbRed;
        private NumberBox nbGreen;
        private NumberBox nbBlue;
        private System.Windows.Forms.RadioButton rbDec;
        private System.Windows.Forms.RadioButton rbHex;
    }
}
