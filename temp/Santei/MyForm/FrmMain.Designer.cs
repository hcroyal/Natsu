﻿namespace Natsu.MyForm
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar_System = new DevExpress.XtraBars.BarSubItem();
            this.btn_Logout = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.bar_Manager = new DevExpress.XtraBars.BarSubItem();
            this.btn_Batch = new DevExpress.XtraBars.BarButtonItem();
            this.btn_User = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Check = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Progress = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Productivity = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ZoomImage = new DevExpress.XtraBars.BarButtonItem();
            this.btn_FeedBack = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Start_Performance_Test = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Stop_Performance_Test = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pn_Top = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoHinhLamDuoc = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoHinhConLai = new DevExpress.XtraEditors.LabelControl();
            this.lb_4 = new DevExpress.XtraEditors.LabelControl();
            this.lb_TongSoHinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_3 = new DevExpress.XtraEditors.LabelControl();
            this.lb_UserName = new DevExpress.XtraEditors.LabelControl();
            this.lb_IdImage = new DevExpress.XtraEditors.LabelControl();
            this.lb_6 = new DevExpress.XtraEditors.LabelControl();
            this.lb_fBatchName = new DevExpress.XtraEditors.LabelControl();
            this.lb_5 = new DevExpress.XtraEditors.LabelControl();
            this.lb_2 = new DevExpress.XtraEditors.LabelControl();
            this.lb_1 = new DevExpress.XtraEditors.LabelControl();
            this.pn_Input = new DevExpress.XtraEditors.PanelControl();
            this.UcNatsu1 = new Natsu.MyUserControl.UcSantei();
            this.pn_Button = new DevExpress.XtraEditors.PanelControl();
            this.btn_Pause = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Submit_Logout = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Start_Submit = new DevExpress.XtraEditors.SimpleButton();
            this.pn_Image = new DevExpress.XtraEditors.PanelControl();
            this.UcPictureBox1 = new Natsu.MyUserControl.UcPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Top)).BeginInit();
            this.pn_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Input)).BeginInit();
            this.pn_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Button)).BeginInit();
            this.pn_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Image)).BeginInit();
            this.pn_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bar_System,
            this.btn_Logout,
            this.btn_Exit,
            this.bar_Manager,
            this.btn_Batch,
            this.btn_User,
            this.btn_Check,
            this.btn_Progress,
            this.btn_Productivity,
            this.btn_ExportExcel,
            this.btn_ZoomImage,
            this.btn_FeedBack,
            this.btn_Start_Performance_Test,
            this.btn_Stop_Performance_Test});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 16;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_System),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_Manager),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ZoomImage),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_FeedBack)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar_System
            // 
            this.bar_System.Caption = "System";
            this.bar_System.Id = 0;
            this.bar_System.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Logout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Exit)});
            this.bar_System.Name = "bar_System";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Caption = "&Logout";
            this.btn_Logout.Id = 1;
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Logout_ItemClick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Caption = "&Exit";
            this.btn_Exit.Id = 2;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Exit_ItemClick);
            // 
            // bar_Manager
            // 
            this.bar_Manager.Caption = "Manager";
            this.bar_Manager.Id = 3;
            this.bar_Manager.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Batch),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_User),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Check),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Progress),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Productivity),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportExcel)});
            this.bar_Manager.Name = "bar_Manager";
            // 
            // btn_Batch
            // 
            this.btn_Batch.Caption = "Manager &Batch";
            this.btn_Batch.Id = 4;
            this.btn_Batch.Name = "btn_Batch";
            this.btn_Batch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Batch_ItemClick);
            // 
            // btn_User
            // 
            this.btn_User.Caption = "Manager &User";
            this.btn_User.Id = 5;
            this.btn_User.Name = "btn_User";
            this.btn_User.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_User_ItemClick);
            // 
            // btn_Check
            // 
            this.btn_Check.Caption = "&Check";
            this.btn_Check.Id = 6;
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Check_ItemClick);
            // 
            // btn_Progress
            // 
            this.btn_Progress.Caption = "&Progress";
            this.btn_Progress.Id = 7;
            this.btn_Progress.Name = "btn_Progress";
            this.btn_Progress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Progress_ItemClick);
            // 
            // btn_Productivity
            // 
            this.btn_Productivity.Caption = "Pro&ductivity";
            this.btn_Productivity.Id = 8;
            this.btn_Productivity.Name = "btn_Productivity";
            this.btn_Productivity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Productivity_ItemClick);
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.Caption = "&Export Excel";
            this.btn_ExportExcel.Id = 9;
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ExportExcel_ItemClick);
            // 
            // btn_ZoomImage
            // 
            this.btn_ZoomImage.Caption = "Zoom Image";
            this.btn_ZoomImage.Id = 10;
            this.btn_ZoomImage.Name = "btn_ZoomImage";
            this.btn_ZoomImage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ZoomImage_ItemClick);
            // 
            // btn_FeedBack
            // 
            this.btn_FeedBack.Caption = "Feedback";
            this.btn_FeedBack.Id = 11;
            this.btn_FeedBack.Name = "btn_FeedBack";
            this.btn_FeedBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_FeedBack_ItemClick);
            // 
            // btn_Start_Performance_Test
            // 
            this.btn_Start_Performance_Test.Caption = "Start";
            this.btn_Start_Performance_Test.Id = 14;
            this.btn_Start_Performance_Test.Name = "btn_Start_Performance_Test";
            // 
            // btn_Stop_Performance_Test
            // 
            this.btn_Stop_Performance_Test.Caption = "Stop";
            this.btn_Stop_Performance_Test.Id = 15;
            this.btn_Stop_Performance_Test.Name = "btn_Stop_Performance_Test";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1264, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 646);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1264, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 626);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1264, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 626);
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.labelControl1);
            this.pn_Top.Controls.Add(this.lb_SoHinhLamDuoc);
            this.pn_Top.Controls.Add(this.lb_SoHinhConLai);
            this.pn_Top.Controls.Add(this.lb_4);
            this.pn_Top.Controls.Add(this.lb_TongSoHinh);
            this.pn_Top.Controls.Add(this.lb_3);
            this.pn_Top.Controls.Add(this.lb_UserName);
            this.pn_Top.Controls.Add(this.lb_IdImage);
            this.pn_Top.Controls.Add(this.lb_6);
            this.pn_Top.Controls.Add(this.lb_fBatchName);
            this.pn_Top.Controls.Add(this.lb_5);
            this.pn_Top.Controls.Add(this.lb_2);
            this.pn_Top.Controls.Add(this.lb_1);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.Location = new System.Drawing.Point(0, 20);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(1264, 25);
            this.pn_Top.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(1190, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "算定基礎届";
            // 
            // lb_SoHinhLamDuoc
            // 
            this.lb_SoHinhLamDuoc.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_SoHinhLamDuoc.Appearance.Options.UseForeColor = true;
            this.lb_SoHinhLamDuoc.Location = new System.Drawing.Point(525, 6);
            this.lb_SoHinhLamDuoc.Name = "lb_SoHinhLamDuoc";
            this.lb_SoHinhLamDuoc.Size = new System.Drawing.Size(6, 13);
            this.lb_SoHinhLamDuoc.TabIndex = 1;
            this.lb_SoHinhLamDuoc.Text = "0";
            // 
            // lb_SoHinhConLai
            // 
            this.lb_SoHinhConLai.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lb_SoHinhConLai.Appearance.Options.UseForeColor = true;
            this.lb_SoHinhConLai.Location = new System.Drawing.Point(417, 6);
            this.lb_SoHinhConLai.Name = "lb_SoHinhConLai";
            this.lb_SoHinhConLai.Size = new System.Drawing.Size(6, 13);
            this.lb_SoHinhConLai.TabIndex = 2;
            this.lb_SoHinhConLai.Text = "0";
            // 
            // lb_4
            // 
            this.lb_4.Location = new System.Drawing.Point(456, 6);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(67, 13);
            this.lb_4.TabIndex = 3;
            this.lb_4.Text = "Images Done:";
            // 
            // lb_TongSoHinh
            // 
            this.lb_TongSoHinh.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lb_TongSoHinh.Appearance.Options.UseForeColor = true;
            this.lb_TongSoHinh.Location = new System.Drawing.Point(266, 6);
            this.lb_TongSoHinh.Name = "lb_TongSoHinh";
            this.lb_TongSoHinh.Size = new System.Drawing.Size(6, 13);
            this.lb_TongSoHinh.TabIndex = 4;
            this.lb_TongSoHinh.Text = "0";
            // 
            // lb_3
            // 
            this.lb_3.Location = new System.Drawing.Point(305, 6);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(109, 13);
            this.lb_3.TabIndex = 5;
            this.lb_3.Text = "The remaining Images:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_UserName.Location = new System.Drawing.Point(915, 6);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(49, 13);
            this.lb_UserName.TabIndex = 6;
            this.lb_UserName.Text = "UserName";
            // 
            // lb_IdImage
            // 
            this.lb_IdImage.Location = new System.Drawing.Point(630, 6);
            this.lb_IdImage.Name = "lb_IdImage";
            this.lb_IdImage.Size = new System.Drawing.Size(6, 13);
            this.lb_IdImage.TabIndex = 7;
            this.lb_IdImage.Text = "0";
            this.lb_IdImage.Click += new System.EventHandler(this.lb_IdImage_Click);
            // 
            // lb_6
            // 
            this.lb_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_6.Location = new System.Drawing.Point(856, 6);
            this.lb_6.Name = "lb_6";
            this.lb_6.Size = new System.Drawing.Size(53, 13);
            this.lb_6.TabIndex = 8;
            this.lb_6.Text = "UserName:";
            // 
            // lb_fBatchName
            // 
            this.lb_fBatchName.Location = new System.Drawing.Point(47, 6);
            this.lb_fBatchName.Name = "lb_fBatchName";
            this.lb_fBatchName.Size = new System.Drawing.Size(27, 13);
            this.lb_fBatchName.TabIndex = 9;
            this.lb_fBatchName.Text = "Batch";
            // 
            // lb_5
            // 
            this.lb_5.Location = new System.Drawing.Point(580, 6);
            this.lb_5.Name = "lb_5";
            this.lb_5.Size = new System.Drawing.Size(44, 13);
            this.lb_5.TabIndex = 10;
            this.lb_5.Text = "IdImage:";
            // 
            // lb_2
            // 
            this.lb_2.Location = new System.Drawing.Point(199, 6);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(66, 13);
            this.lb_2.TabIndex = 11;
            this.lb_2.Text = "Total Images:";
            // 
            // lb_1
            // 
            this.lb_1.Location = new System.Drawing.Point(10, 6);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(31, 13);
            this.lb_1.TabIndex = 12;
            this.lb_1.Text = "Batch:";
            // 
            // pn_Input
            // 
            this.pn_Input.Controls.Add(this.UcNatsu1);
            this.pn_Input.Controls.Add(this.pn_Button);
            this.pn_Input.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_Input.Location = new System.Drawing.Point(749, 45);
            this.pn_Input.Name = "pn_Input";
            this.pn_Input.Size = new System.Drawing.Size(515, 601);
            this.pn_Input.TabIndex = 8;
            // 
            // UcNatsu1
            // 
            this.UcNatsu1.AutoScroll = true;
            this.UcNatsu1.AutoSize = true;
            this.UcNatsu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcNatsu1.Location = new System.Drawing.Point(2, 2);
            this.UcNatsu1.Name = "UcNatsu1";
            this.UcNatsu1.Size = new System.Drawing.Size(511, 567);
            this.UcNatsu1.TabIndex = 8;
            // 
            // pn_Button
            // 
            this.pn_Button.Controls.Add(this.btn_Pause);
            this.pn_Button.Controls.Add(this.btn_Submit_Logout);
            this.pn_Button.Controls.Add(this.btn_Start_Submit);
            this.pn_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Button.Location = new System.Drawing.Point(2, 569);
            this.pn_Button.Name = "pn_Button";
            this.pn_Button.Size = new System.Drawing.Size(511, 30);
            this.pn_Button.TabIndex = 0;
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(312, 5);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(95, 23);
            this.btn_Pause.TabIndex = 7;
            this.btn_Pause.Text = "Pause (ESC)";
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Submit_Logout
            // 
            this.btn_Submit_Logout.Location = new System.Drawing.Point(216, 6);
            this.btn_Submit_Logout.Name = "btn_Submit_Logout";
            this.btn_Submit_Logout.Size = new System.Drawing.Size(90, 21);
            this.btn_Submit_Logout.TabIndex = 6;
            this.btn_Submit_Logout.Text = "Submit + Logout";
            this.btn_Submit_Logout.Click += new System.EventHandler(this.btn_Submit_Logout_Click);
            // 
            // btn_Start_Submit
            // 
            this.btn_Start_Submit.Location = new System.Drawing.Point(120, 6);
            this.btn_Start_Submit.Name = "btn_Start_Submit";
            this.btn_Start_Submit.Size = new System.Drawing.Size(90, 21);
            this.btn_Start_Submit.TabIndex = 5;
            this.btn_Start_Submit.Text = "Start";
            this.btn_Start_Submit.Click += new System.EventHandler(this.btn_Start_Submit_Click);
            // 
            // pn_Image
            // 
            this.pn_Image.Controls.Add(this.UcPictureBox1);
            this.pn_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Image.Location = new System.Drawing.Point(0, 45);
            this.pn_Image.Name = "pn_Image";
            this.pn_Image.Size = new System.Drawing.Size(749, 601);
            this.pn_Image.TabIndex = 9;
            // 
            // UcPictureBox1
            // 
            this.UcPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcPictureBox1.Location = new System.Drawing.Point(2, 2);
            this.UcPictureBox1.Name = "UcPictureBox1";
            this.UcPictureBox1.Size = new System.Drawing.Size(745, 597);
            this.UcPictureBox1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 646);
            this.Controls.Add(this.pn_Image);
            this.Controls.Add(this.pn_Input);
            this.Controls.Add(this.pn_Top);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "Santei";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Top)).EndInit();
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Input)).EndInit();
            this.pn_Input.ResumeLayout(false);
            this.pn_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Button)).EndInit();
            this.pn_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pn_Image)).EndInit();
            this.pn_Image.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem bar_System;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_Logout;
        private DevExpress.XtraBars.BarButtonItem btn_Exit;
        private DevExpress.XtraBars.BarSubItem bar_Manager;
        private DevExpress.XtraBars.BarButtonItem btn_Batch;
        private DevExpress.XtraBars.BarButtonItem btn_User;
        private DevExpress.XtraBars.BarButtonItem btn_Check;
        private DevExpress.XtraBars.BarButtonItem btn_Progress;
        private DevExpress.XtraBars.BarButtonItem btn_Productivity;
        private DevExpress.XtraBars.BarButtonItem btn_ExportExcel;
        private DevExpress.XtraBars.BarButtonItem btn_ZoomImage;
        private DevExpress.XtraEditors.PanelControl pn_Image;
        private MyUserControl.UcPictureBox UcPictureBox1;
        private DevExpress.XtraEditors.PanelControl pn_Input;
        private DevExpress.XtraEditors.PanelControl pn_Button;
        private DevExpress.XtraEditors.PanelControl pn_Top;
        private DevExpress.XtraEditors.LabelControl lb_SoHinhLamDuoc;
        private DevExpress.XtraEditors.LabelControl lb_SoHinhConLai;
        private DevExpress.XtraEditors.LabelControl lb_4;
        private DevExpress.XtraEditors.LabelControl lb_TongSoHinh;
        private DevExpress.XtraEditors.LabelControl lb_3;
        private DevExpress.XtraEditors.LabelControl lb_UserName;
        private DevExpress.XtraEditors.LabelControl lb_IdImage;
        private DevExpress.XtraEditors.LabelControl lb_6;
        private DevExpress.XtraEditors.LabelControl lb_fBatchName;
        private DevExpress.XtraEditors.LabelControl lb_5;
        private DevExpress.XtraEditors.LabelControl lb_2;
        private DevExpress.XtraEditors.LabelControl lb_1;
        private DevExpress.XtraEditors.SimpleButton btn_Pause;
        private DevExpress.XtraEditors.SimpleButton btn_Submit_Logout;
        private DevExpress.XtraEditors.SimpleButton btn_Start_Submit;
        private MyUserControl.UcSantei UcNatsu1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem btn_FeedBack;
        private DevExpress.XtraBars.BarButtonItem btn_Start_Performance_Test;
        private DevExpress.XtraBars.BarButtonItem btn_Stop_Performance_Test;
    }
}

