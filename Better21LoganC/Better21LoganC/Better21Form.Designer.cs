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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSetup = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.chkAI1 = new System.Windows.Forms.CheckBox();
            this.chkAI2 = new System.Windows.Forms.CheckBox();
            this.tbxAIName1 = new System.Windows.Forms.TextBox();
            this.cmbDifficulty1 = new System.Windows.Forms.ComboBox();
            this.tbxAI2name = new System.Windows.Forms.TextBox();
            this.cmbDifficulty2 = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // grbSetup
            // 
            this.grbSetup.Controls.Add(this.label4);
            this.grbSetup.Controls.Add(this.label3);
            this.grbSetup.Controls.Add(this.label2);
            this.grbSetup.Controls.Add(this.label1);
            this.grbSetup.Controls.Add(this.btnStart);
            this.grbSetup.Controls.Add(this.cmbDifficulty2);
            this.grbSetup.Controls.Add(this.tbxAI2name);
            this.grbSetup.Controls.Add(this.cmbDifficulty1);
            this.grbSetup.Controls.Add(this.tbxAIName1);
            this.grbSetup.Controls.Add(this.chkAI2);
            this.grbSetup.Controls.Add(this.chkAI1);
            this.grbSetup.Controls.Add(this.tbxUsername);
            this.grbSetup.Controls.Add(this.lblUserName);
            this.grbSetup.Location = new System.Drawing.Point(203, 138);
            this.grbSetup.Name = "grbSetup";
            this.grbSetup.Size = new System.Drawing.Size(723, 375);
            this.grbSetup.TabIndex = 2;
            this.grbSetup.TabStop = false;
            this.grbSetup.Text = "groupBox1";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(127, 39);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Your Name:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(196, 36);
            this.tbxUsername.MaxLength = 15;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 1;
            // 
            // chkAI1
            // 
            this.chkAI1.AutoSize = true;
            this.chkAI1.Location = new System.Drawing.Point(196, 77);
            this.chkAI1.Name = "chkAI1";
            this.chkAI1.Size = new System.Drawing.Size(82, 17);
            this.chkAI1.TabIndex = 2;
            this.chkAI1.Text = "AI player 1?";
            this.chkAI1.UseVisualStyleBackColor = true;
            this.chkAI1.CheckedChanged += new System.EventHandler(this.ChkAI1_CheckedChanged);
            // 
            // chkAI2
            // 
            this.chkAI2.AutoSize = true;
            this.chkAI2.Location = new System.Drawing.Point(196, 153);
            this.chkAI2.Name = "chkAI2";
            this.chkAI2.Size = new System.Drawing.Size(82, 17);
            this.chkAI2.TabIndex = 3;
            this.chkAI2.Text = "AI player 2?";
            this.chkAI2.UseVisualStyleBackColor = true;
            this.chkAI2.CheckedChanged += new System.EventHandler(this.ChkAI2_CheckedChanged);
            // 
            // tbxAIName1
            // 
            this.tbxAIName1.Enabled = false;
            this.tbxAIName1.Location = new System.Drawing.Point(277, 100);
            this.tbxAIName1.MaxLength = 15;
            this.tbxAIName1.Name = "tbxAIName1";
            this.tbxAIName1.Size = new System.Drawing.Size(100, 20);
            this.tbxAIName1.TabIndex = 4;
            // 
            // cmbDifficulty1
            // 
            this.cmbDifficulty1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty1.Enabled = false;
            this.cmbDifficulty1.FormattingEnabled = true;
            this.cmbDifficulty1.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Extreme"});
            this.cmbDifficulty1.Location = new System.Drawing.Point(277, 126);
            this.cmbDifficulty1.Name = "cmbDifficulty1";
            this.cmbDifficulty1.Size = new System.Drawing.Size(121, 21);
            this.cmbDifficulty1.TabIndex = 6;
            // 
            // tbxAI2name
            // 
            this.tbxAI2name.Enabled = false;
            this.tbxAI2name.Location = new System.Drawing.Point(277, 176);
            this.tbxAI2name.MaxLength = 15;
            this.tbxAI2name.Name = "tbxAI2name";
            this.tbxAI2name.Size = new System.Drawing.Size(100, 20);
            this.tbxAI2name.TabIndex = 7;
            // 
            // cmbDifficulty2
            // 
            this.cmbDifficulty2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty2.Enabled = false;
            this.cmbDifficulty2.FormattingEnabled = true;
            this.cmbDifficulty2.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Extreme"});
            this.cmbDifficulty2.Location = new System.Drawing.Point(277, 202);
            this.cmbDifficulty2.Name = "cmbDifficulty2";
            this.cmbDifficulty2.Size = new System.Drawing.Size(121, 21);
            this.cmbDifficulty2.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(196, 267);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "difficulty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "difficulty:";
            // 
            // frmBetter21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.grbSetup);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBetter21";
            this.Text = "Better 21 by Logan Cantin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbSetup.ResumeLayout(false);
            this.grbSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbSetup;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbDifficulty2;
        private System.Windows.Forms.TextBox tbxAI2name;
        private System.Windows.Forms.ComboBox cmbDifficulty1;
        private System.Windows.Forms.TextBox tbxAIName1;
        private System.Windows.Forms.CheckBox chkAI2;
        private System.Windows.Forms.CheckBox chkAI1;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

