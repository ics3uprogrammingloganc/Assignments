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
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkPepper = new System.Windows.Forms.CheckBox();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.btnRemovePizza = new System.Windows.Forms.Button();
            this.lblPizzaCost = new System.Windows.Forms.Label();
            this.tbxPizzaCost = new System.Windows.Forms.TextBox();
            this.cmbPizza = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxSubtotal = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.gbxPizza = new System.Windows.Forms.GroupBox();
            this.gbxPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(111, 20);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 1;
            this.lblSize.Tag = "pizza";
            this.lblSize.Text = "Size:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(87, 53);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(54, 13);
            this.lblToppings.TabIndex = 3;
            this.lblToppings.Tag = "pizza";
            this.lblToppings.Text = "Toppings:";
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(299, 107);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 4;
            this.chkPepperoni.Tag = "pizza";
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(299, 131);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 5;
            this.chkOlives.Tag = "pizza";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(299, 155);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(57, 17);
            this.chkBacon.TabIndex = 6;
            this.chkBacon.Tag = "pizza";
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkPepper
            // 
            this.chkPepper.AutoSize = true;
            this.chkPepper.Location = new System.Drawing.Point(299, 179);
            this.chkPepper.Name = "chkPepper";
            this.chkPepper.Size = new System.Drawing.Size(60, 17);
            this.chkPepper.TabIndex = 7;
            this.chkPepper.Tag = "pizza";
            this.chkPepper.Text = "Pepper";
            this.chkPepper.UseVisualStyleBackColor = true;
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Location = new System.Drawing.Point(388, 22);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(75, 23);
            this.btnAddPizza.TabIndex = 8;
            this.btnAddPizza.Text = "Add Pizza";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            // 
            // btnRemovePizza
            // 
            this.btnRemovePizza.Location = new System.Drawing.Point(469, 22);
            this.btnRemovePizza.Name = "btnRemovePizza";
            this.btnRemovePizza.Size = new System.Drawing.Size(85, 23);
            this.btnRemovePizza.TabIndex = 9;
            this.btnRemovePizza.Text = "Remove Pizza";
            this.btnRemovePizza.UseVisualStyleBackColor = true;
            // 
            // lblPizzaCost
            // 
            this.lblPizzaCost.AutoSize = true;
            this.lblPizzaCost.Location = new System.Drawing.Point(52, 170);
            this.lblPizzaCost.Name = "lblPizzaCost";
            this.lblPizzaCost.Size = new System.Drawing.Size(89, 13);
            this.lblPizzaCost.TabIndex = 10;
            this.lblPizzaCost.Tag = "pizza";
            this.lblPizzaCost.Text = "Cost of this pizza:";
            // 
            // tbxPizzaCost
            // 
            this.tbxPizzaCost.Location = new System.Drawing.Point(147, 167);
            this.tbxPizzaCost.Name = "tbxPizzaCost";
            this.tbxPizzaCost.ReadOnly = true;
            this.tbxPizzaCost.Size = new System.Drawing.Size(135, 20);
            this.tbxPizzaCost.TabIndex = 11;
            this.tbxPizzaCost.Tag = "pizza";
            // 
            // cmbPizza
            // 
            this.cmbPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizza.FormattingEnabled = true;
            this.cmbPizza.Location = new System.Drawing.Point(152, 24);
            this.cmbPizza.Name = "cmbPizza";
            this.cmbPizza.Size = new System.Drawing.Size(121, 21);
            this.cmbPizza.TabIndex = 12;
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Medium",
            "Large",
            "Extra Large"});
            this.cmbSize.Location = new System.Drawing.Point(299, 72);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 21);
            this.cmbSize.TabIndex = 13;
            this.cmbSize.Tag = "pizza";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(235, 303);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(58, 13);
            this.lblSubtotal.TabIndex = 14;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(253, 332);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            // 
            // tbxSubtotal
            // 
            this.tbxSubtotal.Location = new System.Drawing.Point(299, 300);
            this.tbxSubtotal.Name = "tbxSubtotal";
            this.tbxSubtotal.ReadOnly = true;
            this.tbxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.tbxSubtotal.TabIndex = 16;
            this.tbxSubtotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(299, 329);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(100, 20);
            this.tbxTotal.TabIndex = 17;
            // 
            // gbxPizza
            // 
            this.gbxPizza.Controls.Add(this.tbxPizzaCost);
            this.gbxPizza.Controls.Add(this.lblPizzaCost);
            this.gbxPizza.Controls.Add(this.lblToppings);
            this.gbxPizza.Controls.Add(this.lblSize);
            this.gbxPizza.Location = new System.Drawing.Point(152, 55);
            this.gbxPizza.Name = "gbxPizza";
            this.gbxPizza.Size = new System.Drawing.Size(402, 224);
            this.gbxPizza.TabIndex = 18;
            this.gbxPizza.TabStop = false;
            this.gbxPizza.Tag = "Pizza";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 453);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbxSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.cmbPizza);
            this.Controls.Add(this.btnRemovePizza);
            this.Controls.Add(this.btnAddPizza);
            this.Controls.Add(this.chkPepper);
            this.Controls.Add(this.chkBacon);
            this.Controls.Add(this.chkOlives);
            this.Controls.Add(this.chkPepperoni);
            this.Controls.Add(this.gbxPizza);
            this.Name = "frmPizzaOrder";
            this.Text = "Form1";
            this.gbxPizza.ResumeLayout(false);
            this.gbxPizza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkPepper;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Button btnRemovePizza;
        private System.Windows.Forms.Label lblPizzaCost;
        private System.Windows.Forms.TextBox tbxPizzaCost;
        private System.Windows.Forms.ComboBox cmbPizza;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbxSubtotal;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.GroupBox gbxPizza;
    }
}

