namespace Lab_Form
{
    partial class Frm_M19
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Lab_Year = new System.Windows.Forms.Label();
            this.Btn_AddEmployee = new System.Windows.Forms.Button();
            this.Btn_look = new System.Windows.Forms.Button();
            this.Lab_lookEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(175, 57);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 22);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(175, 143);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(100, 22);
            this.txt_Year.TabIndex = 1;
            // 
            // Lab_Name
            // 
            this.Lab_Name.AutoSize = true;
            this.Lab_Name.Location = new System.Drawing.Point(37, 66);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(53, 12);
            this.Lab_Name.TabIndex = 2;
            this.Lab_Name.Text = "員工姓名";
            // 
            // Lab_Year
            // 
            this.Lab_Year.AutoSize = true;
            this.Lab_Year.Location = new System.Drawing.Point(37, 146);
            this.Lab_Year.Name = "Lab_Year";
            this.Lab_Year.Size = new System.Drawing.Size(53, 12);
            this.Lab_Year.TabIndex = 3;
            this.Lab_Year.Text = "員工年齡";
            // 
            // Btn_AddEmployee
            // 
            this.Btn_AddEmployee.Location = new System.Drawing.Point(60, 203);
            this.Btn_AddEmployee.Name = "Btn_AddEmployee";
            this.Btn_AddEmployee.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddEmployee.TabIndex = 4;
            this.Btn_AddEmployee.Text = "加入員工";
            this.Btn_AddEmployee.UseVisualStyleBackColor = true;
            this.Btn_AddEmployee.Click += new System.EventHandler(this.Btn_AddEmployee_Click);
            // 
            // Btn_look
            // 
            this.Btn_look.Location = new System.Drawing.Point(225, 202);
            this.Btn_look.Name = "Btn_look";
            this.Btn_look.Size = new System.Drawing.Size(75, 23);
            this.Btn_look.TabIndex = 5;
            this.Btn_look.Text = "顯示員工";
            this.Btn_look.UseVisualStyleBackColor = true;
            this.Btn_look.Click += new System.EventHandler(this.Btn_look_Click);
            // 
            // Lab_lookEmployee
            // 
            this.Lab_lookEmployee.AutoSize = true;
            this.Lab_lookEmployee.Location = new System.Drawing.Point(414, 66);
            this.Lab_lookEmployee.Name = "Lab_lookEmployee";
            this.Lab_lookEmployee.Size = new System.Drawing.Size(33, 12);
            this.Lab_lookEmployee.TabIndex = 6;
            this.Lab_lookEmployee.Text = "label1";
            // 
            // Frm_M19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lab_lookEmployee);
            this.Controls.Add(this.Btn_look);
            this.Controls.Add(this.Btn_AddEmployee);
            this.Controls.Add(this.Lab_Year);
            this.Controls.Add(this.Lab_Name);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.txt_Name);
            this.Name = "Frm_M19";
            this.Text = "Frm_M19";
            this.Load += new System.EventHandler(this.Frm_M19_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.Label Lab_Name;
        private System.Windows.Forms.Label Lab_Year;
        private System.Windows.Forms.Button Btn_AddEmployee;
        private System.Windows.Forms.Button Btn_look;
        private System.Windows.Forms.Label Lab_lookEmployee;
    }
}