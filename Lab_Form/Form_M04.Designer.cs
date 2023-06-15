namespace Lab_Form
{
    partial class Form_M04
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
            this.button1 = new System.Windows.Forms.Button();
            this.Math = new System.Windows.Forms.Button();
            this.ReturnMethod = new System.Windows.Forms.Button();
            this.btnFirstClass = new System.Windows.Forms.Button();
            this.封裝 = new System.Windows.Forms.Button();
            this.btn_MypartialClass = new System.Windows.Forms.Button();
            this.NewMember = new System.Windows.Forms.Button();
            this.ReferenceType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Math
            // 
            this.Math.Location = new System.Drawing.Point(686, 102);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(75, 23);
            this.Math.TabIndex = 1;
            this.Math.Text = "Math";
            this.Math.UseVisualStyleBackColor = true;
            this.Math.Click += new System.EventHandler(this.Math_Click);
            // 
            // ReturnMethod
            // 
            this.ReturnMethod.Location = new System.Drawing.Point(677, 324);
            this.ReturnMethod.Name = "ReturnMethod";
            this.ReturnMethod.Size = new System.Drawing.Size(75, 23);
            this.ReturnMethod.TabIndex = 2;
            this.ReturnMethod.Text = "ReturnMethod";
            this.ReturnMethod.UseVisualStyleBackColor = true;
            this.ReturnMethod.Click += new System.EventHandler(this.ReturnMethod_Click);
            // 
            // btnFirstClass
            // 
            this.btnFirstClass.Location = new System.Drawing.Point(686, 281);
            this.btnFirstClass.Name = "btnFirstClass";
            this.btnFirstClass.Size = new System.Drawing.Size(75, 23);
            this.btnFirstClass.TabIndex = 3;
            this.btnFirstClass.Text = "btnFirstClass";
            this.btnFirstClass.UseVisualStyleBackColor = true;
            this.btnFirstClass.Click += new System.EventHandler(this.btnFirstClass_Click);
            // 
            // 封裝
            // 
            this.封裝.Location = new System.Drawing.Point(686, 227);
            this.封裝.Name = "封裝";
            this.封裝.Size = new System.Drawing.Size(75, 23);
            this.封裝.TabIndex = 4;
            this.封裝.Text = "封裝";
            this.封裝.UseVisualStyleBackColor = true;
            this.封裝.Click += new System.EventHandler(this.封裝_Click);
            // 
            // btn_MypartialClass
            // 
            this.btn_MypartialClass.Location = new System.Drawing.Point(686, 167);
            this.btn_MypartialClass.Name = "btn_MypartialClass";
            this.btn_MypartialClass.Size = new System.Drawing.Size(75, 23);
            this.btn_MypartialClass.TabIndex = 5;
            this.btn_MypartialClass.Text = "btn_MypartialClass";
            this.btn_MypartialClass.UseVisualStyleBackColor = true;
            this.btn_MypartialClass.Click += new System.EventHandler(this.btn_MypartialClass_Click);
            // 
            // NewMember
            // 
            this.NewMember.Location = new System.Drawing.Point(363, 214);
            this.NewMember.Name = "NewMember";
            this.NewMember.Size = new System.Drawing.Size(75, 23);
            this.NewMember.TabIndex = 6;
            this.NewMember.Text = "New Member初始化";
            this.NewMember.UseVisualStyleBackColor = true;
            this.NewMember.Click += new System.EventHandler(this.NewMember_Click);
            // 
            // ReferenceType
            // 
            this.ReferenceType.Location = new System.Drawing.Point(229, 237);
            this.ReferenceType.Name = "ReferenceType";
            this.ReferenceType.Size = new System.Drawing.Size(75, 23);
            this.ReferenceType.TabIndex = 7;
            this.ReferenceType.Text = "New Member初始化";
            this.ReferenceType.UseVisualStyleBackColor = true;
            // 
            // Form_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReferenceType);
            this.Controls.Add(this.NewMember);
            this.Controls.Add(this.btn_MypartialClass);
            this.Controls.Add(this.封裝);
            this.Controls.Add(this.btnFirstClass);
            this.Controls.Add(this.ReturnMethod);
            this.Controls.Add(this.Math);
            this.Controls.Add(this.button1);
            this.Name = "Form_M04";
            this.Text = "Form_M04";
            this.Load += new System.EventHandler(this.Form_M04_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Math;
        private System.Windows.Forms.Button ReturnMethod;
        private System.Windows.Forms.Button btnFirstClass;
        private System.Windows.Forms.Button 封裝;
        private System.Windows.Forms.Button btn_MypartialClass;
        private System.Windows.Forms.Button NewMember;
        private System.Windows.Forms.Button ReferenceType;
    }
}