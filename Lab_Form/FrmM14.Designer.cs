namespace Lab_Form
{
    partial class FrmM14
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
            this.BtnValueType = new System.Windows.Forms.Button();
            this.BtnReferenceType = new System.Windows.Forms.Button();
            this.txtReferenceTy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnValueType
            // 
            this.BtnValueType.Location = new System.Drawing.Point(506, 176);
            this.BtnValueType.Name = "BtnValueType";
            this.BtnValueType.Size = new System.Drawing.Size(75, 23);
            this.BtnValueType.TabIndex = 0;
            this.BtnValueType.Text = "BtnValueType";
            this.BtnValueType.UseVisualStyleBackColor = true;
            this.BtnValueType.Click += new System.EventHandler(this.BtnValueType_Click);
            // 
            // BtnReferenceType
            // 
            this.BtnReferenceType.Location = new System.Drawing.Point(363, 206);
            this.BtnReferenceType.Name = "BtnReferenceType";
            this.BtnReferenceType.Size = new System.Drawing.Size(75, 31);
            this.BtnReferenceType.TabIndex = 1;
            this.BtnReferenceType.Text = "ReferenceType";
            this.BtnReferenceType.UseVisualStyleBackColor = true;
            this.BtnReferenceType.TextChanged += new System.EventHandler(this.BtnReferenceType_TextChanged);
            this.BtnReferenceType.Click += new System.EventHandler(this.BtnReferenceType_Click);
            // 
            // txtReferenceTy
            // 
            this.txtReferenceTy.Location = new System.Drawing.Point(338, 118);
            this.txtReferenceTy.Name = "txtReferenceTy";
            this.txtReferenceTy.Size = new System.Drawing.Size(100, 22);
            this.txtReferenceTy.TabIndex = 2;
            // 
            // FrmM14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReferenceTy);
            this.Controls.Add(this.BtnReferenceType);
            this.Controls.Add(this.BtnValueType);
            this.Name = "FrmM14";
            this.Text = "FrmM14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnValueType;
        private System.Windows.Forms.Button BtnReferenceType;
        private System.Windows.Forms.TextBox txtReferenceTy;
    }
}