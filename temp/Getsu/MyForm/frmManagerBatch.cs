using Natsu.MyClass;
using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Natsu.MyForm
{
    public partial class FrmManagerBatch : DevExpress.XtraEditors.XtraForm
    {
        public FrmManagerBatch()
        {
            InitializeComponent();
        }

        private void frmManagerBatch_Load(object sender, EventArgs e)
        {
            RefreshBatch();
        }

        private void btn_TaoBatch_Click(object sender, EventArgs e)
        {
            new FrmCreateBatch().ShowDialog();
            RefreshBatch();
        }

        private void RefreshBatch()
        {
            var temp = from var in Global.Db.tbl_Batches orderby var.fdatecreated select var;
            gridControl1.DataSource = temp;
        }

        private void repositoryItemButtonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fbatchname = gridView1.GetFocusedRowCellValue("fBatchName").ToString();
            string temp = Global.StrPath + "\\" + fbatchname;
            if (MessageBox.Show(@"You definitely want to delete the batch: " + fbatchname + @"?", @"Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Global.Db.XoaBatch(fbatchname);
                    Directory.Delete(temp, true);
                    RefreshBatch();
                    MessageBox.Show(@"Deleted batch successfully!");
                    
                }
                catch (Exception)
                {
                    RefreshBatch();
                    MessageBox.Show(@"Delete batch error!");
                    
                }
            }
            

        }

        private void btn_DeleteSelectedBatch_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s = "";
            foreach (var rowHandle in gridView1.GetSelectedRows())
            {
                i += 1;
                string fbatchname = gridView1.GetRowCellValue(rowHandle, "fBatchName").ToString();
                s += fbatchname + "\n";
            }
            if (i <= 0)
            {
                MessageBox.Show("You have not selected batch. Please select batch before delete!");
                return;
            }
            if (MessageBox.Show("You want delete " + i + " batch:\n" + s, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            foreach (var rowHandle in gridView1.GetSelectedRows())
            {
                string fbatchname = gridView1.GetRowCellValue(rowHandle, "fBatchName").ToString();
                string temp = Global.StrPath + "\\" + fbatchname;
                Global.Db.XoaBatch(fbatchname);
                Directory.Delete(temp, true);
            }
            RefreshBatch();

        }
    }
}