using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Update
{
    public partial class Update : DevExpress.XtraEditors.XtraForm
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog()==DialogResult.OK)
            {
                
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex==0)
            {
                txt_Path.Text = "";
                txt_Path.Enabled = false;
                btn_Browser.Enabled = false;
            }
            else
            {
                txt_Path.Text = "";
                txt_Path.Enabled = true;
                btn_Browser.Enabled = true;
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            txt_Path.Text = "";
            txt_Path.Enabled = false;
            btn_Browser.Enabled = false;
        }
    }
}