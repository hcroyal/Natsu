namespace Natsu.MyForm
{
    partial class frm_ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_ThongBao = new DevExpress.XtraEditors.LabelControl();
            this.btn_ChangePass = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ShowPassNhapLai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ShowPassMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ShowPassCu = new DevExpress.XtraEditors.SimpleButton();
            this.txt_PassNhapLai = new DevExpress.XtraEditors.TextEdit();
            this.txt_PassMoi = new DevExpress.XtraEditors.TextEdit();
            this.txt_PassCu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PassNhapLai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PassMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PassCu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ThongBao
            // 
            this.lb_ThongBao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lb_ThongBao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao.Appearance.Options.UseFont = true;
            this.lb_ThongBao.Appearance.Options.UseForeColor = true;
            this.lb_ThongBao.Location = new System.Drawing.Point(106, 206);
            this.lb_ThongBao.Name = "lb_ThongBao";
            this.lb_ThongBao.Size = new System.Drawing.Size(0, 19);
            this.lb_ThongBao.TabIndex = 28;
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ChangePass.Appearance.Options.UseFont = true;
            this.btn_ChangePass.Location = new System.Drawing.Point(232, 139);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(124, 54);
            this.btn_ChangePass.TabIndex = 27;
            this.btn_ChangePass.Text = "Đổi Password";
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // btn_ShowPassNhapLai
            // 
            this.btn_ShowPassNhapLai.Location = new System.Drawing.Point(443, 98);
            this.btn_ShowPassNhapLai.Name = "btn_ShowPassNhapLai";
            this.btn_ShowPassNhapLai.Size = new System.Drawing.Size(40, 23);
            this.btn_ShowPassNhapLai.TabIndex = 24;
            this.btn_ShowPassNhapLai.Text = "Show";
            // 
            // btn_ShowPassMoi
            // 
            this.btn_ShowPassMoi.Location = new System.Drawing.Point(443, 54);
            this.btn_ShowPassMoi.Name = "btn_ShowPassMoi";
            this.btn_ShowPassMoi.Size = new System.Drawing.Size(40, 23);
            this.btn_ShowPassMoi.TabIndex = 25;
            this.btn_ShowPassMoi.Text = "Show";
            // 
            // btn_ShowPassCu
            // 
            this.btn_ShowPassCu.Location = new System.Drawing.Point(443, 13);
            this.btn_ShowPassCu.Name = "btn_ShowPassCu";
            this.btn_ShowPassCu.Size = new System.Drawing.Size(40, 23);
            this.btn_ShowPassCu.TabIndex = 26;
            this.btn_ShowPassCu.Text = "Show";
            // 
            // txt_PassNhapLai
            // 
            this.txt_PassNhapLai.Location = new System.Drawing.Point(164, 98);
            this.txt_PassNhapLai.Name = "txt_PassNhapLai";
            this.txt_PassNhapLai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_PassNhapLai.Properties.Appearance.Options.UseFont = true;
            this.txt_PassNhapLai.Properties.UseSystemPasswordChar = true;
            this.txt_PassNhapLai.Size = new System.Drawing.Size(273, 22);
            this.txt_PassNhapLai.TabIndex = 23;
            // 
            // txt_PassMoi
            // 
            this.txt_PassMoi.Location = new System.Drawing.Point(164, 54);
            this.txt_PassMoi.Name = "txt_PassMoi";
            this.txt_PassMoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_PassMoi.Properties.Appearance.Options.UseFont = true;
            this.txt_PassMoi.Properties.UseSystemPasswordChar = true;
            this.txt_PassMoi.Size = new System.Drawing.Size(273, 22);
            this.txt_PassMoi.TabIndex = 22;
            // 
            // txt_PassCu
            // 
            this.txt_PassCu.Location = new System.Drawing.Point(164, 13);
            this.txt_PassCu.Name = "txt_PassCu";
            this.txt_PassCu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_PassCu.Properties.Appearance.Options.UseFont = true;
            this.txt_PassCu.Properties.UseSystemPasswordChar = true;
            this.txt_PassCu.Size = new System.Drawing.Size(273, 22);
            this.txt_PassCu.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(124, 17);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Nhập lại pass mới:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(57, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 17);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Password mới:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(71, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 16);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Password cũ:";
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 233);
            this.Controls.Add(this.lb_ThongBao);
            this.Controls.Add(this.btn_ChangePass);
            this.Controls.Add(this.btn_ShowPassNhapLai);
            this.Controls.Add(this.btn_ShowPassMoi);
            this.Controls.Add(this.btn_ShowPassCu);
            this.Controls.Add(this.txt_PassNhapLai);
            this.Controls.Add(this.txt_PassMoi);
            this.Controls.Add(this.txt_PassCu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ChangePassword";
            this.Load += new System.EventHandler(this.frm_ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_PassNhapLai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PassMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PassCu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lb_ThongBao;
        private DevExpress.XtraEditors.SimpleButton btn_ChangePass;
        private DevExpress.XtraEditors.SimpleButton btn_ShowPassNhapLai;
        private DevExpress.XtraEditors.SimpleButton btn_ShowPassMoi;
        private DevExpress.XtraEditors.SimpleButton btn_ShowPassCu;
        private DevExpress.XtraEditors.TextEdit txt_PassNhapLai;
        private DevExpress.XtraEditors.TextEdit txt_PassMoi;
        private DevExpress.XtraEditors.TextEdit txt_PassCu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}