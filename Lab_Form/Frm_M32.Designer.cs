namespace Lab_Form
{
    partial class Frm_M32
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
            this.Btn_foreach = new System.Windows.Forms.Button();
            this.Btn_Do = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_While = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_foreach
            // 
            this.Btn_foreach.Location = new System.Drawing.Point(197, 121);
            this.Btn_foreach.Name = "Btn_foreach";
            this.Btn_foreach.Size = new System.Drawing.Size(106, 43);
            this.Btn_foreach.TabIndex = 0;
            this.Btn_foreach.Text = "foreach";
            this.Btn_foreach.UseVisualStyleBackColor = true;
            this.Btn_foreach.Click += new System.EventHandler(this.Btn_foreach_Click);
            // 
            // Btn_Do
            // 
            this.Btn_Do.Location = new System.Drawing.Point(343, 121);
            this.Btn_Do.Name = "Btn_Do";
            this.Btn_Do.Size = new System.Drawing.Size(106, 43);
            this.Btn_Do.TabIndex = 1;
            this.Btn_Do.Text = "Do";
            this.Btn_Do.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "foreach";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Btn_While
            // 
            this.Btn_While.Location = new System.Drawing.Point(343, 220);
            this.Btn_While.Name = "Btn_While";
            this.Btn_While.Size = new System.Drawing.Size(106, 43);
            this.Btn_While.TabIndex = 3;
            this.Btn_While.Text = "While";
            this.Btn_While.UseVisualStyleBackColor = true;
            this.Btn_While.Click += new System.EventHandler(this.Btn_While_Click);
            // 
            // Frm_M32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_While);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Do);
            this.Controls.Add(this.Btn_foreach);
            this.Name = "Frm_M32";
            this.Text = "Frm_M32";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_foreach;
        private System.Windows.Forms.Button Btn_Do;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_While;
    }
}