namespace Lab_Form
{
    partial class Frm_M24
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
            this.Btn_Reverse = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.Btn_If = new System.Windows.Forms.Button();
            this.Btn_elseif = new System.Windows.Forms.Button();
            this.Btn_IfElseIf = new System.Windows.Forms.Button();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.Lab_Grade = new System.Windows.Forms.Label();
            this.Btn_switch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Reverse
            // 
            this.Btn_Reverse.Location = new System.Drawing.Point(128, 135);
            this.Btn_Reverse.Name = "Btn_Reverse";
            this.Btn_Reverse.Size = new System.Drawing.Size(114, 66);
            this.Btn_Reverse.TabIndex = 0;
            this.Btn_Reverse.Text = "button1";
            this.Btn_Reverse.UseVisualStyleBackColor = true;
            this.Btn_Reverse.Click += new System.EventHandler(this.Btn_Reverse_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(128, 257);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(114, 66);
            this.three.TabIndex = 1;
            this.three.Text = "三元";
            this.three.UseVisualStyleBackColor = true;
            // 
            // Btn_If
            // 
            this.Btn_If.Location = new System.Drawing.Point(346, 192);
            this.Btn_If.Name = "Btn_If";
            this.Btn_If.Size = new System.Drawing.Size(141, 73);
            this.Btn_If.TabIndex = 2;
            this.Btn_If.Text = "if";
            this.Btn_If.UseVisualStyleBackColor = true;
            this.Btn_If.Click += new System.EventHandler(this.Btn_If_Click);
            // 
            // Btn_elseif
            // 
            this.Btn_elseif.Location = new System.Drawing.Point(346, 285);
            this.Btn_elseif.Name = "Btn_elseif";
            this.Btn_elseif.Size = new System.Drawing.Size(141, 73);
            this.Btn_elseif.TabIndex = 3;
            this.Btn_elseif.Text = "elseif";
            this.Btn_elseif.UseVisualStyleBackColor = true;
            this.Btn_elseif.Click += new System.EventHandler(this.Btn_elseif_Click);
            // 
            // Btn_IfElseIf
            // 
            this.Btn_IfElseIf.Location = new System.Drawing.Point(501, 379);
            this.Btn_IfElseIf.Name = "Btn_IfElseIf";
            this.Btn_IfElseIf.Size = new System.Drawing.Size(141, 73);
            this.Btn_IfElseIf.TabIndex = 4;
            this.Btn_IfElseIf.Text = "if..else..if";
            this.Btn_IfElseIf.UseVisualStyleBackColor = true;
            this.Btn_IfElseIf.Click += new System.EventHandler(this.Btn_IfElseIf_Click);
            // 
            // txt_Score
            // 
            this.txt_Score.Location = new System.Drawing.Point(526, 336);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(100, 22);
            this.txt_Score.TabIndex = 5;
            // 
            // Lab_Grade
            // 
            this.Lab_Grade.AutoSize = true;
            this.Lab_Grade.Location = new System.Drawing.Point(652, 346);
            this.Lab_Grade.Name = "Lab_Grade";
            this.Lab_Grade.Size = new System.Drawing.Size(29, 12);
            this.Lab_Grade.TabIndex = 6;
            this.Lab_Grade.Text = "級距";
            // 
            // Btn_switch
            // 
            this.Btn_switch.Location = new System.Drawing.Point(174, 402);
            this.Btn_switch.Name = "Btn_switch";
            this.Btn_switch.Size = new System.Drawing.Size(75, 23);
            this.Btn_switch.TabIndex = 7;
            this.Btn_switch.Text = "switch";
            this.Btn_switch.UseVisualStyleBackColor = true;
            this.Btn_switch.Click += new System.EventHandler(this.Btn_switch_Click);
            // 
            // Frm_M24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 500);
            this.Controls.Add(this.Btn_switch);
            this.Controls.Add(this.Lab_Grade);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.Btn_IfElseIf);
            this.Controls.Add(this.Btn_elseif);
            this.Controls.Add(this.Btn_If);
            this.Controls.Add(this.three);
            this.Controls.Add(this.Btn_Reverse);
            this.Name = "Frm_M24";
            this.Text = "Frm_M24";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Reverse;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button Btn_If;
        private System.Windows.Forms.Button Btn_elseif;
        private System.Windows.Forms.Button Btn_IfElseIf;
        private System.Windows.Forms.TextBox txt_Score;
        private System.Windows.Forms.Label Lab_Grade;
        private System.Windows.Forms.Button Btn_switch;
    }
}