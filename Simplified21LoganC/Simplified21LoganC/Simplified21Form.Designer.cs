namespace Simplified21LoganC
{
    partial class frmSimplified21
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
            this.lstPlayerHand = new System.Windows.Forms.ListBox();
            this.lstDealerCards = new System.Windows.Forms.ListBox();
            this.grbDealer = new System.Windows.Forms.GroupBox();
            this.lblDealerSum = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.grbPlayer = new System.Windows.Forms.GroupBox();
            this.lblSplitSum = new System.Windows.Forms.Label();
            this.lstPlayerSplitHand = new System.Windows.Forms.ListBox();
            this.lblUserSum = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbDealer.SuspendLayout();
            this.grbPlayer.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPlayerHand
            // 
            this.lstPlayerHand.FormattingEnabled = true;
            this.lstPlayerHand.Location = new System.Drawing.Point(7, 19);
            this.lstPlayerHand.Name = "lstPlayerHand";
            this.lstPlayerHand.Size = new System.Drawing.Size(184, 95);
            this.lstPlayerHand.TabIndex = 0;
            // 
            // lstDealerCards
            // 
            this.lstDealerCards.FormattingEnabled = true;
            this.lstDealerCards.Location = new System.Drawing.Point(6, 20);
            this.lstDealerCards.Name = "lstDealerCards";
            this.lstDealerCards.Size = new System.Drawing.Size(184, 95);
            this.lstDealerCards.TabIndex = 1;
            // 
            // grbDealer
            // 
            this.grbDealer.Controls.Add(this.lblDealerSum);
            this.grbDealer.Controls.Add(this.lblDealerScore);
            this.grbDealer.Controls.Add(this.lstDealerCards);
            this.grbDealer.Location = new System.Drawing.Point(13, 41);
            this.grbDealer.Name = "grbDealer";
            this.grbDealer.Size = new System.Drawing.Size(369, 172);
            this.grbDealer.TabIndex = 2;
            this.grbDealer.TabStop = false;
            this.grbDealer.Text = "Dealer";
            // 
            // lblDealerSum
            // 
            this.lblDealerSum.AutoSize = true;
            this.lblDealerSum.Location = new System.Drawing.Point(211, 46);
            this.lblDealerSum.Name = "lblDealerSum";
            this.lblDealerSum.Size = new System.Drawing.Size(35, 13);
            this.lblDealerSum.TabIndex = 3;
            this.lblDealerSum.Text = "label1";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Location = new System.Drawing.Point(208, 29);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(81, 13);
            this.lblDealerScore.TabIndex = 2;
            this.lblDealerScore.Text = "Dealer Score: 0";
            // 
            // grbPlayer
            // 
            this.grbPlayer.Controls.Add(this.lblSplitSum);
            this.grbPlayer.Controls.Add(this.lstPlayerHand);
            this.grbPlayer.Controls.Add(this.lstPlayerSplitHand);
            this.grbPlayer.Controls.Add(this.lblUserSum);
            this.grbPlayer.Controls.Add(this.lblUserScore);
            this.grbPlayer.Controls.Add(this.btnStay);
            this.grbPlayer.Controls.Add(this.btnSplit);
            this.grbPlayer.Controls.Add(this.btnHit);
            this.grbPlayer.Location = new System.Drawing.Point(13, 219);
            this.grbPlayer.Name = "grbPlayer";
            this.grbPlayer.Size = new System.Drawing.Size(369, 198);
            this.grbPlayer.TabIndex = 3;
            this.grbPlayer.TabStop = false;
            this.grbPlayer.Text = "Player";
            // 
            // lblSplitSum
            // 
            this.lblSplitSum.AutoSize = true;
            this.lblSplitSum.Location = new System.Drawing.Point(108, 117);
            this.lblSplitSum.Name = "lblSplitSum";
            this.lblSplitSum.Size = new System.Drawing.Size(57, 13);
            this.lblSplitSum.TabIndex = 7;
            this.lblSplitSum.Text = "Split Sum: ";
            // 
            // lstPlayerSplitHand
            // 
            this.lstPlayerSplitHand.FormattingEnabled = true;
            this.lstPlayerSplitHand.Location = new System.Drawing.Point(117, 19);
            this.lstPlayerSplitHand.Name = "lstPlayerSplitHand";
            this.lstPlayerSplitHand.Size = new System.Drawing.Size(74, 95);
            this.lstPlayerSplitHand.TabIndex = 6;
            this.lstPlayerSplitHand.Visible = false;
            // 
            // lblUserSum
            // 
            this.lblUserSum.AutoSize = true;
            this.lblUserSum.Location = new System.Drawing.Point(6, 117);
            this.lblUserSum.Name = "lblUserSum";
            this.lblUserSum.Size = new System.Drawing.Size(56, 13);
            this.lblUserSum.TabIndex = 5;
            this.lblUserSum.Text = "Your Sum:";
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Location = new System.Drawing.Point(207, 36);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(72, 13);
            this.lblUserScore.TabIndex = 4;
            this.lblUserScore.Text = "Your Score: 0";
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(168, 154);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(75, 23);
            this.btnStay.TabIndex = 3;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(87, 154);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 2;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(6, 154);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 1;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(396, 24);
            this.mnuMenu.TabIndex = 4;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(132, 22);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(132, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(94, 153);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(162, 115);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play Blackjack!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 439);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbPlayer);
            this.Controls.Add(this.grbDealer);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21 by Logan Cantin";
            this.grbDealer.ResumeLayout(false);
            this.grbDealer.PerformLayout();
            this.grbPlayer.ResumeLayout(false);
            this.grbPlayer.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayerHand;
        private System.Windows.Forms.ListBox lstDealerCards;
        private System.Windows.Forms.GroupBox grbDealer;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.GroupBox grbPlayer;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblUserSum;
        private System.Windows.Forms.Label lblDealerSum;
        private System.Windows.Forms.ListBox lstPlayerSplitHand;
        private System.Windows.Forms.Label lblSplitSum;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Button btnPlay;
    }
}

