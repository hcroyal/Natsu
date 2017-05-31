﻿namespace Natsu.MyUserControl
{
    partial class UcPictureBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageBox1 = new ImageGlass.ImageBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.trackBar_Ngang = new System.Windows.Forms.TrackBar();
            this.btn_xoayphai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoaytrai = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar_Doc = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Ngang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Doc)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.GridColor = System.Drawing.Color.White;
            this.imageBox1.HorizontalScrollBarStyle = ImageGlass.ImageBoxScrollBarStyle.Hide;
            this.imageBox1.Location = new System.Drawing.Point(2, 2);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(743, 444);
            this.imageBox1.TabIndex = 1;
            this.imageBox1.VerticalScrollBarStyle = ImageGlass.ImageBoxScrollBarStyle.Hide;
            this.imageBox1.MouseLeave += new System.EventHandler(this.imageBox1_MouseLeave);
            this.imageBox1.MouseHover += new System.EventHandler(this.imageBox1_MouseHover);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseMove);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.trackBar_Ngang);
            this.panelControl1.Controls.Add(this.btn_xoayphai);
            this.panelControl1.Controls.Add(this.btn_Xoaytrai);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 452);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(778, 29);
            this.panelControl1.TabIndex = 4;
            // 
            // trackBar_Ngang
            // 
            this.trackBar_Ngang.Location = new System.Drawing.Point(5, 3);
            this.trackBar_Ngang.Maximum = 3000;
            this.trackBar_Ngang.Name = "trackBar_Ngang";
            this.trackBar_Ngang.Size = new System.Drawing.Size(300, 45);
            this.trackBar_Ngang.TabIndex = 2;
            this.trackBar_Ngang.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Ngang.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_Ngang_MouseUp);
            // 
            // btn_xoayphai
            // 
            this.btn_xoayphai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoayphai.Location = new System.Drawing.Point(597, 4);
            this.btn_xoayphai.Name = "btn_xoayphai";
            this.btn_xoayphai.Size = new System.Drawing.Size(75, 23);
            this.btn_xoayphai.TabIndex = 5;
            this.btn_xoayphai.Text = "Rotate right";
            this.btn_xoayphai.Click += new System.EventHandler(this.btn_xoayphai_Click);
            // 
            // btn_Xoaytrai
            // 
            this.btn_Xoaytrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoaytrai.Location = new System.Drawing.Point(516, 4);
            this.btn_Xoaytrai.Name = "btn_Xoaytrai";
            this.btn_Xoaytrai.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoaytrai.TabIndex = 4;
            this.btn_Xoaytrai.Text = "Rotate left";
            this.btn_Xoaytrai.Click += new System.EventHandler(this.btn_Xoaytrai_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.panel1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(778, 452);
            this.panelControl2.TabIndex = 5;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.imageBox1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(747, 448);
            this.panelControl3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar_Doc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(749, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 448);
            this.panel1.TabIndex = 4;
            // 
            // trackBar_Doc
            // 
            this.trackBar_Doc.Location = new System.Drawing.Point(3, 67);
            this.trackBar_Doc.Maximum = 3000;
            this.trackBar_Doc.Name = "trackBar_Doc";
            this.trackBar_Doc.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Doc.Size = new System.Drawing.Size(45, 300);
            this.trackBar_Doc.TabIndex = 3;
            this.trackBar_Doc.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Doc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_Doc_MouseUp);
            // 
            // UcPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "UcPictureBox";
            this.Size = new System.Drawing.Size(778, 481);
            this.Load += new System.EventHandler(this.uc_PictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Ngang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Doc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ImageGlass.ImageBox imageBox1;
        public System.Windows.Forms.TrackBar trackBar_Ngang;
        public System.Windows.Forms.TrackBar trackBar_Doc;
        public DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btn_xoayphai;
        public DevExpress.XtraEditors.SimpleButton btn_Xoaytrai;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraEditors.PanelControl panelControl3;
        public System.Windows.Forms.Panel panel1;
    }
}
