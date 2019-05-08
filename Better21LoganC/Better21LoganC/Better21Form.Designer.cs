namespace Better21LoganC
{
    partial class frmBetter21
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
            this.pbxTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTest
            // 
            this.pbxTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxTest.Location = new System.Drawing.Point(172, 82);
            this.pbxTest.Name = "pbxTest";
            this.pbxTest.Size = new System.Drawing.Size(112, 159);
            this.pbxTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTest.TabIndex = 0;
            this.pbxTest.TabStop = false;
            // 
            // frmBetter21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 336);
            this.Controls.Add(this.pbxTest);
            this.Name = "frmBetter21";
            this.Text = "Better 21 by Logan Cantin";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxTest;
    }
}

