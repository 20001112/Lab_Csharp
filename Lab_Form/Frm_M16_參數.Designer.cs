namespace Lab_Form
{
    partial class Frm_M16_參數
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
            this.btnByValue = new System.Windows.Forms.Button();
            this.btnByReference = new System.Windows.Forms.Button();
            this.ByREf = new System.Windows.Forms.Button();
            this.BtnByOut = new System.Windows.Forms.Button();
            this.BtnParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnByValue
            // 
            this.btnByValue.Location = new System.Drawing.Point(405, 70);
            this.btnByValue.Name = "btnByValue";
            this.btnByValue.Size = new System.Drawing.Size(75, 23);
            this.btnByValue.TabIndex = 0;
            this.btnByValue.Text = "ByValue";
            this.btnByValue.UseVisualStyleBackColor = true;
            this.btnByValue.Click += new System.EventHandler(this.btnByValue_Click);
            // 
            // btnByReference
            // 
            this.btnByReference.Location = new System.Drawing.Point(473, 176);
            this.btnByReference.Name = "btnByReference";
            this.btnByReference.Size = new System.Drawing.Size(75, 23);
            this.btnByReference.TabIndex = 1;
            this.btnByReference.Text = "btnByReference";
            this.btnByReference.UseVisualStyleBackColor = true;
            this.btnByReference.Click += new System.EventHandler(this.btnByReference_Click);
            // 
            // ByREf
            // 
            this.ByREf.Location = new System.Drawing.Point(473, 292);
            this.ByREf.Name = "ByREf";
            this.ByREf.Size = new System.Drawing.Size(75, 23);
            this.ByREf.TabIndex = 2;
            this.ByREf.Text = "ByREf";
            this.ByREf.UseVisualStyleBackColor = true;
            this.ByREf.Click += new System.EventHandler(this.ByREf_Click);
            // 
            // BtnByOut
            // 
            this.BtnByOut.Location = new System.Drawing.Point(243, 239);
            this.BtnByOut.Name = "BtnByOut";
            this.BtnByOut.Size = new System.Drawing.Size(75, 23);
            this.BtnByOut.TabIndex = 3;
            this.BtnByOut.Text = "ByOut";
            this.BtnByOut.UseVisualStyleBackColor = true;
            this.BtnByOut.Click += new System.EventHandler(this.BtnByOut_Click);
            // 
            // BtnParams
            // 
            this.BtnParams.Location = new System.Drawing.Point(280, 344);
            this.BtnParams.Name = "BtnParams";
            this.BtnParams.Size = new System.Drawing.Size(75, 23);
            this.BtnParams.TabIndex = 4;
            this.BtnParams.Text = "Params";
            this.BtnParams.UseVisualStyleBackColor = true;
            this.BtnParams.Click += new System.EventHandler(this.BtnParams_Click);
            // 
            // Frm_M16_參數
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnParams);
            this.Controls.Add(this.BtnByOut);
            this.Controls.Add(this.ByREf);
            this.Controls.Add(this.btnByReference);
            this.Controls.Add(this.btnByValue);
            this.Name = "Frm_M16_參數";
            this.Text = "Frm_M16_參數";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnByValue;
        private System.Windows.Forms.Button btnByReference;
        private System.Windows.Forms.Button ByREf;
        private System.Windows.Forms.Button BtnByOut;
        private System.Windows.Forms.Button BtnParams;
    }
}