namespace Lab_Form
{
    partial class Frm_M34_Read
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
            this.Btn_Streamread = new System.Windows.Forms.Button();
            this.Btn_Streamwriten = new System.Windows.Forms.Button();
            this.txtReadWrite = new System.Windows.Forms.TextBox();
            this.Btn_down = new System.Windows.Forms.Button();
            this.Btn_try = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Streamread
            // 
            this.Btn_Streamread.Location = new System.Drawing.Point(30, 39);
            this.Btn_Streamread.Name = "Btn_Streamread";
            this.Btn_Streamread.Size = new System.Drawing.Size(143, 39);
            this.Btn_Streamread.TabIndex = 0;
            this.Btn_Streamread.Text = "Streamread";
            this.Btn_Streamread.UseVisualStyleBackColor = true;
            this.Btn_Streamread.Click += new System.EventHandler(this.Btn_Streamread_Click);
            // 
            // Btn_Streamwriten
            // 
            this.Btn_Streamwriten.Location = new System.Drawing.Point(30, 121);
            this.Btn_Streamwriten.Name = "Btn_Streamwriten";
            this.Btn_Streamwriten.Size = new System.Drawing.Size(143, 39);
            this.Btn_Streamwriten.TabIndex = 1;
            this.Btn_Streamwriten.Text = "Streamwriten";
            this.Btn_Streamwriten.UseVisualStyleBackColor = true;
            this.Btn_Streamwriten.Click += new System.EventHandler(this.Btn_Streamwriten_Click);
            // 
            // txtReadWrite
            // 
            this.txtReadWrite.Location = new System.Drawing.Point(326, 25);
            this.txtReadWrite.Multiline = true;
            this.txtReadWrite.Name = "txtReadWrite";
            this.txtReadWrite.Size = new System.Drawing.Size(380, 327);
            this.txtReadWrite.TabIndex = 2;
            // 
            // Btn_down
            // 
            this.Btn_down.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.Btn_down.Location = new System.Drawing.Point(30, 205);
            this.Btn_down.Name = "Btn_down";
            this.Btn_down.Size = new System.Drawing.Size(143, 39);
            this.Btn_down.TabIndex = 3;
            this.Btn_down.Text = "中斷模式";
            this.Btn_down.UseVisualStyleBackColor = true;
            this.Btn_down.Click += new System.EventHandler(this.Btn_down_Click);
            // 
            // Btn_try
            // 
            this.Btn_try.Location = new System.Drawing.Point(30, 288);
            this.Btn_try.Name = "Btn_try";
            this.Btn_try.Size = new System.Drawing.Size(135, 47);
            this.Btn_try.TabIndex = 4;
            this.Btn_try.Text = "try";
            this.Btn_try.UseVisualStyleBackColor = true;
            this.Btn_try.Click += new System.EventHandler(this.Btn_try_Click);
            // 
            // Frm_M34_Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_try);
            this.Controls.Add(this.Btn_down);
            this.Controls.Add(this.txtReadWrite);
            this.Controls.Add(this.Btn_Streamwriten);
            this.Controls.Add(this.Btn_Streamread);
            this.Name = "Frm_M34_Read";
            this.Text = "Frm_M34_Read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Streamread;
        private System.Windows.Forms.Button Btn_Streamwriten;
        private System.Windows.Forms.TextBox txtReadWrite;
        private System.Windows.Forms.Button Btn_down;
        private System.Windows.Forms.Button Btn_try;
    }
}