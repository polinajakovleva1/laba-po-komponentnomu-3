﻿using System;
using System.Windows.Forms;

namespace LabControls
{
    public partial class FilePathSelect : UserControl
    {
        public FilePathSelect()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get
            {
                return txtPath.Text;
            }
            set
            {
                txtPath.Text = value;
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = txtPath.Text;
            if (ofd.ShowDialog() == DialogResult.OK)
                txtPath.Text = ofd.FileName;
        }
    }
}
