namespace Lab_Form
{
    partial class Frm_M26
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
            this.Btn_Array = new System.Windows.Forms.Button();
            this.Btn_arrowd = new System.Windows.Forms.Button();
            this.Btn_CreateArra = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Array
            // 
            this.Btn_Array.Location = new System.Drawing.Point(76, 66);
            this.Btn_Array.Name = "Btn_Array";
            this.Btn_Array.Size = new System.Drawing.Size(140, 51);
            this.Btn_Array.TabIndex = 0;
            this.Btn_Array.Text = "建立陣列";
            this.Btn_Array.UseVisualStyleBackColor = true;
            this.Btn_Array.Click += new System.EventHandler(this.Btn_Array_Click);
            // 
            // Btn_arrowd
            // 
            this.Btn_arrowd.Location = new System.Drawing.Point(67, 187);
            this.Btn_arrowd.Name = "Btn_arrowd";
            this.Btn_arrowd.Size = new System.Drawing.Size(140, 51);
            this.Btn_arrowd.TabIndex = 1;
            this.Btn_arrowd.Text = "建立陣列所引";
            this.Btn_arrowd.UseVisualStyleBackColor = true;
            this.Btn_arrowd.Click += new System.EventHandler(this.Btn_arrowd_Click);
            // 
            // Btn_CreateArra
            // 
            this.Btn_CreateArra.Location = new System.Drawing.Point(76, 282);
            this.Btn_CreateArra.Name = "Btn_CreateArra";
            this.Btn_CreateArra.Size = new System.Drawing.Size(140, 51);
            this.Btn_CreateArra.TabIndex = 2;
            this.Btn_CreateArra.Text = "建立陣列辦法";
            this.Btn_CreateArra.UseVisualStyleBackColor = true;
            this.Btn_CreateArra.Click += new System.EventHandler(this.Btn_CreateArra_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "建立陣列辦法2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_M26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_CreateArra);
            this.Controls.Add(this.Btn_arrowd);
            this.Controls.Add(this.Btn_Array);
            this.Name = "Frm_M26";
            this.Text = "Frm_M26";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Array;
        private System.Windows.Forms.Button Btn_arrowd;
        private System.Windows.Forms.Button Btn_CreateArra;
        private System.Windows.Forms.Button button2;
    }
}