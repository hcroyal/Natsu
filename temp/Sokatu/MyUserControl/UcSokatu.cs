using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Natsu.MyUserControl
{
    public partial class UcSokatu : UserControl
    {
        public event AllTextChange Changed;

        public UcSokatu()
        {
            InitializeComponent();
        }

        public void ResetData()
        {
            UcNatsuItem1.ResetData();
            UcNatsuItem1.txt_TruongSo01.Focus();
        }

        public bool IsEmpty()
        {
            bool empty = UcNatsuItem1.IsEmpty();
            return empty;
        }

        public void SaveData(string idImage)
        {
            UcNatsuItem1.SaveData(idImage, "1");
        }

        public void SuaVaLuu(string usersaiit, string usersainhieu, string idimage)
        {
            UcNatsuItem1.SaveData_SuaVaLuu(usersaiit, usersainhieu, idimage, "1");
            
        }

        private void UcNatsuItem1_Load(object sender, EventArgs e)
        {
            UcNatsuItem1.Changed += UcNatsuItem1_Changed;
          
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