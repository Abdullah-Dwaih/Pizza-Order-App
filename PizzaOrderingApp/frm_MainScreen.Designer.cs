namespace PizzaOrderingApp
{
    partial class frm_MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainScreen));
            this.lbl_MainAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GoToOrderForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MainAddress
            // 
            this.lbl_MainAddress.AutoSize = true;
            this.lbl_MainAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainAddress.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainAddress.ForeColor = System.Drawing.Color.White;
            this.lbl_MainAddress.Location = new System.Drawing.Point(105, 66);
            this.lbl_MainAddress.Name = "lbl_MainAddress";
            this.lbl_MainAddress.Size = new System.Drawing.Size(780, 97);
            this.lbl_MainAddress.TabIndex = 0;
            this.lbl_MainAddress.Text = "PIZZA ONLINE DINNER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOM TO THE FIRST CLOUDE DINNER";
            // 
            // btn_GoToOrderForm
            // 
            this.btn_GoToOrderForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GoToOrderForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoToOrderForm.FlatAppearance.BorderSize = 0;
            this.btn_GoToOrderForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoToOrderForm.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoToOrderForm.ForeColor = System.Drawing.Color.White;
            this.btn_GoToOrderForm.Location = new System.Drawing.Point(122, 399);
            this.btn_GoToOrderForm.Name = "btn_GoToOrderForm";
            this.btn_GoToOrderForm.Size = new System.Drawing.Size(270, 77);
            this.btn_GoToOrderForm.TabIndex = 2;
            this.btn_GoToOrderForm.Text = "Press To Order";
            this.btn_GoToOrderForm.UseVisualStyleBackColor = false;
            this.btn_GoToOrderForm.Click += new System.EventHandler(this.btn_GoToOrderForm_Click);
            // 
            // frm_MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1400, 629);
            this.Controls.Add(this.btn_GoToOrderForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_MainAddress);
            this.Name = "frm_MainScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MainAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GoToOrderForm;
    }
}

