namespace Assignment2_FallingObjectsLoganC
{
    partial class frmFallingObjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFallingObjects));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pbxBall = new System.Windows.Forms.PictureBox();
            this.pbxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(46, 54);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(246, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter the time since ball was dropped (in seconds):";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(49, 212);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 1;
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(49, 120);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(100, 20);
            this.tbxInput.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(168, 120);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pbxBall
            // 
            this.pbxBall.BackColor = System.Drawing.Color.Transparent;
            this.pbxBall.Image = global::Assignment2_FallingObjectsLoganC.Properties.Resources.ball;
            this.pbxBall.Location = new System.Drawing.Point(499, 52);
            this.pbxBall.Name = "pbxBall";
            this.pbxBall.Size = new System.Drawing.Size(41, 41);
            this.pbxBall.TabIndex = 5;
            this.pbxBall.TabStop = false;
            // 
            // pbxBackground
            // 
            this.pbxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pbxBackground.Image")));
            this.pbxBackground.Location = new System.Drawing.Point(365, 12);
            this.pbxBackground.Name = "pbxBackground";
            this.pbxBackground.Size = new System.Drawing.Size(431, 490);
            this.pbxBackground.TabIndex = 4;
            this.pbxBackground.TabStop = false;
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 556);
            this.Controls.Add(this.pbxBall);
            this.Controls.Add(this.pbxBackground);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmFallingObjects";
            this.Text = "Assignment 2 - Falling Objects by Logan C";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox pbxBackground;
        private System.Windows.Forms.PictureBox pbxBall;
    }
}

