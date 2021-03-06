﻿using Natsu.MyClass;
using Natsu.Properties;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace Natsu.MyForm
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        private bool _lock;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void SetValue()
        {
            if (Global.StrRole == "DESO")
            {
                lb_SoHinhConLai.Text = (from w in Global.Db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "") select w.idimage).Count().ToString();
                lb_SoHinhLamDuoc.Text = (from w in Global.Db.tbl_MissImage_DESOs where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch select w.IdImage).Count().ToString();
            }
        }

        public string GetImage()
        {
            LockControl(true);
            var ktUser = (from w in Global.DbBpo.tbl_Users where w.Username == Global.StrUsername select w.NotGoodUser).FirstOrDefault();
            Global.NotGoodUser = ktUser == true;
            if (Global.StrRole == "DESO")
            {
                if (Global.BatchChiaUser)
                {
                    if (Global.NotGoodUser)
                    {
                        string temp = (from w in Global.Db.tbl_MissImage_DESOs where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0 select w.IdImage).FirstOrDefault();
                        if (string.IsNullOrEmpty(temp))
                        {
                            try
                            {
                                var getFilename = (from w in Global.Db.GetImage_Group_Notgood(Global.StrBatch, Global.StrUsername) select w.Column1).FirstOrDefault();
                                if (string.IsNullOrEmpty(getFilename))
                                {
                                    return "NULL";
                                }
                                lb_IdImage.Text = getFilename;
                                UcPictureBox1.imageBox1.Image = null;
                                if (UcPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename, Settings.Default.ZoomImage) == "Error")
                                {
                                    UcPictureBox1.imageBox1.Image = Resources.svn_deleted;
                                    return "Error";

                                }
                            }
                            catch (Exception i)
                            {
                                //LogFile.WriteLog(Global.StrUsername + ".txt", i.Message);
                                return "NULL";
                            }
                        }
                        else
                        {
                            lb_IdImage.Text = temp;
                            UcPictureBox1.imageBox1.Image = null;
                            if (UcPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp, Settings.Default.ZoomImage) == "Error")
                            {
                                UcPictureBox1.imageBox1.Image = Resources.svn_deleted;
                                return "Error";
                            }
                        }
                    }
                    else
                    {
                        string temp = (from w in Global.Db.tbl_MissImage_DESOs where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0 select w.IdImage).FirstOrDefault();
                        if (string.IsNullOrEmpty(temp))
                        {
                            try
                            {
                                var getFilename = (from w in Global.Db.GetImage_Group_Good(Global.StrBatch, Global.StrUsername) select w.Column1).FirstOrDefault();
                                if (string.IsNullOrEmpty(getFilename))
                                {
                                    return "NULL";
                                }
                                lb_IdImage.Text = getFilename;
                                UcPictureBox1.imageBox1.Image = null;
                                if (UcPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename, Settings.Default.ZoomImage) == "Error")
                                {
                                    UcPictureBox1.imageBox1.Image = Resources.svn_deleted;
                                    return "Error";

                                }
                            }
                            catch (Exception i)
                            {
                                //LogFile.WriteLog(Global.StrUsername + ".txt", i.Message);
                                return "NULL";
                            }
                        }
                        else
                        {
                            lb_IdImage.Text = temp;
                            UcPictureBox1.imageBox1.Image = null;
                            if (UcPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp, Settings.Default.ZoomImage) == "Error")
                            {
                                UcPictureBox1.imageBox1.Image = Resources.svn_deleted;
                                return "Error";
                            }
                        }
                    }
                }
                else
                {
                    string temp = (from w in Global.Db.tbl_MissImage_DESOs where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0 select w.IdImage).FirstOrDefault();
                    if (string.IsNullOrEmpty(temp))
                    {
                        try
                        {
                            var getFilename = (from w in Global.Db.LayHinhMoi_DeSo(Global.StrBatch, Global.StrUsername) select w.Column1).FirstOrDefault();
                            if (string.IsNullOrEmpty(getFilename))
                            {
                                return "NULL";
                            }
                            lb_IdImage.Text = getFilename;
                            UcPictureBox1.imageBox1.Image = null;
                            if (UcPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename, Settings.Default.ZoomImage) == "Error")
                            {
                                UcPictureBox1.imageBox1.Image = Resources.svn_deleted;
                                return "Error";

                            }
                        }
                        catch (Exception i)
                        {
                            //LogFile.WriteLog(Global.StrUsername + ".txt", i.Message);
                            return "NULL";
                        }
                    }
                    else
                    {
                        lb_IdImage.Text = temp;
                        UcPictureBox1.imageBox1.Image = null;
                        if (UcPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp, Settings.Default.ZoomImage) == "Error")
                        {
                            UcPictureBox1.imageBox1.Image = Resources.svn_deleted;
                            return "Error";
                        }
                    }
                }
                UcNatsu1.UcNatsuItem1.txt_TruongSo01.Focus();
            }
            timer1.Enabled = true;
            
            return "OK";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                _lock = false;
                UserLookAndFeel.Default.SkinName = Settings.Default.ApplicationSkinName;
                var ktBatch = (from w in Global.Db.tbl_Batches where w.fBatchName == Global.StrBatch select w.ChiaUser).FirstOrDefault();
                if (ktBatch==true)
                {
                    Global.BatchChiaUser = true;
                }
                else
                {
                    Global.BatchChiaUser = false;
                }
                lb_IdImage.Text = "";
                lb_fBatchName.Text = Global.StrBatch;
                lb_UserName.Text = Global.StrUsername;
                lb_TongSoHinh.Text = (from w in Global.Db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
                lb_SoHinhConLai.Text = (from w in Global.Db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "") select w.idimage).Count().ToString();
                lb_SoHinhLamDuoc.Text = (from w in Global.Db.tbl_MissImage_DESOs where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch select w.IdImage).Count().ToString();

                bar_Manager.Enabled = false;
                btn_Stop_Performance_Test.Enabled = false;
                bar_Manager.Enabled = false;
                if (Global.StrRole == "DESO" || Global.StrRole == "DEJP")
                {
                    Global.FlagTong = true;
                    bar_Manager.Enabled = false;
                    btn_Submit_Logout.Enabled = false;
                    btn_ZoomImage.Enabled = false;
                    btn_Check.Enabled = false;
                    UcNatsu1.ResetData();
                }
                else if (Global.StrRole == "ADMIN")
                {
                    Global.FlagTong = false;
                    btn_Start_Submit.Enabled = false;
                    btn_Submit_Logout.Enabled = false;
                    btn_ZoomImage.Enabled = true;
                    bar_Manager.Enabled = true;
                    btn_Check.Enabled = true;
                }
                else if (Global.StrRole == "CHECKERDESO" || Global.StrRole == "CHECKERDEJP" || Global.StrRole == "CHECKERDECHU")
                {
                    Global.FlagTong = false;
                    btn_Start_Submit.Enabled = false;
                    btn_Submit_Logout.Enabled = false;
                    btn_ZoomImage.Enabled = true;
                    bar_Manager.Enabled = false;
                    btn_Check.Enabled = true;
                }
                SetValue();
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error Load Main: " + i.Message);
            }
        }

        private void btn_Start_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                //Kiểm tra token
                var token = (from w in Global.DbBpo.tbl_TokenLogins where w.UserName == Global.StrUsername && w.IDProject == Global.StrIdProject select w.Token).FirstOrDefault();

                if (token != Global.StrToken)
                {
                    MessageBox.Show(@"User logged on to another PC, please login again!");
                    DialogResult = DialogResult.Yes;
                }
                if (btn_Start_Submit.Text == @"Start")
                {
                    
                    if (string.IsNullOrEmpty(Global.StrBatch))
                    {
                        MessageBox.Show(@"Please log in again and select Batch!");
                        return;
                    }
                    var ktBatch1 = (from w in Global.Db.tbl_Batches where w.fBatchName == Global.StrBatch select w.ChiaUser).FirstOrDefault();
                    if (ktBatch1 == true)
                    {
                        Global.BatchChiaUser = true;
                    }
                    else
                    {
                        Global.BatchChiaUser = false;
                    }
                    string temp = GetImage();
                    if (temp == "NULL")
                    {
                        if (Global.NotGoodUser)
                        {
                            var listResult = Global.Db.GetBatNotFinishDeSo_NotGood_New1(Global.StrUsername).ToList();
                            if (listResult.Count > 0)
                            {
                                if (MessageBox.Show(@"Batch next is: " + listResult[0].fbatchname + "\nWould you like to continue??", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Global.StrBatch = listResult[0].fbatchname;
                                    var ktBatch = (from w in Global.Db.tbl_Batches where w.fBatchName == Global.StrBatch select w.ChiaUser).FirstOrDefault();
                                    if (ktBatch == true)
                                    {
                                        Global.BatchChiaUser = true;
                                    }
                                    else
                                    {
                                        Global.BatchChiaUser = false;
                                    }
                                    lb_fBatchName.Text = Global.StrBatch;
                                    lb_IdImage.Text = "";
                                    lb_TongSoHinh.Text =
                                        (from w in Global.Db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
                                    lb_SoHinhConLai.Text = (from w in Global.Db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "") select w.idimage).Count().ToString();
                                    lb_SoHinhLamDuoc.Text = (from w in Global.Db.tbl_MissImage_DESOs where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch select w.IdImage).Count().ToString();

                                    SetValue();
                                    btn_Start_Submit.Text = @"Start";
                                    btn_Start_Submit_Click(null, null);
                                }
                                else
                                {
                                    btn_Logout_ItemClick(null, null);
                                }
                            }
                            else
                            {
                                MessageBox.Show(@"Finished batch '" + lb_fBatchName.Text + "'");
                                btn_Logout_ItemClick(null, null);
                            }

                        }
                        else
                        {
                            var listResult = Global.Db.GetBatNotFinishDeSo_Good_New1(Global.StrUsername).ToList();
                            if (listResult.Count > 0)
                            {
                                if (MessageBox.Show(@"Batch next is: " + listResult[0].fbatchname + "\nWould you like to continue??", "Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Global.StrBatch = listResult[0].fbatchname;
                                    var ktBatch = (from w in Global.Db.tbl_Batches where w.fBatchName == Global.StrBatch select w.ChiaUser).FirstOrDefault();
                                    if (ktBatch == true)
                                    {
                                        Global.BatchChiaUser = true;
                                    }
                                    else
                                    {
                                        Global.BatchChiaUser = false;
                                    }
                                    lb_fBatchName.Text = Global.StrBatch;
                                    lb_IdImage.Text = "";
                                    lb_TongSoHinh.Text =
                                        (from w in Global.Db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
                                    lb_SoHinhConLai.Text = (from w in Global.Db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "") select w.idimage).Count().ToString();
                                    lb_SoHinhLamDuoc.Text = (from w in Global.Db.tbl_MissImage_DESOs where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch select w.IdImage).Count().ToString();

                                    SetValue();
                                    btn_Start_Submit.Text = @"Start";
                                    btn_Start_Submit_Click(null, null);
                                }
                                else
                                {
                                    btn_Logout_ItemClick(null, null);
                                }
                            }
                            else
                            {
                                MessageBox.Show(@"Finished batch '" + lb_fBatchName.Text + "'");
                                btn_Logout_ItemClick(null, null);
                            }

                        }
                    }
                    else if (temp == "Error")
                    {
                        MessageBox.Show(@"Can not load image!");
                        btn_Logout_ItemClick(null, null);
                    }
                    UcNatsu1.ResetData();
                    btn_Start_Submit.Text = @"Submit";

                }
                else
                {
                    if (Global.StrRole == "DESO")
                    {
                        if (UcNatsu1.TrongTruongSo3())
                        {
                            MessageBox.Show(@"Vui lòng kiểm tra lại trường số 3");
                            return;
                        }
                        if (UcNatsu1.IsEmptyTruong00(UcNatsu1.UcNatsuItem1) || UcNatsu1.IsEmptyTruong00(UcNatsu1.UcNatsuItem2) || UcNatsu1.IsEmptyTruong00(UcNatsu1.UcNatsuItem3) || UcNatsu1.IsEmptyTruong00(UcNatsu1.UcNatsuItem4) || UcNatsu1.IsEmptyTruong00(UcNatsu1.UcNatsuItem5))
                        {
                            MessageBox.Show(@"Field 00 is empty");
                            return;
                        }
                        if (UcNatsu1.TrongTruongSo12())
                        {
                            MessageBox.Show(@"Vui lòng kiểm tra lại trường số 12");
                            return;
                        }
                        if (UcNatsu1.IsEmpty())
                        {
                            if (MessageBox.Show(@"A field(s) is empty. Do you want to continue ? \r\nYes = Submit and next Image < Press Enter >\r\nNo = Enter the blank field for this image. < Press N > ", @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) == DialogResult.No)
                                return;
                        }
                        UcNatsu1.SaveData(lb_IdImage.Text);
                        UcNatsu1.ResetData();
                        var version = (from w in Global.DbBpo.tbl_Versions where w.IDProject == Global.StrIdProject select w.IDVersion).FirstOrDefault();
                        if (version!=Global.Version)
                        {
                            MessageBox.Show(@"The current version is out of date, please update to the new version!");
                            Process.Start(Global.UrlUpdateVersion);
                            Application.Exit();
                        }
                        string temp = GetImage();
                        if (temp == "NULL")
                        {
                            
                            if (Global.NotGoodUser)
                            {
                                var listResult = Global.Db.GetBatNotFinishDeSo_NotGood_New1(Global.StrUsername).ToList();
                                if (listResult.Count > 0)
                                {
                                    if (MessageBox.Show(@"Batch next is: " + listResult[0].fbatchname + "\nWould you like to continue??", @"Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        Global.StrBatch = listResult[0].fbatchname;
                                        var ktBatch = (from w in Global.Db.tbl_Batches where w.fBatchName == Global.StrBatch select w.ChiaUser).FirstOrDefault();
                                        if (ktBatch == true)
                                        {
                                            Global.BatchChiaUser = true;
                                        }
                                        else
                                        {
                                            Global.BatchChiaUser = false;
                                        }
                                        lb_fBatchName.Text = Global.StrBatch;
                                        lb_IdImage.Text = "";
                                        lb_TongSoHinh.Text =
                                            (from w in Global.Db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
                                        lb_SoHinhConLai.Text = (from w in Global.Db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "") select w.idimage).Count().ToString();
                                        lb_SoHinhLamDuoc.Text = (from w in Global.Db.tbl_MissImage_DESOs where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch select w.IdImage).Count().ToString();

                                        SetValue();
                                        btn_Start_Submit.Text = @"Start";
                                        btn_Submit_Logout.Enabled = false;
                                        btn_Start_Submit_Click(null, null);
                                    }
                                    else
                                    {
                                        btn_Logout_ItemClick(null, null);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(@"Finished batch '" + lb_fBatchName.Text + "'");
                                    btn_Logout_ItemClick(null, null);
                                }

                            }
                            else
                            {
                                var listResult = Global.Db.GetBatNotFinishDeSo_Good_New1(Global.StrUsername).ToList();
                                if (listResult.Count > 0)
                                {
                                    if (MessageBox.Show(@"Batch next is: " + listResult[0].fbatchname + "\nWould you like to continue??", @"Notification!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        Global.StrBatch = listResult[0].fbatchname;
                                        var ktBatch = (from w in Global.Db.tbl_Batches where w.fBatchName == Global.StrBatch select w.ChiaUser).FirstOrDefault();
                                        if (ktBatch == true)
                                        {
                                            Global.BatchChiaUser = true;
                                        }
                                        else
                                        {
                                            Global.BatchChiaUser = false;
                                        }
                                        lb_fBatchName.Text = Global.StrBatch;
                                        lb_IdImage.Text = "";
                                        lb_TongSoHinh.Text =
                                            (from w in Global.Db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
                                        lb_SoHinhConLai.Text = (from w in Global.Db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "") select w.idimage).Count().ToString();
                                        lb_SoHinhLamDuoc.Text = (from w in Global.Db.tbl_MissImage_DESOs where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch select w.IdImage).Count().ToString();

                                        SetValue();
                                        btn_Start_Submit.Text = @"Start";
                                        btn_Submit_Logout.Enabled = false;
                                        btn_Start_Submit_Click(null, null);
                                    }
                                    else
                                    {
                                        btn_Logout_ItemClick(null, null);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(@"Finished batch '" + lb_fBatchName.Text + "'");
                                    btn_Logout_ItemClick(null, null);
                                }

                            }
                            
                        }
                        else if (temp == "Error")
                        {
                            MessageBox.Show(@"Can not load image!");
                            btn_Logout_ItemClick(null, null);
                        }
                    }
                    SetValue();
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error Submit" + i.Message);
            }
        }

        private void btn_Submit_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                //Kiểm tra token
                var token = (from w in Global.DbBpo.tbl_TokenLogins where w.UserName == Global.StrUsername && w.IDProject == Global.StrIdProject select w.Token).FirstOrDefault();

                if (token != Global.StrToken)
                {
                    MessageBox.Show(@"User logged on to another PC, please login again!");
                    DialogResult = DialogResult.Yes;
                }
                if (Global.StrRole == "DESO")
                {
                    if (UcNatsu1.TrongTruongSo3())
                    {
                        MessageBox.Show(@"Vui lòng kiểm tra lại trường số 3");
                        return;
                    }
                    if (UcNatsu1.IsEmptyTruong00(UcNatsu1.UcNatsuItem1) || UcNatsu1.IsEmptyTruong00(UcNatsu1.UcNatsuItem2) || UcNatsu1.IsEmptyTruong00(UcNatsu1.UcNatsuItem3) || UcNatsu1.IsEmptyTruong00(UcNatsu1.UcNatsuItem4) || UcNatsu1.IsEmptyTruong00(UcNatsu1.UcNatsuItem5))
                    {
                        MessageBox.Show(@"Field 00 is empty");
                        return;
                    }
                    if (UcNatsu1.TrongTruongSo12())
                    {
                        MessageBox.Show(@"Vui lòng kiểm tra lại trường số 12");
                        return;
                    }
                    if (UcNatsu1.IsEmpty())
                    {
                        if (MessageBox.Show(@"A field(s) is empty. Do you want to continue ? \r\nYes = Submit and next Image < Press Enter >\r\nNo = Enter the blank field for this image. < Press N > ", @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) == DialogResult.No)
                            return;
                    }
                    UcNatsu1.SaveData(lb_IdImage.Text);
                }
                btn_Logout_ItemClick(null, null);
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error Submit" + i.Message);
            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (_lock==false)
            {
                if (e.Control && e.KeyCode == Keys.Enter)
                    btn_Start_Submit_Click(null, null);
                if (e.Control && e.KeyCode == Keys.PageUp)
                    UcPictureBox1.btn_Xoaytrai_Click(null, null);
                if (e.Control && e.KeyCode == Keys.PageDown)
                    UcPictureBox1.btn_xoayphai_Click(null, null);
                if (e.KeyCode == Keys.Escape)
                {
                    new FrmFreeTime().ShowDialog();
                    Global.DbBpo.UpdateTimeFree(Global.StrToken, Global.FreeTime);
                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
            Global.DbBpo.UpdateTimeLogout(Global.StrToken);
            Global.DbBpo.ResetToken(Global.StrUsername, Global.StrIdProject, Global.StrToken);
            Settings.Default.ApplicationSkinName = UserLookAndFeel.Default.SkinName;
            Settings.Default.Save();
            Global.FlagTong = false;
        }

        private void btn_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btn_ZoomImage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmChangeZoom().ShowDialog();
            Settings.Default.Reload();
            GetImage();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            new FrmFreeTime().ShowDialog();
            Global.DbBpo.UpdateTimeFree(Global.StrToken, Global.FreeTime);
        }

        private void btn_Batch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmManagerBatch().ShowDialog();
        }

        private void btn_User_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmUser().ShowDialog();
        }

        private void btn_Check_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmCheckDeSo().ShowDialog();
        }

        private void btn_Progress_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmTienDo().ShowDialog();
        }

        private void btn_Productivity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmNangSuat().ShowDialog();
        }

        private void btn_ExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmExportExcel().ShowDialog();
        }

        private void lb_IdImage_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lb_IdImage.Text);
            XtraMessageBox.Show("Copy Success!");
        }

        private void btn_FeedBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmFeedback().ShowDialog();
        }

        private void LockControl(bool kt)
        {
            if (kt)
            {
                _lock = true;
                btn_ZoomImage.Enabled = false;
                btn_Start_Submit.Enabled = false;
                btn_Submit_Logout.Enabled = false;
            }
            else
            {
                _lock = false;
                btn_ZoomImage.Enabled = true;
                btn_Start_Submit.Enabled = true;
                btn_Submit_Logout.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LockControl(false);
            timer1.Enabled = false;
        }

        private void UcNatsu1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_ChangePassword().ShowDialog();
        }
    }
}