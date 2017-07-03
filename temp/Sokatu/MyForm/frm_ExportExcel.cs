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
        private List<String> lLoi = new List<String>();
        private List<String> temp = new List<String>();
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
                    if (i%2==0)
                    {
                        temp.Clear(); 
                        wrksheet.Cells[h, 1] = dr.Cells[0].Value + ""; //tên image
                        temp.Add(dr.Cells[0].Value + "");
                        wrksheet.Cells[h, 2] = dr.Cells[1].Value + ""; //1
                        temp.Add(dr.Cells[1].Value + "");
                        if ((dr.Cells[2].Value + "").Length == 6) //2
                        {
                            wrksheet.Cells[h, 3] = (dr.Cells[2].Value + "").Substring(0, 2);
                            temp.Add((dr.Cells[2].Value + "").Substring(0, 2));
                            wrksheet.Cells[h, 4] = (dr.Cells[2].Value + "").Substring(2, 2);
                            temp.Add((dr.Cells[2].Value + "").Substring(2, 2));
                            wrksheet.Cells[h, 5] = (dr.Cells[2].Value + "").Substring(4, 2);
                            temp.Add((dr.Cells[2].Value + "").Substring(4, 2));
                        }
                        else
                        {
                            wrksheet.Cells[h, 3] = "";
                            temp.Add("");
                            wrksheet.Cells[h, 4] = "";
                            temp.Add("");
                            wrksheet.Cells[h, 5] = dr.Cells[2].Value + "";
                            temp.Add(dr.Cells[2].Value + "");
                        }

                        wrksheet.Cells[h, 6] = dr.Cells[3].Value + ""; //3
                        temp.Add(dr.Cells[3].Value + "");
                        if (dr.Cells[4].Value + "" == "2") //4
                        {
                            wrksheet.Cells[h, 7] = "0";
                            temp.Add("0");
                        }
                        else
                        {
                            wrksheet.Cells[h, 7] = dr.Cells[4].Value + "";
                            temp.Add(dr.Cells[4].Value + "");
                        }

                        wrksheet.Cells[h, 8] = dr.Cells[5].Value + ""; //5
                        temp.Add(dr.Cells[5].Value + "");
                        wrksheet.Cells[h, 9] = dr.Cells[6].Value + ""; //6
                        temp.Add(dr.Cells[6].Value + "");
                        wrksheet.Cells[h, 10] = dr.Cells[7].Value + ""; //7
                        temp.Add(dr.Cells[7].Value + "");
                        wrksheet.Cells[h, 11] = dr.Cells[8].Value + ""; //8
                        temp.Add(dr.Cells[8].Value + "");
                        wrksheet.Cells[h, 12] = dr.Cells[9].Value + ""; //9
                        temp.Add(dr.Cells[9].Value + "");
                        wrksheet.Cells[h, 13] = dr.Cells[10].Value + ""; //10
                        temp.Add(dr.Cells[10].Value + "");

                        if (dr.Cells[11].Value + "" == "2") //11
                        {
                            wrksheet.Cells[h, 14] = "0";
                            temp.Add("0");
                        }
                        else
                        {
                            wrksheet.Cells[h, 14] = dr.Cells[11].Value + "";
                            temp.Add(dr.Cells[11].Value + "");
                        }

                        wrksheet.Cells[h, 15] = dr.Cells[12].Value + ""; //12
                        temp.Add(dr.Cells[12].Value + "");
                        wrksheet.Cells[h, 16] = dr.Cells[13].Value + ""; //13
                        temp.Add(dr.Cells[13].Value + "");
                        wrksheet.Cells[h, 17] = dr.Cells[14].Value + ""; //14
                        temp.Add(dr.Cells[14].Value + "");
                        wrksheet.Cells[h, 18] = dr.Cells[15].Value + ""; //15
                        temp.Add(dr.Cells[15].Value + "");
                        wrksheet.Cells[h, 19] = dr.Cells[16].Value + ""; //16
                        temp.Add(dr.Cells[16].Value + "");
                        wrksheet.Cells[h, 20] = dr.Cells[17].Value + ""; //17
                        temp.Add(dr.Cells[17].Value + "");

                        if (dr.Cells[18].Value + "" == "2") //18
                        {
                            wrksheet.Cells[h, 21] = "0";
                            temp.Add("0");
                        }
                        else
                        {
                            wrksheet.Cells[h, 21] = dr.Cells[18].Value + "";
                            temp.Add(dr.Cells[18].Value + "");
                        }
                    }
                    else
                    {
                        wrksheet.Cells[h, 22] = dr.Cells[1].Value + ""; //1
                        if (temp[1] != dr.Cells[1].Value + "")
                        {
                            lLoi.Add("V" + h);
                        }
                        if ((dr.Cells[2].Value + "").Length == 6) //2
                        {
                            wrksheet.Cells[h, 23] = (dr.Cells[2].Value + "").Substring(0, 2);
                            if (temp[2] != (dr.Cells[2].Value + "").Substring(0, 2))
                            {
                                lLoi.Add("W" + h);
                            }
                            wrksheet.Cells[h, 24] = (dr.Cells[2].Value + "").Substring(2, 2);
                            if (temp[3] != (dr.Cells[2].Value + "").Substring(2, 2))
                            {
                                lLoi.Add("X" + h);
                            }
                            wrksheet.Cells[h, 25] = (dr.Cells[2].Value + "").Substring(4, 2);
                            if (temp[4] != (dr.Cells[2].Value + "").Substring(4, 2))
                            {
                                lLoi.Add("Y" + h);
                            }
                        }
                        else
                        {
                            wrksheet.Cells[h, 23] = "";
                            if (temp[2] != "")
                            {
                                lLoi.Add("W" + h);
                            }
                            wrksheet.Cells[h, 24] = "";
                            if (temp[3] != "")
                            {
                                lLoi.Add("X" + h);
                            }
                            wrksheet.Cells[h, 25] = dr.Cells[2].Value + "";
                            if (temp[4] != dr.Cells[2].Value + "")
                            {
                                lLoi.Add("Y" + h);
                            }
                        }

                        wrksheet.Cells[h, 26] = dr.Cells[3].Value + ""; //3
                        if (temp[5] != dr.Cells[3].Value + "")
                        {
                            lLoi.Add("Z" + h);
                        }

                        if (dr.Cells[4].Value + "" == "2") //4
                        {
                            wrksheet.Cells[h, 27] = "0";
                            if (temp[6] != "0")
                            {
                                lLoi.Add("AA" + h);
                            }
                        }
                        else
                        {
                            wrksheet.Cells[h, 27] = dr.Cells[4].Value + "";
                            if (temp[6] != dr.Cells[4].Value + "")
                            {
                                lLoi.Add("AA" + h);
                            }
                        }

                        wrksheet.Cells[h, 28] = dr.Cells[5].Value + ""; //5
                        if (temp[7] != dr.Cells[5].Value + "")
                        {
                            lLoi.Add("AB" + h);
                        }
                        wrksheet.Cells[h, 29] = dr.Cells[6].Value + ""; //6
                        if (temp[8] != dr.Cells[6].Value + "")
                        {
                            lLoi.Add("AC" + h);
                        }
                        wrksheet.Cells[h, 30] = dr.Cells[7].Value + ""; //7
                        if (temp[9] != dr.Cells[7].Value + "")
                        {
                            lLoi.Add("AD" + h);
                        }
                        wrksheet.Cells[h, 31] = dr.Cells[8].Value + ""; //8
                        if (temp[10] != dr.Cells[8].Value + "")
                        {
                            lLoi.Add("AE" + h);
                        }
                        wrksheet.Cells[h, 32] = dr.Cells[9].Value + ""; //9
                        if (temp[11] != dr.Cells[9].Value + "")
                        {
                            lLoi.Add("AF" + h);
                        }
                        wrksheet.Cells[h, 33] = dr.Cells[10].Value + ""; //10
                        if (temp[12] != dr.Cells[10].Value + "")
                        {
                            lLoi.Add("AG" + h);
                        }

                        if (dr.Cells[11].Value + "" == "2") //11
                        {
                            wrksheet.Cells[h, 34] = "0";
                            if (temp[13] != "0")
                            {
                                lLoi.Add("AH" + h);
                            }
                        }
                        else
                        {
                            wrksheet.Cells[h, 34] = dr.Cells[11].Value + "";
                            if (temp[13] != dr.Cells[11].Value + "")
                            {
                                lLoi.Add("AH" + h);
                            }
                        }

                        wrksheet.Cells[h, 35] = dr.Cells[12].Value + ""; //12
                        if (temp[14] != dr.Cells[12].Value + "")
                        {
                            lLoi.Add("AI" + h);
                        }
                        wrksheet.Cells[h, 36] = dr.Cells[13].Value + ""; //13
                        if (temp[15] != dr.Cells[13].Value + "")
                        {
                            lLoi.Add("AJ" + h);
                        }
                        wrksheet.Cells[h, 37] = dr.Cells[14].Value + ""; //14
                        if (temp[16] != dr.Cells[14].Value + "")
                        {
                            lLoi.Add("AK" + h);
                        }
                        wrksheet.Cells[h, 38] = dr.Cells[15].Value + ""; //15
                        if (temp[17] != dr.Cells[15].Value + "")
                        {
                            lLoi.Add("AL" + h);
                        }
                        wrksheet.Cells[h, 39] = dr.Cells[16].Value + ""; //16
                        if (temp[18] != dr.Cells[16].Value + "")
                        {
                            lLoi.Add("AM" + h);
                        }
                        wrksheet.Cells[h, 40] = dr.Cells[17].Value + ""; //17
                        if (temp[19] != dr.Cells[17].Value + "")
                        {
                            lLoi.Add("AN" + h);
                        }

                        if (dr.Cells[18].Value + "" == "2") //18
                        {
                            wrksheet.Cells[h, 41] = "0";
                            if (temp[20] != "0")
                            {
                                lLoi.Add("AO" + h);
                            }
                        }
                        else
                        {
                            wrksheet.Cells[h, 41] = dr.Cells[18].Value + "";
                            if (temp[20] != dr.Cells[18].Value + "")
                            {
                                lLoi.Add("AO" + h);
                            }
                        }
                        h++;
                    }

                    lb_SoDong.Text = (h - 1) + @"/" + dataGridView1.Rows.Count/2;
                    Microsoft.Office.Interop.Excel.Range rowHead = wrksheet.get_Range("A1", "AO" + (h-1));
                    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    i++;
                    
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog1.FileName = cbb_Batch.Text.Replace(@"\","_") + "_Sokatu";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fillcolor(book, lLoi);
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
    }
}