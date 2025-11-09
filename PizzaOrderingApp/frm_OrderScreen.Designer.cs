namespace PizzaOrderingApp
{
    partial class frm_OrderScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OrderScreen));
            this.lbl_MainAddress = new System.Windows.Forms.Label();
            this.gb_PizzaSize = new System.Windows.Forms.GroupBox();
            this.rad_Medium = new System.Windows.Forms.RadioButton();
            this.rad_Big = new System.Windows.Forms.RadioButton();
            this.rad_small = new System.Windows.Forms.RadioButton();
            this.gb_CrustType = new System.Windows.Forms.GroupBox();
            this.rad_ThickCrust = new System.Windows.Forms.RadioButton();
            this.rad_ThinCrust = new System.Windows.Forms.RadioButton();
            this.gb_Toppings = new System.Windows.Forms.GroupBox();
            this.chk_Papper = new System.Windows.Forms.CheckBox();
            this.chk_Mashrom = new System.Windows.Forms.CheckBox();
            this.chk_Olives = new System.Windows.Forms.CheckBox();
            this.chk_Tomato = new System.Windows.Forms.CheckBox();
            this.chk_Onion = new System.Windows.Forms.CheckBox();
            this.chk_ExtraChess = new System.Windows.Forms.CheckBox();
            this.gb_WhereToEat = new System.Windows.Forms.GroupBox();
            this.rad_TakeOut = new System.Windows.Forms.RadioButton();
            this.rad_EatIn = new System.Windows.Forms.RadioButton();
            this.lab_TotalPriceLable = new System.Windows.Forms.Label();
            this.lab_TotalPrice = new System.Windows.Forms.Label();
            this.btn_ConfirmOrder = new System.Windows.Forms.Button();
            this.btn_ResetOrder = new System.Windows.Forms.Button();
            this.gb_PizzaSize.SuspendLayout();
            this.gb_CrustType.SuspendLayout();
            this.gb_Toppings.SuspendLayout();
            this.gb_WhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_MainAddress
            // 
            this.lbl_MainAddress.AutoSize = true;
            this.lbl_MainAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainAddress.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainAddress.ForeColor = System.Drawing.Color.White;
            this.lbl_MainAddress.Location = new System.Drawing.Point(67, 48);
            this.lbl_MainAddress.Name = "lbl_MainAddress";
            this.lbl_MainAddress.Size = new System.Drawing.Size(656, 97);
            this.lbl_MainAddress.TabIndex = 1;
            this.lbl_MainAddress.Text = "MAKE YOUR PIZZA";
            // 
            // gb_PizzaSize
            // 
            this.gb_PizzaSize.BackColor = System.Drawing.Color.Transparent;
            this.gb_PizzaSize.Controls.Add(this.rad_Medium);
            this.gb_PizzaSize.Controls.Add(this.rad_Big);
            this.gb_PizzaSize.Controls.Add(this.rad_small);
            this.gb_PizzaSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_PizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_PizzaSize.ForeColor = System.Drawing.Color.White;
            this.gb_PizzaSize.Location = new System.Drawing.Point(84, 211);
            this.gb_PizzaSize.Name = "gb_PizzaSize";
            this.gb_PizzaSize.Size = new System.Drawing.Size(165, 131);
            this.gb_PizzaSize.TabIndex = 2;
            this.gb_PizzaSize.TabStop = false;
            this.gb_PizzaSize.Text = "Size";
            // 
            // rad_Medium
            // 
            this.rad_Medium.AutoSize = true;
            this.rad_Medium.BackColor = System.Drawing.Color.Transparent;
            this.rad_Medium.Checked = true;
            this.rad_Medium.ForeColor = System.Drawing.Color.White;
            this.rad_Medium.Location = new System.Drawing.Point(6, 62);
            this.rad_Medium.Name = "rad_Medium";
            this.rad_Medium.Size = new System.Drawing.Size(89, 24);
            this.rad_Medium.TabIndex = 5;
            this.rad_Medium.TabStop = true;
            this.rad_Medium.Tag = "10";
            this.rad_Medium.Text = "Medium";
            this.rad_Medium.UseVisualStyleBackColor = false;
            this.rad_Medium.CheckedChanged += new System.EventHandler(this.rad_Medium_CheckedChanged);
            // 
            // rad_Big
            // 
            this.rad_Big.AutoSize = true;
            this.rad_Big.BackColor = System.Drawing.Color.Transparent;
            this.rad_Big.ForeColor = System.Drawing.Color.White;
            this.rad_Big.Location = new System.Drawing.Point(6, 88);
            this.rad_Big.Name = "rad_Big";
            this.rad_Big.Size = new System.Drawing.Size(55, 24);
            this.rad_Big.TabIndex = 4;
            this.rad_Big.Tag = "15";
            this.rad_Big.Text = "Big";
            this.rad_Big.UseVisualStyleBackColor = false;
            this.rad_Big.CheckedChanged += new System.EventHandler(this.rad_Big_CheckedChanged);
            // 
            // rad_small
            // 
            this.rad_small.AutoSize = true;
            this.rad_small.BackColor = System.Drawing.Color.Transparent;
            this.rad_small.ForeColor = System.Drawing.Color.White;
            this.rad_small.Location = new System.Drawing.Point(6, 36);
            this.rad_small.Name = "rad_small";
            this.rad_small.Size = new System.Drawing.Size(72, 24);
            this.rad_small.TabIndex = 3;
            this.rad_small.Tag = "5";
            this.rad_small.Text = "Small";
            this.rad_small.UseVisualStyleBackColor = false;
            this.rad_small.CheckedChanged += new System.EventHandler(this.rad_small_CheckedChanged);
            // 
            // gb_CrustType
            // 
            this.gb_CrustType.BackColor = System.Drawing.Color.Transparent;
            this.gb_CrustType.Controls.Add(this.rad_ThickCrust);
            this.gb_CrustType.Controls.Add(this.rad_ThinCrust);
            this.gb_CrustType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_CrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CrustType.ForeColor = System.Drawing.Color.White;
            this.gb_CrustType.Location = new System.Drawing.Point(84, 397);
            this.gb_CrustType.Name = "gb_CrustType";
            this.gb_CrustType.Size = new System.Drawing.Size(165, 111);
            this.gb_CrustType.TabIndex = 6;
            this.gb_CrustType.TabStop = false;
            this.gb_CrustType.Text = "Crust";
            // 
            // rad_ThickCrust
            // 
            this.rad_ThickCrust.AutoSize = true;
            this.rad_ThickCrust.BackColor = System.Drawing.Color.Transparent;
            this.rad_ThickCrust.ForeColor = System.Drawing.Color.White;
            this.rad_ThickCrust.Location = new System.Drawing.Point(6, 62);
            this.rad_ThickCrust.Name = "rad_ThickCrust";
            this.rad_ThickCrust.Size = new System.Drawing.Size(70, 24);
            this.rad_ThickCrust.TabIndex = 5;
            this.rad_ThickCrust.Tag = "5";
            this.rad_ThickCrust.Text = "Thick";
            this.rad_ThickCrust.UseVisualStyleBackColor = false;
            this.rad_ThickCrust.CheckedChanged += new System.EventHandler(this.rad_ThickCrust_CheckedChanged);
            // 
            // rad_ThinCrust
            // 
            this.rad_ThinCrust.AutoSize = true;
            this.rad_ThinCrust.BackColor = System.Drawing.Color.Transparent;
            this.rad_ThinCrust.Checked = true;
            this.rad_ThinCrust.ForeColor = System.Drawing.Color.White;
            this.rad_ThinCrust.Location = new System.Drawing.Point(6, 36);
            this.rad_ThinCrust.Name = "rad_ThinCrust";
            this.rad_ThinCrust.Size = new System.Drawing.Size(62, 24);
            this.rad_ThinCrust.TabIndex = 3;
            this.rad_ThinCrust.TabStop = true;
            this.rad_ThinCrust.Tag = "0";
            this.rad_ThinCrust.Text = "Thin";
            this.rad_ThinCrust.UseVisualStyleBackColor = false;
            this.rad_ThinCrust.CheckedChanged += new System.EventHandler(this.rad_ThinCrust_CheckedChanged);
            // 
            // gb_Toppings
            // 
            this.gb_Toppings.BackColor = System.Drawing.Color.Transparent;
            this.gb_Toppings.Controls.Add(this.chk_Papper);
            this.gb_Toppings.Controls.Add(this.chk_Mashrom);
            this.gb_Toppings.Controls.Add(this.chk_Olives);
            this.gb_Toppings.Controls.Add(this.chk_Tomato);
            this.gb_Toppings.Controls.Add(this.chk_Onion);
            this.gb_Toppings.Controls.Add(this.chk_ExtraChess);
            this.gb_Toppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Toppings.ForeColor = System.Drawing.Color.White;
            this.gb_Toppings.Location = new System.Drawing.Point(400, 211);
            this.gb_Toppings.Name = "gb_Toppings";
            this.gb_Toppings.Size = new System.Drawing.Size(270, 131);
            this.gb_Toppings.TabIndex = 6;
            this.gb_Toppings.TabStop = false;
            this.gb_Toppings.Text = "Toppings";
            // 
            // chk_Papper
            // 
            this.chk_Papper.AutoSize = true;
            this.chk_Papper.Location = new System.Drawing.Point(159, 88);
            this.chk_Papper.Name = "chk_Papper";
            this.chk_Papper.Size = new System.Drawing.Size(84, 24);
            this.chk_Papper.TabIndex = 5;
            this.chk_Papper.Tag = "2";
            this.chk_Papper.Text = "Papper";
            this.chk_Papper.UseVisualStyleBackColor = true;
            this.chk_Papper.CheckedChanged += new System.EventHandler(this.chk_Papper_CheckedChanged);
            // 
            // chk_Mashrom
            // 
            this.chk_Mashrom.AutoSize = true;
            this.chk_Mashrom.Location = new System.Drawing.Point(159, 58);
            this.chk_Mashrom.Name = "chk_Mashrom";
            this.chk_Mashrom.Size = new System.Drawing.Size(101, 24);
            this.chk_Mashrom.TabIndex = 4;
            this.chk_Mashrom.Tag = "5";
            this.chk_Mashrom.Text = "Mashrom";
            this.chk_Mashrom.UseVisualStyleBackColor = true;
            this.chk_Mashrom.CheckedChanged += new System.EventHandler(this.chk_Mashrom_CheckedChanged);
            // 
            // chk_Olives
            // 
            this.chk_Olives.AutoSize = true;
            this.chk_Olives.Location = new System.Drawing.Point(159, 29);
            this.chk_Olives.Name = "chk_Olives";
            this.chk_Olives.Size = new System.Drawing.Size(78, 24);
            this.chk_Olives.TabIndex = 3;
            this.chk_Olives.Tag = "3";
            this.chk_Olives.Text = "Olives";
            this.chk_Olives.UseVisualStyleBackColor = true;
            this.chk_Olives.CheckedChanged += new System.EventHandler(this.chk_Olives_CheckedChanged);
            // 
            // chk_Tomato
            // 
            this.chk_Tomato.AutoSize = true;
            this.chk_Tomato.Location = new System.Drawing.Point(16, 87);
            this.chk_Tomato.Name = "chk_Tomato";
            this.chk_Tomato.Size = new System.Drawing.Size(87, 24);
            this.chk_Tomato.TabIndex = 2;
            this.chk_Tomato.Tag = "3";
            this.chk_Tomato.Text = "Tomato";
            this.chk_Tomato.UseVisualStyleBackColor = true;
            this.chk_Tomato.CheckedChanged += new System.EventHandler(this.chk_Tomato_CheckedChanged);
            // 
            // chk_Onion
            // 
            this.chk_Onion.AutoSize = true;
            this.chk_Onion.Location = new System.Drawing.Point(16, 58);
            this.chk_Onion.Name = "chk_Onion";
            this.chk_Onion.Size = new System.Drawing.Size(75, 24);
            this.chk_Onion.TabIndex = 1;
            this.chk_Onion.Tag = "2";
            this.chk_Onion.Text = "Onion";
            this.chk_Onion.UseVisualStyleBackColor = true;
            this.chk_Onion.CheckedChanged += new System.EventHandler(this.chk_Onion_CheckedChanged);
            // 
            // chk_ExtraChess
            // 
            this.chk_ExtraChess.AutoSize = true;
            this.chk_ExtraChess.Location = new System.Drawing.Point(16, 29);
            this.chk_ExtraChess.Name = "chk_ExtraChess";
            this.chk_ExtraChess.Size = new System.Drawing.Size(123, 24);
            this.chk_ExtraChess.TabIndex = 0;
            this.chk_ExtraChess.Tag = "5";
            this.chk_ExtraChess.Text = "Extra Chess";
            this.chk_ExtraChess.UseVisualStyleBackColor = true;
            this.chk_ExtraChess.CheckedChanged += new System.EventHandler(this.chk_ExtraChess_CheckedChanged);
            // 
            // gb_WhereToEat
            // 
            this.gb_WhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gb_WhereToEat.Controls.Add(this.rad_TakeOut);
            this.gb_WhereToEat.Controls.Add(this.rad_EatIn);
            this.gb_WhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_WhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_WhereToEat.ForeColor = System.Drawing.Color.White;
            this.gb_WhereToEat.Location = new System.Drawing.Point(400, 397);
            this.gb_WhereToEat.Name = "gb_WhereToEat";
            this.gb_WhereToEat.Size = new System.Drawing.Size(165, 111);
            this.gb_WhereToEat.TabIndex = 7;
            this.gb_WhereToEat.TabStop = false;
            this.gb_WhereToEat.Text = "Where To Eat";
            // 
            // rad_TakeOut
            // 
            this.rad_TakeOut.AutoSize = true;
            this.rad_TakeOut.BackColor = System.Drawing.Color.Transparent;
            this.rad_TakeOut.ForeColor = System.Drawing.Color.White;
            this.rad_TakeOut.Location = new System.Drawing.Point(6, 62);
            this.rad_TakeOut.Name = "rad_TakeOut";
            this.rad_TakeOut.Size = new System.Drawing.Size(98, 24);
            this.rad_TakeOut.TabIndex = 5;
            this.rad_TakeOut.Tag = "0";
            this.rad_TakeOut.Text = "Take Out";
            this.rad_TakeOut.UseVisualStyleBackColor = false;
            this.rad_TakeOut.CheckedChanged += new System.EventHandler(this.rad_TakeOut_CheckedChanged);
            // 
            // rad_EatIn
            // 
            this.rad_EatIn.AutoSize = true;
            this.rad_EatIn.BackColor = System.Drawing.Color.Transparent;
            this.rad_EatIn.Checked = true;
            this.rad_EatIn.ForeColor = System.Drawing.Color.White;
            this.rad_EatIn.Location = new System.Drawing.Point(6, 36);
            this.rad_EatIn.Name = "rad_EatIn";
            this.rad_EatIn.Size = new System.Drawing.Size(73, 24);
            this.rad_EatIn.TabIndex = 3;
            this.rad_EatIn.TabStop = true;
            this.rad_EatIn.Tag = "3";
            this.rad_EatIn.Text = "Eat In";
            this.rad_EatIn.UseVisualStyleBackColor = false;
            this.rad_EatIn.CheckedChanged += new System.EventHandler(this.rad_EatIn_CheckedChanged);
            // 
            // lab_TotalPriceLable
            // 
            this.lab_TotalPriceLable.AutoSize = true;
            this.lab_TotalPriceLable.BackColor = System.Drawing.Color.Transparent;
            this.lab_TotalPriceLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_TotalPriceLable.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TotalPriceLable.ForeColor = System.Drawing.Color.Tomato;
            this.lab_TotalPriceLable.Location = new System.Drawing.Point(81, 576);
            this.lab_TotalPriceLable.Name = "lab_TotalPriceLable";
            this.lab_TotalPriceLable.Size = new System.Drawing.Size(157, 35);
            this.lab_TotalPriceLable.TabIndex = 8;
            this.lab_TotalPriceLable.Text = "Total Price : ";
            // 
            // lab_TotalPrice
            // 
            this.lab_TotalPrice.AutoSize = true;
            this.lab_TotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lab_TotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_TotalPrice.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TotalPrice.ForeColor = System.Drawing.Color.Tomato;
            this.lab_TotalPrice.Location = new System.Drawing.Point(234, 576);
            this.lab_TotalPrice.Name = "lab_TotalPrice";
            this.lab_TotalPrice.Size = new System.Drawing.Size(49, 35);
            this.lab_TotalPrice.TabIndex = 9;
            this.lab_TotalPrice.Text = "$ 0";
            // 
            // btn_ConfirmOrder
            // 
            this.btn_ConfirmOrder.BackColor = System.Drawing.Color.Tomato;
            this.btn_ConfirmOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConfirmOrder.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmOrder.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmOrder.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmOrder.Location = new System.Drawing.Point(473, 634);
            this.btn_ConfirmOrder.Name = "btn_ConfirmOrder";
            this.btn_ConfirmOrder.Size = new System.Drawing.Size(197, 56);
            this.btn_ConfirmOrder.TabIndex = 10;
            this.btn_ConfirmOrder.Text = "Confirm";
            this.btn_ConfirmOrder.UseVisualStyleBackColor = false;
            this.btn_ConfirmOrder.Click += new System.EventHandler(this.btn_ConfirmOrder_Click);
            // 
            // btn_ResetOrder
            // 
            this.btn_ResetOrder.BackColor = System.Drawing.Color.Snow;
            this.btn_ResetOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResetOrder.FlatAppearance.BorderSize = 0;
            this.btn_ResetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetOrder.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetOrder.ForeColor = System.Drawing.Color.Tomato;
            this.btn_ResetOrder.Location = new System.Drawing.Point(695, 634);
            this.btn_ResetOrder.Name = "btn_ResetOrder";
            this.btn_ResetOrder.Size = new System.Drawing.Size(197, 56);
            this.btn_ResetOrder.TabIndex = 11;
            this.btn_ResetOrder.Text = "Reset";
            this.btn_ResetOrder.UseVisualStyleBackColor = false;
            this.btn_ResetOrder.Click += new System.EventHandler(this.btn_ResetOrder_Click);
            // 
            // frm_OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1408, 751);
            this.Controls.Add(this.btn_ResetOrder);
            this.Controls.Add(this.btn_ConfirmOrder);
            this.Controls.Add(this.lab_TotalPrice);
            this.Controls.Add(this.lab_TotalPriceLable);
            this.Controls.Add(this.gb_WhereToEat);
            this.Controls.Add(this.gb_Toppings);
            this.Controls.Add(this.gb_CrustType);
            this.Controls.Add(this.gb_PizzaSize);
            this.Controls.Add(this.lbl_MainAddress);
            this.Name = "frm_OrderScreen";
            this.Text = "frm_OrderScreen";
            this.Load += new System.EventHandler(this.frm_OrderScreen_Load);
            this.gb_PizzaSize.ResumeLayout(false);
            this.gb_PizzaSize.PerformLayout();
            this.gb_CrustType.ResumeLayout(false);
            this.gb_CrustType.PerformLayout();
            this.gb_Toppings.ResumeLayout(false);
            this.gb_Toppings.PerformLayout();
            this.gb_WhereToEat.ResumeLayout(false);
            this.gb_WhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MainAddress;
        private System.Windows.Forms.GroupBox gb_PizzaSize;
        private System.Windows.Forms.RadioButton rad_small;
        private System.Windows.Forms.RadioButton rad_Big;
        private System.Windows.Forms.RadioButton rad_Medium;
        private System.Windows.Forms.GroupBox gb_CrustType;
        private System.Windows.Forms.RadioButton rad_ThickCrust;
        private System.Windows.Forms.RadioButton rad_ThinCrust;
        private System.Windows.Forms.GroupBox gb_Toppings;
        private System.Windows.Forms.CheckBox chk_Tomato;
        private System.Windows.Forms.CheckBox chk_Onion;
        private System.Windows.Forms.CheckBox chk_ExtraChess;
        private System.Windows.Forms.CheckBox chk_Papper;
        private System.Windows.Forms.CheckBox chk_Mashrom;
        private System.Windows.Forms.CheckBox chk_Olives;
        private System.Windows.Forms.GroupBox gb_WhereToEat;
        private System.Windows.Forms.RadioButton rad_TakeOut;
        private System.Windows.Forms.RadioButton rad_EatIn;
        private System.Windows.Forms.Label lab_TotalPriceLable;
        private System.Windows.Forms.Label lab_TotalPrice;
        private System.Windows.Forms.Button btn_ConfirmOrder;
        private System.Windows.Forms.Button btn_ResetOrder;
    }
}