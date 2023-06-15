namespace Lab_Form
{
    partial class la
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(la));
            this.labName = new System.Windows.Forms.Label();
            this.button_Hello = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.buttonok = new System.Windows.Forms.Button();
            this.StaticVar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(710, 332);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(87, 16);
            this.labName.TabIndex = 0;
            this.labName.Text = "請輸入姓名";
            // 
            // button_Hello
            // 
            this.button_Hello.Location = new System.Drawing.Point(821, 382);
            this.button_Hello.Name = "button_Hello";
            this.button_Hello.Size = new System.Drawing.Size(100, 24);
            this.button_Hello.TabIndex = 2;
            this.button_Hello.Text = "Say_Hello";
            this.button_Hello.UseVisualStyleBackColor = true;
            this.button_Hello.Click += new System.EventHandler(this.button_Hello_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(821, 326);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 3;
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(771, 427);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(75, 23);
            this.buttonok.TabIndex = 4;
            this.buttonok.Text = "buttonok";
            this.buttonok.UseVisualStyleBackColor = true;
            // 
            // StaticVar
            // 
            this.StaticVar.Location = new System.Drawing.Point(807, 220);
            this.StaticVar.Name = "StaticVar";
            this.StaticVar.Size = new System.Drawing.Size(75, 23);
            this.StaticVar.TabIndex = 5;
            this.StaticVar.Text = "StaticVar";
            this.StaticVar.UseVisualStyleBackColor = true;
            this.StaticVar.Click += new System.EventHandler(this.StaticVar_Click);
            // 
            // la
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(938, 467);
            this.Controls.Add(this.StaticVar);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.button_Hello);
            this.Controls.Add(this.labName);
            this.Name = "la";
            this.Text = "Hello Form";
            this.Load += new System.EventHandler(this.la_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button button_Hello;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Button StaticVar;
    }
}

