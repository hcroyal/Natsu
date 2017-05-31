using DevExpress.XtraEditors;
using Natsu.MyClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Natsu.MyForm
{
    public partial class FrmCreateBatch : XtraForm
    {
        private string[] _lFileNames;
        private int _soluonghinh;
        private bool _multi;

        public FrmCreateBatch()
        {
            InitializeComponent();
        }

        private void frmCreateBatch_Load(object sender, EventArgs e)
        {
            txt_UserCreate.Text = Global.StrUsername;
            txt_DateCreate.Text = DateTime.Now.ToShortDateString() + @"  -  " + DateTime.Now.ToShortTimeString();
        }

        private void btn_BrowserImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_BatchName.Text))
            {
                MessageBox.Show(@"Please enter a batch name", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = @"All Types Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _lFileNames = dlg.FileNames;
                txt_ImagePath.Text = Path.GetDirectoryName(dlg.FileName);
            }
            _soluonghinh = 0;
            _soluonghinh = dlg.FileNames.Length;
            lb_SoLuongHinh.Text = dlg.FileNames.Length + @" files ";
        }

        private void btn_CreateBatch_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            //UpLoadMulti_5Folder();
        }

        private void UpLoadSingle()
        {
            progressBarControl1.EditValue = 0;
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = _lFileNames.Length;
            progressBarControl1.Properties.Minimum = 0;
            var batch = (from w in Global.Db.tbl_Batches.Where(w => w.fBatchName == txt_BatchName.Text) select w.fBatchName).FirstOrDefault();
            if (!string.IsNullOrEmpty(txt_ImagePath.Text))
            {
                if (string.IsNullOrEmpty(batch))
                {
                    var fBatch = new tbl_Batch
                    {
                        fBatchName = txt_BatchName.Text,
                        fusercreate = txt_UserCreate.Text,
                        fdatecreated = DateTime.Now,
                        fPathPicture = txt_ImagePath.Text,
                        fLocation = txt_Location.Text+"\\"+txt_BatchName.Text+"\\",
                        fSoLuongAnh = _soluonghinh.ToString(),
                        LoaiBatch = "Getsu"
                        //LoaiBatch = rg_LoaiBatch.Properties.Items[rg_LoaiBatch.SelectedIndex].Description
                    };
                    Global.Db.tbl_Batches.InsertOnSubmit(fBatch);
                    Global.Db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show(@"Batch exists please enter another batch name!");
                    return;
                }
            }
            else
            {
                MessageBox.Show(@"You have not selected an image yet!");
                return;
            }
            string temp = Global.StrPath + "\\" + txt_BatchName.Text;
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }
            else
            {
                MessageBox.Show(@"Batch named batch!");
                return;
            }
            foreach (string i in _lFileNames)
            {
                FileInfo fi = new FileInfo(i);

                tbl_Image tempImage = new tbl_Image
                {
                    fbatchname = txt_BatchName.Text,
                    idimage = Path.GetFileName(fi.ToString()),
                    ReadImageDESo = 0,
                    CheckedDESo = 0,
                    TienDoDESO = "Hình chưa nhập",
                    ReadImageDESO_Good = 1,
                    ReadImageDESO_NotGood = 1
                };
                Global.Db.tbl_Images.InsertOnSubmit(tempImage);
                Global.Db.SubmitChanges();

                string des = temp + @"\" + Path.GetFileName(fi.ToString());
                fi.CopyTo(des);
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
            }
            MessageBox.Show(@"Create a new batch successfully!");
            progressBarControl1.EditValue = 0;
            txt_BatchName.Text = "";
            txt_ImagePath.Text = "";
            lb_SoLuongHinh.Text = "";
        }
        private void UpLoadMulti()
        {
            List<string> lStrBath = new List<string>();
            lStrBath.AddRange(Directory.GetDirectories(txt_PathFolder.Text));
            progressBarControl1.EditValue = 0;
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = lStrBath.Count;
            progressBarControl1.Properties.Minimum = 0;
            foreach (string item in lStrBath)
            {
                string batchName = new DirectoryInfo(item).Name;
                var fBatch = new tbl_Batch
                {
                    
                    fBatchName = batchName,
                    fusercreate = txt_UserCreate.Text,
                    fdatecreated = DateTime.Now,
                    fPathPicture = item,
                    fLocation = txt_Location.Text + "\\" + batchName + "\\",
                    fSoLuongAnh = Directory.GetFiles(item).Length.ToString(),
                    LoaiBatch = "Getsu"
                };
                Global.Db.tbl_Batches.InsertOnSubmit(fBatch);
                Global.Db.SubmitChanges();

                string searchFolder = txt_PathFolder.Text + "\\" + new DirectoryInfo(item).Name;
                var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
                string[] tmp = GetFilesFrom(searchFolder, filters, false);
                string temp = Global.StrPath + "\\" + batchName;
                Directory.CreateDirectory(temp);
                string imageJPG = "";
                foreach (string i in tmp)
                {
                    FileInfo fi = new FileInfo(i);
                    tbl_Image tempImage = new tbl_Image
                    {
                        fbatchname = batchName,
                        idimage = Path.GetFileName(fi.ToString()),
                        ReadImageDESo = 0,
                        CheckedDESo = 0,
                        TienDoDESO = "Hình chưa nhập",
                        ReadImageDESO_Good = 1,
                        ReadImageDESO_NotGood = 1
                    };
                    Global.Db.tbl_Images.InsertOnSubmit(tempImage);
                    Global.Db.SubmitChanges();
                    string des = temp + @"\" + Path.GetFileName(fi.ToString());
                    fi.CopyTo(des);
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
            }
            MessageBox.Show(@"Create a new batch successfully!");
            progressBarControl1.EditValue = 0;
            txt_BatchName.Text = "";
            txt_ImagePath.Text = "";
            lb_SoLuongHinh.Text = "";
        }
        private void UpLoadMulti_5Folder()
        {
            List<string> lStrBath1 = new List<string>();
            List<string> lStrBath2 = new List<string>();
            List<string> lStrBath3 = new List<string>();
            List<string> lStrBath4 = new List<string>();
            lStrBath1.AddRange(Directory.GetDirectories(txt_PathFolder.Text));
            progressBarControl1.EditValue = 0;
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = lStrBath1.Count;
            progressBarControl1.Properties.Minimum = 0;

            FileInfo myfile = new FileInfo("G:/Notes.txt");
            StreamWriter tex = myfile.CreateText();
            foreach (string item1 in lStrBath1)
            {
                lStrBath2.Clear();
                lStrBath2.AddRange(Directory.GetDirectories(item1));
                if (lStrBath2.Count>0)
                {
                    foreach (string item2 in lStrBath2)
                    {
                        lStrBath3.Clear();
                        lStrBath3.AddRange(Directory.GetDirectories(item2));
                        if (lStrBath3.Count > 0)
                        {
                            foreach (string item3 in lStrBath3)
                            {
                                lStrBath4.Clear();
                                lStrBath4.AddRange(Directory.GetDirectories(item3));
                                if (lStrBath4.Count > 0)
                                {
                                    foreach (string item4 in lStrBath4)
                                    {
                                        createBatch(item4);
                                    }
                                }
                                else
                                {
                                    createBatch(item3);
                                }
                            }
                        }
                        else
                        {
                            createBatch(item2);
                        }
                    }
                }
                else
                {
                    createBatch(item1);
                }
                progressBarControl1.PerformStep();
                progressBarControl1.Update();




                //string batchName = new DirectoryInfo(item1).Name;
                //var fBatch = new tbl_Batch
                //{

                //    fBatchName = batchName,
                //    fusercreate = txt_UserCreate.Text,
                //    fdatecreated = DateTime.Now,
                //    fPathPicture = item1,
                //    fLocation = txt_Location.Text + "\\" + batchName + "\\",
                //    fSoLuongAnh = Directory.GetFiles(item1).Length.ToString(),
                //    LoaiBatch = "Getsu"
                //};
                //Global.Db.tbl_Batches.InsertOnSubmit(fBatch);
                //Global.Db.SubmitChanges();

                //string searchFolder = txt_PathFolder.Text + "\\" + new DirectoryInfo(item1).Name;
                //var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
                //string[] tmp = GetFilesFrom(searchFolder, filters, false);
                //string temp = Global.StrPath + "\\" + batchName;
                //Directory.CreateDirectory(temp);
                //string imageJPG = "";
                //foreach (string i in tmp)
                //{
                //    FileInfo fi = new FileInfo(i);
                //    tbl_Image tempImage = new tbl_Image
                //    {
                //        fbatchname = batchName,
                //        idimage = Path.GetFileName(fi.ToString()),
                //        ReadImageDESo = 0,
                //        CheckedDESo = 0,
                //        TienDoDESO = "Hình chưa nhập",
                //        ReadImageDESO_Good = 1,
                //        ReadImageDESO_NotGood = 1
                //    };
                //    Global.Db.tbl_Images.InsertOnSubmit(tempImage);
                //    Global.Db.SubmitChanges();
                //    string des = temp + @"\" + Path.GetFileName(fi.ToString());
                //    fi.CopyTo(des);
                //    progressBarControl1.PerformStep();
                //    progressBarControl1.Update();
                //}
                //progressBarControl1.PerformStep();
                //progressBarControl1.Update();
            }
            MessageBox.Show(@"Create a new batch successfully!");
            progressBarControl1.EditValue = 0;
            txt_BatchName.Text = "";
            txt_ImagePath.Text = "";
            lb_SoLuongHinh.Text = "";
        }

        public void createBatch(string location)
        {
            string batchName = new DirectoryInfo(location).Name;
            var fBatch = new tbl_Batch
            {

                fBatchName = batchName,
                fusercreate = txt_UserCreate.Text,
                fdatecreated = DateTime.Now,
                fPathPicture = location,
                fLocation = txt_Location.Text + "\\" + batchName + "\\",
                fSoLuongAnh = Directory.GetFiles(location).Length.ToString(),
                LoaiBatch = "Getsu"
            };
            Global.Db.tbl_Batches.InsertOnSubmit(fBatch);
            Global.Db.SubmitChanges();

            string searchFolder = txt_PathFolder.Text + "\\" + new DirectoryInfo(location).Name;
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
            string[] tmp = GetFilesFrom(searchFolder, filters, false);
            string temp = Global.StrPath + "\\" + batchName;
            Directory.CreateDirectory(temp);
            string imageJPG = "";

            var filters1 = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
            string[] tmp1 = GetFilesFrom(location, filters1, false);
            foreach (string s in tmp1)
            {
                FileInfo fi = new FileInfo(location);
                tbl_Image tempImage = new tbl_Image
                {
                    fbatchname = batchName,
                    idimage = Path.GetFileName(fi.ToString()),
                    ReadImageDESo = 0,
                    CheckedDESo = 0,
                    TienDoDESO = "Hình chưa nhập",
                    ReadImageDESO_Good = 1,
                    ReadImageDESO_NotGood = 1
                };
                Global.Db.tbl_Images.InsertOnSubmit(tempImage);
                Global.Db.SubmitChanges();
                string des = location + @"\" + Path.GetFileName(fi.ToString());
                fi.CopyTo(des);
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
            }
        }
        public static string[] GetFilesFrom(string searchFolder, string[] filters, bool isRecursive)
        {
            List<string> filesFound = new List<string>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, $"*.{filter}", searchOption));
            }
            return filesFound.ToArray();
        }

        private void txt_BatchName_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_BatchName.Text))
            {
                _multi = false;
                txt_PathFolder.Enabled = false;
                btn_Browser.Enabled = false;
            }
            else
            {
                txt_PathFolder.Enabled = true;
                btn_Browser.Enabled = true;
            }
        }

        private void txt_PathFolder_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_PathFolder.Text))
            {
                _multi = true;
                txt_BatchName.Enabled = false;
                txt_ImagePath.Enabled = false;
                btn_BrowserImage.Enabled = false;
            }
            else
            {
                txt_BatchName.Enabled = true;
                txt_ImagePath.Enabled = true;
                btn_BrowserImage.Enabled = true;
            }
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastSelectedFolder))
            {
                folderBrowserDialog1.SelectedPath = Properties.Settings.Default.LastSelectedFolder;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_PathFolder.Text = folderBrowserDialog1.SelectedPath;
                if (!string.IsNullOrEmpty(txt_PathFolder.Text))
                {
                    Properties.Settings.Default.LastSelectedFolder = txt_PathFolder.Text;
                    Properties.Settings.Default.Save();
                }
               
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (_multi)
            {
                UpLoadMulti();
            }
            else
            {
                UpLoadSingle();
            }
        }
    }
}