using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabControls
{
    public partial class ColorSpecify : UserControl
    {
        private Color curColor;
        public bool ok = true;//для обозначения всле ли поля конвертировались

        public struct Rect
        {
            public int x, y, h, w;
        }

        public Rect r = new Rect { x = 170, y = 15, h = 140, w = 145 };//создает закрашиваемое окно

        public ColorSpecify()
        {
            InitializeComponent();
            nbRed.IsDec = true;
            nbGreen.IsDec = true;
            nbBlue.IsDec = true;
            nbRed.Text = "0";
            nbGreen.Text = "0";
            nbBlue.Text = "0";
            curColor = Color.Black;
        }

        public Color CurColor
        {
            get => curColor;
            set { curColor = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(curColor), r.x, r.y, r.w, r.h);
            nbRed.ForeColor = Color.FromArgb(curColor.R, curColor.G, curColor.B);
            nbGreen.ForeColor = Color.FromArgb(curColor.R, curColor.G, curColor.B);
            nbBlue.ForeColor = Color.FromArgb(curColor.R, curColor.G, curColor.B);
        }
        
        private void DrawRectangle()//для покраски прямоугольника
        {
            var graphics = CreateGraphics();
            var rectangle = new Rectangle(r.x, r.y, r.w, r.h);
            OnPaint(new PaintEventArgs(graphics, rectangle));
        }

        private void rbDec_CheckedChanged(object sender, EventArgs e)
        {
            nbRed.IsDec = rbDec.Checked;
            nbGreen.IsDec = rbDec.Checked;
            nbBlue.IsDec = rbDec.Checked;
            ok = false;
            if (rbDec.Checked)
            {
                nbRed.Text = getDec(nbRed.Text);
                nbGreen.Text = getDec(nbGreen.Text);
                nbBlue.Text = getDec(nbBlue.Text);
            }
            else
            {
                nbRed.Text = getHex(nbRed.Text);
                nbGreen.Text = getHex(nbGreen.Text);
                nbBlue.Text = getHex(nbBlue.Text);
            }
            ok = true;
        }

        public string getHex(string s)//конверитирование int to hex
        {
            int x;
            int.TryParse(s, out x);
            return String.Format("{0:X}", x);
        }

        public string getDec(string s)//конвертирование hex to int
        {
            int x = Convert.ToInt32(s, 16);
            return x.ToString();
        }

        private void nbRed_TextChanged(object sender, EventArgs e)
        {
            ChangeColor();
            DrawRectangle();
        }

        private void nbGreen_TextChanged(object sender, EventArgs e)
        {
            ChangeColor();
            DrawRectangle();
        }

        private void nbBlue_TextChanged(object sender, EventArgs e)
        {
            ChangeColor();
            DrawRectangle();
        }

        public void ChangeColor()
        {
            int r, g, b;
            if (ok)
            {
                if (rbDec.Checked)
                {
                    int.TryParse(nbRed.Text, out r);
                    int.TryParse(nbGreen.Text, out g);
                    int.TryParse(nbBlue.Text, out b);
                }
                else
                {
                    r = Convert.ToInt32(nbRed.Text, 16);
                    g = Convert.ToInt32(nbGreen.Text, 16);
                    b = Convert.ToInt32(nbBlue.Text, 16);
                }
                CurColor = Color.FromArgb(r, g, b);
            }
        }
    }
}
