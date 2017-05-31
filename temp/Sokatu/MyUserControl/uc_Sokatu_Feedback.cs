using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ImageGlass;
using Natsu.MyClass;

namespace Natsu.MyUserControl
{
    public partial class UcSokatuFeedback : UserControl
    {
        public UcSokatuFeedback()
        {
            InitializeComponent();
        }

        public void LoadImage(string fbatchname,string url_image,string idimage)
        {
            ucPictureBox1.LoadImage(url_image, idimage, 100);
            ucPictureBox1.imageBox1.SizeMode = ImageBoxSizeMode.Fit;
            LoadText_User(fbatchname, idimage);
            LoadChecker(fbatchname, idimage);
            SoSanhTextBox();
            SoSanhChecker();
        }
        
        public void LoadText_User(string fbatchname, string idimage)
        {
            var deso = (from w in Global.Db.tbl_DESO_Backups
                        where w.fBatchName == fbatchname && w.IdImage == idimage
                        select w).ToList();
            ucSokatuItemFeedback1.lb_user.Text = deso[0].UserName;
            ucSokatuItemFeedback1.LoadData(deso[0]);

            ucSokatuItemFeedback2.lb_user.Text = deso[1].UserName;
            ucSokatuItemFeedback2.LoadData(deso[1]);
        }

        public void LoadChecker(string fbatchname, string idimage)
        {
            var deso = (from w in Global.Db.tbl_DESOs
                        where w.fBatchName == fbatchname && w.UserName == "Checker" && w.IdImage == idimage
                        select w).ToList();
            ucSokatuItemFeedback3.lb_user.Text = deso[0].UserName;
            ucSokatuItemFeedback3.LoadDataChecker(deso[0]);
        }

        public void LoadImageUser(string user, string fbatchname, string urlImage, string idimage)
        {
            ucPictureBox1.LoadImage(urlImage, idimage, 100);
            ucPictureBox1.imageBox1.SizeMode = ImageBoxSizeMode.Fit;
            LoadText_User(user, fbatchname, idimage);
            LoadChecker_User(fbatchname, idimage);
            SoSanhTextBoxSingle();
        }

        public void LoadText_User(string user, string fbatchname, string idimage)
        {
            var deso = (from w in Global.Db.tbl_DESO_Backups
                        where w.fBatchName == fbatchname && w.IdImage == idimage && w.UserName == user
                        select w).ToList();
            ucSokatuItemFeedback2.lb_user.Text = deso[0].UserName;
            ucSokatuItemFeedback2.LoadData(deso[0]);
        }

        public void LoadChecker_User(string fbatchname, string idimage)
        {
            var deso = (from w in Global.Db.tbl_DESOs
                        where w.fBatchName == fbatchname && w.IdImage == idimage && w.UserName == "Checker"
                        select w).ToList();

            ucSokatuItemFeedback3.lb_user.Text = deso[0].UserName;
            ucSokatuItemFeedback3.LoadDataChecker(deso[0]);
        }

