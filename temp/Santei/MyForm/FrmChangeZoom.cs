﻿using DevExpress.XtraEditors;
using Natsu.Properties;
using System;
using System.Windows.Forms;

namespace Natsu.MyForm
{
    public partial class FrmChangeZoom : XtraForm
    {
        public FrmChangeZoom()
        {
            InitializeComponent();
        }

        private void frm_ChangeZoom_Load(object sender, EventArgs e)
        {
            trackBarControl1.EditValue = Settings.Default.ZoomImage;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Settings.Default.ZoomImage = Convert.ToInt32(trackBarControl1.EditValue);
            Settings.Default.Save();
            MessageBox.Show(@"Change zoom successfully!");
            Close();
        }
    }
}