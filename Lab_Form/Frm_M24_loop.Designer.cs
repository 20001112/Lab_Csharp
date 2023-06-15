namespace Lab_Form
{
    partial class Frm_M24_loop
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
            this.Btn_While = new System.Windows.Forms.Button();
            this.Btn_DO = new System.Windows.Forms.Button();
            this.Btn_For = new System.Windows.Forms.Button();
            this.Lab_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_While
            // 
            this.Btn_While.Location = new System.Drawing.Point(169, 141);
            this.Btn_While.Name = "Btn_While";
            this.Btn_While.Size = new System.Drawing.Size(102, 53);
            this.Btn_While.TabIndex = 0;
            this.Btn_While.Text = "While";
            this.Btn_While.UseVisualStyleBackColor = true;
            this.Btn_While.Click += new System.EventHandler(this.Btn_While_Click);
            // 
            // Btn_DO
            // 
            this.Btn_DO.Location = new System.Drawing.Point(156, 226);
            this.Btn_DO.Name = "Btn_DO";
            this.Btn_DO.Size = new System.Drawing.Size(128, 54);
            this.Btn_DO.TabIndex = 1;
            this.Btn_DO.Text = "DO";
            this.Btn_DO.UseVisualStyleBackColor = true;
            this.Btn_DO.Click += new System.EventHandler(this.Btn_DO_Click);
            // 
            // Btn_For
            // 
            this.Btn_For.Location = new System.Drawing.Point(143, 318);
            this.Btn_For.Name = "Btn_For";
            this.Btn_For.Size = new System.Drawing.Size(128, 54);
            this.Btn_For.TabIndex = 2;
            this.Btn_For.Text = "forin";
            this.Btn_For.UseVisualStyleBackColor = true;
            this.Btn_For.Click += new System.EventHandler(this.Btn_For_Click);
            // 
            // Lab_Result
            // 
            this.Lab_Result.AutoSize = true;
            this.Lab_Result.Location = new System.Drawing.Point(396, 117);
            this.Lab_Result.Name = "Lab_Result";
            this.Lab_Result.Size = new System.Drawing.Size(34, 12);
            this.Lab_Result.TabIndex = 3;
            this.Lab_Result.Text = "Result";
            // 
            // Frm_M24_loop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lab_Result);
            this.Controls.Add(this.Btn_For);
            this.Controls.Add(this.Btn_DO);
            this.Controls.Add(this.Btn_While);
            this.Name = "Frm_M24_loop";
            this.Text = "Frm_M24_loop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_While;
        private System.Windows.Forms.Button Btn_DO;
        private System.Windows.Forms.Button Btn_For;
        private System.Windows.Forms.Label Lab_Result;
    }
}