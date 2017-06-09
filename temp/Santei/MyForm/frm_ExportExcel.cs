using Natsu.MyClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Natsu.MyForm
{
    public partial class FrmExportExcel : DevExpress.XtraEditors.XtraForm
    {
        private List<String> lRowerror = new List<String>();
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Global.Db.ExportExcel_Getsu(cbb_Batch.Text);
            TableToExcel(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xlsx",dataGridView1);


            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ErrorSantei.xlsx"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ErrorSantei.xlsx");
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ErrorSantei.xlsx"), Properties.Resources.ErrorSantei);
            }
            else
            {
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ErrorSantei.xlsx"), Properties.Resources.ErrorSantei);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Global.Db.ExportExcel_Getsu_Error(cbb_Batch.Text);
            if (dataGridView1.RowCount > 0)
            {
                TableToExcelError(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ErrorSantei.xlsx", dataGridView1);
            }
            else
            {
                MessageBox.Show("No Error");
            }
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

        public bool TableToExcel(string strfilename,DataGridView dataGrid)
        {
            try
            {
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
                progressBarControl1.Properties.Maximum = dataGrid.Rows.Count;
                progressBarControl1.Properties.Minimum = 0;
                progressBarControl1.Properties.StartColor = Color.DarkRed; // choose the color
                progressBarControl1.Properties.EndColor = Color.Green; // choose the color

                foreach (DataGridViewRow dr in dataGrid.Rows)
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
                    else if ((dr.Cells[3].Value + "") == "*")
                    {
                        wrksheet.Cells[h, 4] = "*";
                        wrksheet.Cells[h, 5] = "*";
                        wrksheet.Cells[h, 6] = "*";
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
                    else if ((dr.Cells[12].Value + "") == "*")
                    {
                        wrksheet.Cells[h, 15] = "*";
                        wrksheet.Cells[h, 16] = "*";
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

                    lb_SoDong.Text = (h - 1) + @"/" + dataGrid.Rows.Count;
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
                saveFileDialog1.FileName = cbb_Batch.Text.Replace(@"\","_") + "_Santei";
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
        public bool TableToExcelError(string strfilename, DataGridView dataGrid)
        {
            try
            {
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
                progressBarControl1.Properties.Maximum = dataGrid.Rows.Count;
                progressBarControl1.Properties.Minimum = 0;
                progressBarControl1.Properties.StartColor = Color.DarkRed; // choose the color
                progressBarControl1.Properties.EndColor = Color.Green; // choose the color

                foreach (DataGridViewRow dr in dataGrid.Rows)
                {
                    wrksheet.Cells[h, 1] = dr.Cells[0].Value + ""; //tên image
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value + ""; //1
                    if (dr.Cells[27].Value+""=="1")
                    {
                        lRowerror.Add("B" + h);
                    }
               
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value?.ToString() ?? ""; //2
                    if (dr.Cells[28].Value + "" == "1")
                    {
                        lRowerror.Add("C" + h);
                    }

                    if ((dr.Cells[3].Value?.ToString() ?? "").Length == 6)  //3
                    {
                        wrksheet.Cells[h, 4] = (dr.Cells[3].Value?.ToString() ?? "").Substring(0, 2);
                        wrksheet.Cells[h, 5] = (dr.Cells[3].Value?.ToString() ?? "").Substring(2, 2);
                        wrksheet.Cells[h, 6] = (dr.Cells[3].Value?.ToString() ?? "").Substring(4, 2);
                    }
                    else if ((dr.Cells[3].Value + "") == "*")
                    {
                        wrksheet.Cells[h, 4] = "*";
                        wrksheet.Cells[h, 5] = "*";
                        wrksheet.Cells[h, 6] = "*";
                    }
                    else
                    {
                        wrksheet.Cells[h, 4] = "";
                        wrksheet.Cells[h, 5] = "";
                        wrksheet.Cells[h, 6] = dr.Cells[3].Value?.ToString() ?? "";
                    }

                    if (dr.Cells[29].Value + "" == "1")
                    {
                        lRowerror.Add("D" + h);
                        lRowerror.Add("E" + h);
                        lRowerror.Add("F" + h);
                    }

                    wrksheet.Cells[h, 7] = dr.Cells[4].Value?.ToString() ?? ""; //4
                    if (dr.Cells[30].Value + "" == "1")
                    {
                        lRowerror.Add("G" + h);
                    }

                    wrksheet.Cells[h, 8] = dr.Cells[5].Value?.ToString() ?? ""; //5
                    if (dr.Cells[31].Value + "" == "1")
                    {
                        lRowerror.Add("H" + h);
                    }

                    wrksheet.Cells[h, 9] = dr.Cells[6].Value?.ToString() ?? ""; //6
                    if (dr.Cells[32].Value + "" == "1")
                    {
                        lRowerror.Add("I" + h);
                    }

                    wrksheet.Cells[h, 10] = dr.Cells[7].Value?.ToString() ?? ""; //7
                    if (dr.Cells[33].Value + "" == "1")
                    {
                        lRowerror.Add("J" + h);
                    }

                    wrksheet.Cells[h, 11] = dr.Cells[8].Value?.ToString() ?? ""; //8
                    if (dr.Cells[34].Value + "" == "1")
                    {
                        lRowerror.Add("K" + h);
                    }

                    wrksheet.Cells[h, 12] = dr.Cells[9].Value?.ToString() ?? ""; //9
                    if (dr.Cells[35].Value + "" == "1")
                    {
                        lRowerror.Add("L" + h);
                    }

                    wrksheet.Cells[h, 13] = dr.Cells[10].Value?.ToString() ?? ""; //10
                    if (dr.Cells[36].Value + "" == "1")
                    {
                        lRowerror.Add("M" + h);
                    }

                    wrksheet.Cells[h, 14] = dr.Cells[11].Value?.ToString() ?? ""; //11
                    if (dr.Cells[37].Value + "" == "1")
                    {
                        lRowerror.Add("N" + h);
                    }


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
                    if (dr.Cells[38].Value + "" == "1")
                    {
                        lRowerror.Add("O" + h);
                        lRowerror.Add("P" + h);
                    }


                    wrksheet.Cells[h, 17] = dr.Cells[13].Value?.ToString() ?? ""; //13
                    if (dr.Cells[39].Value + "" == "1")
                    {
                        lRowerror.Add("Q" + h);
                    }

                    wrksheet.Cells[h, 18] = dr.Cells[14].Value?.ToString() ?? ""; //14
                    if (dr.Cells[40].Value + "" == "1")
                    {
                        lRowerror.Add("R" + h);
                    }

                    wrksheet.Cells[h, 19] = dr.Cells[15].Value?.ToString() ?? ""; //15
                    if (dr.Cells[41].Value + "" == "1")
                    {
                        lRowerror.Add("S" + h);
                    }

                    wrksheet.Cells[h, 20] = dr.Cells[16].Value?.ToString() ?? ""; //16
                    if (dr.Cells[42].Value + "" == "1")
                    {
                        lRowerror.Add("T" + h);
                    }

                    wrksheet.Cells[h, 21] = dr.Cells[17].Value?.ToString() ?? ""; //17
                    if (dr.Cells[43].Value + "" == "1")
                    {
                        lRowerror.Add("U" + h);
                    }

                    wrksheet.Cells[h, 22] = dr.Cells[18].Value?.ToString() ?? ""; //18.
                    if (dr.Cells[44].Value + "" == "1")
                    {
                        lRowerror.Add("V" + h);
                    }

                    wrksheet.Cells[h, 23] = dr.Cells[19].Value?.ToString() ?? ""; //19
                    if (dr.Cells[45].Value + "" == "1")
                    {
                        lRowerror.Add("W" + h);
                    }

                    wrksheet.Cells[h, 24] = dr.Cells[20].Value?.ToString() ?? ""; //20
                    if (dr.Cells[46].Value + "" == "1")
                    {
                        lRowerror.Add("X" + h);
                    }

                    wrksheet.Cells[h, 25] = dr.Cells[21].Value?.ToString() ?? ""; //21
                    if (dr.Cells[47].Value + "" == "1")
                    {
                        lRowerror.Add("Y" + h);
                    }

                    wrksheet.Cells[h, 26] = dr.Cells[22].Value?.ToString() ?? ""; //22
                    if (dr.Cells[48].Value + "" == "1")
                    {
                        lRowerror.Add("Z" + h);
                    }

                    wrksheet.Cells[h, 27] = dr.Cells[23].Value?.ToString() ?? ""; //23
                    if (dr.Cells[49].Value + "" == "1")
                    {
                        lRowerror.Add("AA" + h);
                    }

                    wrksheet.Cells[h, 28] = dr.Cells[24].Value?.ToString() ?? ""; //24
                    if (dr.Cells[50].Value + "" == "1")
                    {
                        lRowerror.Add("AB" + h);
                    }

                    wrksheet.Cells[h, 29] = dr.Cells[25].Value?.ToString() ?? ""; //25
                    if (dr.Cells[51].Value + "" == "1")
                    {
                        lRowerror.Add("AC" + h);
                    }
                    wrksheet.Cells[h, 30] = dr.Cells[52].Value?.ToString() ?? ""; //00
                    if (dr.Cells[52].Value + "" == "2")
                    {
                        lRowerror.Add("AD" + h);
                    }

                    wrksheet.Cells[h, 31] = dr.Cells[26].Value?.ToString() ?? "";

                    

                    lb_SoDong.Text = (h - 1) + @"/" + dataGrid.Rows.Count;
                    Microsoft.Office.Interop.Excel.Range rowHead = wrksheet.get_Range("A1", "AE" + h);
                    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    i++;
                    h++;
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog1.FileName = cbb_Batch.Text.Replace(@"\","_") + "_Santei_Error";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fillcolor(book, lRowerror);
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
        public bool fillcolor(Microsoft.Office.Interop.Excel.Workbook book, List<String> cells)
        {
            //Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Sheets _sheet;
            Microsoft.Office.Interop.Excel.Worksheet wrksheet;
            try
            {
                //book = App.Workbooks.Open(strfilename, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                //book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                _sheet = (Microsoft.Office.Interop.Excel.Sheets)book.Sheets;
                wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;

                Microsoft.Office.Interop.Excel.Range chartRange;
                for (int i = 0; i < cells.Count; i++)
                {
                    chartRange = wrksheet.get_Range(cells[i]);
                    chartRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                return false;
            }

            return true;
        }

        private void btnExportError_Click(object sender, EventArgs e)
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
           

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ErrorSantei.xlsx"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ErrorSantei.xlsx");
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ErrorSantei.xlsx"), Properties.Resources.ErrorSantei);
            }
            else
            {
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ErrorSantei.xlsx"), Properties.Resources.ErrorSantei);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Global.Db.ExportExcel_Getsu_Error(cbb_Batch.Text);
            if (dataGridView1.RowCount > 0)
            {
                TableToExcelError(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ErrorSantei.xlsx", dataGridView1);
            }
            else
            {
                MessageBox.Show("No Error");
            }
        }
    }

}