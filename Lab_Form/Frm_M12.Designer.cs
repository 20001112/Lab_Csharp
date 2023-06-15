namespace Lab_Form
{
    partial class Frm_M12
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
            this.Btn_01 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabCount = new System.Windows.Forms.Label();
            this.Lab_2 = new System.Windows.Forms.Button();
            this.Lab_Then = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grp_01 = new System.Windows.Forms.GroupBox();
            this.Btn_04 = new System.Windows.Forms.Button();
            this.Btn_05 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpstatic = new System.Windows.Forms.GroupBox();
            this.instanceVar = new System.Windows.Forms.Button();
            this.staticVar = new System.Windows.Forms.Button();
            this.instanceCount = new System.Windows.Forms.Label();
            this.staticCount = new System.Windows.Forms.Label();
            this.HelloFrom = new System.Windows.Forms.Button();
            this.grp_01.SuspendLayout();
            this.grpstatic.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_01
            // 
            this.Btn_01.Location = new System.Drawing.Point(583, 94);
            this.Btn_01.Name = "Btn_01";
            this.Btn_01.Size = new System.Drawing.Size(75, 23);
            this.Btn_01.TabIndex = 0;
            this.Btn_01.Text = "+1";
            this.Btn_01.UseVisualStyleBackColor = true;
            this.Btn_01.Click += new System.EventHandler(this.Btn_01_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // LabCount
            // 
            this.LabCount.AutoSize = true;
            this.LabCount.Location = new System.Drawing.Point(316, 208);
            this.LabCount.Name = "LabCount";
            this.LabCount.Size = new System.Drawing.Size(52, 12);
            this.LabCount.TabIndex = 2;
            this.LabCount.Text = "LabCount";
            // 
            // Lab_2
            // 
            this.Lab_2.Location = new System.Drawing.Point(583, 197);
            this.Lab_2.Name = "Lab_2";
            this.Lab_2.Size = new System.Drawing.Size(75, 23);
            this.Lab_2.TabIndex = 3;
            this.Lab_2.Text = "++";
            this.Lab_2.UseVisualStyleBackColor = true;
            this.Lab_2.Click += new System.EventHandler(this.Lab_2_Click);
            // 
            // Lab_Then
            // 
            this.Lab_Then.AutoSize = true;
            this.Lab_Then.Location = new System.Drawing.Point(316, 265);
            this.Lab_Then.Name = "Lab_Then";
            this.Lab_Then.Size = new System.Drawing.Size(52, 12);
            this.Lab_Then.TabIndex = 4;
            this.Lab_Then.Text = "LabResult";
            this.Lab_Then.Click += new System.EventHandler(this.Lab_Then_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Then++";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_01
            // 
            this.grp_01.Controls.Add(this.Btn_05);
            this.grp_01.Controls.Add(this.Btn_04);
            this.grp_01.Location = new System.Drawing.Point(53, 154);
            this.grp_01.Name = "grp_01";
            this.grp_01.Size = new System.Drawing.Size(200, 100);
            this.grp_01.TabIndex = 6;
            this.grp_01.TabStop = false;
            this.grp_01.Text = "grp_Var";
            // 
            // Btn_04
            // 
            this.Btn_04.Location = new System.Drawing.Point(74, 22);
            this.Btn_04.Name = "Btn_04";
            this.Btn_04.Size = new System.Drawing.Size(75, 23);
            this.Btn_04.TabIndex = 0;
            this.Btn_04.Text = "Btn_04";
            this.Btn_04.UseVisualStyleBackColor = true;
            this.Btn_04.Click += new System.EventHandler(this.Btn_04_Click);
            // 
            // Btn_05
            // 
            this.Btn_05.Location = new System.Drawing.Point(73, 67);
            this.Btn_05.Name = "Btn_05";
            this.Btn_05.Size = new System.Drawing.Size(75, 23);
            this.Btn_05.TabIndex = 1;
            this.Btn_05.Text = "Btn_05";
            this.Btn_05.UseVisualStyleBackColor = true;
            // 
            // grpstatic
            // 
            this.grpstatic.Controls.Add(this.staticVar);
            this.grpstatic.Controls.Add(this.instanceVar);
            this.grpstatic.Location = new System.Drawing.Point(44, 310);
            this.grpstatic.Name = "grpstatic";
            this.grpstatic.Size = new System.Drawing.Size(223, 91);
            this.grpstatic.TabIndex = 7;
            this.grpstatic.TabStop = false;
            this.grpstatic.Text = "grpstatic";
            // 
            // instanceVar
            // 
            this.instanceVar.Location = new System.Drawing.Point(62, 21);
            this.instanceVar.Name = "instanceVar";
            this.instanceVar.Size = new System.Drawing.Size(95, 29);
            this.instanceVar.TabIndex = 8;
            this.instanceVar.Text = "instanceVar";
            this.instanceVar.UseVisualStyleBackColor = true;
            this.instanceVar.Click += new System.EventHandler(this.instanceVar_Click);
            // 
            // staticVar
            // 
            this.staticVar.Location = new System.Drawing.Point(62, 62);
            this.staticVar.Name = "staticVar";
            this.staticVar.Size = new System.Drawing.Size(75, 23);
            this.staticVar.TabIndex = 9;
            this.staticVar.Text = "staticVar";
            this.staticVar.UseVisualStyleBackColor = true;
            this.staticVar.Click += new System.EventHandler(this.staticVar_Click);
            // 
            // instanceCount
            // 
            this.instanceCount.AutoSize = true;
            this.instanceCount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.instanceCount.Location = new System.Drawing.Point(290, 331);
            this.instanceCount.Name = "instanceCount";
            this.instanceCount.Size = new System.Drawing.Size(96, 16);
            this.instanceCount.TabIndex = 8;
            this.instanceCount.Text = "instanceCount";
            // 
            // staticCount
            // 
            this.staticCount.AutoSize = true;
            this.staticCount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.staticCount.Location = new System.Drawing.Point(300, 379);
            this.staticCount.Name = "staticCount";
            this.staticCount.Size = new System.Drawing.Size(77, 16);
            this.staticCount.TabIndex = 9;
            this.staticCount.Text = "staticCount";
            // 
            // HelloFrom
            // 
            this.HelloFrom.Location = new System.Drawing.Point(537, 372);
            this.HelloFrom.Name = "HelloFrom";
            this.HelloFrom.Size = new System.Drawing.Size(75, 23);
            this.HelloFrom.TabIndex = 10;
            this.HelloFrom.Text = "HelloFrom";
            this.HelloFrom.UseVisualStyleBackColor = true;
            this.HelloFrom.Click += new System.EventHandler(this.HelloFrom_Click);
            // 
            // Frm_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelloFrom);
            this.Controls.Add(this.staticCount);
            this.Controls.Add(this.instanceCount);
            this.Controls.Add(this.grpstatic);
            this.Controls.Add(this.grp_01);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lab_Then);
            this.Controls.Add(this.Lab_2);
            this.Controls.Add(this.LabCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_01);
            this.Name = "Frm_M12";
            this.Text = "Frm_M12";
            this.grp_01.ResumeLayout(false);
            this.grpstatic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_01;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabCount;
        private System.Windows.Forms.Button Lab_2;
        private System.Windows.Forms.Label Lab_Then;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grp_01;
        private System.Windows.Forms.Button Btn_05;
        private System.Windows.Forms.Button Btn_04;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpstatic;
        private System.Windows.Forms.Button staticVar;
        private System.Windows.Forms.Button instanceVar;
        private System.Windows.Forms.Label instanceCount;
        private System.Windows.Forms.Label staticCount;
        private System.Windows.Forms.Button HelloFrom;
    }
}