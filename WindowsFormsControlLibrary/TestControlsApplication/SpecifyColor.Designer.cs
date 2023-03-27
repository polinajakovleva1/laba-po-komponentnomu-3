namespace TestControlsApplication
{
    partial class SpecifyColor
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
            this.colorSpecify1 = new LabControls.ColorSpecify();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorSpecify1
            // 
            this.colorSpecify1.CurColor = System.Drawing.Color.Black;
            this.colorSpecify1.Location = new System.Drawing.Point(72, 73);
            this.colorSpecify1.Name = "colorSpecify1";
            this.colorSpecify1.Size = new System.Drawing.Size(380, 222);
            this.colorSpecify1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpecifyColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorSpecify1);
            this.Name = "SpecifyColor";
            this.Text = "SpecifyColor";
            this.ResumeLayout(false);

        }

        #endregion

        private LabControls.ColorSpecify colorSpecify1;
        private System.Windows.Forms.Button button1;
    }
}