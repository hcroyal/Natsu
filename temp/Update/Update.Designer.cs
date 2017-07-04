namespace Update
{
    partial class Update
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Project = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Version = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Path = new DevExpress.XtraEditors.TextEdit();
            this.btn_Browser = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Path.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(193, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "UPDATE";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(307, 65);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 1;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Auto Update"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Update Manual")});
            this.radioGroup1.Size = new System.Drawing.Size(135, 73);
            this.radioGroup1.TabIndex = 1;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 242);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(463, 35);
            this.progressBarControl1.TabIndex = 2;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(182, 191);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(97, 35);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Chương trình:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Version:";
            // 
            // lbl_Project
            // 
            this.lbl_Project.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Project.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_Project.Appearance.Options.UseFont = true;
            this.lbl_Project.Appearance.Options.UseForeColor = true;
            this.lbl_Project.Location = new System.Drawing.Point(97, 77);
            this.lbl_Project.Name = "lbl_Project";
            this.lbl_Project.Size = new System.Drawing.Size(89, 16);
            this.lbl_Project.TabIndex = 4;
            this.lbl_Project.Text = "Chương trình:";
            // 
            // lbl_Version
            // 
            this.lbl_Version.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Version.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Version.Appearance.Options.UseFont = true;
            this.lbl_Version.Appearance.Options.UseForeColor = true;
            this.lbl_Version.Location = new System.Drawing.Point(97, 114);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(89, 16);
            this.lbl_Version.TabIndex = 4;
            this.lbl_Version.Text = "Chương trình:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Save:";
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(58, 155);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(315, 20);
            this.txt_Path.TabIndex = 5;
            // 
            // btn_Browser
            // 
            this.btn_Browser.Location = new System.Drawing.Point(379, 153);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(63, 23);
            this.btn_Browser.TabIndex = 6;
            this.btn_Browser.Text = "Browser...";
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 277);
            this.Controls.Add(this.btn_Browser);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_Project);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.labelControl1);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Path.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbl_Project;
        private DevExpress.XtraEditors.LabelControl lbl_Version;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Path;
        private DevExpress.XtraEditors.SimpleButton btn_Browser;
    }
}