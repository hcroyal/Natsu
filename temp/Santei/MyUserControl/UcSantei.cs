using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Natsu.MyClass;

namespace Natsu.MyUserControl
{
    public partial class UcSantei : UserControl
    {
        public event AllTextChange Changed;

        public UcSantei()
        {
            InitializeComponent();
        }

        public void ResetData()
        {
            UcNatsuItem1.ResetData();
            UcNatsuItem2.ResetData();
            UcNatsuItem3.ResetData();
            UcNatsuItem4.ResetData();
            UcNatsuItem5.ResetData();
            UcNatsuItem1.txt_TruongSo01.Focus();
        }

        public bool IsEmpty()
        {
            bool empty = UcNatsuItem1.IsEmpty() &&
                         UcNatsuItem2.IsEmpty() &&
                         UcNatsuItem3.IsEmpty() &&
                         UcNatsuItem4.IsEmpty() &&
                         UcNatsuItem5.IsEmpty();
            return empty;
        }
        public bool IsEmptyTruong00(UcSanteiItem uc)
        {
            bool kq;
            if (!uc.IsEmpty())
            {
                kq = uc.txt_TruongSo00.Text == "";
            }
            else
            {
                kq = false;
            }
            return kq;
        }
        public void SaveData(string idImage)
        {
            //UcNatsuItem1.SaveData(idImage, "1");
            //UcNatsuItem2.SaveData(idImage, "2");
            //UcNatsuItem3.SaveData(idImage, "3");
            //UcNatsuItem4.SaveData(idImage, "4");
            //UcNatsuItem5.SaveData(idImage, "5");

            Global.Db.Insert_GetsuWithError_New(
                idImage, Global.StrBatch, Global.StrUsername,
                "1",
                UcNatsuItem1.txt_TruongSo00.Text,
                UcNatsuItem1.txt_TruongSo01.Text,
                UcNatsuItem1.txt_TruongSo02.Text,
                UcNatsuItem1.txt_TruongSo03.Text,
                UcNatsuItem1.txt_TruongSo04.Text,
                UcNatsuItem1.txt_TruongSo05.Text,
                UcNatsuItem1.txt_TruongSo06.Text,
                UcNatsuItem1.txt_TruongSo07.Text,
                UcNatsuItem1.txt_TruongSo08.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo09.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo10.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo11.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo12.Text,
                UcNatsuItem1.txt_TruongSo13.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo14.Text,
                UcNatsuItem1.txt_TruongSo15.Text,
                UcNatsuItem1.txt_TruongSo16.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo17.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo18.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo19.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo20.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo21.Text,
                UcNatsuItem1.txt_TruongSo22.Text,
                UcNatsuItem1.txt_TruongSo23.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo24.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo25.Text?.Replace(",", ""),
                UcNatsuItem1.txt_TruongSo01.Tag + "",
                UcNatsuItem1.txt_TruongSo02.Tag + "",
                UcNatsuItem1.txt_TruongSo03.Tag + "",
                UcNatsuItem1.txt_TruongSo04.Tag + "",
                UcNatsuItem1.txt_TruongSo05.Tag + "",
                UcNatsuItem1.txt_TruongSo06.Tag + "",
                UcNatsuItem1.txt_TruongSo07.Tag + "",
                UcNatsuItem1.txt_TruongSo08.Tag + "",
                UcNatsuItem1.txt_TruongSo09.Tag + "",
                UcNatsuItem1.txt_TruongSo10.Tag + "",
                UcNatsuItem1.txt_TruongSo11.Tag + "",
                UcNatsuItem1.txt_TruongSo12.Tag + "",
                UcNatsuItem1.txt_TruongSo13.Tag + "",
                UcNatsuItem1.txt_TruongSo14.Tag + "",
                UcNatsuItem1.txt_TruongSo15.Tag + "",
                UcNatsuItem1.txt_TruongSo16.Tag + "",
                UcNatsuItem1.txt_TruongSo17.Tag + "",
                UcNatsuItem1.txt_TruongSo18.Tag + "",
                UcNatsuItem1.txt_TruongSo19.Tag + "",
                UcNatsuItem1.txt_TruongSo20.Tag + "",
                UcNatsuItem1.txt_TruongSo21.Tag + "",
                UcNatsuItem1.txt_TruongSo22.Tag + "",
                UcNatsuItem1.txt_TruongSo23.Tag + "",
                UcNatsuItem1.txt_TruongSo24.Tag + "",
                UcNatsuItem1.txt_TruongSo25.Tag + "",
                "2",
                UcNatsuItem2.txt_TruongSo00.Text,
                UcNatsuItem2.txt_TruongSo01.Text,
                UcNatsuItem2.txt_TruongSo02.Text,
                UcNatsuItem2.txt_TruongSo03.Text,
                UcNatsuItem2.txt_TruongSo04.Text,
                UcNatsuItem2.txt_TruongSo05.Text,
                UcNatsuItem2.txt_TruongSo06.Text,
                UcNatsuItem2.txt_TruongSo07.Text,
                UcNatsuItem2.txt_TruongSo08.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo09.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo10.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo11.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo12.Text,
                UcNatsuItem2.txt_TruongSo13.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo14.Text,
                UcNatsuItem2.txt_TruongSo15.Text,
                UcNatsuItem2.txt_TruongSo16.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo17.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo18.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo19.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo20.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo21.Text,
                UcNatsuItem2.txt_TruongSo22.Text,
                UcNatsuItem2.txt_TruongSo23.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo24.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo25.Text?.Replace(",", ""),
                UcNatsuItem2.txt_TruongSo01.Tag + "",
                UcNatsuItem2.txt_TruongSo02.Tag + "",
                UcNatsuItem2.txt_TruongSo03.Tag + "",
                UcNatsuItem2.txt_TruongSo04.Tag + "",
                UcNatsuItem2.txt_TruongSo05.Tag + "",
                UcNatsuItem2.txt_TruongSo06.Tag + "",
                UcNatsuItem2.txt_TruongSo07.Tag + "",
                UcNatsuItem2.txt_TruongSo08.Tag + "",
                UcNatsuItem2.txt_TruongSo09.Tag + "",
                UcNatsuItem2.txt_TruongSo10.Tag + "",
                UcNatsuItem2.txt_TruongSo11.Tag + "",
                UcNatsuItem2.txt_TruongSo12.Tag + "",
                UcNatsuItem2.txt_TruongSo13.Tag + "",
                UcNatsuItem2.txt_TruongSo14.Tag + "",
                UcNatsuItem2.txt_TruongSo15.Tag + "",
                UcNatsuItem2.txt_TruongSo16.Tag + "",
                UcNatsuItem2.txt_TruongSo17.Tag + "",
                UcNatsuItem2.txt_TruongSo18.Tag + "",
                UcNatsuItem2.txt_TruongSo19.Tag + "",
                UcNatsuItem2.txt_TruongSo20.Tag + "",
                UcNatsuItem2.txt_TruongSo21.Tag + "",
                UcNatsuItem2.txt_TruongSo22.Tag + "",
                UcNatsuItem2.txt_TruongSo23.Tag + "",
                UcNatsuItem2.txt_TruongSo24.Tag + "",
                UcNatsuItem2.txt_TruongSo25.Tag + "",
                "3",
                UcNatsuItem3.txt_TruongSo00.Text,
                UcNatsuItem3.txt_TruongSo01.Text,
                UcNatsuItem3.txt_TruongSo02.Text,
                UcNatsuItem3.txt_TruongSo03.Text,
                UcNatsuItem3.txt_TruongSo04.Text,
                UcNatsuItem3.txt_TruongSo05.Text,
                UcNatsuItem3.txt_TruongSo06.Text,
                UcNatsuItem3.txt_TruongSo07.Text,
                UcNatsuItem3.txt_TruongSo08.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo09.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo10.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo11.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo12.Text,
                UcNatsuItem3.txt_TruongSo13.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo14.Text,
                UcNatsuItem3.txt_TruongSo15.Text,
                UcNatsuItem3.txt_TruongSo16.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo17.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo18.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo19.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo20.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo21.Text,
                UcNatsuItem3.txt_TruongSo22.Text,
                UcNatsuItem3.txt_TruongSo23.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo24.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo25.Text?.Replace(",", ""),
                UcNatsuItem3.txt_TruongSo01.Tag + "",
                UcNatsuItem3.txt_TruongSo02.Tag + "",
                UcNatsuItem3.txt_TruongSo03.Tag + "",
                UcNatsuItem3.txt_TruongSo04.Tag + "",
                UcNatsuItem3.txt_TruongSo05.Tag + "",
                UcNatsuItem3.txt_TruongSo06.Tag + "",
                UcNatsuItem3.txt_TruongSo07.Tag + "",
                UcNatsuItem3.txt_TruongSo08.Tag + "",
                UcNatsuItem3.txt_TruongSo09.Tag + "",
                UcNatsuItem3.txt_TruongSo10.Tag + "",
                UcNatsuItem3.txt_TruongSo11.Tag + "",
                UcNatsuItem3.txt_TruongSo12.Tag + "",
                UcNatsuItem3.txt_TruongSo13.Tag + "",
                UcNatsuItem3.txt_TruongSo14.Tag + "",
                UcNatsuItem3.txt_TruongSo15.Tag + "",
                UcNatsuItem3.txt_TruongSo16.Tag + "",
                UcNatsuItem3.txt_TruongSo17.Tag + "",
                UcNatsuItem3.txt_TruongSo18.Tag + "",
                UcNatsuItem3.txt_TruongSo19.Tag + "",
                UcNatsuItem3.txt_TruongSo20.Tag + "",
                UcNatsuItem3.txt_TruongSo21.Tag + "",
                UcNatsuItem3.txt_TruongSo22.Tag + "",
                UcNatsuItem3.txt_TruongSo23.Tag + "",
                UcNatsuItem3.txt_TruongSo24.Tag + "",
                UcNatsuItem3.txt_TruongSo25.Tag + "",
                "4",
                UcNatsuItem4.txt_TruongSo00.Text,
                UcNatsuItem4.txt_TruongSo01.Text,
                UcNatsuItem4.txt_TruongSo02.Text,
                UcNatsuItem4.txt_TruongSo03.Text,
                UcNatsuItem4.txt_TruongSo04.Text,
                UcNatsuItem4.txt_TruongSo05.Text,
                UcNatsuItem4.txt_TruongSo06.Text,
                UcNatsuItem4.txt_TruongSo07.Text,
                UcNatsuItem4.txt_TruongSo08.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo09.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo10.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo11.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo12.Text,
                UcNatsuItem4.txt_TruongSo13.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo14.Text,
                UcNatsuItem4.txt_TruongSo15.Text,
                UcNatsuItem4.txt_TruongSo16.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo17.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo18.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo19.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo20.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo21.Text,
                UcNatsuItem4.txt_TruongSo22.Text,
                UcNatsuItem4.txt_TruongSo23.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo24.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo25.Text?.Replace(",", ""),
                UcNatsuItem4.txt_TruongSo01.Tag + "",
                UcNatsuItem4.txt_TruongSo02.Tag + "",
                UcNatsuItem4.txt_TruongSo03.Tag + "",
                UcNatsuItem4.txt_TruongSo04.Tag + "",
                UcNatsuItem4.txt_TruongSo05.Tag + "",
                UcNatsuItem4.txt_TruongSo06.Tag + "",
                UcNatsuItem4.txt_TruongSo07.Tag + "",
                UcNatsuItem4.txt_TruongSo08.Tag + "",
                UcNatsuItem4.txt_TruongSo09.Tag + "",
                UcNatsuItem4.txt_TruongSo10.Tag + "",
                UcNatsuItem4.txt_TruongSo11.Tag + "",
                UcNatsuItem4.txt_TruongSo12.Tag + "",
                UcNatsuItem4.txt_TruongSo13.Tag + "",
                UcNatsuItem4.txt_TruongSo14.Tag + "",
                UcNatsuItem4.txt_TruongSo15.Tag + "",
                UcNatsuItem4.txt_TruongSo16.Tag + "",
                UcNatsuItem4.txt_TruongSo17.Tag + "",
                UcNatsuItem4.txt_TruongSo18.Tag + "",
                UcNatsuItem4.txt_TruongSo19.Tag + "",
                UcNatsuItem4.txt_TruongSo20.Tag + "",
                UcNatsuItem4.txt_TruongSo21.Tag + "",
                UcNatsuItem4.txt_TruongSo22.Tag + "",
                UcNatsuItem4.txt_TruongSo23.Tag + "",
                UcNatsuItem4.txt_TruongSo24.Tag + "",
                UcNatsuItem4.txt_TruongSo25.Tag + "",
                "5",
                UcNatsuItem5.txt_TruongSo00.Text,
                UcNatsuItem5.txt_TruongSo01.Text,
                UcNatsuItem5.txt_TruongSo02.Text,
                UcNatsuItem5.txt_TruongSo03.Text,
                UcNatsuItem5.txt_TruongSo04.Text,
                UcNatsuItem5.txt_TruongSo05.Text,
                UcNatsuItem5.txt_TruongSo06.Text,
                UcNatsuItem5.txt_TruongSo07.Text,
                UcNatsuItem5.txt_TruongSo08.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo09.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo10.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo11.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo12.Text,
                UcNatsuItem5.txt_TruongSo13.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo14.Text,
                UcNatsuItem5.txt_TruongSo15.Text,
                UcNatsuItem5.txt_TruongSo16.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo17.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo18.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo19.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo20.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo21.Text,
                UcNatsuItem5.txt_TruongSo22.Text,
                UcNatsuItem5.txt_TruongSo23.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo24.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo25.Text?.Replace(",", ""),
                UcNatsuItem5.txt_TruongSo01.Tag + "",
                UcNatsuItem5.txt_TruongSo02.Tag + "",
                UcNatsuItem5.txt_TruongSo03.Tag + "",
                UcNatsuItem5.txt_TruongSo04.Tag + "",
                UcNatsuItem5.txt_TruongSo05.Tag + "",
                UcNatsuItem5.txt_TruongSo06.Tag + "",
                UcNatsuItem5.txt_TruongSo07.Tag + "",
                UcNatsuItem5.txt_TruongSo08.Tag + "",
                UcNatsuItem5.txt_TruongSo09.Tag + "",
                UcNatsuItem5.txt_TruongSo10.Tag + "",
                UcNatsuItem5.txt_TruongSo11.Tag + "",
                UcNatsuItem5.txt_TruongSo12.Tag + "",
                UcNatsuItem5.txt_TruongSo13.Tag + "",
                UcNatsuItem5.txt_TruongSo14.Tag + "",
                UcNatsuItem5.txt_TruongSo15.Tag + "",
                UcNatsuItem5.txt_TruongSo16.Tag + "",
                UcNatsuItem5.txt_TruongSo17.Tag + "",
                UcNatsuItem5.txt_TruongSo18.Tag + "",
                UcNatsuItem5.txt_TruongSo19.Tag + "",
                UcNatsuItem5.txt_TruongSo20.Tag + "",
                UcNatsuItem5.txt_TruongSo21.Tag + "",
                UcNatsuItem5.txt_TruongSo22.Tag + "",
                UcNatsuItem5.txt_TruongSo23.Tag + "",
                UcNatsuItem5.txt_TruongSo24.Tag + "",
                UcNatsuItem5.txt_TruongSo25.Tag + ""
            );
        }

