using DevExpress.XtraEditors;
using Natsu.MyClass;
using Natsu.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Natsu.MyForm
{
    public partial class FrmCheckDeSo : XtraForm
    {
        //private bool _flag = false;

        public FrmCheckDeSo()
        {
            InitializeComponent();
        }

        private void ResetData()
        {
            ucNatsu2.ResetData();
            ucNatsu1.ResetData();
            ucPictureBox1.imageBox1.Image = null;
        }

        private void Compare_TextBox(TextEdit t1, TextEdit t2)
        {
            if (!string.IsNullOrEmpty(t1.Text) || !string.IsNullOrEmpty(t2.Text))
            {
                if (t1.Text != t2.Text)
                {
                    t1.BackColor = Color.PaleVioletRed;
                    t2.BackColor = Color.PaleVioletRed;
                }
            }
            else
            {
                t1.BackColor = Color.White;
                t1.ForeColor = Color.Black;
                t2.BackColor = Color.White;
                t2.ForeColor = Color.Black;
            }
        }

        public void LoadBatchMoi()
        {
            if (MessageBox.Show(@"You want to do the next batch?", @"Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                ResetData();
                btn_Luu_DeSo1.Visible = false;
                btn_Luu_DeSo2.Visible = false;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
                cbb_Batch_Check.DataSource = (from w in Global.Db.GetBatNotFinishCheckerDeSo(Global.StrUsername) select w.fBatchName).ToList();
                cbb_Batch_Check.DisplayMember = "fBatchName";
            }
            else
            {
                //tp_Natsu_DeSo1.PageVisible = false;
                //tp_Natsu_DeSo2.PageVisible = false;

                btn_Luu_DeSo1.Visible = false;
                btn_Luu_DeSo2.Visible = false;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;

                ResetData();

                cbb_Batch_Check.DataSource = (from w in Global.Db.GetBatNotFinishCheckerDeSo(Global.StrUsername) select w.fBatchName).ToList();
                cbb_Batch_Check.DisplayMember = "fBatchName";
                Global.StrBatch = cbb_Batch_Check.Text;
                var soloi = (from w in Global.Db.GetSoLoi_CheckDeSo(cbb_Batch_Check.Text) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" Error";
                btn_Start_Click(null, null);
            }
        }

        private void frm_Check_Load(object sender, EventArgs e)
        {
            try
            {
                cbb_Batch_Check.DataSource = (from w in Global.Db.GetBatNotFinishCheckerDeSo(Global.StrUsername) select w.fBatchName).ToList();
                cbb_Batch_Check.DisplayMember = "fBatchName";
                cbb_Batch_Check.Text = Global.StrBatch;
                Global.StrBatch = cbb_Batch_Check.Text;
                var soloi = (from w in Global.Db.GetSoLoi_CheckDeSo(cbb_Batch_Check.Text) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" Error";

                //tp_Natsu_DeSo1.PageVisible = false;
                //tp_Natsu_DeSo2.PageVisible = false;

                btn_Luu_DeSo1.Visible = false;
                btn_Luu_DeSo2.Visible = false;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;

                ucNatsu1.UcNatsuItem1.Changed += UcNatsu1Item1_Changed;
              

                ucNatsu2.UcNatsuItem1.Changed += UcNatsu2Item1_Changed;
             
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error" + i);
            }
        }

        private void UcNatsu2Item1_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User2.Visible = true;
        }

        private void UcNatsu1Item1_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuaVaLuu_User1.Visible = true;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                var nhap = (from w in Global.Db.tbl_Images where w.fbatchname == Global.StrBatch && w.ReadImageDESo == 2 select w.idimage).Count();
                var sohinh = (from w in Global.Db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count();
                var check = (from w in Global.Db.tbl_MissImage_DESOs where w.fBatchName == Global.StrBatch && w.Submit == 0 select w.IdImage).Count();
                if (sohinh > nhap)
                {
                    MessageBox.Show(@"Not finished DeSo!");
                    return;
                }
                if (check > 0)
                {
                    var listUser =
                    (from w in Global.Db.tbl_MissImage_DESOs where w.fBatchName == Global.StrBatch && w.Submit == 0 select w.UserName).ToList();
                    string sss = "";
                    foreach (var item in listUser)
                    {
                        sss += item + "\r\n";
                    }

                    if (listUser.Count > 0)
                    {
                        MessageBox.Show(@"The user took the image but did not enter: \r\n" + sss);
                        return;
                    }
                }
                string temp = GetImage_DeSo();
                if (temp == "NULL")
                {
                    ucPictureBox1.imageBox1.Image = null;
                    MessageBox.Show(@"Picture is out!");
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show(@"Can not load image!");
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;

                btn_Start.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void Load_DeSo(string strBatch, string idimage)
        {
            try
            {
                var deso = (from w in Global.Db.tbl_DESOs
                            where w.fBatchName == strBatch && w.IdImage == idimage
                            select new
                            {
                                w.UserName,
                                w.Truong_01,
                                w.Truong_02,
                                w.Truong_03,
                                w.Truong_04,
                                w.Truong_05,
                                w.Truong_06,
                                w.Truong_07,
                                w.Truong_08,
                                w.Truong_09,
                                w.Truong_10,
                                w.Truong_11,
                                w.Truong_12,
                                w.Truong_13,
                                w.Truong_14,
                                w.Truong_15,
                                w.Truong_16,
                                w.Truong_17,
                                w.Truong_18,
                                w.Truong_19,
                                w.Truong_20,
                                w.Truong_21,
                                w.Truong_22,
                                w.Truong_23,
                                w.Truong_24,
                                w.Truong_25
                            }).ToList();
                lb_username1.Text = deso[0].UserName;
                lb_username2.Text = deso[1].UserName;
                //load user 1
                ucNatsu1.UcNatsuItem1.txt_TruongSo01.Text = deso[0].Truong_01;
                ucNatsu1.UcNatsuItem1.txt_TruongSo02.Text = deso[0].Truong_02;
                ucNatsu1.UcNatsuItem1.txt_TruongSo03.Text = deso[0].Truong_03;
                ucNatsu1.UcNatsuItem1.txt_TruongSo04.Text = deso[0].Truong_04;
                ucNatsu1.UcNatsuItem1.txt_TruongSo05.Text = deso[0].Truong_05;
                ucNatsu1.UcNatsuItem1.txt_TruongSo06.Text = deso[0].Truong_06;
                ucNatsu1.UcNatsuItem1.txt_TruongSo07.Text = deso[0].Truong_07;
                ucNatsu1.UcNatsuItem1.txt_TruongSo08.Text = deso[0].Truong_08;
                ucNatsu1.UcNatsuItem1.txt_TruongSo09.Text = deso[0].Truong_09;
                ucNatsu1.UcNatsuItem1.txt_TruongSo10.Text = deso[0].Truong_10;
                ucNatsu1.UcNatsuItem1.txt_TruongSo11.Text = deso[0].Truong_11;
                ucNatsu1.UcNatsuItem1.txt_TruongSo12.Text = deso[0].Truong_12;
                ucNatsu1.UcNatsuItem1.txt_TruongSo13.Text = deso[0].Truong_13;
                ucNatsu1.UcNatsuItem1.txt_TruongSo14.Text = deso[0].Truong_14;
                ucNatsu1.UcNatsuItem1.txt_TruongSo15.Text = deso[0].Truong_15;
                ucNatsu1.UcNatsuItem1.txt_TruongSo16.Text = deso[0].Truong_16;
                ucNatsu1.UcNatsuItem1.txt_TruongSo17.Text = deso[0].Truong_17;
                ucNatsu1.UcNatsuItem1.txt_TruongSo18.Text = deso[0].Truong_18;
                ucNatsu1.UcNatsuItem1.txt_TruongSo19.Text = deso[0].Truong_19;
                ucNatsu1.UcNatsuItem1.txt_TruongSo20.Text = deso[0].Truong_20;
                ucNatsu1.UcNatsuItem1.txt_TruongSo21.Text = deso[0].Truong_21;
                ucNatsu1.UcNatsuItem1.txt_TruongSo22.Text = deso[0].Truong_22;
                ucNatsu1.UcNatsuItem1.txt_TruongSo23.Text = deso[0].Truong_23;
                ucNatsu1.UcNatsuItem1.txt_TruongSo24.Text = deso[0].Truong_24;
                ucNatsu1.UcNatsuItem1.txt_TruongSo25.Text = deso[0].Truong_25;
            
                //Load user 2
                ucNatsu2.UcNatsuItem1.txt_TruongSo01.Text = deso[1].Truong_01;
                ucNatsu2.UcNatsuItem1.txt_TruongSo02.Text = deso[1].Truong_02;
                ucNatsu2.UcNatsuItem1.txt_TruongSo03.Text = deso[1].Truong_03;
                ucNatsu2.UcNatsuItem1.txt_TruongSo04.Text = deso[1].Truong_04;
                ucNatsu2.UcNatsuItem1.txt_TruongSo05.Text = deso[1].Truong_05;
                ucNatsu2.UcNatsuItem1.txt_TruongSo06.Text = deso[1].Truong_06;
                ucNatsu2.UcNatsuItem1.txt_TruongSo07.Text = deso[1].Truong_07;
                ucNatsu2.UcNatsuItem1.txt_TruongSo08.Text = deso[1].Truong_08;
                ucNatsu2.UcNatsuItem1.txt_TruongSo09.Text = deso[1].Truong_09;
                ucNatsu2.UcNatsuItem1.txt_TruongSo10.Text = deso[1].Truong_10;
                ucNatsu2.UcNatsuItem1.txt_TruongSo11.Text = deso[1].Truong_11;
                ucNatsu2.UcNatsuItem1.txt_TruongSo12.Text = deso[1].Truong_12;
                ucNatsu2.UcNatsuItem1.txt_TruongSo13.Text = deso[1].Truong_13;
                ucNatsu2.UcNatsuItem1.txt_TruongSo14.Text = deso[1].Truong_14;
                ucNatsu2.UcNatsuItem1.txt_TruongSo15.Text = deso[1].Truong_15;
                ucNatsu2.UcNatsuItem1.txt_TruongSo16.Text = deso[1].Truong_16;
                ucNatsu2.UcNatsuItem1.txt_TruongSo17.Text = deso[1].Truong_17;
                ucNatsu2.UcNatsuItem1.txt_TruongSo18.Text = deso[1].Truong_18;
                ucNatsu2.UcNatsuItem1.txt_TruongSo19.Text = deso[1].Truong_19;
                ucNatsu2.UcNatsuItem1.txt_TruongSo20.Text = deso[1].Truong_20;
                ucNatsu2.UcNatsuItem1.txt_TruongSo21.Text = deso[1].Truong_21;
                ucNatsu2.UcNatsuItem1.txt_TruongSo22.Text = deso[1].Truong_22;
                ucNatsu2.UcNatsuItem1.txt_TruongSo23.Text = deso[1].Truong_23;
                ucNatsu2.UcNatsuItem1.txt_TruongSo24.Text = deso[1].Truong_24;
                ucNatsu2.UcNatsuItem1.txt_TruongSo25.Text = deso[1].Truong_25;

              
                //Compare
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo01, ucNatsu2.UcNatsuItem1.txt_TruongSo01);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo02, ucNatsu2.UcNatsuItem1.txt_TruongSo02);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo03, ucNatsu2.UcNatsuItem1.txt_TruongSo03);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo04, ucNatsu2.UcNatsuItem1.txt_TruongSo04);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo05, ucNatsu2.UcNatsuItem1.txt_TruongSo05);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo06, ucNatsu2.UcNatsuItem1.txt_TruongSo06);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo07, ucNatsu2.UcNatsuItem1.txt_TruongSo07);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo08, ucNatsu2.UcNatsuItem1.txt_TruongSo08);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo09, ucNatsu2.UcNatsuItem1.txt_TruongSo09);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo10, ucNatsu2.UcNatsuItem1.txt_TruongSo10);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo11, ucNatsu2.UcNatsuItem1.txt_TruongSo11);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo12, ucNatsu2.UcNatsuItem1.txt_TruongSo12);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo13, ucNatsu2.UcNatsuItem1.txt_TruongSo13);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo14, ucNatsu2.UcNatsuItem1.txt_TruongSo14);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo15, ucNatsu2.UcNatsuItem1.txt_TruongSo15);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo16, ucNatsu2.UcNatsuItem1.txt_TruongSo16);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo17, ucNatsu2.UcNatsuItem1.txt_TruongSo17);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo18, ucNatsu2.UcNatsuItem1.txt_TruongSo18);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo19, ucNatsu2.UcNatsuItem1.txt_TruongSo19);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo20, ucNatsu2.UcNatsuItem1.txt_TruongSo20);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo21, ucNatsu2.UcNatsuItem1.txt_TruongSo21);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo22, ucNatsu2.UcNatsuItem1.txt_TruongSo22);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo23, ucNatsu2.UcNatsuItem1.txt_TruongSo23);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo24, ucNatsu2.UcNatsuItem1.txt_TruongSo24);
                Compare_TextBox(ucNatsu1.UcNatsuItem1.txt_TruongSo25, ucNatsu2.UcNatsuItem1.txt_TruongSo25);
                
                var soloi = (from w in Global.Db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" Error";
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error loading data: " + i.Message);
            }
        }
        private void loadCurency()
        {
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo08);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo09);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo10);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo11);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo13);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo16);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo17);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo18);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo19);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo20);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo23);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo24);
            curency(ucNatsu1.UcNatsuItem1.txt_TruongSo25);

          

            //UC 2
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo08);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo09);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo10);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo11);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo13);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo16);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo17);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo18);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo19);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo20);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo23);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo24);
            curency(ucNatsu2.UcNatsuItem1.txt_TruongSo25);

        }
        private void curency(TextEdit txt)
        {
            try
            {
                string t;
                if (txt.Text.Length > 0)
                {
                    if (txt.Text.Substring(0, 1) == "-")
                    {
                        if (txt.Text.Length > 1)
                        {
                            t = txt.Text.Substring(1, txt.Text.Length - 1);
                            if (txt.SelectionLength != txt.Text.Length)
                            {
                                if (txt.Text != "?")
                                {
                                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                                    int valueBefore = Int32.Parse(t, System.Globalization.NumberStyles.AllowThousands);
                                    txt.Text = "-" + String.Format(culture, "{0:N0}", valueBefore);
                                    txt.Select(txt.Text.Length, 0);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (txt.SelectionLength != txt.Text.Length)
                        {
                            if (txt.Text != "?")
                            {
                                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                                int valueBefore = Int32.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);
                                txt.Text = string.Format(culture, "{0:N0}", valueBefore);
                                txt.Select(txt.Text.Length, 0);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }

        }
        private string GetImage_DeSo()
        {
            var temp = (from w in Global.Db.tbl_MissCheck_DESOs where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0 select w.IdImage).FirstOrDefault();
            if (string.IsNullOrEmpty(temp))
            {
                var getFilename = (from w in Global.Db.GetImageCheck_DeSo(Global.StrBatch, Global.StrUsername) select w.Column1).FirstOrDefault();
                if (string.IsNullOrEmpty(getFilename))
                    return "NULL";
                lb_Image.Text = getFilename;
                ucPictureBox1.imageBox1.Image = null;
                if (ucPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename, Settings.Default.ZoomImage) == "Error")
                {
                    ucPictureBox1.imageBox1.Image = Resources.svn_deleted;
                    return "Error";
                }
            }
            else
            {
                lb_Image.Text = temp;
                ucPictureBox1.imageBox1.Image = null;
                if (ucPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp, Settings.Default.ZoomImage) == "Error")
                {
                    ucPictureBox1.imageBox1.Image = Resources.svn_deleted;
                    return "Error";
                }
            }
            return "Ok";
        }

        private void btn_Luu_DeSo1_Click(object sender, EventArgs e)
        {
            try
            {
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                Global.Db.LuuDESo(lb_Image.Text, Global.StrBatch, lb_username1.Text, lb_username2.Text, Global.StrUsername);
                ResetData();

                var soloi = (from w in Global.Db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" Error";
                string temp = GetImage_DeSo();

                if (temp == "NULL")
                {
                    ucPictureBox1.imageBox1.Image = null;
                    MessageBox.Show(@"Picture is out!");
                    LoadBatchMoi();
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show(@"Can not load image!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error : " + i.Message);
            }
        }

        private void btn_Luu_DeSo2_Click(object sender, EventArgs e)
        {
            try
            {
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                Global.Db.LuuDESo(lb_Image.Text, Global.StrBatch, lb_username2.Text, lb_username1.Text, Global.StrUsername);

                var soloi = (from w in Global.Db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" Error";
                ResetData();
                string temp = GetImage_DeSo();

                if (temp == "NULL")
                {
                    ucPictureBox1.imageBox1.Image = null;
                    MessageBox.Show(@"Picture is out!");
                    LoadBatchMoi();
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show(@"Can not load image!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error : " + i.Message);
            }
        }

        private void btn_SuaVaLuu_User1_Click(object sender, EventArgs e)
        {
            try
            {
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                ucNatsu1.SuaVaLuu(lb_username1.Text, lb_username2.Text, lb_Image.Text);
                ResetData();

                var soloi = (from w in Global.Db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" Error";
                if (GetImage_DeSo() == "NULL")
                {
                    ucPictureBox1.imageBox1.Image = null;
                    MessageBox.Show(@"Picture is out!");
                    LoadBatchMoi();
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error : " + i.Message);
            }
        }

        private void btn_SuaVaLuu_User2_Click(object sender, EventArgs e)
        {
            try
            {
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                ucNatsu2.SuaVaLuu(lb_username2.Text, lb_username1.Text, lb_Image.Text);

                ResetData();

                var soloi = (from w in Global.Db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + @" Error";
                if (GetImage_DeSo() == "NULL")
                {
                    ucPictureBox1.imageBox1.Image = null;
                    MessageBox.Show(@"Picture is out!");
                    LoadBatchMoi();
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error : " + i.Message);
            }
        }

        private void cbb_Batch_Check_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tp_Natsu_DeSo1.PageVisible = false;
            //tp_Natsu_DeSo2.PageVisible = false;

            btn_Luu_DeSo1.Visible = false;
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User1.Visible = false;
            btn_SuaVaLuu_User2.Visible = false;

            Global.StrBatch = cbb_Batch_Check.Text;
            var soloi = (from w in Global.Db.GetSoLoi_CheckDeSo(cbb_Batch_Check.Text) select w.Column1).FirstOrDefault();
            lb_Loi.Text = soloi + @" Error";
            ResetData();
            btn_Start.Visible = true;
        }

        private void btn_Screen_Click(object sender, EventArgs e)
        {
        }

        private void ucNatsu1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                ucNatsu1.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                ucNatsu2.VerticalScroll.Value = e.NewValue;
        }

        private void ucNatsu2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                ucNatsu2.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                ucNatsu1.VerticalScroll.Value = e.NewValue;
        }

        private void FrmCheckDeSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.PageUp)
                ucPictureBox1.btn_Xoaytrai_Click(null, null);
            if (e.Control && e.KeyCode == Keys.PageDown)
                ucPictureBox1.btn_xoayphai_Click(null, null);
        }

        private void lb_Image_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lb_Image.Text);
            XtraMessageBox.Show("Copy Success!");
        }
    }
}