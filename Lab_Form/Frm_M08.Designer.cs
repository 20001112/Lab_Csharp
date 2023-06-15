namespace Lab_Form
{
    partial class Frm_M08
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
            this.RegisterEvent = new System.Windows.Forms.Button();
            this.Register01 = new System.Windows.Forms.Button();
            this.Register02 = new System.Windows.Forms.Button();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.mathpay = new System.Windows.Forms.Button();
            this.btnSetProperty = new System.Windows.Forms.Button();
            this.paybox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.messagebox = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.HelloFrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterEvent
            // 
            this.RegisterEvent.Location = new System.Drawing.Point(553, 107);
            this.RegisterEvent.Name = "RegisterEvent";
            this.RegisterEvent.Size = new System.Drawing.Size(75, 23);
            this.RegisterEvent.TabIndex = 0;
            this.RegisterEvent.Text = "RegisterEvent";
            this.RegisterEvent.UseVisualStyleBackColor = true;
            this.RegisterEvent.Click += new System.EventHandler(this.RegisterEvent_Click);
            // 
            // Register01
            // 
            this.Register01.Location = new System.Drawing.Point(553, 163);
            this.Register01.Name = "Register01";
            this.Register01.Size = new System.Drawing.Size(75, 23);
            this.Register01.TabIndex = 1;
            this.Register01.Text = "Register01";
            this.Register01.UseVisualStyleBackColor = true;
            // 
            // Register02
            // 
            this.Register02.Location = new System.Drawing.Point(553, 239);
            this.Register02.Name = "Register02";
            this.Register02.Size = new System.Drawing.Size(75, 23);
            this.Register02.TabIndex = 2;
            this.Register02.Text = "Register02";
            this.Register02.UseVisualStyleBackColor = true;
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "50%",
            "20%"});
            this.cmbDiscount.Location = new System.Drawing.Point(553, 337);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(121, 20);
            this.cmbDiscount.TabIndex = 3;
            // 
            // mathpay
            // 
            this.mathpay.Location = new System.Drawing.Point(553, 375);
            this.mathpay.Name = "mathpay";
            this.mathpay.Size = new System.Drawing.Size(75, 23);
            this.mathpay.TabIndex = 4;
            this.mathpay.Text = "計算金額";
            this.mathpay.UseVisualStyleBackColor = true;
            // 
            // btnSetProperty
            // 
            this.btnSetProperty.Location = new System.Drawing.Point(353, 221);
            this.btnSetProperty.Name = "btnSetProperty";
            this.btnSetProperty.Size = new System.Drawing.Size(75, 23);
            this.btnSetProperty.TabIndex = 5;
            this.btnSetProperty.Text = "btnSetProperty";
            this.btnSetProperty.UseVisualStyleBackColor = true;
            this.btnSetProperty.Click += new System.EventHandler(this.btnSetProperty_Click);
            // 
            // paybox
            // 
            this.paybox.Location = new System.Drawing.Point(553, 299);
            this.paybox.Name = "paybox";
            this.paybox.Size = new System.Drawing.Size(118, 22);
            this.paybox.TabIndex = 6;
            this.paybox.TextChanged += new System.EventHandler(this.paybox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // messagebox
            // 
            this.messagebox.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.messagebox.Location = new System.Drawing.Point(353, 361);
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(75, 23);
            this.messagebox.TabIndex = 8;
            this.messagebox.Text = "messagebox";
            this.messagebox.UseVisualStyleBackColor = true;
            this.messagebox.Click += new System.EventHandler(this.messagebox_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(352, 162);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 9;
            this.button.Text = "button2";
            this.button.UseVisualStyleBackColor = true;
            // 
            // HelloFrom
            // 
            this.HelloFrom.Location = new System.Drawing.Point(188, 163);
            this.HelloFrom.Name = "HelloFrom";
            this.HelloFrom.Size = new System.Drawing.Size(75, 23);
            this.HelloFrom.TabIndex = 10;
            this.HelloFrom.Text = "HelloFrom";
            this.HelloFrom.UseVisualStyleBackColor = true;
            this.HelloFrom.Click += new System.EventHandler(this.HelloFrom_Click);
            // 
            // Frm_M08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelloFrom);
            this.Controls.Add(this.button);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paybox);
            this.Controls.Add(this.btnSetProperty);
            this.Controls.Add(this.mathpay);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.Register02);
            this.Controls.Add(this.Register01);
            this.Controls.Add(this.RegisterEvent);
            this.Name = "Frm_M08";
            this.Text = "Frm_M08";
            this.Load += new System.EventHandler(this.Frm_M08_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterEvent;
        private System.Windows.Forms.Button Register01;
        private System.Windows.Forms.Button Register02;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Button mathpay;
        private System.Windows.Forms.Button btnSetProperty;
        private System.Windows.Forms.TextBox paybox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button messagebox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button HelloFrom;
    }
}