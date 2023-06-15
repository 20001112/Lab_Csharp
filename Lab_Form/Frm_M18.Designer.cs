namespace Lab_Form
{
    partial class Frm_M18
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
            this.Btn_Products = new System.Windows.Forms.Button();
            this.BtnValidatino01 = new System.Windows.Forms.Button();
            this.Btn_Validatino02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Products
            // 
            this.Btn_Products.Enabled = false;
            this.Btn_Products.Location = new System.Drawing.Point(404, 132);
            this.Btn_Products.Name = "Btn_Products";
            this.Btn_Products.Size = new System.Drawing.Size(161, 121);
            this.Btn_Products.TabIndex = 0;
            this.Btn_Products.Text = "Products";
            this.Btn_Products.UseVisualStyleBackColor = true;
            this.Btn_Products.Click += new System.EventHandler(this.Btn_Products_Click);
            // 
            // BtnValidatino01
            // 
            this.BtnValidatino01.Location = new System.Drawing.Point(98, 151);
            this.BtnValidatino01.Name = "BtnValidatino01";
            this.BtnValidatino01.Size = new System.Drawing.Size(98, 39);
            this.BtnValidatino01.TabIndex = 1;
            this.BtnValidatino01.Text = "Validatino01";
            this.BtnValidatino01.UseVisualStyleBackColor = true;
            this.BtnValidatino01.Click += new System.EventHandler(this.BtnValidatino01_Click);
            // 
            // Btn_Validatino02
            // 
            this.Btn_Validatino02.Location = new System.Drawing.Point(98, 228);
            this.Btn_Validatino02.Name = "Btn_Validatino02";
            this.Btn_Validatino02.Size = new System.Drawing.Size(98, 39);
            this.Btn_Validatino02.TabIndex = 2;
            this.Btn_Validatino02.Text = "Validatino01";
            this.Btn_Validatino02.UseVisualStyleBackColor = true;
            this.Btn_Validatino02.Click += new System.EventHandler(this.Btn_Validatino02_Click);
            // 
            // Frm_M18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Validatino02);
            this.Controls.Add(this.BtnValidatino01);
            this.Controls.Add(this.Btn_Products);
            this.Name = "Frm_M18";
            this.Text = "Frm_M18";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Products;
        private System.Windows.Forms.Button BtnValidatino01;
        private System.Windows.Forms.Button Btn_Validatino02;
    }
}