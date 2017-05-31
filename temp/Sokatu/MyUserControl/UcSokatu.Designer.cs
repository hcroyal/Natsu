namespace Natsu.MyUserControl
{
    partial class UcSokatu
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
            this.UcNatsuItem1 = new Natsu.MyUserControl.UcSokatuItem();
            this.SuspendLayout();
            // 
            // UcNatsuItem1
            // 
            this.UcNatsuItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcNatsuItem1.Location = new System.Drawing.Point(0, 0);
            this.UcNatsuItem1.Name = "UcNatsuItem1";
            this.UcNatsuItem1.Size = new System.Drawing.Size(361, 139);
            this.UcNatsuItem1.TabIndex = 1;
            this.UcNatsuItem1.Load += new System.EventHandler(this.UcNatsuItem1_Load);
            // 
            // UcNatsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.UcNatsuItem1);
            this.Name = "UcNatsu";
            this.Size = new System.Drawing.Size(361, 139);
            this.ResumeLayout(false);

        }

        #endregion

        public UcSokatuItem UcNatsuItem1;
    }
}
