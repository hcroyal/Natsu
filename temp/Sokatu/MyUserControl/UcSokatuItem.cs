using DevExpress.XtraEditors;
using Natsu.MyClass;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Natsu.MyUserControl
{
    public delegate void AllTextChange(object sender, EventArgs e);

    public partial class UcSokatuItem : UserControl
    {
        public event AllTextChange Changed;

        public UcSokatuItem()
        {
            InitializeComponent();
        }

        private double _totalTruong11 = 0;
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

        public void SaveData(string idimage, string idphieu)
        {
            Global.Db.Insert_Getsu(idimage, Global.StrBatch, Global.StrUsername,
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
                                    idphieu);
        }

        public void SaveData_SuaVaLuu(string usersaiit, string usersainhieu, string idimage, string idphieu)
        {
            Global.Db.SuaVaLuu_deso(usersaiit, usersainhieu, idimage, Global.StrBatch, Global.StrUsername,
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
                                    txt_TruongSo25.Text?.Replace(",", ""));
        }

        public void DoiMauTextBox(TextEdit txt, int sobytenho, int sobytelon)
        {
            if (txt.Text != "" && txt.Text.IndexOf('?') < 0 && (txt.Text.Length > sobytelon || txt.Text.Length < sobytenho))
            {
                txt.BackColor = Color.Red;
                txt.ForeColor = Color.White;
            }
            else
            {
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
            }
        }
        public void DoiMauTextBoxCoSo0(TextEdit txt, int sobytenho, int sobytelon)
        {
            if (txt.Text != "" && txt.Text.IndexOf('?') < 0 && (txt.Text.Length > sobytelon || txt.Text.Length < sobytenho))
            {
                txt.BackColor = Color.Red;
                txt.ForeColor = Color.White;
            }
            else
            {
                if (txt.Text== "0" || txt.Text=="00")
                {
                    txt.BackColor = Color.Coral;
                    txt.ForeColor = Color.Black;
                   
                }
                else
                {
                    txt.BackColor = Color.White;
                    txt.ForeColor = Color.Black;
                }
            }
        }

        private void UcNatsuItem_Load(object sender, EventArgs e)
        {
            txt_TruongSo07.Enabled = false;
            txt_TruongSo08.Enabled = false;
            txt_TruongSo09.Enabled = false;
            txt_TruongSo10.Enabled = false;

            txt_TruongSo14.Enabled = false;
            txt_TruongSo15.Enabled = false;
            txt_TruongSo16.Enabled = false;
            txt_TruongSo17.Enabled = false;

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

        private void Total_Truong10(TextEdit txt1, TextEdit txt2, TextEdit txt3)
        {
            try
            {
                double x1 = 0, x2 = 0;
                if (!string.IsNullOrEmpty(txt1.Text))
                    x1 = double.Parse(txt1.Text.Replace(",", ""));
                if (!string.IsNullOrEmpty(txt2.Text))
                    x2 = double.Parse(txt2.Text.Replace(",", ""));
                txt3.Text = x1 + x2 + "";
                curency(txt3);
            }
            catch (Exception e)
            {
               ;
            }
          
        }

        private void Total_Truong11()
        {
            try
            {
                double truong10 = 0, truong18 = 0, truong25 = 0;
                if (!string.IsNullOrEmpty(txt_TruongSo10.Text))
                    truong10 = double.Parse(txt_TruongSo10.Text.Replace(",", ""));
                if (!string.IsNullOrEmpty(txt_TruongSo18.Text))
                    truong18 = double.Parse(txt_TruongSo18.Text.Replace(",", ""));
                if (!string.IsNullOrEmpty(txt_TruongSo25.Text))
                    truong25 = double.Parse(txt_TruongSo25.Text.Replace(",", ""));
                _totalTruong11 = truong10 + truong18 + truong25;
            }
            catch (Exception e)
            {
            }
           
        }

        private void Total_Truong19()
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_TruongSo11.Text))
                    _totalTruong19 = int.Parse(txt_TruongSo11.Text.Replace(",", "")) / 3;
            }
            catch (Exception e)
            {
              
            }
           
        }

        private void txt_TruongSo01_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 2, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo02_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 6, 6);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo03_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo04_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 5);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo05_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo06_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBoxCoSo0((TextEdit)sender, 0, 2);
            
            if (!string.IsNullOrEmpty(((TextEdit) sender).Text))
            {
                txt_TruongSo07.Enabled = true;
                txt_TruongSo07.Text = "";
            }
            else
            {
                txt_TruongSo07.Enabled = false;
                txt_TruongSo07.Text = "";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo07_EditValueChanged(object sender, EventArgs e)
        {
            
            DoiMauTextBoxCoSo0((TextEdit)sender, 0, 2);
            if (!string.IsNullOrEmpty(((TextEdit)sender).Text))
            {
                txt_TruongSo08.Enabled = true;
                txt_TruongSo08.Text = "";
            }
            else
            {
                txt_TruongSo08.Enabled = false;
                txt_TruongSo08.Text = "";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo08_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBoxCoSo0((TextEdit)sender, 0, 2);
            if (!string.IsNullOrEmpty(((TextEdit)sender).Text))
            {
                txt_TruongSo09.Enabled = true;
                txt_TruongSo09.Text = "";
            }
            else
            {
                txt_TruongSo09.Enabled = false;
                txt_TruongSo09.Text = "";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo09_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBoxCoSo0((TextEdit)sender, 0, 2);
            if (!string.IsNullOrEmpty(((TextEdit)sender).Text))
            {
                txt_TruongSo10.Enabled = true;
                txt_TruongSo10.Text = "";
            }
            else
            {
                txt_TruongSo10.Enabled = false;
                txt_TruongSo10.Text = "";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo10_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBoxCoSo0((TextEdit)sender, 0, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo11_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 1);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo12_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo13_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBoxCoSo0((TextEdit)sender, 0, 2);
            if (!string.IsNullOrEmpty(((TextEdit)sender).Text))
            {
                txt_TruongSo14.Enabled = true;
                txt_TruongSo14.Text = "";
            }
            else
            {
                txt_TruongSo14.Enabled = false;
                txt_TruongSo14.Text = "";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo14_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBoxCoSo0((TextEdit)sender, 0, 2);
            if (!string.IsNullOrEmpty(((TextEdit)sender).Text))
            {
                txt_TruongSo15.Enabled = true;
                txt_TruongSo15.Text = "";
            }
            else
            {
                txt_TruongSo15.Enabled = false;
                txt_TruongSo15.Text = "";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo15_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBoxCoSo0((TextEdit)sender, 0, 2);
            if (!string.IsNullOrEmpty(((TextEdit)sender).Text))
            {
                txt_TruongSo16.Enabled = true;
                txt_TruongSo16.Text = "";
            }
            else
            {
                txt_TruongSo16.Enabled = false;
                txt_TruongSo16.Text = "";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo16_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBoxCoSo0((TextEdit)sender, 0, 2);
            if (!string.IsNullOrEmpty(((TextEdit)sender).Text))
            {
                txt_TruongSo17.Enabled = true;
                txt_TruongSo17.Text = "";
            }
            else
            {
                txt_TruongSo17.Enabled = false;
                txt_TruongSo17.Text = "";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo17_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBoxCoSo0((TextEdit)sender, 0, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo18_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 1);
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
            }
            else
            {
                txt_TruongSo19.BackColor = Color.White;
                txt_TruongSo19.ForeColor = Color.Black;
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo20_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo21_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 1);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo22_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 2);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo23_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Total_Truong10(txt_TruongSo23, txt_TruongSo24, txt_TruongSo25);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo24_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Total_Truong10(txt_TruongSo23, txt_TruongSo24, txt_TruongSo25);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo25_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
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
            }
            else
            {
                txt_TruongSo11.BackColor = Color.White;
                txt_TruongSo11.ForeColor = Color.Black;
            }
            Changed?.Invoke(sender, e);
        }

      

        private void txt_TruongSo01_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                ((TextEdit)sender).Text = ((TextEdit)sender).Text + "000";
                ((TextEdit)sender).Select(((TextEdit)sender).Text.Length, 0);
            }
            else if (e.KeyCode==Keys.Enter && !e.Control)
            {
                SendKeys.Send("{Tab}");
            }
            else if (e.KeyCode==Keys.Right)
            {
                SendKeys.Send("{Tab}");
            }
            else if (e.KeyCode == Keys.Left)
            {
                SendKeys.Send("+{Tab}");
            }
        }

        private void txt_TruongSo01_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Down)
            {
                txt_TruongSo03.Focus();
            }
        }

        private void txt_TruongSo02_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo04.Focus();
            }
        }

        private void txt_TruongSo03_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo05.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo01.Focus();
            }
        }

        private void txt_TruongSo04_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo06.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo02.Focus();
            }
        }

        private void txt_TruongSo05_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo12.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo03.Focus();
            }
        }

        private void txt_TruongSo06_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo04.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo13.Focus();
            }
        }

        private void txt_TruongSo07_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo04.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo14.Focus();
            }
        }

        private void txt_TruongSo08_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo04.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo15.Focus();
            }
           
        }

        private void txt_TruongSo09_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo04.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo16.Focus();
            }
           
        }

        private void txt_TruongSo10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo04.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo17.Focus();
            }
           
        }

        private void txt_TruongSo11_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo04.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo17.Focus();
            }
        }

        private void txt_TruongSo12_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo05.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo18.Focus();
            }

        }
        private void txt_TruongSo13_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo06.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo18.Focus();
            }
        }

        private void txt_TruongSo14_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo07.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo18.Focus();
            }

        }
        private void txt_TruongSo15_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo08.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo18.Focus();
            }

        }

        private void txt_TruongSo16_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo09.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo18.Focus();
            }
        }

        private void txt_TruongSo17_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo10.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt_TruongSo18.Focus();
            }
        }

        private void txt_TruongSo18_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo10.Focus();
            }
            else if (e.KeyCode == Keys.Down)
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

        private void txt_TruongSo19_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo11.Focus();
            }
            else if (e.KeyCode == Keys.Down)
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

        private void txt_TruongSo20_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo12.Focus();
            }
            else if (e.KeyCode == Keys.Down)
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

        private void txt_TruongSo22_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo15.Focus();
            }
           
        }

        private void txt_TruongSo23_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo16.Focus();
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
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
                // ignored
            }
        }

       
        private void txt_TruongSo21_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt_TruongSo20.Focus();
            }
         
        }
    }
}