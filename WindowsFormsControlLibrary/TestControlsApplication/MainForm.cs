using System;
using System.Windows.Forms;

namespace TestControlsApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void показатьЗаданиеЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecifyColor form = new SpecifyColor();
            form.MdiParent = this;
            form.Show();
        }

        private void показатьЧасыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeForm form = new TimeForm();
            form.MdiParent = this;
            form.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
