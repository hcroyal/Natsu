using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Natsu.MyUserControl
{
    public partial class UcSokatuItemFeedback : UserControl
    {
        public UcSokatuItemFeedback()
        {
            InitializeComponent();
        }
        public void LoadData(tbl_DESO_Backup data)
        {
            txt_TruongSo01.Text = data.Truong_01;
            txt_TruongSo02.Text = data.Truong_02;
            txt_TruongSo03.Text = data.Truong_03;
            txt_TruongSo04.Text = data.Truong_04;
            txt_TruongSo05.Text = data.Truong_05;
            txt_TruongSo06.Text = data.Truong_06;
            txt_TruongSo07.Text = data.Truong_07;
            txt_TruongSo08.Text = data.Truong_08;
            txt_TruongSo09.Text = data.Truong_09;
            txt_TruongSo10.Text = data.Truong_10;
            txt_TruongSo11.Text = data.Truong_11;
            txt_TruongSo12.Text = data.Truong_12;
            txt_TruongSo13.Text = data.Truong_13;
            txt_TruongSo14.Text = data.Truong_14;
            txt_TruongSo15.Text = data.Truong_15;
            txt_TruongSo16.Text = data.Truong_16;
            txt_TruongSo17.Text = data.Truong_17;
            txt_TruongSo18.Text = data.Truong_18;
        }

        public void LoadDataChecker(tbl_DESO data)
        {
            txt_TruongSo01.Text = data.Truong_01;
            txt_TruongSo02.Text = data.Truong_02;
            txt_TruongSo03.Text = data.Truong_03;
            txt_TruongSo04.Text = data.Truong_04;
            txt_TruongSo05.Text = data.Truong_05;
            txt_TruongSo06.Text = data.Truong_06;
            txt_TruongSo07.Text = data.Truong_07;
            txt_TruongSo08.Text = data.Truong_08;
            txt_TruongSo09.Text = data.Truong_09;
            txt_TruongSo10.Text = data.Truong_10;
            txt_TruongSo11.Text = data.Truong_11;
            txt_TruongSo12.Text = data.Truong_12;
            txt_TruongSo13.Text = data.Truong_13;
            txt_TruongSo14.Text = data.Truong_14;
            txt_TruongSo15.Text = data.Truong_15;
            txt_TruongSo16.Text = data.Truong_16;
            txt_TruongSo17.Text = data.Truong_17;
            txt_TruongSo18.Text = data.Truong_18;
        }
    }
}
