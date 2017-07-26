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
        public FrmExportExcel()
        {
            InitializeComponent();
        }

        private int sodong = 0;
        public DateTime date1,date2;
        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_Batch.Text))
            {
                MessageBox.Show(@"Batch not selected .");
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

            date1=DateTime.Now;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Global.Db.ExportExcel_Getsu_New(cbb_Batch.Text);

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
            
            date2 = DateTime.Now;
            MessageBox.Show(@"Thời gian xuất : " + date1 + @"   -   " + date2,sodong+"");

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xlsx"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xlsx");
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ErrorSantei.xlsx"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ErrorSantei.xlsx");
            }
        }

        private void frm_ExportExcel_Load(object sender, EventArgs e)
        {
            cbb_Batch.Items.Clear();
            var result = from w in Global.Db.tbl_Batches where w.CongKhaiBatch==true orderby w.fdatecreated select w.fBatchName;

            if (result.Count() > 0)
            {
                cbb_Batch.Items.AddRange(result.ToArray());
                cbb_Batch.DisplayMember = "fBatchName";
                cbb_Batch.ValueMember = "fbatchname";
                cbb_Batch.Text = Global.StrBatch;
            }
        }

        public bool TableToExcel(string strfilename, DataGridView dataGrid)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = App.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet wrksheet =(Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                int h = 2;
                progressBarControl1.EditValue = 0;
                progressBarControl1.Properties.Step = 1;
                progressBarControl1.Properties.PercentView = true;
                progressBarControl1.Properties.Maximum = dataGrid.Rows.Count/2;
                progressBarControl1.Properties.Minimum = 0;
                progressBarControl1.Properties.StartColor = Color.DarkRed; // choose the color
                progressBarControl1.Properties.EndColor = Color.Green; // choose the color
                string truong1 = "";
                string truong2 = "";
                string truong3_1 = "";
                string truong3_2 = "";
                string truong3_3 = "";
                string truong4 = "";
                string truong5 = "";
                string truong6 = "";
                string truong7 = "";
                string truong8 = "";
                string truong9 = "";
                string truong10 = "";
                string truong11 = "";
                string truong12_1 = "";
                string truong12_2 = "";
                string truong13 = "";
                string truong14 = "";
                string truong15 = "";
                string truong16 = "";
                string truong17 = "";
                string truong18 = "";
                string truong19 = "";
                string truong20 = "";
                string truong21 = "";
                string truong22 = "";
                string truong23 = "";
                string truong24 = "";
                string truong25 = "";

                int TongSoLoi = (from w in Global.Db.tbl_DESOs where w.fBatchName == cbb_Batch.Text && w.UserName != "Checker" && w.Error == 1 select w).Count();
                int TongSoDong = dataGrid.Rows.Count/2;
                int PhanTramTongSoDong = TongSoDong / 100 * 4;
                int SoLuongLapLai = TongSoLoi / PhanTramTongSoDong;
                int k = 0;
                if (TongSoLoi<PhanTramTongSoDong)
                {
                    for (int j = 0; j < dataGrid.RowCount; j += 2)
                    {


                        wrksheet.Cells[h, 1] = dataGrid[0, j].Value + ""; //tên image
                        wrksheet.Cells[h, 2] = truong1 = dataGrid[1, j].Value + ""; //1
                        wrksheet.Cells[h, 3] = truong2 = dataGrid[2, j].Value + ""; //2
                        if ((dataGrid[3, j].Value + "").Length == 6) //3
                        {
                            wrksheet.Cells[h, 4] = truong3_1 = (dataGrid[3, j].Value + "").Substring(0, 2);
                            wrksheet.Cells[h, 5] = truong3_2 = (dataGrid[3, j].Value + "").Substring(2, 2);
                            wrksheet.Cells[h, 6] = truong3_3 = (dataGrid[3, j].Value + "").Substring(4, 2);
                        }
                        else if ((dataGrid[3, j].Value + "") == "*")
                        {
                            wrksheet.Cells[h, 4] = truong3_1 = "*";
                            wrksheet.Cells[h, 5] = truong3_2 = "*";
                            wrksheet.Cells[h, 6] = truong3_3 = "*";
                        }
                        else
                        {
                            wrksheet.Cells[h, 4] = truong3_1 = "";
                            wrksheet.Cells[h, 5] = truong3_2 = "";
                            wrksheet.Cells[h, 6] = truong3_3 = dataGrid[3, j].Value + "";
                        }


                        wrksheet.Cells[h, 7] = truong4 = dataGrid[4, j].Value + ""; //4
                        wrksheet.Cells[h, 8] = truong5 = dataGrid[5, j].Value + ""; //5
                        wrksheet.Cells[h, 9] = truong6 = dataGrid[6, j].Value + ""; //6
                        wrksheet.Cells[h, 10] = truong7 = dataGrid[7, j].Value + ""; ; //7
                        wrksheet.Cells[h, 11] = truong8 = dataGrid[8, j].Value + ""; //8
                        wrksheet.Cells[h, 12] = truong9 = dataGrid[9, j].Value + ""; //9
                        wrksheet.Cells[h, 13] = truong10 = dataGrid[10, j].Value + ""; //10
                        wrksheet.Cells[h, 14] = truong11 = dataGrid[11, j].Value + ""; //11

                        if ((dataGrid[12, j].Value + "").Length == 4) //12
                        {
                            wrksheet.Cells[h, 15] = truong12_1 = (dataGrid[12, j].Value + "").Substring(0, 2);
                            wrksheet.Cells[h, 16] = truong12_2 = (dataGrid[12, j].Value + "").Substring(2, 2);
                        }
                        else if ((dataGrid[12, j].Value + "") == "*")
                        {
                            wrksheet.Cells[h, 15] = truong12_1 = "*";
                            wrksheet.Cells[h, 16] = truong12_2 = "*";
                        }
                        else
                        {
                            wrksheet.Cells[h, 15] = truong12_1 = "";
                            wrksheet.Cells[h, 16] = truong12_2 = dataGrid[12, j].Value + "";
                        }

                        wrksheet.Cells[h, 17] = truong13 = dataGrid[13, j].Value + ""; //13
                        wrksheet.Cells[h, 18] = truong14 = dataGrid[14, j].Value + ""; //14
                        wrksheet.Cells[h, 19] = truong15 = dataGrid[15, j].Value + ""; //15
                        wrksheet.Cells[h, 20] = truong16 = dataGrid[16, j].Value + ""; //16
                        wrksheet.Cells[h, 21] = truong17 = dataGrid[17, j].Value + ""; //17
                        wrksheet.Cells[h, 22] = truong18 = dataGrid[18, j].Value + ""; //18
                        wrksheet.Cells[h, 23] = truong19 = dataGrid[19, j].Value + ""; //19
                        wrksheet.Cells[h, 24] = truong20 = dataGrid[20, j].Value + ""; //20
                        wrksheet.Cells[h, 25] = truong21 = dataGrid[21, j].Value + ""; //21
                        wrksheet.Cells[h, 26] = truong22 = dataGrid[22, j].Value + ""; //22
                        wrksheet.Cells[h, 27] = truong23 = dataGrid[23, j].Value + ""; //23
                        wrksheet.Cells[h, 28] = truong24 = dataGrid[24, j].Value + ""; //24
                        wrksheet.Cells[h, 29] = truong25 = dataGrid[25, j].Value + ""; //25
                        wrksheet.Cells[h, 30] = dataGrid[26, j].Value + ""; //ID

                        wrksheet.Cells[h, 31] = dataGrid[1, j + 1].Value + ""; //1
                        if (truong1 != dataGrid[1, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 31].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 32] = dataGrid[2, j + 1].Value + ""; //2
                        if (truong2 != dataGrid[2, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 32].Interior.Color = Color.Red;
                        }
                        if ((dataGrid[3, j + 1].Value + "").Length == 6) //3
                        {
                            wrksheet.Cells[h, 33] = (dataGrid[3, j + 1].Value + "").Substring(0, 2);
                            if (truong3_1 != (dataGrid[3, j + 1].Value + "").Substring(0, 2))
                            {
                                wrksheet.Cells[h, 33].Interior.Color = Color.Red;
                            }
                            wrksheet.Cells[h, 34] = (dataGrid[3, j + 1].Value + "").Substring(2, 2);
                            if (truong3_2 != (dataGrid[3, j + 1].Value + "").Substring(2, 2))
                            {
                                wrksheet.Cells[h, 34].Interior.Color = Color.Red;
                            }
                            wrksheet.Cells[h, 35] = (dataGrid[3, j + 1].Value + "").Substring(4, 2);
                            if (truong3_3 != (dataGrid[3, j + 1].Value + "").Substring(4, 2))
                            {
                                wrksheet.Cells[h, 35].Interior.Color = Color.Red;
                            }
                        }
                        else if ((dataGrid[3, j + 1].Value + "") == "*")
                        {
                            wrksheet.Cells[h, 33] = "*";
                            if (truong3_1 != "*")
                            {
                                wrksheet.Cells[h, 33].Interior.Color = Color.Red;
                            }
                            wrksheet.Cells[h, 34] = "*";
                            if (truong3_2 != "*")
                            {
                                wrksheet.Cells[h, 34].Interior.Color = Color.Red;
                            }
                            wrksheet.Cells[h, 35] = "*";
                            if (truong3_3 != "*")
                            {
                                wrksheet.Cells[h, 35].Interior.Color = Color.Red;
                            }
                        }
                        else
                        {
                            wrksheet.Cells[h, 33] = "";
                            if (truong3_1 != "")
                            {
                                wrksheet.Cells[h, 33].Interior.Color = Color.Red;
                            }
                            wrksheet.Cells[h, 34] = "";
                            if (truong3_2 != "")
                            {
                                wrksheet.Cells[h, 34].Interior.Color = Color.Red;
                            }
                            wrksheet.Cells[h, 35] = dataGrid[3, j + 1].Value + "";
                            if (truong3_3 != dataGrid[3, j + 1].Value + "")
                            {
                                wrksheet.Cells[h, 35].Interior.Color = Color.Red;
                            }
                        }

                        wrksheet.Cells[h, 36] = dataGrid[4, j + 1].Value + ""; //4
                        if (truong4 != dataGrid[4, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 36].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 37] = dataGrid[5, j + 1].Value + ""; //5
                        if (truong5 != dataGrid[5, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 37].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 38] = dataGrid[6, j + 1].Value + ""; //6
                        if (truong6 != dataGrid[6, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 38].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 39] = dataGrid[7, j + 1].Value + ""; //7
                        if (truong7 != dataGrid[7, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 39].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 40] = dataGrid[8, j + 1].Value + ""; //8
                        if (truong8 != dataGrid[8, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 40].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 41] = dataGrid[9, j + 1].Value + ""; //9
                        if (truong9 != dataGrid[9, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 41].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 42] = dataGrid[10, j + 1].Value + ""; //10
                        if (truong10 != dataGrid[10, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 42].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 43] = dataGrid[11, j + 1].Value + ""; //11
                        if (truong11 != dataGrid[11, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 43].Interior.Color = Color.Red;
                        }

                        if ((dataGrid[12, j + 1].Value + "").Length == 4) //12
                        {
                            wrksheet.Cells[h, 44] = (dataGrid[12, j + 1].Value + "").Substring(0, 2);
                            if (truong12_1 != (dataGrid[12, j + 1].Value + "").Substring(0, 2))
                            {
                                wrksheet.Cells[h, 44].Interior.Color = Color.Red;
                            }
                            wrksheet.Cells[h, 45] = (dataGrid[12, j + 1].Value + "").Substring(2, 2);
                            if (truong12_2 != (dataGrid[12, j + 1].Value + "").Substring(2, 2))
                            {
                                wrksheet.Cells[h, 45].Interior.Color = Color.Red;
                            }
                        }
                        else if ((dataGrid[12, j + 1].Value + "") == "*")
                        {
                            wrksheet.Cells[h, 44] = "*";
                            if (truong12_1 != "*")
                            {
                                wrksheet.Cells[h, 44].Interior.Color = Color.Red;
                            }
                            wrksheet.Cells[h, 45] = "*";
                            if (truong12_2 != "*")
                            {
                                wrksheet.Cells[h, 45].Interior.Color = Color.Red;
                            }
                        }
                        else
                        {
                            wrksheet.Cells[h, 44] = "";
                            if (truong12_1 != "")
                            {
                                wrksheet.Cells[h, 44].Interior.Color = Color.Red;
                            }
                            wrksheet.Cells[h, 45] = dataGrid[12, j + 1].Value + "";
                            if (truong12_2 != dataGrid[12, j + 1].Value + "")
                            {
                                wrksheet.Cells[h, 45].Interior.Color = Color.Red;
                            }
                        }

                        wrksheet.Cells[h, 46] = dataGrid[13, j + 1].Value + ""; //13
                        if (truong13 != dataGrid[13, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 46].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 47] = dataGrid[14, j + 1].Value + ""; //14
                        if (truong14 != dataGrid[14, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 47].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 48] = dataGrid[15, j + 1].Value + ""; //15
                        if (truong15 != dataGrid[15, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 48].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 49] = dataGrid[16, j + 1].Value + ""; //16
                        if (truong16 != dataGrid[16, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 49].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 50] = dataGrid[17, j + 1].Value + ""; //17
                        if (truong17 != dataGrid[17, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 50].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 51] = dataGrid[18, j + 1].Value + ""; //18
                        if (truong18 != dataGrid[18, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 51].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 52] = dataGrid[19, j + 1].Value + ""; //19
                        if (truong19 != dataGrid[19, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 52].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 53] = dataGrid[20, j + 1].Value + ""; //20
                        if (truong20 != dataGrid[20, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 53].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 54] = dataGrid[21, j + 1].Value + ""; //21
                        if (truong21 != dataGrid[21, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 54].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 55] = dataGrid[22, j + 1].Value + ""; //22
                        if (truong22 != dataGrid[22, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 55].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 56] = dataGrid[23, j + 1].Value + ""; //23
                        if (truong23 != dataGrid[23, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 56].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 57] = dataGrid[24, j + 1].Value + ""; //24
                        if (truong24 != dataGrid[24, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 57].Interior.Color = Color.Red;
                        }
                        wrksheet.Cells[h, 58] = dataGrid[25, j + 1].Value + ""; //25
                        if (truong25 != dataGrid[25, j + 1].Value + "")
                        {
                            wrksheet.Cells[h, 58].Interior.Color = Color.Red;
                        }

                        h++;

                        lb_SoDong.Text = (h - 1) + @"/" + dataGrid.Rows.Count / 2;
                        progressBarControl1.PerformStep();
                        progressBarControl1.Update();
                    }
                }
                else
                {
                    for (int j = 0; j < dataGrid.RowCount; j += 2)
                    {


                        wrksheet.Cells[h, 1] = dataGrid[0, j].Value + ""; //tên image
                        wrksheet.Cells[h, 2] = truong1 = dataGrid[1, j].Value + ""; //1
                        wrksheet.Cells[h, 3] = truong2 = dataGrid[2, j].Value + ""; //2
                        if ((dataGrid[3, j].Value + "").Length == 6) //3
                        {
                            wrksheet.Cells[h, 4] = truong3_1 = (dataGrid[3, j].Value + "").Substring(0, 2);
                            wrksheet.Cells[h, 5] = truong3_2 = (dataGrid[3, j].Value + "").Substring(2, 2);
                            wrksheet.Cells[h, 6] = truong3_3 = (dataGrid[3, j].Value + "").Substring(4, 2);
                        }
                        else if ((dataGrid[3, j].Value + "") == "*")
                        {
                            wrksheet.Cells[h, 4] = truong3_1 = "*";
                            wrksheet.Cells[h, 5] = truong3_2 = "*";
                            wrksheet.Cells[h, 6] = truong3_3 = "*";
                        }
                        else
                        {
                            wrksheet.Cells[h, 4] = truong3_1 = "";
                            wrksheet.Cells[h, 5] = truong3_2 = "";
                            wrksheet.Cells[h, 6] = truong3_3 = dataGrid[3, j].Value + "";
                        }


                        wrksheet.Cells[h, 7] = truong4 = dataGrid[4, j].Value + ""; //4
                        wrksheet.Cells[h, 8] = truong5 = dataGrid[5, j].Value + ""; //5
                        wrksheet.Cells[h, 9] = truong6 = dataGrid[6, j].Value + ""; //6
                        wrksheet.Cells[h, 10] = truong7 = dataGrid[7, j].Value + ""; ; //7
                        wrksheet.Cells[h, 11] = truong8 = dataGrid[8, j].Value + ""; //8
                        wrksheet.Cells[h, 12] = truong9 = dataGrid[9, j].Value + ""; //9
                        wrksheet.Cells[h, 13] = truong10 = dataGrid[10, j].Value + ""; //10
                        wrksheet.Cells[h, 14] = truong11 = dataGrid[11, j].Value + ""; //11

                        if ((dataGrid[12, j].Value + "").Length == 4) //12
                        {
                            wrksheet.Cells[h, 15] = truong12_1 = (dataGrid[12, j].Value + "").Substring(0, 2);
                            wrksheet.Cells[h, 16] = truong12_2 = (dataGrid[12, j].Value + "").Substring(2, 2);
                        }
                        else if ((dataGrid[12, j].Value + "") == "*")
                        {
                            wrksheet.Cells[h, 15] = truong12_1 = "*";
                            wrksheet.Cells[h, 16] = truong12_2 = "*";
                        }
                        else
                        {
                            wrksheet.Cells[h, 15] = truong12_1 = "";
                            wrksheet.Cells[h, 16] = truong12_2 = dataGrid[12, j].Value + "";
                        }

                        wrksheet.Cells[h, 17] = truong13 = dataGrid[13, j].Value + ""; //13
                        wrksheet.Cells[h, 18] = truong14 = dataGrid[14, j].Value + ""; //14
                        wrksheet.Cells[h, 19] = truong15 = dataGrid[15, j].Value + ""; //15
                        wrksheet.Cells[h, 20] = truong16 = dataGrid[16, j].Value + ""; //16
                        wrksheet.Cells[h, 21] = truong17 = dataGrid[17, j].Value + ""; //17
                        wrksheet.Cells[h, 22] = truong18 = dataGrid[18, j].Value + ""; //18
                        wrksheet.Cells[h, 23] = truong19 = dataGrid[19, j].Value + ""; //19
                        wrksheet.Cells[h, 24] = truong20 = dataGrid[20, j].Value + ""; //20
                        wrksheet.Cells[h, 25] = truong21 = dataGrid[21, j].Value + ""; //21
                        wrksheet.Cells[h, 26] = truong22 = dataGrid[22, j].Value + ""; //22
                        wrksheet.Cells[h, 27] = truong23 = dataGrid[23, j].Value + ""; //23
                        wrksheet.Cells[h, 28] = truong24 = dataGrid[24, j].Value + ""; //24
                        wrksheet.Cells[h, 29] = truong25 = dataGrid[25, j].Value + ""; //25
                        wrksheet.Cells[h, 30] = dataGrid[26, j].Value + ""; //ID

                        string temp = dataGrid[0, j].Value + "";
                        string image = temp.Substring(temp.Length - 28, 28);
                        int idPhieu = int.Parse(dataGrid[26, j].Value + "");
                        var kt = (from w in Global.Db.tbl_DESOs where w.fBatchName == cbb_Batch.Text && w.IdImage == image && w.IdPhieu == idPhieu && w.Error == 1 && w.UserName != "Checker" select w.IdImage).FirstOrDefault();
                        if (!string.IsNullOrEmpty(kt))
                        {
                            if (k == SoLuongLapLai)
                            {
                                k = 0;
                                sodong += 1;
                                wrksheet.Cells[h, 31] = dataGrid[1, j + 1].Value + ""; //1
                                if (truong1 != dataGrid[1, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 31].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 32] = dataGrid[2, j + 1].Value + ""; //2
                                if (truong2 != dataGrid[2, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 32].Interior.Color = Color.Red;
                                }
                                if ((dataGrid[3, j + 1].Value + "").Length == 6) //3
                                {
                                    wrksheet.Cells[h, 33] = (dataGrid[3, j + 1].Value + "").Substring(0, 2);
                                    if (truong3_1 != (dataGrid[3, j + 1].Value + "").Substring(0, 2))
                                    {
                                        wrksheet.Cells[h, 33].Interior.Color = Color.Red;
                                    }
                                    wrksheet.Cells[h, 34] = (dataGrid[3, j + 1].Value + "").Substring(2, 2);
                                    if (truong3_2 != (dataGrid[3, j + 1].Value + "").Substring(2, 2))
                                    {
                                        wrksheet.Cells[h, 34].Interior.Color = Color.Red;
                                    }
                                    wrksheet.Cells[h, 35] = (dataGrid[3, j + 1].Value + "").Substring(4, 2);
                                    if (truong3_3 != (dataGrid[3, j + 1].Value + "").Substring(4, 2))
                                    {
                                        wrksheet.Cells[h, 35].Interior.Color = Color.Red;
                                    }
                                }
                                else if ((dataGrid[3, j + 1].Value + "") == "*")
                                {
                                    wrksheet.Cells[h, 33] = "*";
                                    if (truong3_1 != "*")
                                    {
                                        wrksheet.Cells[h, 33].Interior.Color = Color.Red;
                                    }
                                    wrksheet.Cells[h, 34] = "*";
                                    if (truong3_2 != "*")
                                    {
                                        wrksheet.Cells[h, 34].Interior.Color = Color.Red;
                                    }
                                    wrksheet.Cells[h, 35] = "*";
                                    if (truong3_3 != "*")
                                    {
                                        wrksheet.Cells[h, 35].Interior.Color = Color.Red;
                                    }
                                }
                                else
                                {
                                    wrksheet.Cells[h, 33] = "";
                                    if (truong3_1 != "")
                                    {
                                        wrksheet.Cells[h, 33].Interior.Color = Color.Red;
                                    }
                                    wrksheet.Cells[h, 34] = "";
                                    if (truong3_2 != "")
                                    {
                                        wrksheet.Cells[h, 34].Interior.Color = Color.Red;
                                    }
                                    wrksheet.Cells[h, 35] = dataGrid[3, j + 1].Value + "";
                                    if (truong3_3 != dataGrid[3, j + 1].Value + "")
                                    {
                                        wrksheet.Cells[h, 35].Interior.Color = Color.Red;
                                    }
                                }

                                wrksheet.Cells[h, 36] = dataGrid[4, j + 1].Value + ""; //4
                                if (truong4 != dataGrid[4, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 36].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 37] = dataGrid[5, j + 1].Value + ""; //5
                                if (truong5 != dataGrid[5, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 37].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 38] = dataGrid[6, j + 1].Value + ""; //6
                                if (truong6 != dataGrid[6, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 38].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 39] = dataGrid[7, j + 1].Value + ""; //7
                                if (truong7 != dataGrid[7, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 39].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 40] = dataGrid[8, j + 1].Value + ""; //8
                                if (truong8 != dataGrid[8, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 40].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 41] = dataGrid[9, j + 1].Value + ""; //9
                                if (truong9 != dataGrid[9, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 41].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 42] = dataGrid[10, j + 1].Value + ""; //10
                                if (truong10 != dataGrid[10, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 42].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 43] = dataGrid[11, j + 1].Value + ""; //11
                                if (truong11 != dataGrid[11, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 43].Interior.Color = Color.Red;
                                }

                                if ((dataGrid[12, j + 1].Value + "").Length == 4) //12
                                {
                                    wrksheet.Cells[h, 44] = (dataGrid[12, j + 1].Value + "").Substring(0, 2);
                                    if (truong12_1 != (dataGrid[12, j + 1].Value + "").Substring(0, 2))
                                    {
                                        wrksheet.Cells[h, 44].Interior.Color = Color.Red;
                                    }
                                    wrksheet.Cells[h, 45] = (dataGrid[12, j + 1].Value + "").Substring(2, 2);
                                    if (truong12_2 != (dataGrid[12, j + 1].Value + "").Substring(2, 2))
                                    {
                                        wrksheet.Cells[h, 45].Interior.Color = Color.Red;
                                    }
                                }
                                else if ((dataGrid[12, j + 1].Value + "") == "*")
                                {
                                    wrksheet.Cells[h, 44] = "*";
                                    if (truong12_1 != "*")
                                    {
                                        wrksheet.Cells[h, 44].Interior.Color = Color.Red;
                                    }
                                    wrksheet.Cells[h, 45] = "*";
                                    if (truong12_2 != "*")
                                    {
                                        wrksheet.Cells[h, 45].Interior.Color = Color.Red;
                                    }
                                }
                                else
                                {
                                    wrksheet.Cells[h, 44] = "";
                                    if (truong12_1 != "")
                                    {
                                        wrksheet.Cells[h, 44].Interior.Color = Color.Red;
                                    }
                                    wrksheet.Cells[h, 45] = dataGrid[12, j + 1].Value + "";
                                    if (truong12_2 != dataGrid[12, j + 1].Value + "")
                                    {
                                        wrksheet.Cells[h, 45].Interior.Color = Color.Red;
                                    }
                                }

                                wrksheet.Cells[h, 46] = dataGrid[13, j + 1].Value + ""; //13
                                if (truong13 != dataGrid[13, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 46].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 47] = dataGrid[14, j + 1].Value + ""; //14
                                if (truong14 != dataGrid[14, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 47].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 48] = dataGrid[15, j + 1].Value + ""; //15
                                if (truong15 != dataGrid[15, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 48].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 49] = dataGrid[16, j + 1].Value + ""; //16
                                if (truong16 != dataGrid[16, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 49].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 50] = dataGrid[17, j + 1].Value + ""; //17
                                if (truong17 != dataGrid[17, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 50].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 51] = dataGrid[18, j + 1].Value + ""; //18
                                if (truong18 != dataGrid[18, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 51].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 52] = dataGrid[19, j + 1].Value + ""; //19
                                if (truong19 != dataGrid[19, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 52].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 53] = dataGrid[20, j + 1].Value + ""; //20
                                if (truong20 != dataGrid[20, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 53].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 54] = dataGrid[21, j + 1].Value + ""; //21
                                if (truong21 != dataGrid[21, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 54].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 55] = dataGrid[22, j + 1].Value + ""; //22
                                if (truong22 != dataGrid[22, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 55].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 56] = dataGrid[23, j + 1].Value + ""; //23
                                if (truong23 != dataGrid[23, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 56].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 57] = dataGrid[24, j + 1].Value + ""; //24
                                if (truong24 != dataGrid[24, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 57].Interior.Color = Color.Red;
                                }
                                wrksheet.Cells[h, 58] = dataGrid[25, j + 1].Value + ""; //25
                                if (truong25 != dataGrid[25, j + 1].Value + "")
                                {
                                    wrksheet.Cells[h, 58].Interior.Color = Color.Red;
                                }
                            }
                            else
                            {
                                k = k + 1;
                                wrksheet.Cells[h, 31] = dataGrid[1, j].Value + ""; //1
                                wrksheet.Cells[h, 32] = dataGrid[2, j].Value + ""; //2
                                if ((dataGrid[3, j].Value + "").Length == 6) //3
                                {
                                    wrksheet.Cells[h, 33] = (dataGrid[3, j].Value + "").Substring(0, 2);
                                    wrksheet.Cells[h, 34] = (dataGrid[3, j].Value + "").Substring(2, 2);
                                    wrksheet.Cells[h, 35] = (dataGrid[3, j].Value + "").Substring(4, 2);
                                }
                                else if ((dataGrid[3, j].Value + "") == "*")
                                {
                                    wrksheet.Cells[h, 33] = "*";
                                    wrksheet.Cells[h, 34] = "*";
                                    wrksheet.Cells[h, 35] = "*";
                                }
                                else
                                {
                                    wrksheet.Cells[h, 33] = "";
                                    wrksheet.Cells[h, 34] = "";
                                    wrksheet.Cells[h, 35] = dataGrid[3, j].Value + "";
                                }

                                wrksheet.Cells[h, 36] = dataGrid[4, j].Value + ""; //4
                                wrksheet.Cells[h, 37] = dataGrid[5, j].Value + ""; //5
                                wrksheet.Cells[h, 38] = dataGrid[6, j].Value + ""; //6
                                wrksheet.Cells[h, 39] = dataGrid[7, j].Value + ""; //7
                                wrksheet.Cells[h, 40] = dataGrid[8, j].Value + ""; //8
                                wrksheet.Cells[h, 41] = dataGrid[9, j].Value + ""; //9
                                wrksheet.Cells[h, 42] = dataGrid[10, j].Value + ""; //10
                                wrksheet.Cells[h, 43] = dataGrid[11, j].Value + ""; //11
                                if ((dataGrid[12, j].Value + "").Length == 4) //12
                                {
                                    wrksheet.Cells[h, 44] = (dataGrid[12, j].Value + "").Substring(0, 2);
                                    wrksheet.Cells[h, 45] = (dataGrid[12, j].Value + "").Substring(2, 2);
                                }
                                else if ((dataGrid[12, j].Value + "") == "*")
                                {
                                    wrksheet.Cells[h, 44] = "*";
                                    wrksheet.Cells[h, 45] = "*";
                                }
                                else
                                {
                                    wrksheet.Cells[h, 44] = "";
                                    wrksheet.Cells[h, 45] = dataGrid[12, j].Value + "";
                                }

                                wrksheet.Cells[h, 46] = dataGrid[13, j].Value + ""; //13
                                wrksheet.Cells[h, 47] = dataGrid[14, j].Value + ""; //14
                                wrksheet.Cells[h, 48] = dataGrid[15, j].Value + ""; //15
                                wrksheet.Cells[h, 49] = dataGrid[16, j].Value + ""; //16
                                wrksheet.Cells[h, 50] = dataGrid[17, j].Value + ""; //17
                                wrksheet.Cells[h, 51] = dataGrid[18, j].Value + ""; //18
                                wrksheet.Cells[h, 52] = dataGrid[19, j].Value + ""; //19
                                wrksheet.Cells[h, 53] = dataGrid[20, j].Value + ""; //20
                                wrksheet.Cells[h, 54] = dataGrid[21, j].Value + ""; //21
                                wrksheet.Cells[h, 55] = dataGrid[22, j].Value + ""; //22
                                wrksheet.Cells[h, 56] = dataGrid[23, j].Value + ""; //23
                                wrksheet.Cells[h, 57] = dataGrid[24, j].Value + ""; //24
                                wrksheet.Cells[h, 58] = dataGrid[25, j].Value + ""; //25
                            }
                        }
                        else
                        {
                            wrksheet.Cells[h, 31] = dataGrid[1, j].Value + ""; //1
                            wrksheet.Cells[h, 32] = dataGrid[2, j].Value + ""; //2
                            if ((dataGrid[3, j].Value + "").Length == 6) //3
                            {
                                wrksheet.Cells[h, 33] = (dataGrid[3, j].Value + "").Substring(0, 2);
                                wrksheet.Cells[h, 34] = (dataGrid[3, j].Value + "").Substring(2, 2);
                                wrksheet.Cells[h, 35] = (dataGrid[3, j].Value + "").Substring(4, 2);
                            }
                            else if ((dataGrid[3, j].Value + "") == "*")
                            {
                                wrksheet.Cells[h, 33] = "*";
                                wrksheet.Cells[h, 34] = "*";
                                wrksheet.Cells[h, 35] = "*";
                            }
                            else
                            {
                                wrksheet.Cells[h, 33] = "";
                                wrksheet.Cells[h, 34] = "";
                                wrksheet.Cells[h, 35] = dataGrid[3, j].Value + "";
                            }

                            wrksheet.Cells[h, 36] = dataGrid[4, j].Value + ""; //4
                            wrksheet.Cells[h, 37] = dataGrid[5, j].Value + ""; //5
                            wrksheet.Cells[h, 38] = dataGrid[6, j].Value + ""; //6
                            wrksheet.Cells[h, 39] = dataGrid[7, j].Value + ""; //7
                            wrksheet.Cells[h, 40] = dataGrid[8, j].Value + ""; //8
                            wrksheet.Cells[h, 41] = dataGrid[9, j].Value + ""; //9
                            wrksheet.Cells[h, 42] = dataGrid[10, j].Value + ""; //10
                            wrksheet.Cells[h, 43] = dataGrid[11, j].Value + ""; //11
                            if ((dataGrid[12, j].Value + "").Length == 4) //12
                            {
                                wrksheet.Cells[h, 44] = (dataGrid[12, j].Value + "").Substring(0, 2);
                                wrksheet.Cells[h, 45] = (dataGrid[12, j].Value + "").Substring(2, 2);
                            }
                            else if ((dataGrid[12, j].Value + "") == "*")
                            {
                                wrksheet.Cells[h, 44] = "*";
                                wrksheet.Cells[h, 45] = "*";
                            }
                            else
                            {
                                wrksheet.Cells[h, 44] = "";
                                wrksheet.Cells[h, 45] = dataGrid[12, j].Value + "";
                            }

                            wrksheet.Cells[h, 46] = dataGrid[13, j].Value + ""; //13
                            wrksheet.Cells[h, 47] = dataGrid[14, j].Value + ""; //14
                            wrksheet.Cells[h, 48] = dataGrid[15, j].Value + ""; //15
                            wrksheet.Cells[h, 49] = dataGrid[16, j].Value + ""; //16
                            wrksheet.Cells[h, 50] = dataGrid[17, j].Value + ""; //17
                            wrksheet.Cells[h, 51] = dataGrid[18, j].Value + ""; //18
                            wrksheet.Cells[h, 52] = dataGrid[19, j].Value + ""; //19
                            wrksheet.Cells[h, 53] = dataGrid[20, j].Value + ""; //20
                            wrksheet.Cells[h, 54] = dataGrid[21, j].Value + ""; //21
                            wrksheet.Cells[h, 55] = dataGrid[22, j].Value + ""; //22
                            wrksheet.Cells[h, 56] = dataGrid[23, j].Value + ""; //23
                            wrksheet.Cells[h, 57] = dataGrid[24, j].Value + ""; //24
                            wrksheet.Cells[h, 58] = dataGrid[25, j].Value + ""; //25
                        }
                        h++;

                        lb_SoDong.Text = (h - 1) + @"/" + dataGrid.Rows.Count / 2;
                        progressBarControl1.PerformStep();
                        progressBarControl1.Update();
                    }
                }
                
                Microsoft.Office.Interop.Excel.Range rowHead = wrksheet.get_Range("A1", "BF" + (h - 1));
                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog1.FileName = cbb_Batch.Text.Replace(@"\", "_") + "_Santei";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //fillcolor(book, lLoi);
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

        //public bool TableToExcel(string strfilename, DataGridView dataGrid)
        //{
        //    try
        //    {
        //        Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
        //        Microsoft.Office.Interop.Excel.Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false,
        //            Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
        //        Microsoft.Office.Interop.Excel.Worksheet wrksheet =
        //            (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
        //        int h = 2;
        //        progressBarControl1.EditValue = 0;
        //        progressBarControl1.Properties.Step = 1;
        //        progressBarControl1.Properties.PercentView = true;
        //        progressBarControl1.Properties.Maximum = dataGrid.RowCount *2 - 2;
        //        progressBarControl1.Properties.Minimum = 0;
        //        progressBarControl1.Properties.StartColor = Color.DarkRed; // choose the color
        //        progressBarControl1.Properties.EndColor = Color.Green; // choose the color
                
        //        for (int j = 0; j < dataGrid.RowCount; j += 2)
        //        {

        //            wrksheet.Cells[h, 1] = dataGrid[0, j].Value + ""; //tên image
        //            wrksheet.Cells[h, 2] = dataGrid[1, j].Value + ""; //1
        //            wrksheet.Cells[h, 3]  = dataGrid[2, j].Value + ""; //2
        //            if ((dataGrid[3, j].Value + "").Length == 6) //3
        //            {
        //                wrksheet.Cells[h, 4] =(dataGrid[3, j].Value + "").Substring(0, 2);
        //                wrksheet.Cells[h, 5] =  (dataGrid[3, j].Value + "").Substring(2, 2);
        //                wrksheet.Cells[h, 6] = (dataGrid[3, j].Value + "").Substring(4, 2);
        //            }
        //            else if ((dataGrid[3, j].Value + "") == "*")
        //            {
        //                wrksheet.Cells[h, 4]  = "*";
        //                wrksheet.Cells[h, 5] = "*";
        //                wrksheet.Cells[h, 6] = "*";
        //            }
        //            else
        //            {
        //                wrksheet.Cells[h, 4] =  "";
        //                wrksheet.Cells[h, 5] = "";
        //                wrksheet.Cells[h, 6] = dataGrid[3, j].Value + "";
        //            }


        //            wrksheet.Cells[h, 7]  = dataGrid[4, j].Value + ""; //4
        //            wrksheet.Cells[h, 8] =dataGrid[5, j].Value + ""; //5
        //            wrksheet.Cells[h, 9] = dataGrid[6, j].Value + ""; //6
        //            wrksheet.Cells[h, 10] = dataGrid[7, j].Value + ""; ; //7
        //            wrksheet.Cells[h, 11] = dataGrid[8, j].Value + ""; //8
        //            wrksheet.Cells[h, 12] = dataGrid[9, j].Value + ""; //9
        //            wrksheet.Cells[h, 13] = dataGrid[10, j].Value + ""; //10
        //            wrksheet.Cells[h, 14] = dataGrid[11, j].Value + ""; //11

        //            if ((dataGrid[12, j].Value + "").Length == 4) //12
        //            {
        //                wrksheet.Cells[h, 15] =  (dataGrid[12, j].Value + "").Substring(0, 2);
        //                wrksheet.Cells[h, 16] = (dataGrid[12, j].Value + "").Substring(2, 2);
        //            }
        //            else if ((dataGrid[12, j].Value + "") == "*")
        //            {
        //                wrksheet.Cells[h, 15] = "*";
        //                wrksheet.Cells[h, 16] =  "*";
        //            }
        //            else
        //            {
        //                wrksheet.Cells[h, 15] =  "";
        //                wrksheet.Cells[h, 16] = dataGrid[12, j].Value + "";
        //            }

        //            wrksheet.Cells[h, 17] =  dataGrid[13, j].Value + ""; //13
        //            wrksheet.Cells[h, 18] = dataGrid[14, j].Value + ""; //14
        //            wrksheet.Cells[h, 19] = dataGrid[15, j].Value + ""; //15
        //            wrksheet.Cells[h, 20] = dataGrid[16, j].Value + ""; //16
        //            wrksheet.Cells[h, 21] = dataGrid[17, j].Value + ""; //17
        //            wrksheet.Cells[h, 22] = dataGrid[18, j].Value + ""; //18
        //            wrksheet.Cells[h, 23] = dataGrid[19, j].Value + ""; //19
        //            wrksheet.Cells[h, 24] = dataGrid[20, j].Value + ""; //20
        //            wrksheet.Cells[h, 25] = dataGrid[21, j].Value + ""; //21
        //            wrksheet.Cells[h, 26] = dataGrid[22, j].Value + ""; //22
        //            wrksheet.Cells[h, 27] = dataGrid[23, j].Value + ""; //23
        //            wrksheet.Cells[h, 28] = dataGrid[24, j].Value + ""; //24
        //            wrksheet.Cells[h, 29] = dataGrid[25, j].Value + ""; //25
        //            wrksheet.Cells[h, 30] = dataGrid[26, j].Value + ""; //ID


        //            wrksheet.Cells[h, 31] = dataGrid[1, j + 1].Value + ""; //1
                   
        //                //wrksheet.Cells[h, 31].Interior.Color = Color.Red;

        //            wrksheet.Cells[h, 32] = dataGrid[2, j + 1].Value + ""; //2
        //            if ((dataGrid[3, j + 1].Value + "").Length == 6) //3
        //            {
        //                wrksheet.Cells[h, 33] = (dataGrid[3, j + 1].Value + "").Substring(0, 2);
        //                wrksheet.Cells[h, 34] = (dataGrid[3, j + 1].Value + "").Substring(2, 2);
        //                wrksheet.Cells[h, 35] = (dataGrid[3, j + 1].Value + "").Substring(4, 2);
        //            }
        //            else if ((dataGrid[3, j + 1].Value + "") == "*")
        //            {
        //                wrksheet.Cells[h, 33] = "*";
        //                wrksheet.Cells[h, 34] = "*";
        //                wrksheet.Cells[h, 35] = "*";
        //            }
        //            else
        //            {
        //                wrksheet.Cells[h, 33] = "";
        //                wrksheet.Cells[h, 34] = "";
        //                wrksheet.Cells[h, 35] = dataGrid[3, j + 1].Value + "";
        //            }

        //            wrksheet.Cells[h, 36] = dataGrid[4, j + 1].Value + ""; //4
        //            wrksheet.Cells[h, 37] = dataGrid[5, j + 1].Value + ""; //5
        //            wrksheet.Cells[h, 38] = dataGrid[6, j + 1].Value + ""; //6
        //            wrksheet.Cells[h, 39] = dataGrid[7, j + 1].Value + ""; //7
        //            wrksheet.Cells[h, 40] = dataGrid[8, j + 1].Value + ""; //8
        //            wrksheet.Cells[h, 41] = dataGrid[9, j + 1].Value + ""; //9
        //            wrksheet.Cells[h, 42] = dataGrid[10, j + 1].Value + ""; //10
        //            wrksheet.Cells[h, 43] = dataGrid[11, j + 1].Value + ""; //11
        //            if ((dataGrid[12, j + 1].Value + "").Length == 4) //12
        //            {
        //                wrksheet.Cells[h, 44] = (dataGrid[12, j + 1].Value + "").Substring(0, 2);
        //                wrksheet.Cells[h, 45] = (dataGrid[12, j + 1].Value + "").Substring(2, 2);
        //            }
        //            else if ((dataGrid[12, j + 1].Value + "") == "*")
        //            {
        //                wrksheet.Cells[h, 44] = "*";
        //                wrksheet.Cells[h, 45] = "*";
        //            }
        //            else
        //            {
        //                wrksheet.Cells[h, 44] = "";
        //                wrksheet.Cells[h, 45] = dataGrid[12, j + 1].Value + "";
        //            }

        //            wrksheet.Cells[h, 46] = dataGrid[13, j + 1].Value + ""; //13
        //            wrksheet.Cells[h, 47] = dataGrid[14, j + 1].Value + ""; //14
        //            wrksheet.Cells[h, 48] = dataGrid[15, j + 1].Value + ""; //15
        //            wrksheet.Cells[h, 49] = dataGrid[16, j + 1].Value + ""; //16
        //            wrksheet.Cells[h, 50] = dataGrid[17, j + 1].Value + ""; //17
        //            wrksheet.Cells[h, 51] = dataGrid[18, j + 1].Value + ""; //18
        //            wrksheet.Cells[h, 52] = dataGrid[19, j + 1].Value + ""; //19
        //            wrksheet.Cells[h, 53] = dataGrid[20, j + 1].Value + ""; //20
        //            wrksheet.Cells[h, 54] = dataGrid[21, j + 1].Value + ""; //21
        //            wrksheet.Cells[h, 55] = dataGrid[22, j + 1].Value + ""; //22
        //            wrksheet.Cells[h, 56] = dataGrid[23, j + 1].Value + ""; //23
        //            wrksheet.Cells[h, 57] = dataGrid[24, j + 1].Value + ""; //24
        //            wrksheet.Cells[h, 58] = dataGrid[25, j + 1].Value + ""; //25
        //            h++;
        //            progressBarControl1.PerformStep();
        //            progressBarControl1.Update();
        //            lb_SoDong.Text = (h - 1) + @"/" + dataGrid.Rows.Count / 2;
        //        }
                

        //        Microsoft.Office.Interop.Excel.Range rowHead = wrksheet.get_Range("A1", "BF" + (h - 1));
        //        rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

        //        for (int i = 2; i < h; i++)
        //        {
        //            if (wrksheet.Range["B" + i].Value != wrksheet.Range["AE" + i].Value)
        //            {
        //                wrksheet.Range["AE" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["C" + i].Value != wrksheet.Range["AF" + i].Value)
        //            {
        //                wrksheet.Range["AF" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["D" + i].Value != wrksheet.Range["AG" + i].Value)
        //            {
        //                wrksheet.Range["AG" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["E" + i].Value != wrksheet.Range["AH" + i].Value)
        //            {
        //                wrksheet.Range["AH" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["F" + i].Value != wrksheet.Range["AI" + i].Value)
        //            {
        //                wrksheet.Range["AI" + i].Interior.Color = Color.Red;
        //            }
        //            //

        //            if (wrksheet.Range["G" + i].Value != wrksheet.Range["AJ" + i].Value)
        //            {
        //                wrksheet.Range["AJ" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["H" + i].Value != wrksheet.Range["AK" + i].Value)
        //            {
        //                wrksheet.Range["AK" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["I" + i].Value != wrksheet.Range["AL" + i].Value)
        //            {
        //                wrksheet.Range["AL" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["J" + i].Value != wrksheet.Range["AM" + i].Value)
        //            {
        //                wrksheet.Range["AM" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["K" + i].Value != wrksheet.Range["AN" + i].Value)
        //            {
        //                wrksheet.Range["AN" + i].Interior.Color = Color.Red;
        //            }
        //            //

        //            if (wrksheet.Range["L" + i].Value != wrksheet.Range["AO" + i].Value)
        //            {
        //                wrksheet.Range["AO" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["M" + i].Value != wrksheet.Range["AP" + i].Value)
        //            {
        //                wrksheet.Range["AP" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["N" + i].Value != wrksheet.Range["AQ" + i].Value)
        //            {
        //                wrksheet.Range["AQ" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["O" + i].Value != wrksheet.Range["AR" + i].Value)
        //            {
        //                wrksheet.Range["AR" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["P" + i].Value != wrksheet.Range["AS" + i].Value)
        //            {
        //                wrksheet.Range["AS" + i].Interior.Color = Color.Red;
        //            }
        //            //

        //            if (wrksheet.Range["Q" + i].Value != wrksheet.Range["AT" + i].Value)
        //            {
        //                wrksheet.Range["AT" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["R" + i].Value != wrksheet.Range["AU" + i].Value)
        //            {
        //                wrksheet.Range["AU" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["S" + i].Value != wrksheet.Range["AV" + i].Value)
        //            {
        //                wrksheet.Range["AV" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["T" + i].Value != wrksheet.Range["AW" + i].Value)
        //            {
        //                wrksheet.Range["AW" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["U" + i].Value != wrksheet.Range["AX" + i].Value)
        //            {
        //                wrksheet.Range["AX" + i].Interior.Color = Color.Red;
        //            }
        //            //

        //            if (wrksheet.Range["V" + i].Value != wrksheet.Range["AY" + i].Value)
        //            {
        //                wrksheet.Range["AY" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["W" + i].Value != wrksheet.Range["AZ" + i].Value)
        //            {
        //                wrksheet.Range["AZ" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["X" + i].Value != wrksheet.Range["BA" + i].Value)
        //            {
        //                wrksheet.Range["BA" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["Y" + i].Value != wrksheet.Range["BB" + i].Value)
        //            {
        //                wrksheet.Range["BB" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["Z" + i].Value != wrksheet.Range["BC" + i].Value)
        //            {
        //                wrksheet.Range["BC" + i].Interior.Color = Color.Red;
        //            }
        //            //

        //            if (wrksheet.Range["AA" + i].Value != wrksheet.Range["BD" + i].Value)
        //            {
        //                wrksheet.Range["BD" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["AB" + i].Value != wrksheet.Range["BE" + i].Value)
        //            {
        //                wrksheet.Range["BE" + i].Interior.Color = Color.Red;
        //            }
        //            if (wrksheet.Range["AC" + i].Value != wrksheet.Range["BF" + i].Value)
        //            {
        //                wrksheet.Range["BF" + i].Interior.Color = Color.Red;
        //            }
        //            progressBarControl1.PerformStep();
        //            progressBarControl1.Update();
        //        }

               

        //        string savePath = "";
        //        saveFileDialog1.Title = "Save Excel Files";
        //        saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
        //        saveFileDialog1.FileName = cbb_Batch.Text.Replace(@"\", "_") + "_Santei";
        //        saveFileDialog1.RestoreDirectory = true;
        //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //        {
        //            book.SaveCopyAs(saveFileDialog1.FileName);
        //            book.Saved = true;
        //            savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
        //            App.Quit();
        //        }
        //        else
        //        {
        //            MessageBox.Show(@"Error exporting excel!");
        //            return false;
        //        }
        //        Process.Start(savePath);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }

        //}

        public bool TableToExcelError(string strfilename, DataGridView dataGrid)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = App.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
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
                        wrksheet.Cells[h, 2].Interior.Color = Color.Red;
                    }
               
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value?.ToString() ?? ""; //2
                    if (dr.Cells[28].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 3].Interior.Color = Color.Red;
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
                        wrksheet.Cells[h, 4].Interior.Color = Color.Red;
                        wrksheet.Cells[h, 5].Interior.Color = Color.Red;
                        wrksheet.Cells[h, 6].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 7] = dr.Cells[4].Value?.ToString() ?? ""; //4
                    if (dr.Cells[30].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 7].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 8] = dr.Cells[5].Value?.ToString() ?? ""; //5
                    if (dr.Cells[31].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 8].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 9] = dr.Cells[6].Value?.ToString() ?? ""; //6
                    if (dr.Cells[32].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 9].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 10] = dr.Cells[7].Value?.ToString() ?? ""; //7
                    if (dr.Cells[33].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 10].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 11] = dr.Cells[8].Value?.ToString() ?? ""; //8
                    if (dr.Cells[34].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 11].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 12] = dr.Cells[9].Value?.ToString() ?? ""; //9
                    if (dr.Cells[35].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 12].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 13] = dr.Cells[10].Value?.ToString() ?? ""; //10
                    if (dr.Cells[36].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 13].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 14] = dr.Cells[11].Value?.ToString() ?? ""; //11
                    if (dr.Cells[37].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 14].Interior.Color = Color.Red;
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
                        wrksheet.Cells[h, 15].Interior.Color = Color.Red;
                        wrksheet.Cells[h, 16].Interior.Color = Color.Red;
                    }


                    wrksheet.Cells[h, 17] = dr.Cells[13].Value?.ToString() ?? ""; //13
                    if (dr.Cells[39].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 17].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 18] = dr.Cells[14].Value?.ToString() ?? ""; //14
                    if (dr.Cells[40].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 18].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 19] = dr.Cells[15].Value?.ToString() ?? ""; //15
                    if (dr.Cells[41].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 19].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 20] = dr.Cells[16].Value?.ToString() ?? ""; //16
                    if (dr.Cells[42].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 20].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 21] = dr.Cells[17].Value?.ToString() ?? ""; //17
                    if (dr.Cells[43].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 21].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 22] = dr.Cells[18].Value?.ToString() ?? ""; //18.
                    if (dr.Cells[44].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 22].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 23] = dr.Cells[19].Value?.ToString() ?? ""; //19
                    if (dr.Cells[45].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 23].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 24] = dr.Cells[20].Value?.ToString() ?? ""; //20
                    if (dr.Cells[46].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 24].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 25] = dr.Cells[21].Value?.ToString() ?? ""; //21
                    if (dr.Cells[47].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 25].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 26] = dr.Cells[22].Value?.ToString() ?? ""; //22
                    if (dr.Cells[48].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 26].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 27] = dr.Cells[23].Value?.ToString() ?? ""; //23
                    if (dr.Cells[49].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 27].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 28] = dr.Cells[24].Value?.ToString() ?? ""; //24
                    if (dr.Cells[50].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 28].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 29] = dr.Cells[25].Value?.ToString() ?? ""; //25
                    if (dr.Cells[51].Value + "" == "1")
                    {
                        wrksheet.Cells[h, 29].Interior.Color = Color.Red;
                    }
                    wrksheet.Cells[h, 30] = dr.Cells[52].Value?.ToString() ?? ""; //00
                    if (dr.Cells[52].Value + "" == "2")
                    {
                        wrksheet.Cells[h, 30].Interior.Color = Color.Red;
                    }

                    wrksheet.Cells[h, 31] = dr.Cells[26].Value?.ToString() ?? "";

                    

                    lb_SoDong.Text = (h - 1) + @"/" + dataGrid.Rows.Count;
                    i++;
                    h++;
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }
                Microsoft.Office.Interop.Excel.Range rowHead = wrksheet.get_Range("A1", "AE" + h);
                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog1.FileName = cbb_Batch.Text.Replace(@"\","_") + "_Santei_Error";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //fillcolor(book, lRowerror);
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