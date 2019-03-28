namespace PizzaOrderLoganC
{
    partial class frmPizzaOrder
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNamePrompt = new System.Windows.Forms.Label();
            this.lblPhonePrompt = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.grbPizza = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnNewPizza = new System.Windows.Forms.Button();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.tbxSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlive = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.grbSides = new System.Windows.Forms.GroupBox();
            this.tbxTotalSides = new System.Windows.Forms.TextBox();
            this.btnSidesDone = new System.Windows.Forms.Button();
            this.tbxSubtotalSides = new System.Windows.Forms.TextBox();
            this.nudSauces = new System.Windows.Forms.NumericUpDown();
            this.lblTotalSides = new System.Windows.Forms.Label();
            this.lblSauces = new System.Windows.Forms.Label();
            this.lblSubtotalSides = new System.Windows.Forms.Label();
            this.nudDrinks = new System.Windows.Forms.NumericUpDown();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.tbxReceipt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grbPizza.SuspendLayout();
            this.grbSides.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSauces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(471, 46);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Luigi Pizza!";
            // 
            // lblNamePrompt
            // 
            this.lblNamePrompt.AutoSize = true;
            this.lblNamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePrompt.Location = new System.Drawing.Point(92, 142);
            this.lblNamePrompt.Name = "lblNamePrompt";
            this.lblNamePrompt.Size = new System.Drawing.Size(161, 25);
            this.lblNamePrompt.TabIndex = 1;
            this.lblNamePrompt.Text = "Enter your name:";
            // 
            // lblPhonePrompt
            // 
            this.lblPhonePrompt.AutoSize = true;
            this.lblPhonePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonePrompt.Location = new System.Drawing.Point(15, 190);
            this.lblPhonePrompt.Name = "lblPhonePrompt";
            this.lblPhonePrompt.Size = new System.Drawing.Size(238, 25);
            this.lblPhonePrompt.TabIndex = 2;
            this.lblPhonePrompt.Text = "Enter your phone number:";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(259, 139);
            this.tbxName.MaxLength = 20;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(203, 30);
            this.tbxName.TabIndex = 3;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(259, 187);
            this.tbxPhone.MaxLength = 10;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(203, 30);
            this.tbxPhone.TabIndex = 4;
            this.tbxPhone.TextChanged += new System.EventHandler(this.tbxPhone_TextChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(174, 261);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(154, 50);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order!";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // grbPizza
            // 
            this.grbPizza.Controls.Add(this.btnDone);
            this.grbPizza.Controls.Add(this.btnNewPizza);
            this.grbPizza.Controls.Add(this.tbxTotal);
            this.grbPizza.Controls.Add(this.tbxSubtotal);
            this.grbPizza.Controls.Add(this.lblTotal);
            this.grbPizza.Controls.Add(this.lblSubtotal);
            this.grbPizza.Controls.Add(this.chkOnion);
            this.grbPizza.Controls.Add(this.chkOlive);
            this.grbPizza.Controls.Add(this.chkPepperoni);
            this.grbPizza.Controls.Add(this.chkMushroom);
            this.grbPizza.Controls.Add(this.lblToppings);
            this.grbPizza.Controls.Add(this.lblSize);
            this.grbPizza.Controls.Add(this.cmbSize);
            this.grbPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPizza.Location = new System.Drawing.Point(13, 323);
            this.grbPizza.Name = "grbPizza";
            this.grbPizza.Size = new System.Drawing.Size(336, 354);
            this.grbPizza.TabIndex = 6;
            this.grbPizza.TabStop = false;
            this.grbPizza.Text = "Pizza #1";
            this.grbPizza.Visible = false;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(202, 302);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(97, 34);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnNewPizza
            // 
            this.btnNewPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPizza.Location = new System.Drawing.Point(46, 302);
            this.btnNewPizza.Name = "btnNewPizza";
            this.btnNewPizza.Size = new System.Drawing.Size(138, 35);
            this.btnNewPizza.TabIndex = 11;
            this.btnNewPizza.Text = "New Pizza";
            this.btnNewPizza.UseVisualStyleBackColor = true;
            this.btnNewPizza.Click += new System.EventHandler(this.btnNewPizza_Click);
            // 
            // tbxTotal
            // 
            this.tbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotal.Location = new System.Drawing.Point(168, 253);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(100, 30);
            this.tbxTotal.TabIndex = 10;
            // 
            // tbxSubtotal
            // 
            this.tbxSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubtotal.Location = new System.Drawing.Point(168, 214);
            this.tbxSubtotal.Name = "tbxSubtotal";
            this.tbxSubtotal.ReadOnly = true;
            this.tbxSubtotal.Size = new System.Drawing.Size(100, 30);
            this.tbxSubtotal.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(94, 253);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(67, 219);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(99, 25);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(168, 177);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(65, 21);
            this.chkOnion.TabIndex = 6;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkOlive
            // 
            this.chkOlive.AutoSize = true;
            this.chkOlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlive.Location = new System.Drawing.Point(168, 150);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(59, 21);
            this.chkOlive.TabIndex = 5;
            this.chkOlive.Text = "Olive";
            this.chkOlive.UseVisualStyleBackColor = true;
            this.chkOlive.CheckedChanged += new System.EventHandler(this.chkOlive_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepperoni.Location = new System.Drawing.Point(168, 123);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(92, 21);
            this.chkPepperoni.TabIndex = 4;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chkPepperoni_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushroom.Location = new System.Drawing.Point(168, 96);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(93, 21);
            this.chkMushroom.TabIndex = 3;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(62, 90);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(100, 25);
            this.lblToppings.TabIndex = 2;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(105, 55);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(57, 25);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size:";
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Medium",
            "Large",
            "X-Large",
            "-Select a size-"});
            this.cmbSize.Location = new System.Drawing.Point(168, 55);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 24);
            this.cmbSize.TabIndex = 0;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // grbSides
            // 
            this.grbSides.Controls.Add(this.tbxTotalSides);
            this.grbSides.Controls.Add(this.btnSidesDone);
            this.grbSides.Controls.Add(this.tbxSubtotalSides);
            this.grbSides.Controls.Add(this.nudSauces);
            this.grbSides.Controls.Add(this.lblTotalSides);
            this.grbSides.Controls.Add(this.lblSauces);
            this.grbSides.Controls.Add(this.lblSubtotalSides);
            this.grbSides.Controls.Add(this.nudDrinks);
            this.grbSides.Controls.Add(this.lblDrinks);
            this.grbSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSides.Location = new System.Drawing.Point(417, 323);
            this.grbSides.Name = "grbSides";
            this.grbSides.Size = new System.Drawing.Size(323, 354);
            this.grbSides.TabIndex = 7;
            this.grbSides.TabStop = false;
            this.grbSides.Text = "Sides";
            this.grbSides.Visible = false;
            // 
            // tbxTotalSides
            // 
            this.tbxTotalSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalSides.Location = new System.Drawing.Point(153, 225);
            this.tbxTotalSides.Name = "tbxTotalSides";
            this.tbxTotalSides.ReadOnly = true;
            this.tbxTotalSides.Size = new System.Drawing.Size(100, 30);
            this.tbxTotalSides.TabIndex = 14;
            // 
            // btnSidesDone
            // 
            this.btnSidesDone.Location = new System.Drawing.Point(113, 302);
            this.btnSidesDone.Name = "btnSidesDone";
            this.btnSidesDone.Size = new System.Drawing.Size(127, 43);
            this.btnSidesDone.TabIndex = 4;
            this.btnSidesDone.Text = "Done";
            this.btnSidesDone.UseVisualStyleBackColor = true;
            this.btnSidesDone.Click += new System.EventHandler(this.btnSidesDone_Click);
            // 
            // tbxSubtotalSides
            // 
            this.tbxSubtotalSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubtotalSides.Location = new System.Drawing.Point(153, 186);
            this.tbxSubtotalSides.Name = "tbxSubtotalSides";
            this.tbxSubtotalSides.ReadOnly = true;
            this.tbxSubtotalSides.Size = new System.Drawing.Size(100, 30);
            this.tbxSubtotalSides.TabIndex = 13;
            // 
            // nudSauces
            // 
            this.nudSauces.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSauces.Location = new System.Drawing.Point(144, 113);
            this.nudSauces.Name = "nudSauces";
            this.nudSauces.Size = new System.Drawing.Size(120, 30);
            this.nudSauces.TabIndex = 3;
            this.nudSauces.ValueChanged += new System.EventHandler(this.nudSauces_ValueChanged);
            // 
            // lblTotalSides
            // 
            this.lblTotalSides.AutoSize = true;
            this.lblTotalSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSides.Location = new System.Drawing.Point(79, 225);
            this.lblTotalSides.Name = "lblTotalSides";
            this.lblTotalSides.Size = new System.Drawing.Size(68, 25);
            this.lblTotalSides.TabIndex = 12;
            this.lblTotalSides.Text = "Total:";
            // 
            // lblSauces
            // 
            this.lblSauces.AutoSize = true;
            this.lblSauces.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSauces.Location = new System.Drawing.Point(52, 115);
            this.lblSauces.Name = "lblSauces";
            this.lblSauces.Size = new System.Drawing.Size(85, 25);
            this.lblSauces.TabIndex = 2;
            this.lblSauces.Text = "Sauces:";
            // 
            // lblSubtotalSides
            // 
            this.lblSubtotalSides.AutoSize = true;
            this.lblSubtotalSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalSides.Location = new System.Drawing.Point(52, 191);
            this.lblSubtotalSides.Name = "lblSubtotalSides";
            this.lblSubtotalSides.Size = new System.Drawing.Size(99, 25);
            this.lblSubtotalSides.TabIndex = 11;
            this.lblSubtotalSides.Text = "Subtotal:";
            // 
            // nudDrinks
            // 
            this.nudDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDrinks.Location = new System.Drawing.Point(144, 65);
            this.nudDrinks.Name = "nudDrinks";
            this.nudDrinks.Size = new System.Drawing.Size(120, 30);
            this.nudDrinks.TabIndex = 1;
            this.nudDrinks.ValueChanged += new System.EventHandler(this.nudDrinks_ValueChanged);
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinks.Location = new System.Drawing.Point(65, 67);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(73, 25);
            this.lblDrinks.TabIndex = 0;
            this.lblDrinks.Text = "Drinks:";
            // 
            // tbxReceipt
            // 
            this.tbxReceipt.Location = new System.Drawing.Point(841, 83);
            this.tbxReceipt.Multiline = true;
            this.tbxReceipt.Name = "tbxReceipt";
            this.tbxReceipt.ReadOnly = true;
            this.tbxReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxReceipt.Size = new System.Drawing.Size(490, 585);
            this.tbxReceipt.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1367, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRestart,
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniRestart
            // 
            this.mniRestart.Name = "mniRestart";
            this.mniRestart.Size = new System.Drawing.Size(180, 22);
            this.mniRestart.Text = "Restart";
            this.mniRestart.Click += new System.EventHandler(this.mniRestart_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 725);
            this.Controls.Add(this.tbxReceipt);
            this.Controls.Add(this.grbSides);
            this.Controls.Add(this.grbPizza);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblPhonePrompt);
            this.Controls.Add(this.lblNamePrompt);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order by Logan Cantin";
            this.grbPizza.ResumeLayout(false);
            this.grbPizza.PerformLayout();
            this.grbSides.ResumeLayout(false);
            this.grbSides.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSauces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNamePrompt;
        private System.Windows.Forms.Label lblPhonePrompt;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox grbPizza;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlive;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.TextBox tbxSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnNewPizza;
        private System.Windows.Forms.GroupBox grbSides;
        private System.Windows.Forms.TextBox tbxTotalSides;
        private System.Windows.Forms.Button btnSidesDone;
        private System.Windows.Forms.TextBox tbxSubtotalSides;
        private System.Windows.Forms.NumericUpDown nudSauces;
        private System.Windows.Forms.Label lblTotalSides;
        private System.Windows.Forms.Label lblSauces;
        private System.Windows.Forms.Label lblSubtotalSides;
        private System.Windows.Forms.NumericUpDown nudDrinks;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.TextBox tbxReceipt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniRestart;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

