using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LabControls
{
    public partial class NumberBox : TextBox
    {
        public bool IsDec { get; set; }

        public NumberBox()
        {
            InitializeComponent();
            IsDec = true;
        }

        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            IsDec = true;
        }
        
        public bool OnlyHexInString(string text)//проверка на то, что символ введенный символ соответствует 16-тиричному числу
        {
            return System.Text.RegularExpressions.Regex.IsMatch(text, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        protected override void OnKeyPress(KeyPressEventArgs e)//когда в элемент управления вводится символ
        {         
            if (IsDec)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
                base.OnKeyPress(e);
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)) && !OnlyHexInString(e.KeyChar.ToString()))
                    e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            int x;
            if (Text == "")
                Text = "0";
            else
            {
                if (Text.Length > 1)
                    Text = Text.TrimStart('0');
                if (IsDec)
                {
                    int.TryParse(Text, out x);
                    if (x > 255)
                        Text = "255";
                }
                else
                {
                    x = Convert.ToInt32(Text, 16);
                    if (x > 255)
                        Text = "FF";
                }
            }
            Text = Text.ToUpper();
            SelectionStart = Text.Length;
            base.OnTextChanged(e);
        }
    }
}
