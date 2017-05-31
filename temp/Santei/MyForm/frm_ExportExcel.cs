﻿using Natsu.MyClass;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Natsu.MyForm
{
    public partial class FrmExportExcel : DevExpress.XtraEditors.XtraForm
    {
        public FrmExportExcel()
        {
            InitializeComponent();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_Batch.Text))
            {
                MessageBox.Show(@"Batch not selected.");
                return;
            }

            var result = Global.Db.InputFinish(cbb_Batch.Text);
            if (result == 1)
            {
                MessageBox.Show(@"This batch has not been imported yet. Please enter it first.");
                return;
            }
            var userMissimage = (from w in Global.Db.MissImage_DESO(cbb_Batch.Text) select w.username).ToList();
            string sss = "";
            foreach (var item in userMissimage)
            {
                sss += item + "\r\n";
            }

            if (userMissimage.Count > 0)
            {
                MessageBox.Show(@"The user took the picture but did not enter: \r\n" + sss);
                return;
            }

            //Kiểm tra check xong chưa
            var xyz = Global.Db.CheckerFinish(cbb_Batch.Text);
            if (xyz != 0)
            {
                MessageBox.Show(@"Not finished check or have user get but not check. Please check first");

                var u = (from w in Global.Db.UserMissImagecheck(cbb_Batch.Text)
                         select w.username).ToList();
                string sssss = "";
                foreach (var item in u)
                {
                    sssss += item + "\r\n";
                }

                if (u.Count > 0)
                {
                    MessageBox.Show(@"Checker checklist to check but not check: \r\n" + sssss);
                }

                return;
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xlsx"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xlsx");
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel.xlsx"), Properties.Resources.ExportExcel);
            }
            else
            {
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel.xlsx"), Properties.Resources.ExportExcel);
            }
            TableToExcel(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xlsx");
        }

        private void frm_ExportExcel_Load(object sender, EventArgs e)
        {
            cbb_Batch.Items.Clear();
            var result = from w in Global.Db.tbl_Batches select w.fBatchName;

            if (result.Count() > 0)
            {
                cbb_Batch.Items.AddRange(result.ToArray());
                cbb_Batch.DisplayMember = "fBatchName";
                cbb_Batch.ValueMember = "fbatchname";
                cbb_Batch.Text = Global.StrBatch;
            }
        }

        public bool TableToExcel(string strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.Db.ExportExcel_Getsu(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false,
                    Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Worksheet wrksheet =
                    (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                int h = 2;
                int i = 0;
                progressBarControl1.EditValue = 0;
                progressBarControl1.Properties.Step = 1;
                progressBarControl1.Properties.PercentView = true;
                progressBarControl1.Properties.Maximum = dataGridView1.Rows.Count;
                progressBarControl1.Properties.Minimum = 0;
                progressBarControl1.Properties.StartColor = Color.DarkRed; // choose the color
                progressBarControl1.Properties.EndColor = Color.Green; // choose the color

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    wrksheet.Cells[h, 1] = dr.Cells[0].Value?.ToString() ?? ""; //tên image
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value?.ToString() ?? ""; //1
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value?.ToString() ?? ""; //2
                    if ((dr.Cells[3].Value?.ToString() ?? "").Length == 6)  //3
                    {
                        wrksheet.Cells[h, 4] = (dr.Cells[3].Value?.ToString() ?? "").Substring(0, 2);
                        wrksheet.Cells[h, 5] = (dr.Cells[3].Value?.ToString() ?? "").Substring(2, 2);
                        wrksheet.Cells[h, 6] = (dr.Cells[3].Value?.ToString() ?? "").Substring(4, 2);
                    }
                    else
                    {
                        wrksheet.Cells[h, 4] = "";  
                        wrksheet.Cells[h, 5] = "";
                        wrksheet.Cells[h, 6] = dr.Cells[3].Value?.ToString() ?? "";
                    }

                    wrksheet.Cells[h, 7] = dr.Cells[4].Value?.ToString() ?? ""; //4
                    wrksheet.Cells[h, 8] = dr.Cells[5].Value?.ToString() ?? ""; //5
                    wrksheet.Cells[h, 9] = dr.Cells[6].Value?.ToString() ?? ""; //6
                    wrksheet.Cells[h, 10] = dr.Cells[7].Value?.ToString() ?? ""; //7
                    wrksheet.Cells[h, 11] = dr.Cells[8].Value?.ToString() ?? ""; //8
                    wrksheet.Cells[h, 12] = dr.Cells[9].Value?.ToString() ?? ""; //9
                    wrksheet.Cells[h, 13] = dr.Cells[10].Value?.ToString() ?? ""; //10
                    wrksheet.Cells[h, 14] = dr.Cells[11].Value?.ToString() ?? ""; //11

                    if ((dr.Cells[12].Value?.ToString() ?? "").Length == 4) //12
                    {
                        wrksheet.Cells[h, 15] = (dr.Cells[12].Value?.ToString() ?? "").Substring(0, 2);
                        wrksheet.Cells[h, 16] = (dr.Cells[12].Value?.ToString() ?? "").Substring(2, 2);
                    }
                    else
                    {
                        wrksheet.Cells[h, 15] = "";
                        wrksheet.Cells[h, 16] = dr.Cells[12].Value?.ToString() ?? "";
                    }

                    wrksheet.Cells[h, 17] = dr.Cells[13].Value?.ToString() ?? ""; //13
                    wrksheet.Cells[h, 18] = dr.Cells[14].Value?.ToString() ?? ""; //14
                    wrksheet.Cells[h, 19] = dr.Cells[15].Value?.ToString() ?? ""; //15
                    wrksheet.Cells[h, 20] = dr.Cells[16].Value?.ToString() ?? ""; //16
                    wrksheet.Cells[h, 21] = dr.Cells[17].Value?.ToString() ?? ""; //17
                    wrksheet.Cells[h, 22] = dr.Cells[18].Value?.ToString() ?? ""; //18
                    wrksheet.Cells[h, 23] = dr.Cells[19].Value?.ToString() ?? ""; //19
                    wrksheet.Cells[h, 24] = dr.Cells[20].Value?.ToString() ?? ""; //20
                    wrksheet.Cells[h, 25] = dr.Cells[21].Value?.ToString() ?? ""; //21
                    wrksheet.Cells[h, 26] = dr.Cells[22].Value?.ToString() ?? ""; //22
                    wrksheet.Cells[h, 27] = dr.Cells[23].Value?.ToString() ?? ""; //23
                    wrksheet.Cells[h, 28] = dr.Cells[24].Value?.ToString() ?? ""; //24
                    wrksheet.Cells[h, 29] = dr.Cells[25].Value?.ToString() ?? ""; //25
                    wrksheet.Cells[h, 30] = dr.Cells[26].Value?.ToString() ?? "";

                    lb_SoDong.Text = (h - 1) + @"/" + dataGridView1.Rows.Count;
                    Microsoft.Office.Interop.Excel.Range rowHead = wrksheet.get_Range("A1", "AD" + h);
                    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    i++;
                    h++;
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog1.FileName = cbb_Batch.Text + "_Santei";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    book.SaveCopyAs(saveFileDialog1.FileName);
                    book.Saved = true;
                    savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    App.Quit();
                }
                else
                {
                    MessageBox.Show(@"Error exporting excel!");
                    return false;
                }
                Process.Start(savePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}