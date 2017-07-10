using DevExpress.XtraEditors;
using Natsu.MyClass;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Natsu.MyUserControl
{
    public delegate void AllTextChange(object sender, EventArgs e);

    public partial class UcSanteiItem : UserControl
    {
        public event AllTextChange Changed;

        public UcSanteiItem()
        {
            InitializeComponent();
        }

        private double _totalTruong11 = 0;
        private double _totalTruong11_2 = 0;
        private int _totalTruong19 = 0;

        public void ResetData()
        {
            txt_TruongSo01.Text = "";
            txt_TruongSo02.Text = "";
            txt_TruongSo03.Text = "";
            txt_TruongSo04.Text = "";
            txt_TruongSo05.Text = "";
            txt_TruongSo06.Text = "";
            txt_TruongSo07.Text = "";
            txt_TruongSo08.Text = "";
            txt_TruongSo09.Text = "";
            txt_TruongSo10.Text = "";
            txt_TruongSo00.Text = "";
            txt_TruongSo11.Text = "";
            txt_TruongSo12.Text = "";
            txt_TruongSo13.Text = "";
            txt_TruongSo14.Text = "";
            txt_TruongSo15.Text = "";
            txt_TruongSo16.Text = "";
            txt_TruongSo17.Text = "";
            txt_TruongSo18.Text = "";
            txt_TruongSo19.Text = "";
            txt_TruongSo20.Text = "";
            txt_TruongSo21.Text = "";
            txt_TruongSo22.Text = "";
            txt_TruongSo23.Text = "";
            txt_TruongSo24.Text = "";
            txt_TruongSo25.Text = "";

            txt_TruongSo01.BackColor = Color.White;
            txt_TruongSo02.BackColor = Color.White;
            txt_TruongSo03.BackColor = Color.White;
            txt_TruongSo04.BackColor = Color.White;
            txt_TruongSo05.BackColor = Color.White;
            txt_TruongSo06.BackColor = Color.White;
            txt_TruongSo07.BackColor = Color.White;
            txt_TruongSo08.BackColor = Color.White;
            txt_TruongSo09.BackColor = Color.White;
            txt_TruongSo10.BackColor = Color.White;
            txt_TruongSo00.BackColor = Color.White;
            txt_TruongSo11.BackColor = Color.White;
            txt_TruongSo12.BackColor = Color.White;
            txt_TruongSo13.BackColor = Color.White;
            txt_TruongSo14.BackColor = Color.White;
            txt_TruongSo15.BackColor = Color.White;
            txt_TruongSo16.BackColor = Color.White;
            txt_TruongSo17.BackColor = Color.White;
            txt_TruongSo18.BackColor = Color.White;
            txt_TruongSo19.BackColor = Color.White;
            txt_TruongSo20.BackColor = Color.White;
            txt_TruongSo21.BackColor = Color.White;
            txt_TruongSo22.BackColor = Color.White;
            txt_TruongSo23.BackColor = Color.White;
            txt_TruongSo24.BackColor = Color.White;
            txt_TruongSo25.BackColor = Color.White;

            txt_TruongSo01.ForeColor = Color.Black;
            txt_TruongSo02.ForeColor = Color.Black;
            txt_TruongSo03.ForeColor = Color.Black;
            txt_TruongSo04.ForeColor = Color.Black;
            txt_TruongSo05.ForeColor = Color.Black;
            txt_TruongSo06.ForeColor = Color.Black;
            txt_TruongSo07.ForeColor = Color.Black;
            txt_TruongSo08.ForeColor = Color.Black;
            txt_TruongSo09.ForeColor = Color.Black;
            txt_TruongSo10.ForeColor = Color.Black;
            txt_TruongSo00.ForeColor = Color.Black;
            txt_TruongSo11.ForeColor = Color.Black;
            txt_TruongSo12.ForeColor = Color.Black;
            txt_TruongSo13.ForeColor = Color.Black;
            txt_TruongSo14.ForeColor = Color.Black;
            txt_TruongSo15.ForeColor = Color.Black;
            txt_TruongSo16.ForeColor = Color.Black;
            txt_TruongSo17.ForeColor = Color.Black;
            txt_TruongSo18.ForeColor = Color.Black;
            txt_TruongSo19.ForeColor = Color.Black;
            txt_TruongSo20.ForeColor = Color.Black;
            txt_TruongSo21.ForeColor = Color.Black;
            txt_TruongSo22.ForeColor = Color.Black;
            txt_TruongSo23.ForeColor = Color.Black;
            txt_TruongSo24.ForeColor = Color.Black;
            txt_TruongSo25.ForeColor = Color.Black;

            txt_TruongSo01.Tag = "0";
            txt_TruongSo02.Tag = "0";
            txt_TruongSo03.Tag = "0";
            txt_TruongSo04.Tag = "0";
            txt_TruongSo05.Tag = "0";
            txt_TruongSo06.Tag = "0";
            txt_TruongSo07.Tag = "0";
            txt_TruongSo08.Tag = "0";
            txt_TruongSo09.Tag = "0";
            txt_TruongSo10.Tag = "0";
            txt_TruongSo11.Tag = "0";
            txt_TruongSo12.Tag = "0";
            txt_TruongSo13.Tag = "0";
            txt_TruongSo14.Tag = "0";
            txt_TruongSo15.Tag = "0";
            txt_TruongSo16.Tag = "0";
            txt_TruongSo17.Tag = "0";
            txt_TruongSo18.Tag = "0";
            txt_TruongSo19.Tag = "0";
            txt_TruongSo20.Tag = "0";
            txt_TruongSo21.Tag = "0";
            txt_TruongSo22.Tag = "0";
            txt_TruongSo23.Tag = "0";
            txt_TruongSo24.Tag = "0";
            txt_TruongSo25.Tag = "0";

        }

        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(txt_TruongSo01.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo02.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo03.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo04.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo05.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo06.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo07.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo08.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo09.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo10.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo11.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo12.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo13.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo14.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo15.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo16.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo17.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo18.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo19.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo20.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo21.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo22.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo23.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo24.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo25.Text);
        }

        //public void SaveData(string idimage, string idphieu)
        //{
        //    Global.Db.Insert_GetsuWithError(idimage, Global.StrBatch, Global.StrUsername,
        //        txt_TruongSo01.Text,
        //        txt_TruongSo02.Text,
        //        txt_TruongSo03.Text,
        //        txt_TruongSo04.Text,
        //        txt_TruongSo05.Text,
        //        txt_TruongSo06.Text,
        //        txt_TruongSo07.Text,
        //        txt_TruongSo08.Text?.Replace(",", ""),
        //        txt_TruongSo09.Text?.Replace(",", ""),
        //        txt_TruongSo10.Text?.Replace(",", ""),
        //        txt_TruongSo00.Text,
        //        txt_TruongSo11.Text?.Replace(",", ""),
        //        txt_TruongSo12.Text,
        //        txt_TruongSo13.Text?.Replace(",", ""),
        //        txt_TruongSo14.Text,
        //        txt_TruongSo15.Text,
        //        txt_TruongSo16.Text?.Replace(",", ""),
        //        txt_TruongSo17.Text?.Replace(",", ""),
        //        txt_TruongSo18.Text?.Replace(",", ""),
        //        txt_TruongSo19.Text?.Replace(",", ""),
        //        txt_TruongSo20.Text?.Replace(",", ""),
        //        txt_TruongSo21.Text,
        //        txt_TruongSo22.Text,
        //        txt_TruongSo23.Text?.Replace(",", ""),
        //        txt_TruongSo24.Text?.Replace(",", ""),
        //        txt_TruongSo25.Text?.Replace(",", ""),
        //        txt_TruongSo01.Tag + "",
        //        txt_TruongSo02.Tag + "",
        //        txt_TruongSo03.Tag + "",
        //        txt_TruongSo04.Tag + "",
        //        txt_TruongSo05.Tag + "",
        //        txt_TruongSo06.Tag + "",
        //        txt_TruongSo07.Tag + "",
        //        txt_TruongSo08.Tag + "",
        //        txt_TruongSo09.Tag + "",
        //        txt_TruongSo10.Tag + "",
        //        txt_TruongSo11.Tag + "",
        //        txt_TruongSo12.Tag + "",
        //        txt_TruongSo13.Tag + "",
        //        txt_TruongSo14.Tag + "",
        //        txt_TruongSo15.Tag + "",
        //        txt_TruongSo16.Tag + "",
        //        txt_TruongSo17.Tag + "",
        //        txt_TruongSo18.Tag + "",
        //        txt_TruongSo19.Tag + "",
        //        txt_TruongSo20.Tag + "",
        //        txt_TruongSo21.Tag + "",
        //        txt_TruongSo22.Tag + "",
        //        txt_TruongSo23.Tag + "",
        //        txt_TruongSo24.Tag + "",
        //        txt_TruongSo25.Tag + "",
        //        idphieu);
        //}

        public void SaveData_SuaVaLuu(string usersaiit, string usersainhieu, string idimage, string idphieu)
        {
            Global.Db.SuaVaLuu_deso_Error(usersaiit, usersainhieu, idimage, Global.StrBatch, Global.StrUsername,
                idphieu,
                txt_TruongSo01.Text,
                txt_TruongSo02.Text,
                txt_TruongSo03.Text,
                txt_TruongSo04.Text,
                txt_TruongSo05.Text,
                txt_TruongSo06.Text,
                txt_TruongSo07.Text,
                txt_TruongSo08.Text?.Replace(",", ""),
                txt_TruongSo09.Text?.Replace(",", ""),
                txt_TruongSo10.Text?.Replace(",", ""),
                txt_TruongSo00.Text,
                txt_TruongSo11.Text?.Replace(",", ""),
                txt_TruongSo12.Text,
                txt_TruongSo13.Text?.Replace(",", ""),
                txt_TruongSo14.Text,
                txt_TruongSo15.Text,
                txt_TruongSo16.Text?.Replace(",", ""),
                txt_TruongSo17.Text?.Replace(",", ""),
                txt_TruongSo18.Text?.Replace(",", ""),
                txt_TruongSo19.Text?.Replace(",", ""),
                txt_TruongSo20.Text?.Replace(",", ""),
                txt_TruongSo21.Text,
                txt_TruongSo22.Text,
                txt_TruongSo23.Text?.Replace(",", ""),
                txt_TruongSo24.Text?.Replace(",", ""),
                txt_TruongSo25.Text?.Replace(",", ""),
                txt_TruongSo01.Tag + "",
                txt_TruongSo02.Tag + "",
                txt_TruongSo03.Tag + "",
                txt_TruongSo04.Tag + "",
                txt_TruongSo05.Tag + "",
                txt_TruongSo06.Tag + "",
                txt_TruongSo07.Tag + "",
                txt_TruongSo08.Tag + "",
                txt_TruongSo09.Tag + "",
                txt_TruongSo10.Tag + "",
                txt_TruongSo11.Tag + "",
                txt_TruongSo12.Tag + "",
                txt_TruongSo13.Tag + "",
                txt_TruongSo14.Tag + "",
                txt_TruongSo15.Tag + "",
                txt_TruongSo16.Tag + "",
                txt_TruongSo17.Tag + "",
                txt_TruongSo18.Tag + "",
                txt_TruongSo19.Tag + "",
                txt_TruongSo20.Tag + "",
                txt_TruongSo21.Tag + "",
                txt_TruongSo22.Tag + "",
                txt_TruongSo23.Tag + "",
                txt_TruongSo24.Tag + "",
                txt_TruongSo25.Tag + ""
            );
        }

        public void DoiMauTextBox(TextEdit txt, int sobytenho, int sobytelon)
        {
            if (txt.Text != "" && txt.Text.IndexOf('?') < 0 && (txt.Text.Length > sobytelon || txt.Text.Length < sobytenho))
            {
                txt.BackColor = Color.Red;
                txt.ForeColor = Color.White;
                txt.Tag = "1";
            }
            else
            {
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
                txt.Tag = "0";
            }
        }

        private void UcNatsuItem_Load(object sender, EventArgs e)
        {
            txt_TruongSo01.GotFocus += Txt_GotFocus;
            txt_TruongSo02.GotFocus += Txt_GotFocus;
            txt_TruongSo03.GotFocus += Txt_GotFocus;
            txt_TruongSo04.GotFocus += Txt_GotFocus;
            txt_TruongSo05.GotFocus += Txt_GotFocus;
            txt_TruongSo06.GotFocus += Txt_GotFocus;
            txt_TruongSo07.GotFocus += Txt_GotFocus;
            txt_TruongSo08.GotFocus += Txt_GotFocus;
            txt_TruongSo09.GotFocus += Txt_GotFocus;
            txt_TruongSo10.GotFocus += Txt_GotFocus;
            txt_TruongSo11.GotFocus += Txt_GotFocus;
            txt_TruongSo12.GotFocus += Txt_GotFocus;
            txt_TruongSo13.GotFocus += Txt_GotFocus;
            txt_TruongSo14.GotFocus += Txt_GotFocus;
            txt_TruongSo15.GotFocus += Txt_GotFocus;
            txt_TruongSo16.GotFocus += Txt_GotFocus;
            txt_TruongSo17.GotFocus += Txt_GotFocus;
            txt_TruongSo18.GotFocus += Txt_GotFocus;
            txt_TruongSo19.GotFocus += Txt_GotFocus;
            txt_TruongSo20.GotFocus += Txt_GotFocus;
            txt_TruongSo21.GotFocus += Txt_GotFocus;
            txt_TruongSo22.GotFocus += Txt_GotFocus;
            txt_TruongSo23.GotFocus += Txt_GotFocus;
            txt_TruongSo24.GotFocus += Txt_GotFocus;
            txt_TruongSo25.GotFocus += Txt_GotFocus;
        }

        private void Txt_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }
        public void curency(TextEdit luong)
        {
           
            //luong.Select(luong.Text.Length, 0);
            //luong.SelectionStart = luong.Text.Length;

            try
            {
                string t;
                string txt, txt1;
                txt1 = luong.Text.Replace(",", "");
                txt = "";
                int n = txt1.Length;
                int dem = 0;

                if (luong.Text.Length > 0)
                {
                    if (luong.Text.Substring(0, 1) == "-")
                    {
                        if (luong.Text.Length > 1)
                        {
                            if (luong.SelectionLength != luong.Text.Length)
                            {
                                if (luong.Text != "?")
                                {
                                    for (int i = n - 1; i >= 0; i--)
                                    {
                                        if (dem == 2 && i != 0)
                                        {
                                            txt = "," + txt1.Substring(i, 1) + txt;
                                            dem = 0;
                                        }
                                        else
                                        {
                                            txt = txt1.Substring(i, 1) + txt;
                                            dem += 1;
                                        }
                                    }
                                    luong.Text = txt;
                                    luong.Select(luong.Text.Length, 0);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (luong.SelectionLength != luong.Text.Length)
                        {
                            if (luong.Text != "?")
                            {
                                for (int i = n - 1; i >= 0; i--)
                                {
                                    if (dem == 2 && i != 0)
                                    {
                                        txt = "," + txt1.Substring(i, 1) + txt;
                                        dem = 0;
                                    }
                                    else
                                    {
                                        txt = txt1.Substring(i, 1) + txt;
                                        dem += 1;
                                    }
                                }
                                luong.Text = txt;
                                luong.Select(luong.Text.Length, 0);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        //private void curency(TextEdit txt)
        //{

            //    try
            //    {
            //        string t;
            //        if (txt.Text.Length > 0)
            //        {
            //            if (txt.Text.Substring(0, 1) == "-")
            //            {
            //                if (txt.Text.Length > 1)
            //                {
            //                    t = txt.Text.Substring(1, txt.Text.Length - 1);
            //                    if (txt.SelectionLength != txt.Text.Length)
            //                    {
            //                        if (txt.Text != "?")
            //                        {
            //                            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            //                            int valueBefore = Int32.Parse(t, System.Globalization.NumberStyles.AllowThousands);
            //                            txt.Text = "-" + String.Format(culture, "{0:N0}", valueBefore);
            //                            txt.Select(txt.Text.Length, 0);
            //                        }
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                if (txt.SelectionLength != txt.Text.Length)
            //                {
            //                    if (txt.Text != "?")
            //                    {
            //                        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            //                        int valueBefore = Int32.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);
            //                        txt.Text = string.Format(culture, "{0:N0}", valueBefore);
            //                        txt.Select(txt.Text.Length, 0);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        MessageBox.Show(e.Message);
            //    }

            //}

            //private void Total_Truong10(TextEdit txt1, TextEdit txt2, TextEdit txt3)
            //{
            //    if (Global.FlagTong)
            //    {
            //        try
            //        {
            //            double x1 = 0, x2 = 0;
            //            if (!string.IsNullOrEmpty(txt1.Text))
            //                x1 = double.Parse(txt1.Text.Replace(",", ""));
            //            if (!string.IsNullOrEmpty(txt2.Text))
            //                x2 = double.Parse(txt2.Text.Replace(",", ""));
            //            txt3.Text = x1 + x2 + "";
            //            curency(txt3);
            //        }
            //        catch (Exception e)
            //        {

            //        }
            //    }

            //}

            //private void Total_Truong11()
            //{
            //    try
            //    {
            //        double truong08 = 0, truong09 = 0, truong16 = 0, truong17 = 0, truong23 = 0, truong24 = 0;
            //        if (!string.IsNullOrEmpty(txt_TruongSo08.Text))
            //            truong08 = double.Parse(txt_TruongSo08.Text.Replace(",", ""));
            //        if (!string.IsNullOrEmpty(txt_TruongSo09.Text))
            //            truong09 = double.Parse(txt_TruongSo09.Text.Replace(",", ""));
            //        if (!string.IsNullOrEmpty(txt_TruongSo16.Text))
            //            truong16 = double.Parse(txt_TruongSo16.Text.Replace(",", ""));
            //        if (!string.IsNullOrEmpty(txt_TruongSo17.Text))
            //            truong17 = double.Parse(txt_TruongSo17.Text.Replace(",", ""));
            //        if (!string.IsNullOrEmpty(txt_TruongSo23.Text))
            //            truong23 = double.Parse(txt_TruongSo23.Text.Replace(",", ""));
            //        if (!string.IsNullOrEmpty(txt_TruongSo24.Text))
            //            truong24 = double.Parse(txt_TruongSo24.Text.Replace(",", ""));
            //        _totalTruong11 = truong08 + truong09 + truong16 + truong17 + truong23 + truong24;
            //    }
            //    catch (Exception)
            //    {
            //        // ignored
            //    }
            //}
            //private void Total_Truong11_2()
            //{
            //    try
            //    {
            //        double truong10 = 0, truong18 = 0, truong25 = 0;
            //        if (!string.IsNullOrEmpty(txt_TruongSo10.Text))
            //            truong10 = double.Parse(txt_TruongSo10.Text.Replace(",", ""));
            //        if (!string.IsNullOrEmpty(txt_TruongSo18.Text))
            //            truong18 = double.Parse(txt_TruongSo18.Text.Replace(",", ""));
            //        if (!string.IsNullOrEmpty(txt_TruongSo25.Text))
            //            truong25 = double.Parse(txt_TruongSo25.Text.Replace(",", ""));
            //        _totalTruong11_2 = truong10 + truong18 + truong25;
            //    }
            //    catch (Exception)
            //    {
            //        // ignored
            //    }
            //}

            private void Total_Truong10(TextEdit txt1, TextEdit txt2, TextEdit txt3)
        {
            if (Global.FlagTong)
            {
                double x1 = 0, x2 = 0;
                try
                {
                    if (!string.IsNullOrEmpty(txt1.Text))
                        x1 = double.Parse(txt1.Text.Replace(",", ""));
                }
                catch (Exception)
                {
                    // ignored
                }
                try
                {
                    if (!string.IsNullOrEmpty(txt2.Text))
                        x2 = double.Parse(txt2.Text.Replace(",", ""));
                }
                catch (Exception)
                {
                    // ignored
                }
                try
                {
                    txt3.Text = x1 + x2 + "";
                    curency(txt3);
                }
                catch (Exception)
                {
                    // ignored
                }
            }

        }

        private void Total_Truong11()
        {
            double truong08 = 0, truong09 = 0, truong16 = 0, truong17 = 0, truong23 = 0, truong24 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo08.Text))
                    truong08 = double.Parse(txt_TruongSo08.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo09.Text))
                    truong09 = double.Parse(txt_TruongSo09.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo16.Text))
                    truong16 = double.Parse(txt_TruongSo16.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo17.Text))
                    truong17 = double.Parse(txt_TruongSo17.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo23.Text))
                    truong23 = double.Parse(txt_TruongSo23.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo24.Text))
                    truong24 = double.Parse(txt_TruongSo24.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                _totalTruong11 = truong08 + truong09 + truong16 + truong17 + truong23 + truong24;
            }
            catch (Exception)
            {
                // ignored
            }

        }
        private void Total_Truong11_2()
        {
            double truong10 = 0, truong18 = 0, truong25 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo10.Text))
                    truong10 = double.Parse(txt_TruongSo10.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo18.Text))
                    truong18 = double.Parse(txt_TruongSo18.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo25.Text))
                    truong25 = double.Parse(txt_TruongSo25.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                _totalTruong11_2 = truong10 + truong18 + truong25;
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private void Total_Truong19()
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo11.Text))
                {
                    _totalTruong19 = int.Parse(txt_TruongSo11.Text.Replace(",", "")) / 3;
                }
            }
            catch (Exception e)
            {
               
            }
           


        }

        private void txt_TruongSo01_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 6);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo02_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 1);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo03_EditValueChanged(object sender, EventArgs e)
        {
            
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo04_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 5);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo05_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 5);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo06_EditValueChanged(object sender, EventArgs e)
        {
            //DoiMauTextBox((TextEdit)sender, 0, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo07_EditValueChanged(object sender, EventArgs e)
        {
            //DoiMauTextBox((TextEdit)sender, 0, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo08_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Total_Truong10(txt_TruongSo08, txt_TruongSo09, txt_TruongSo10);
            Total_Truong11();
           

            double truong11 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo11.Text))
                    truong11 = double.Parse(txt_TruongSo11.Text.Replace(",", ""));
            }
            catch (Exception exception)
            {

            }

            if (truong11 != _totalTruong11 && !string.IsNullOrEmpty(txt_TruongSo11.Text))
            {
                txt_TruongSo11.BackColor = Color.Red;
                txt_TruongSo11.ForeColor = Color.White;
                txt_TruongSo11.Tag = "1";
            }
            else
            {
                txt_TruongSo11.BackColor = Color.White;
                txt_TruongSo11.ForeColor = Color.Black;
                txt_TruongSo11.Tag = "0";
            }
           
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo09_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Total_Truong10(txt_TruongSo08, txt_TruongSo09, txt_TruongSo10);
            Total_Truong11();
            

            double truong11 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo11.Text))
                    truong11 = double.Parse(txt_TruongSo11.Text.Replace(",", ""));
            }
            catch (Exception exception)
            {

            }

            if (truong11 != _totalTruong11 && !string.IsNullOrEmpty(txt_TruongSo11.Text))
            {
                txt_TruongSo11.BackColor = Color.Red;
                txt_TruongSo11.ForeColor = Color.White;
                txt_TruongSo11.Tag = "1";
            }
            else
            {
                txt_TruongSo11.BackColor = Color.White;
                txt_TruongSo11.ForeColor = Color.Black;
                txt_TruongSo11.Tag = "0";
            }

            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo10_EditValueChanged(object sender, EventArgs e)
        {
            if (Global.StrRole == "DESO")
                txt_TruongSo00.Text = "";
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Changed?.Invoke(sender, e);
        }
        private void txt_TruongSo00_EditValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(sender, e);
        }
        private void txt_TruongSo11_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Total_Truong11();
           
            double truong11 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo11.Text))
                    truong11 = double.Parse(txt_TruongSo11.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }

            if (truong11 != _totalTruong11 && !string.IsNullOrEmpty(txt_TruongSo11.Text))
            {
                txt_TruongSo11.BackColor = Color.Red;
                txt_TruongSo11.ForeColor = Color.White;
                txt_TruongSo11.Tag = "1";
            }
            else
            {
                txt_TruongSo11.BackColor = Color.White;
                txt_TruongSo11.ForeColor = Color.Black;
                txt_TruongSo11.Tag = "0";
            }
            
            Total_Truong19();
            int truong19 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo19.Text))
                    truong19 = int.Parse(txt_TruongSo19.Text.Replace(",", ""));
            }
            catch (Exception)
            {
                // ignored
            }

            if (truong19 != _totalTruong19 && !string.IsNullOrEmpty(txt_TruongSo19.Text))
            {
                txt_TruongSo19.BackColor = Color.Red;
                txt_TruongSo19.ForeColor = Color.White;
                txt_TruongSo19.Tag = "1";
            }
            else
            {
                txt_TruongSo19.BackColor = Color.White;
                txt_TruongSo19.ForeColor = Color.Black;
                txt_TruongSo19.Tag = "1";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo12_EditValueChanged(object sender, EventArgs e)
        {
            //DoiMauTextBox((TextEdit)sender, 4, 4);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo13_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TruongSo13.Text))
            {
                if (!string.IsNullOrEmpty(txt_TruongSo20.Text))
                {
                    txt_TruongSo13.BackColor = Color.OrangeRed;
                    txt_TruongSo13.ForeColor = Color.White;
                    txt_TruongSo20.BackColor = Color.OrangeRed;
                    txt_TruongSo20.ForeColor = Color.White;
                }
                else
                {
                    txt_TruongSo13.BackColor = Color.White;
                    txt_TruongSo13.ForeColor = Color.Black;
                    txt_TruongSo20.BackColor = Color.White;
                    txt_TruongSo20.ForeColor = Color.Black;
                    DoiMauTextBox((TextEdit)sender, 0, 10);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txt_TruongSo20.Text))
                {
                    txt_TruongSo13.BackColor = Color.OrangeRed;
                    txt_TruongSo13.ForeColor = Color.White;
                    txt_TruongSo20.BackColor = Color.OrangeRed;
                    txt_TruongSo20.ForeColor = Color.White;
                }
                else
                {
                    txt_TruongSo13.BackColor = Color.White;
                    txt_TruongSo13.ForeColor = Color.Black;
                    txt_TruongSo20.BackColor = Color.White;
                    txt_TruongSo20.ForeColor = Color.Black;
                    DoiMauTextBox((TextEdit)sender, 0, 10);
                }
            }
            
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo14_EditValueChanged(object sender, EventArgs e)
        {
            //DoiMauTextBox((TextEdit)sender, 2, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo15_EditValueChanged(object sender, EventArgs e)
        {
            //DoiMauTextBox((TextEdit)sender, 0, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo16_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Total_Truong10(txt_TruongSo16, txt_TruongSo17, txt_TruongSo18);
            Total_Truong11();
           

            double truong11 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo11.Text))
                    truong11 = double.Parse(txt_TruongSo11.Text.Replace(",", ""));
            }
            catch (Exception exception)
            {

            }

            if (truong11 != _totalTruong11 && !string.IsNullOrEmpty(txt_TruongSo11.Text))
            {
                txt_TruongSo11.BackColor = Color.Red;
                txt_TruongSo11.ForeColor = Color.White;
                txt_TruongSo11.Tag = "1";
            }
            else
            {
                txt_TruongSo11.BackColor = Color.White;
                txt_TruongSo11.ForeColor = Color.Black;
                txt_TruongSo11.Tag = "0";
            }

            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo17_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Total_Truong10(txt_TruongSo16, txt_TruongSo17, txt_TruongSo18);
            Total_Truong11();
            

            double truong11 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo11.Text))
                    truong11 = double.Parse(txt_TruongSo11.Text.Replace(",", ""));
            }
            catch (Exception exception)
            {

            }

            if (truong11 != _totalTruong11 && !string.IsNullOrEmpty(txt_TruongSo11.Text))
            {
                txt_TruongSo11.BackColor = Color.Red;
                txt_TruongSo11.ForeColor = Color.White;
                txt_TruongSo11.Tag = "1";
            }
            else
            {
                txt_TruongSo11.BackColor = Color.White;
                txt_TruongSo11.ForeColor = Color.Black;
                txt_TruongSo11.Tag = "0";
            }

            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo18_EditValueChanged(object sender, EventArgs e)
        {
            if (Global.StrRole == "DESO")
                txt_TruongSo00.Text = "";
            DoiMauTextBox((TextEdit)sender, 0, 10);
            
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo19_EditValueChanged(object sender, EventArgs e)
        {
            double truong19 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo19.Text))
                    truong19 = double.Parse(txt_TruongSo19.Text.Replace(",", ""));
            }
            catch (Exception exception)
            {

            }

            DoiMauTextBox((TextEdit)sender, 0, 10);
            if (truong19 != _totalTruong19)
            {
                txt_TruongSo19.BackColor = Color.Red;
                txt_TruongSo19.ForeColor = Color.White;
                txt_TruongSo19.Tag = "1";
            }
            else
            {
                txt_TruongSo19.BackColor = Color.White;
                txt_TruongSo19.ForeColor = Color.Black;
                txt_TruongSo19.Tag = "0";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo20_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TruongSo20.Text))
            {
                if (!string.IsNullOrEmpty(txt_TruongSo13.Text))
                {
                    txt_TruongSo13.BackColor = Color.OrangeRed;
                    txt_TruongSo13.ForeColor = Color.White;
                    txt_TruongSo20.BackColor = Color.OrangeRed;
                    txt_TruongSo20.ForeColor = Color.White;
                }
                else
                {
                    txt_TruongSo13.BackColor = Color.White;
                    txt_TruongSo13.ForeColor = Color.Black;
                    txt_TruongSo20.BackColor = Color.White;
                    txt_TruongSo20.ForeColor = Color.Black;
                    DoiMauTextBox((TextEdit)sender, 0, 10);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txt_TruongSo13.Text))
                {
                    txt_TruongSo13.BackColor = Color.OrangeRed;
                    txt_TruongSo13.ForeColor = Color.White;
                    txt_TruongSo20.BackColor = Color.OrangeRed;
                    txt_TruongSo20.ForeColor = Color.White;
                }
                else
                {
                    txt_TruongSo13.BackColor = Color.White;
                    txt_TruongSo13.ForeColor = Color.Black;
                    txt_TruongSo20.BackColor = Color.White;
                    txt_TruongSo20.ForeColor = Color.Black;
                    DoiMauTextBox((TextEdit)sender, 0, 10);
                }
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo21_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 1);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo22_EditValueChanged(object sender, EventArgs e)
        {
            //DoiMauTextBox((TextEdit)sender, 0, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo23_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Total_Truong10(txt_TruongSo23, txt_TruongSo24, txt_TruongSo25);
            Total_Truong11();
           

            double truong11 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo11.Text))
                    truong11 = double.Parse(txt_TruongSo11.Text.Replace(",", ""));
            }
            catch (Exception exception)
            {

            }

            if (truong11 != _totalTruong11 && !string.IsNullOrEmpty(txt_TruongSo11.Text))
            {
                txt_TruongSo11.BackColor = Color.Red;
                txt_TruongSo11.ForeColor = Color.White;
                txt_TruongSo11.Tag = "1";
            }
            else
            {
                txt_TruongSo11.BackColor = Color.White;
                txt_TruongSo11.ForeColor = Color.Black;
                txt_TruongSo11.Tag = "0";
            }

            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo24_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Total_Truong10(txt_TruongSo23, txt_TruongSo24, txt_TruongSo25);
            Total_Truong11();
           

            double truong11 = 0;
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo11.Text))
                    truong11 = double.Parse(txt_TruongSo11.Text.Replace(",", ""));
            }
            catch (Exception exception)
            {

            }

            if (truong11 != _totalTruong11 && !string.IsNullOrEmpty(txt_TruongSo11.Text))
            {
                txt_TruongSo11.BackColor = Color.Red;
                txt_TruongSo11.ForeColor = Color.White;
                txt_TruongSo11.Tag = "1";
            }
            else
            {
                txt_TruongSo11.BackColor = Color.White;
                txt_TruongSo11.ForeColor = Color.Black;
                txt_TruongSo11.Tag = "0";
            }

            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo25_EditValueChanged(object sender, EventArgs e)
        {
            if (Global.StrRole == "DESO")
                txt_TruongSo00.Text = "";
            DoiMauTextBox((TextEdit)sender, 0, 10);

            Changed?.Invoke(sender, e);
        }

        

        private void txt_TruongSo01_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (!e.Control && e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
            else if (e.KeyCode == Keys.Add)
            {
                ((TextEdit)sender).Text = ((TextEdit)sender).Text + "000";
                ((TextEdit)sender).Select(((TextEdit)sender).Text.Length, 0);
            }

        }

        private void txt_TruongSo01_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo07.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
              
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo02.Focus();
            }
           
        }

        private void txt_TruongSo02_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo07.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo01.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo03.Focus();
            }
        }

        private void txt_TruongSo03_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo08.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo02.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo07.Focus();
            }
        }
        private void txt_TruongSo07_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo15.Focus();
            }
            else if(e.KeyCode == Keys.Up)
            {
                txt_TruongSo01.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo03.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo08.Focus();
            }
        }
        private void txt_TruongSo08_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo16.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo03.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo07.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo09.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo09_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo17.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo08.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo10.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo18.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo09.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo00.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }
        private void txt_TruongSo00_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo19.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo10.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo11.Focus();
            }
        }
        private void txt_TruongSo11_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo19.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo00.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo12.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo12_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo20.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo11.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo15.Focus();
            }

        }

        private void txt_TruongSo15_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo22.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo07.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo12.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo16.Focus();
            }

        }

        private void txt_TruongSo16_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo23.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo08.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo15.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo17.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo17_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo24.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo09.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo16.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo18.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo18_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo25.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo10.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo17.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo19.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo19_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo13.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo11.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo18.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo20.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo20_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo12.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo14.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo19.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo22.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo22_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo15.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo20.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo23.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo23_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo16.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo22.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo24.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo24_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo17.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo23.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo25.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo25_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo18.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo24.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo13.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo13_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo19.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo25.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo14.Focus();
            }
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

        private void txt_TruongSo14_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo20.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo13.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt_TruongSo21.Focus();
            }

        }

        private void txt_TruongSo21_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo20.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt_TruongSo14.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_TruongSo03_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(e.NewValue + ""))
                {
                    if (e.NewValue.ToString().IndexOf('?') < 0 && e.NewValue.ToString().Length > 6 || e.NewValue.ToString().Length < 6)
                    {
                        ((TextEdit)sender).BackColor = Color.Red;
                        ((TextEdit)sender).ForeColor = Color.White;
                        ((TextEdit)sender).Tag = "1";
                    }
                    else
                    {
                        if (txt_TruongSo02.Text == "1")
                        {
                            Decimal newValue;
                            if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                            {
                                string s = e.NewValue + "";
                                int kytudau = int.Parse(s.Substring(0, 2));
                                int kytugiua = int.Parse(s.Substring(2, 2));
                                int kytucuoi = int.Parse(s.Substring(4, 2));
                                if (newValue >= 010101 && newValue <= 450730)
                                {
                                    if (kytugiua < 1 || kytugiua > 12 || kytucuoi < 1 || kytucuoi > 31)
                                    {
                                        ((TextEdit)sender).BackColor = Color.Red;
                                        ((TextEdit)sender).ForeColor = Color.White;
                                        ((TextEdit)sender).Tag = "1";
                                    }
                                    else
                                    {
                                        ((TextEdit)sender).BackColor = Color.White;
                                        ((TextEdit)sender).ForeColor = Color.Black;
                                        ((TextEdit)sender).Tag = "0";
                                    }
                                }
                                else
                                {
                                    ((TextEdit)sender).BackColor = Color.Red;
                                    ((TextEdit)sender).ForeColor = Color.White;
                                    ((TextEdit)sender).Tag = "1";
                                }

                            }
                        }
                        else if (txt_TruongSo02.Text == "3")
                        {
                            Decimal newValue;
                            if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                            {
                                string s = e.NewValue + "";
                                int kytudau = int.Parse(s.Substring(0, 2));
                                int kytugiua = int.Parse(s.Substring(2, 2));
                                int kytucuoi = int.Parse(s.Substring(4, 2));
                                if (newValue >= 010731 && newValue <= 151225)
                                {
                                    if (kytugiua < 1 || kytugiua > 12 || kytucuoi < 1 || kytucuoi > 31)
                                    {
                                        ((TextEdit)sender).BackColor = Color.Red;
                                        ((TextEdit)sender).ForeColor = Color.White;
                                        ((TextEdit)sender).Tag = "1";
                                    }
                                    else
                                    {
                                        ((TextEdit)sender).BackColor = Color.White;
                                        ((TextEdit)sender).ForeColor = Color.Black;
                                        ((TextEdit)sender).Tag = "0";
                                    }
                                }
                                else
                                {
                                    ((TextEdit)sender).BackColor = Color.Red;
                                    ((TextEdit)sender).ForeColor = Color.White;
                                    ((TextEdit)sender).Tag = "1";
                                }

                            }
                        }
                        else if (txt_TruongSo02.Text == "5")
                        {
                            Decimal newValue;
                            if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                            {
                                string s = e.NewValue + "";
                                int kytudau = int.Parse(s.Substring(0, 2));
                                int kytugiua = int.Parse(s.Substring(2, 2));
                                int kytucuoi = int.Parse(s.Substring(4, 2));
                                if (newValue >= 011226 && newValue <= 640102)
                                {
                                    if (kytugiua < 1 || kytugiua > 12 || kytucuoi < 1 || kytucuoi > 31)
                                    {
                                        ((TextEdit)sender).BackColor = Color.Red;
                                        ((TextEdit)sender).ForeColor = Color.White;
                                        ((TextEdit)sender).Tag = "1";
                                    }
                                    else
                                    {
                                        ((TextEdit)sender).BackColor = Color.White;
                                        ((TextEdit)sender).ForeColor = Color.Black;
                                        ((TextEdit)sender).Tag = "0";
                                    }
                                }
                                else
                                {
                                    ((TextEdit)sender).BackColor = Color.Red;
                                    ((TextEdit)sender).ForeColor = Color.White;
                                    ((TextEdit)sender).Tag = "1";
                                }
                            }
                        }
                        else if (txt_TruongSo02.Text == "7")
                        {
                            Decimal newValue;
                            if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                            {
                                string s = e.NewValue + "";
                                int kytudau = int.Parse(s.Substring(0, 2));
                                int kytugiua = int.Parse(s.Substring(2, 2));
                                int kytucuoi = int.Parse(s.Substring(4, 2));

                                if (newValue >= 010108 && newValue <= 290601)
                                {
                                    if (kytugiua < 1 || kytugiua > 12 || kytucuoi < 1 || kytucuoi > 31)
                                    {
                                        ((TextEdit)sender).BackColor = Color.Red;
                                        ((TextEdit)sender).ForeColor = Color.White;
                                        ((TextEdit)sender).Tag = "1";
                                    }
                                    else
                                    {
                                        ((TextEdit)sender).BackColor = Color.White;
                                        ((TextEdit)sender).ForeColor = Color.Black;
                                        ((TextEdit)sender).Tag = "0";
                                    }
                                }
                                else
                                {
                                    ((TextEdit)sender).BackColor = Color.Red;
                                    ((TextEdit)sender).ForeColor = Color.White;
                                    ((TextEdit)sender).Tag = "1";
                                }
                            }
                        }
                        else
                        {
                            Decimal newValue;
                            if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                            {
                                string s = newValue + "";
                                int kytudau = int.Parse(s.Substring(0, 2));
                                int kytugiua = int.Parse(s.Substring(2, 2));
                                int kytucuoi = int.Parse(s.Substring(4, 2));
                                if (kytudau < 1 || kytudau > 99 || kytugiua < 0 || kytugiua > 12 || kytucuoi < 0 || kytucuoi > 31)
                                {
                                    //e.Cancel = true;
                                    ((TextEdit)sender).BackColor = Color.Red;
                                    ((TextEdit)sender).ForeColor = Color.White;
                                    ((TextEdit)sender).Tag = "1";
                                }
                                else
                                {
                                    ((TextEdit)sender).BackColor = Color.White;
                                    ((TextEdit)sender).ForeColor = Color.Black;
                                    ((TextEdit)sender).Tag = "0";
                                }

                            }
                        }

                    }

                }
                else
                {
                    ((TextEdit)sender).BackColor = Color.White;
                    ((TextEdit)sender).ForeColor = Color.Black;
                    ((TextEdit)sender).Tag = "0";
                }

            }
            catch (Exception)
            {

            }
        }

        private void txt_TruongSo06_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(e.NewValue + ""))
                {
                    if (e.NewValue.ToString().IndexOf('?') < 0 && e.NewValue.ToString().Length > 2 || e.NewValue.ToString().Length < 0)
                    {
                        ((TextEdit)sender).BackColor = Color.Red;
                        ((TextEdit)sender).ForeColor = Color.White;
                        ((TextEdit)sender).Tag = "1";
                    }
                    else
                    {
                        Decimal newValue;
                        if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                        {
                            int s = int.Parse(newValue + "");

                            if (s > 12)
                            {
                                //e.Cancel = true;
                                ((TextEdit)sender).BackColor = Color.Red;
                                ((TextEdit)sender).ForeColor = Color.White;
                                ((TextEdit)sender).Tag = "1";
                            }
                            else
                            {
                                ((TextEdit)sender).BackColor = Color.White;
                                ((TextEdit)sender).ForeColor = Color.Black;
                                ((TextEdit)sender).Tag = "0";
                            }

                        }

                    }
                }
                else
                {
                    ((TextEdit)sender).BackColor = Color.White;
                    ((TextEdit)sender).ForeColor = Color.Black;
                    ((TextEdit)sender).Tag = "0";
                }

            }
            catch (Exception)
            {

            }

        }

        private void txt_TruongSo07_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(e.NewValue + ""))
                {
                    if (e.NewValue.ToString() != "" && e.NewValue.ToString().IndexOf('?') < 0 && e.NewValue.ToString().Length > 2 || e.NewValue.ToString().Length < 0)
                    {
                        ((TextEdit)sender).BackColor = Color.Red;
                        ((TextEdit)sender).ForeColor = Color.White;
                        ((TextEdit)sender).Tag = "1";
                    }
                    else
                    {
                        Decimal newValue;
                        if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                        {
                            int s = int.Parse(newValue + "");

                            if (s > 31)
                            {
                                //e.Cancel = true;
                                ((TextEdit)sender).BackColor = Color.Red;
                                ((TextEdit)sender).ForeColor = Color.White;
                                ((TextEdit)sender).Tag = "1";
                            }
                            else
                            {
                                ((TextEdit)sender).BackColor = Color.White;
                                ((TextEdit)sender).ForeColor = Color.Black;
                                ((TextEdit)sender).Tag = "0";
                            }

                        }

                    }
                }
                else
                {
                    ((TextEdit)sender).BackColor = Color.White;
                    ((TextEdit)sender).ForeColor = Color.Black;
                    ((TextEdit)sender).Tag = "0";
                }

            }
            catch (Exception)
            {

            }
        }

        private void txt_TruongSo12_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(e.NewValue + ""))
                {
                    if (e.NewValue.ToString().IndexOf('?') < 0 && e.NewValue.ToString().Length > 4 || e.NewValue.ToString().Length < 4)
                    {
                        ((TextEdit)sender).BackColor = Color.Red;
                        ((TextEdit)sender).ForeColor = Color.White;
                        ((TextEdit)sender).Tag = "1";
                    }
                    else
                    {
                        Decimal newValue;
                        if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                        {
                            string s = newValue + "";
                            int kytudau = int.Parse(s.Substring(0, 2));
                            int kytucuoi = int.Parse(s.Substring(2, 2));
                            if (newValue<2906||newValue>2909)
                            {
                                //e.Cancel = true;
                                ((TextEdit)sender).BackColor = Color.Red;
                                ((TextEdit)sender).ForeColor = Color.White;
                                ((TextEdit)sender).Tag = "1";
                            }
                            else
                            {
                                ((TextEdit)sender).BackColor = Color.White;
                                ((TextEdit)sender).ForeColor = Color.Black;
                                ((TextEdit)sender).Tag = "0";
                            }

                        }
                    }
                }
                else
                {
                    ((TextEdit)sender).BackColor = Color.White;
                    ((TextEdit)sender).ForeColor = Color.Black;
                    ((TextEdit)sender).Tag = "0";
                }
            }
            catch (Exception)
            {

            }
        }

        private void txt_TruongSo15_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(e.NewValue + ""))
                {
                    if (e.NewValue.ToString().IndexOf('?') < 0 && e.NewValue.ToString().Length > 2 || e.NewValue.ToString().Length < 0)
                    {
                        ((TextEdit)sender).BackColor = Color.Red;
                        ((TextEdit)sender).ForeColor = Color.White;
                        ((TextEdit)sender).Tag = "1";
                    }
                    else
                    {
                        Decimal newValue;
                        if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                        {
                            int s = int.Parse(newValue + "");

                            if (s > 31)
                            {
                                //e.Cancel = true;
                                ((TextEdit)sender).BackColor = Color.Red;
                                ((TextEdit)sender).ForeColor = Color.White;
                                ((TextEdit)sender).Tag = "1";
                            }
                            else
                            {
                                ((TextEdit)sender).BackColor = Color.White;
                                ((TextEdit)sender).ForeColor = Color.Black;
                                ((TextEdit)sender).Tag = "0";
                            }

                        }

                    }
                }
                else
                {
                    ((TextEdit)sender).BackColor = Color.White;
                    ((TextEdit)sender).ForeColor = Color.Black;
                    ((TextEdit)sender).Tag = "0";
                }

            }
            catch (Exception)
            {

            }
        }

        private void txt_TruongSo14_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                Decimal newValue;
                if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                {
                    if (newValue < 0 || newValue > 12)
                        e.Cancel = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void txt_TruongSo22_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(e.NewValue + ""))
                {
                    if (e.NewValue.ToString().IndexOf('?') < 0 && e.NewValue.ToString().Length > 2 || e.NewValue.ToString().Length < 0)
                    {
                        ((TextEdit)sender).BackColor = Color.Red;
                        ((TextEdit)sender).ForeColor = Color.White;
                        ((TextEdit)sender).Tag = "1";
                    }
                    else
                    {
                        Decimal newValue;
                        if (Decimal.TryParse(e.NewValue.ToString(), out newValue))
                        {
                            int s = int.Parse(newValue + "");

                            if (s > 31)
                            {
                                //e.Cancel = true;
                                ((TextEdit)sender).BackColor = Color.Red;
                                ((TextEdit)sender).ForeColor = Color.White;
                                ((TextEdit)sender).Tag = "1";
                            }
                            else
                            {
                                ((TextEdit)sender).BackColor = Color.White;
                                ((TextEdit)sender).ForeColor = Color.Black;
                                ((TextEdit)sender).Tag = "0";
                            }

                        }

                    }
                }
                else
                {
                    ((TextEdit)sender).BackColor = Color.White;
                    ((TextEdit)sender).ForeColor = Color.Black;
                    ((TextEdit)sender).Tag = "0";
                }

            }
            catch (Exception)
            {

            }
        }

        private void txt_TruongSo00_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control && e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txt_TruongSo21_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control && e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
    }
}