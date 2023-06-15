namespace Lab_Form
{
    partial class Frm_M32_String
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
            this.Btn_String = new System.Windows.Forms.Button();
            this.Btn_StringBuilder = new System.Windows.Forms.Button();
            this.Btn_path = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.Lab_password = new System.Windows.Forms.Label();
            this.Lab_namepassword = new System.Windows.Forms.Label();
            this.txt_NamePassword = new System.Windows.Forms.TextBox();
            this.Btn_Vaild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_String
            // 
            this.Btn_String.Location = new System.Drawing.Point(22, 133);
            this.Btn_String.Name = "Btn_String";
            this.Btn_String.Size = new System.Drawing.Size(205, 66);
            this.Btn_String.TabIndex = 0;
            this.Btn_String.Text = "String";
            this.Btn_String.UseVisualStyleBackColor = true;
            this.Btn_String.Click += new System.EventHandler(this.Btn_String_Click);
            // 
            // Btn_StringBuilder
            // 
            this.Btn_StringBuilder.Location = new System.Drawing.Point(22, 248);
            this.Btn_StringBuilder.Name = "Btn_StringBuilder";
            this.Btn_StringBuilder.Size = new System.Drawing.Size(205, 66);
            this.Btn_StringBuilder.TabIndex = 1;
            this.Btn_StringBuilder.Text = "StringBuilder";
            this.Btn_StringBuilder.UseVisualStyleBackColor = true;
            this.Btn_StringBuilder.Click += new System.EventHandler(this.Btn_StringBuilder_Click);
            // 
            // Btn_path
            // 
            this.Btn_path.Location = new System.Drawing.Point(275, 99);
            this.Btn_path.Name = "Btn_path";
            this.Btn_path.Size = new System.Drawing.Size(205, 66);
            this.Btn_path.TabIndex = 2;
            this.Btn_path.Text = "path";
            this.Btn_path.UseVisualStyleBackColor = true;
            this.Btn_path.Click += new System.EventHandler(this.Btn_path_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(420, 272);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 22);
            this.txt_password.TabIndex = 3;
            // 
            // Lab_password
            // 
            this.Lab_password.AutoSize = true;
            this.Lab_password.Location = new System.Drawing.Point(360, 275);
            this.Lab_password.Name = "Lab_password";
            this.Lab_password.Size = new System.Drawing.Size(29, 12);
            this.Lab_password.TabIndex = 4;
            this.Lab_password.Text = "密碼";
            // 
            // Lab_namepassword
            // 
            this.Lab_namepassword.AutoSize = true;
            this.Lab_namepassword.Location = new System.Drawing.Point(360, 326);
            this.Lab_namepassword.Name = "Lab_namepassword";
            this.Lab_namepassword.Size = new System.Drawing.Size(65, 12);
            this.Lab_namepassword.TabIndex = 5;
            this.Lab_namepassword.Text = "身分證字號";
            // 
            // txt_NamePassword
            // 
            this.txt_NamePassword.Location = new System.Drawing.Point(453, 323);
            this.txt_NamePassword.Name = "txt_NamePassword";
            this.txt_NamePassword.Size = new System.Drawing.Size(100, 22);
            this.txt_NamePassword.TabIndex = 6;
            // 
            // Btn_Vaild
            // 
            this.Btn_Vaild.Location = new System.Drawing.Point(362, 378);
            this.Btn_Vaild.Name = "Btn_Vaild";
            this.Btn_Vaild.Size = new System.Drawing.Size(191, 48);
            this.Btn_Vaild.TabIndex = 7;
            this.Btn_Vaild.Text = "驗證";
            this.Btn_Vaild.UseVisualStyleBackColor = true;
            this.Btn_Vaild.Click += new System.EventHandler(this.Btn_Vaild_Click);
            // 
            // Frm_M32_String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Vaild);
            this.Controls.Add(this.txt_NamePassword);
            this.Controls.Add(this.Lab_namepassword);
            this.Controls.Add(this.Lab_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.Btn_path);
            this.Controls.Add(this.Btn_StringBuilder);
            this.Controls.Add(this.Btn_String);
            this.Name = "Frm_M32_String";
            this.Text = "Frm_M32_String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_String;
        private System.Windows.Forms.Button Btn_StringBuilder;
        private System.Windows.Forms.Button Btn_path;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label Lab_password;
        private System.Windows.Forms.Label Lab_namepassword;
        private System.Windows.Forms.TextBox txt_NamePassword;
        private System.Windows.Forms.Button Btn_Vaild;
    }
}