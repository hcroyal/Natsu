using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

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

        public void SaveData(string idImage)
        {
            UcNatsuItem1.SaveData(idImage, "1");
            UcNatsuItem2.SaveData(idImage, "2");
            UcNatsuItem3.SaveData(idImage, "3");
            UcNatsuItem4.SaveData(idImage, "4");
            UcNatsuItem5.SaveData(idImage, "5");
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
    }
}