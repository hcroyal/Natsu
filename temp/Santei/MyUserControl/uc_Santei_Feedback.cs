using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ImageGlass;
using Natsu.MyClass;

namespace Natsu.MyUserControl
{
    public partial class uc_Santei_Feedback : UserControl
    {
        public uc_Santei_Feedback()
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
                        orderby w.IdImage ascending , w.UserName ascending, w.IdPhieu ascending
                        select w ).ToList();

            UcNatsuItemFeedback31.ucNatsuItemFeedback_21.lb_user.Text = deso[0].UserName;
            UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.LoadData(deso[0]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.LoadData(deso[1]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.LoadData(deso[2]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.LoadData(deso[3]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.LoadData(deso[4]);

            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.lb_user.Text = deso[5].UserName;
            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.LoadData(deso[5]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.LoadData(deso[6]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.LoadData(deso[7]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.LoadData(deso[8]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.LoadData(deso[9]);
        }

        public void LoadChecker(string fbatchname, string idimage)
        {
            var deso = (from w in Global.Db.tbl_DESOs
                        where w.fBatchName == fbatchname && w.UserName == "Checker" && w.IdImage == idimage
                        orderby w.IdImage ascending, w.UserName ascending, w.IdPhieu ascending
                        select w).ToList();

            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.lb_user.Text = deso[0].UserName;
            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.LoadDataChecker(deso[0]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.LoadDataChecker(deso[1]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.LoadDataChecker(deso[2]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.LoadDataChecker(deso[3]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.LoadDataChecker(deso[4]);
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
                        orderby w.IdImage ascending, w.UserName ascending, w.IdPhieu ascending
                        select w).ToList();

            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.lb_user.Text = deso[0].UserName;
            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.LoadData(deso[0]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.LoadData(deso[1]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.LoadData(deso[2]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.LoadData(deso[3]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.LoadData(deso[4]);
        }

        public void LoadChecker_User(string fbatchname, string idimage)
        {
            var deso = (from w in Global.Db.tbl_DESOs
                        where w.fBatchName == fbatchname && w.IdImage == idimage  && w.UserName == "Checker"
                        orderby w.IdImage ascending, w.UserName ascending, w.IdPhieu ascending
                        select w).ToList();

            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.lb_user.Text = deso[0].UserName;
            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.LoadDataChecker(deso[0]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.LoadDataChecker(deso[1]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.LoadDataChecker(deso[2]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.LoadDataChecker(deso[3]);
            UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.LoadDataChecker(deso[4]);
        }

        private void SoSanhTextBox()
        {
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo01);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo02);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo03);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo04);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo05);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo06);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo07);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo08);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo09);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo10);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo11);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo12);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo13);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo14);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo15);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo16);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo17);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo18);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo19);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo20);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo21);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo22);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo23);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo24);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo25);

            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo01);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo02);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo03);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo04);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo05);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo06);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo07);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo08);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo09);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo10);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo11);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo12);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo13);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo14);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo15);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo16);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo17);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo18);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo19);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo20);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo21);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo22);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo23);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo24);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo25);

            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo01);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo02);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo03);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo04);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo05);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo06);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo07);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo08);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo09);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo10);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo11);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo12);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo13);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo14);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo15);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo16);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo17);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo18);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo19);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo20);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo21);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo22);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo23);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo24);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo25);

            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo01);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo02);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo03);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo04);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo05);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo06);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo07);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo08);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo09);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo10);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo11);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo12);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo13);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo14);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo15);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo16);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo17);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo18);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo19);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo20);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo21);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo22);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo23);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo24);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo25);


            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo01);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo02);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo03);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo04);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo05);
            //changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo06);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo07);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo08);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo09);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo10);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo11);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo12);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo13);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo14);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo15);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo16);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo17);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo18);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo19);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo20);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo21);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo22);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo23);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo24);
            changeColorUser(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo25);

        }

        private void SoSanhTextBoxSingle()
        {
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo01);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo02);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo03);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo04);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo05);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo06);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo07);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo08);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo09);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo10);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo11);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo12);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo13);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo14);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo15);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo16);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo17);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo18);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo19);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo20);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo21);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo22);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo23);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo24);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo25);

            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo01);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo02);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo03);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo04);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo05);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo06);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo07);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo08);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo09);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo10);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo11);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo12);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo13);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo14);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo15);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo16);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo17);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo18);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo19);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo20);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo21);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo22);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo23);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo24);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo25);

            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo01);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo02);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo03);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo04);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo05);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo06);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo07);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo08);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo09);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo10);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo11);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo12);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo13);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo14);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo15);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo16);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo17);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo18);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo19);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo20);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo21);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo22);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo23);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo24);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo25);

            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo01);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo02);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo03);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo04);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo05);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo06);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo07);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo08);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo09);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo10);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo11);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo12);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo13);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo14);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo15);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo16);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo17);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo18);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo19);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo20);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo21);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo22);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo23);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo24);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo25);


            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo01);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo02);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo03);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo04);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo05);
            //changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo06);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo07);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo08);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo09);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo10);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo11);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo12);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo13);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo14);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo15);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo16);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo17);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo18);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo19);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo20);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo21);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo22);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo23);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo24);
            changeColorUser_Single(UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo25);
        
        }

        private void SoSanhChecker()
        {
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo01);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo02);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo03);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo04);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo05);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo06);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo07);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo08);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo09);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo10);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo11);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo12);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo13);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo14);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo15);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo16);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo17);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo18);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo19);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo20);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo21);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo22);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo23);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo24);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback1.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback1.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback1.txt_TruongSo25);

            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo01);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo02);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo03);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo04);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo05);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo06);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo07);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo08);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo09);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo10);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo11);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo12);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo13);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo14);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo15);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo16);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo17);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo18);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo19);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo20);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo21);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo22);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo23);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo24);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback2.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback2.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback2.txt_TruongSo25);

            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo01);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo02);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo03);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo04);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo05);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo06);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo07);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo08);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo09);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo10);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo11);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo12);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo13);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo14);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo15);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo16);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo17);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo18);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo19);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo20);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo21);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo22);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo23);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo24);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback3.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback3.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback3.txt_TruongSo25);

            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo01);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo02);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo03);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo04);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo05);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo06);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo07);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo08);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo09);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo10);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo11);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo12);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo13);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo14);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo15);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo16);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo17);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo18);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo19);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo20);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo21);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo22);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo23);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo24);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback4.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback4.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback4.txt_TruongSo25);

            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo01, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo01);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo02, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo02);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo03, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo03);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo04, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo04);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo05, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo05);
            //changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo06, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo06);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo07, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo07);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo08, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo08);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo09, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo09);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo10, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo10);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo11, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo11);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo12, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo12);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo13, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo13);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo14, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo14);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo15, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo15);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo16, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo16);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo17, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo17);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo18, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo18);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo19, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo19);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo20, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo20);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo21, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo21);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo22, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo22);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo23, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo23);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo24, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo24);
            changeColorChecker(UcNatsuItemFeedback31.ucNatsuItemFeedback_21.ucNatsuItemFeedback5.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_22.ucNatsuItemFeedback5.txt_TruongSo25, UcNatsuItemFeedback31.ucNatsuItemFeedback_23.ucNatsuItemFeedback5.txt_TruongSo25);
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
