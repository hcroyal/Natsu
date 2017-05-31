using DevExpress.XtraGrid.Views.Grid;
using Natsu.MyClass;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Natsu.MyForm
{
    public partial class FrmChiTietTienDo : DevExpress.XtraEditors.XtraForm
    {
        public FrmChiTietTienDo()
        {
            InitializeComponent();
        }

        private void frm_ChiTietTienDo_Load(object sender, EventArgs e)
        {
            if (lb_fBatchName.Text=="All")
            {
                lb_TongSoHinh.Text = (from w in Global.Db.tbl_Images select w.idimage).Count().ToString();

                lb_SoHinhChuaNhap.Text = (from w in Global.Db.tbl_Images where w.TienDoDESO == "Hình chưa nhập" select w.idimage).Count().ToString();
                lb_SoHinhDangNhap.Text = (from w in Global.Db.tbl_Images where w.TienDoDESO == "Hình đang nhập" select w.idimage).Count().ToString();
                lb_SoHinhChoCheck.Text = (from w in Global.Db.tbl_Images where w.TienDoDESO == "Hình chờ check" select w.idimage).Count().ToString();
                lb_SoHinhDangCheck.Text = (from w in Global.Db.tbl_Images where w.TienDoDESO == "Hình đang check" select w.idimage).Count().ToString();
                lb_SoHinhHoanThanh.Text = (from w in Global.Db.tbl_Images where w.TienDoDESO == "Hình hoàn thành" select w.idimage).Count().ToString();

                gridControl1.DataSource = null;
                gridControl1.DataSource = Global.Db.ChiTietTienDo_All();
            }
            else
            {
                lb_TongSoHinh.Text = (from w in Global.Db.tbl_Images where w.fbatchname == lb_fBatchName.Text select w.idimage).Count().ToString();

                lb_SoHinhChuaNhap.Text = (from w in Global.Db.tbl_Images where w.fbatchname == lb_fBatchName.Text && w.TienDoDESO == "Hình chưa nhập" select w.idimage).Count().ToString();
                lb_SoHinhDangNhap.Text = (from w in Global.Db.tbl_Images where w.fbatchname == lb_fBatchName.Text && w.TienDoDESO == "Hình đang nhập" select w.idimage).Count().ToString();
                lb_SoHinhChoCheck.Text = (from w in Global.Db.tbl_Images where w.fbatchname == lb_fBatchName.Text && w.TienDoDESO == "Hình chờ check" select w.idimage).Count().ToString();
                lb_SoHinhDangCheck.Text = (from w in Global.Db.tbl_Images where w.fbatchname == lb_fBatchName.Text && w.TienDoDESO == "Hình đang check" select w.idimage).Count().ToString();
                lb_SoHinhHoanThanh.Text = (from w in Global.Db.tbl_Images where w.fbatchname == lb_fBatchName.Text && w.TienDoDESO == "Hình hoàn thành" select w.idimage).Count().ToString();

                gridControl1.DataSource = null;
                gridControl1.DataSource = Global.Db.ChiTietTienDo(lb_fBatchName.Text);
            }
            
            gridView1.RowCellStyle += GridView1_RowCellStyle;
        }

        private void GridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "ThongTin")
            {
                if (view != null)
                {
                    string category = view.GetRowCellDisplayText(e.RowHandle, view.Columns["ThongTin"]);
                    if (category == "Hình đang nhập")
                        e.Appearance.BackColor = Color.HotPink;
                    else if (category == "Hình chờ check")
                    {
                        e.Appearance.BackColor = Color.OrangeRed;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (category == "Hình đang check")
                    {
                        e.Appearance.BackColor = Color.Purple;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (category == "Hình hoàn thành")
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.ForeColor = Color.White;
                    }
                }
            }
        }

        private void popupContainerControl1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void repositoryItemPopupContainerEdit1_Click(object sender, EventArgs e)
        {
            string idimage = gridView1.GetFocusedRowCellValue("idimage").ToString();
            gridControl2.DataSource = null;

            gridControl2.DataSource = Global.Db.ChiTietUserDeSo(lb_fBatchName.Text, idimage);
        }
    }
}