        public void SuaVaLuu(string usersaiit, string usersainhieu, string idimage)
        {
            UcNatsuItem1.SaveData_SuaVaLuu(usersaiit, usersainhieu, idimage, "1");
            UcNatsuItem2.SaveData_SuaVaLuu(usersaiit, usersainhieu, idimage, "2");
            UcNatsuItem3.SaveData_SuaVaLuu(usersaiit, usersainhieu, idimage, "3");
            UcNatsuItem4.SaveData_SuaVaLuu(usersaiit, usersainhieu, idimage, "4");
            UcNatsuItem5.SaveData_SuaVaLuu(usersaiit, usersainhieu, idimage, "5");
        }

        private void UcNatsuItem1_Load(object sender, EventArgs e)
        {
            UcNatsuItem1.Changed += UcNatsuItem1_Changed;
            UcNatsuItem2.Changed += UcNatsuItem1_Changed;
            UcNatsuItem3.Changed += UcNatsuItem1_Changed;
            UcNatsuItem4.Changed += UcNatsuItem1_Changed;
            UcNatsuItem5.Changed += UcNatsuItem1_Changed;
        }

        private void UcNatsuItem1_Changed(object sender, EventArgs e)
        {
            if (sender is TextEdit)
            {
                Changed?.Invoke(sender, e);
            }
        }

        public bool TrongTruongSo3()
        {
            bool kq;
            if (UcNatsuItem1.KiemTraTruongSo3() ||
                UcNatsuItem2.KiemTraTruongSo3() ||
                UcNatsuItem3.KiemTraTruongSo3() ||
                UcNatsuItem4.KiemTraTruongSo3() ||
                UcNatsuItem5.KiemTraTruongSo3())
            {
                kq = true;
            }
            else
            {
                kq = false;
            }
            return kq;
        }
        public bool TrongTruongSo12()
        {
            bool kq;
            if (UcNatsuItem1.KiemTraTruongSo12() ||
                UcNatsuItem2.KiemTraTruongSo12() ||
                UcNatsuItem3.KiemTraTruongSo12() ||
                UcNatsuItem4.KiemTraTruongSo12() ||
                UcNatsuItem5.KiemTraTruongSo12())
            {
                kq = true;
            }
            else
            {
                kq = false;
            }
            return kq;
        }
    }
}