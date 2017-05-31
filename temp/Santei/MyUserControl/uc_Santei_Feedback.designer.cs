namespace Natsu.MyUserControl
{
    partial class uc_Santei_Feedback
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ucPictureBox1 = new Natsu.MyUserControl.UcPictureBox();
            this.UcNatsuItemFeedback31 = new Natsu.MyUserControl.UcSanteiItemFeedback3();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.textBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(36, 500);
            this.panelControl2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 21);
            this.textBox1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.ucPictureBox1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(36, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(879, 500);
            this.panelControl3.TabIndex = 12;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.UcNatsuItemFeedback31);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(915, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(585, 500);
            this.panelControl1.TabIndex = 10;
            // 
            // ucPictureBox1
            // 
            this.ucPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPictureBox1.Location = new System.Drawing.Point(2, 2);
            this.ucPictureBox1.Name = "ucPictureBox1";
            this.ucPictureBox1.Size = new System.Drawing.Size(875, 496);
            this.ucPictureBox1.TabIndex = 0;
            // 
            // UcNatsuItemFeedback31
            // 
            this.UcNatsuItemFeedback31.AutoScroll = true;
            this.UcNatsuItemFeedback31.AutoSize = true;
            this.UcNatsuItemFeedback31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UcNatsuItemFeedback31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcNatsuItemFeedback31.Location = new System.Drawing.Point(2, 2);
            this.UcNatsuItemFeedback31.Name = "UcNatsuItemFeedback31";
            this.UcNatsuItemFeedback31.Size = new System.Drawing.Size(581, 496);
            this.UcNatsuItemFeedback31.TabIndex = 0;
            // 
            // uc_Natsu_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "uc_Natsu_Feedback";
            this.Size = new System.Drawing.Size(1500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        public System.Windows.Forms.TextBox textBox1;
        public DevExpress.XtraEditors.PanelControl panelControl3;
        public UcPictureBox ucPictureBox1;
        public UcSanteiItemFeedback3 UcNatsuItemFeedback31;
    }
}
