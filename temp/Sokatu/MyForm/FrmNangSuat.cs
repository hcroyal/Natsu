﻿using Natsu.MyClass;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Natsu.MyForm
{
    public partial class FrmNangSuat : DevExpress.XtraEditors.XtraForm
    {
        private DateTime _firstDateTime;
        private DateTime _lastDateTime;

        public FrmNangSuat()
        {
            InitializeComponent();
        }

        private void frm_NangSuat_Load(object sender, EventArgs e)
        {
            string firstdate = dtp_FirstDay.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string lastdate = dtp_EndDay.Value.ToString("yyyy-MM-dd") + " 23:59:59";

            _firstDateTime = DateTime.Parse(firstdate);
            _lastDateTime = DateTime.Parse(lastdate);
            LoadDataGrid(_firstDateTime, _lastDateTime);
        }

        private void LoadDataGrid(DateTime tuNgay, DateTime denNgay)
        {
            gridControl_LoaiAE.DataSource = Global.Db.NangSuatDeSo_Getsu(tuNgay, denNgay);
        }

        private void dtp_FirstDay_ValueChanged(object sender, EventArgs e)
        {
            string firstdate = dtp_FirstDay.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string lastdate = dtp_EndDay.Value.ToString("yyyy-MM-dd") + " 23:59:59";

            _firstDateTime = DateTime.Parse(firstdate);
            _lastDateTime = DateTime.Parse(lastdate);
            gridControl_LoaiAE.DataSource = null;
            if (_firstDateTime >= _lastDateTime)
            {
                MessageBox.Show(@"Start date must be less than or equal to end date");
            }
            else
            {
                LoadDataGrid(_firstDateTime, _lastDateTime);
            }
        }

        private void dtp_EndDay_ValueChanged(object sender, EventArgs e)
        {
            string firstdate = dtp_FirstDay.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string lastdate = dtp_EndDay.Value.ToString("yyyy-MM-dd") + " 23:59:59";

            _firstDateTime = DateTime.Parse(firstdate);
            _lastDateTime = DateTime.Parse(lastdate);
            gridControl_LoaiAE.DataSource = null;
            if (_firstDateTime > _lastDateTime)
            {
                MessageBox.Show(@"Start date must be less than or equal to end date");
            }
            else
            {
                LoadDataGrid(_firstDateTime, _lastDateTime);
            }
        }

        public bool TableToExcel(string strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.Db.NangSuatDeSo_Getsu(_firstDateTime, _lastDateTime);
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(strfilename, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Worksheet wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                int h = 1;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    wrksheet.Cells[h + 2, 1] = h;

                    wrksheet.Cells[h + 2, 2] = dr.Cells[0].Value?.ToString() ?? "";
                    wrksheet.Cells[h + 2, 3] = dr.Cells[1].Value?.ToString() ?? "";
                    wrksheet.Cells[h + 2, 4] = dr.Cells[2].Value?.ToString() ?? "";
                    wrksheet.Cells[h + 2, 5] = dr.Cells[3].Value?.ToString() ?? "";
                    wrksheet.Cells[h + 2, 6] = dr.Cells[4].Value?.ToString() ?? "";
                    wrksheet.Cells[h + 2, 7] = dr.Cells[5].Value?.ToString() ?? "";
                    wrksheet.Cells[h + 2, 8] = dr.Cells[6].Value?.ToString() ?? "";

                    h++;
                }

                string savePath;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = @"Save Excel Files";
                saveFileDialog1.Filter = @"Excel files (*.xls)|*.xls";
                saveFileDialog1.FileName = "NangSuat_Natsu_" + dtp_FirstDay.Value.Day + "-" + dtp_EndDay.Value.Day;

                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    book.SaveCopyAs(saveFileDialog1.FileName);
                    book.Saved = true;
                    savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    app.Quit();
                }
                else
                {
                    MessageBox.Show(@"Error exporting excel!");
                    return false;
                }
                if (savePath != null) Process.Start(savePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string firstdate = dtp_FirstDay.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string lastdate = dtp_EndDay.Value.ToString("yyyy-MM-dd") + " 23:59:59";

            _firstDateTime = DateTime.Parse(firstdate);
            _lastDateTime = DateTime.Parse(lastdate);

            dataGridView1.DataSource = Global.Db.NangSuatDeSo_Getsu(_firstDateTime, _lastDateTime);
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xls"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xls");
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Productivity.xls"), Properties.Resources.Productivity);
            }
            else
            {
                File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Productivity.xls"), Properties.Resources.Productivity);
            }
            TableToExcel(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xls");
        }
    }
}