        private void SoSanhTextBox()
        {
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo01, ucSokatuItemFeedback2.txt_TruongSo01);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo02, ucSokatuItemFeedback2.txt_TruongSo02);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo03, ucSokatuItemFeedback2.txt_TruongSo03);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo04, ucSokatuItemFeedback2.txt_TruongSo04);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo05, ucSokatuItemFeedback2.txt_TruongSo05);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo06, ucSokatuItemFeedback2.txt_TruongSo06);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo07, ucSokatuItemFeedback2.txt_TruongSo07);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo08, ucSokatuItemFeedback2.txt_TruongSo08);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo09, ucSokatuItemFeedback2.txt_TruongSo09);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo10, ucSokatuItemFeedback2.txt_TruongSo10);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo11, ucSokatuItemFeedback2.txt_TruongSo11);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo12, ucSokatuItemFeedback2.txt_TruongSo12);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo13, ucSokatuItemFeedback2.txt_TruongSo13);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo14, ucSokatuItemFeedback2.txt_TruongSo14);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo15, ucSokatuItemFeedback2.txt_TruongSo15);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo16, ucSokatuItemFeedback2.txt_TruongSo16);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo17, ucSokatuItemFeedback2.txt_TruongSo17);
            changeColorUser(ucSokatuItemFeedback1.txt_TruongSo18, ucSokatuItemFeedback2.txt_TruongSo18);
       
        }

        private void SoSanhTextBoxSingle()
        {
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo01, ucSokatuItemFeedback3.txt_TruongSo01);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo02, ucSokatuItemFeedback3.txt_TruongSo02);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo03, ucSokatuItemFeedback3.txt_TruongSo03);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo04, ucSokatuItemFeedback3.txt_TruongSo04);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo05, ucSokatuItemFeedback3.txt_TruongSo05);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo06, ucSokatuItemFeedback3.txt_TruongSo06);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo07, ucSokatuItemFeedback3.txt_TruongSo07);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo08, ucSokatuItemFeedback3.txt_TruongSo08);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo09, ucSokatuItemFeedback3.txt_TruongSo09);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo10, ucSokatuItemFeedback3.txt_TruongSo10);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo11, ucSokatuItemFeedback3.txt_TruongSo11);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo12, ucSokatuItemFeedback3.txt_TruongSo12);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo13, ucSokatuItemFeedback3.txt_TruongSo13);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo14, ucSokatuItemFeedback3.txt_TruongSo14);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo15, ucSokatuItemFeedback3.txt_TruongSo15);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo16, ucSokatuItemFeedback3.txt_TruongSo16);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo17, ucSokatuItemFeedback3.txt_TruongSo17);
            changeColorUser_Single(ucSokatuItemFeedback2.txt_TruongSo18, ucSokatuItemFeedback3.txt_TruongSo18);
        }

        private void SoSanhChecker()
        {
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo01, ucSokatuItemFeedback2.txt_TruongSo01, ucSokatuItemFeedback3.txt_TruongSo01);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo02, ucSokatuItemFeedback2.txt_TruongSo02, ucSokatuItemFeedback3.txt_TruongSo02);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo03, ucSokatuItemFeedback2.txt_TruongSo03, ucSokatuItemFeedback3.txt_TruongSo03);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo04, ucSokatuItemFeedback2.txt_TruongSo04, ucSokatuItemFeedback3.txt_TruongSo04);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo05, ucSokatuItemFeedback2.txt_TruongSo05, ucSokatuItemFeedback3.txt_TruongSo05);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo06, ucSokatuItemFeedback2.txt_TruongSo06, ucSokatuItemFeedback3.txt_TruongSo06);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo07, ucSokatuItemFeedback2.txt_TruongSo07, ucSokatuItemFeedback3.txt_TruongSo07);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo08, ucSokatuItemFeedback2.txt_TruongSo08, ucSokatuItemFeedback3.txt_TruongSo08);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo09, ucSokatuItemFeedback2.txt_TruongSo09, ucSokatuItemFeedback3.txt_TruongSo09);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo10, ucSokatuItemFeedback2.txt_TruongSo10, ucSokatuItemFeedback3.txt_TruongSo10);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo11, ucSokatuItemFeedback2.txt_TruongSo11, ucSokatuItemFeedback3.txt_TruongSo11);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo12, ucSokatuItemFeedback2.txt_TruongSo12, ucSokatuItemFeedback3.txt_TruongSo12);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo13, ucSokatuItemFeedback2.txt_TruongSo13, ucSokatuItemFeedback3.txt_TruongSo13);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo14, ucSokatuItemFeedback2.txt_TruongSo14, ucSokatuItemFeedback3.txt_TruongSo14);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo15, ucSokatuItemFeedback2.txt_TruongSo15, ucSokatuItemFeedback3.txt_TruongSo15);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo16, ucSokatuItemFeedback2.txt_TruongSo16, ucSokatuItemFeedback3.txt_TruongSo16);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo17, ucSokatuItemFeedback2.txt_TruongSo17, ucSokatuItemFeedback3.txt_TruongSo17);
            changeColorChecker(ucSokatuItemFeedback1.txt_TruongSo18, ucSokatuItemFeedback2.txt_TruongSo18, ucSokatuItemFeedback3.txt_TruongSo18);
        }

        private void changeColorUser(TextEdit txt1, TextEdit txt2)
        {
            if (txt1.Text != txt2.Text)
            {
                txt1.ForeColor = Color.White;
                txt1.BackColor = Color.Red;
                txt2.ForeColor = Color.White;
                txt2.BackColor = Color.Red;
            }
            else
            {
                txt1.ForeColor = Color.Black;
                txt1.BackColor = Color.White;
                txt2.ForeColor = Color.Black;
                txt2.BackColor = Color.White;
            }
        }
        private void changeColorUser_Single(TextEdit txt1, TextEdit txt2)
        {
            if (txt1.Text != txt2.Text)
            {
                txt1.ForeColor = Color.White;
                txt1.BackColor = Color.Red;
                txt2.ForeColor = Color.White;
                txt2.BackColor = Color.Green;
            }
            else
            {
                txt1.ForeColor = Color.Black;
                txt1.BackColor = Color.White;
                txt2.ForeColor = Color.Black;
                txt2.BackColor = Color.White;
            }
        }

        private void changeColorChecker(TextEdit txt1, TextEdit txt2, TextEdit txt3)
        {
            if (txt1.ForeColor == Color.White|| txt2.ForeColor == Color.White)
            {
                if (txt1.Text == txt3.Text)
                {
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Green;
                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
                else
                {
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Red;

                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
                if (txt2.Text == txt3.Text)
                {
                    txt2.ForeColor = Color.White;
                    txt2.BackColor = Color.Green;
                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
                else
                {
                    txt2.ForeColor = Color.White;
                    txt2.BackColor = Color.Red;

                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
            }
            else
            {
                if (txt1.Text==txt2.Text&& txt1.Text!=txt3.Text)
                {
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Red;
                    txt2.ForeColor = Color.White;
                    txt2.BackColor = Color.Red;

                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
            }
        }
    }
}
