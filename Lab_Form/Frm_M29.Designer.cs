namespace Lab_Form
{
    partial class Frm_M29
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
            this.Lab_Product = new System.Windows.Forms.Label();
            this.Lab_ProductUnitprice = new System.Windows.Forms.Label();
            this.txt_Product = new System.Windows.Forms.TextBox();
            this.txt_ProductUnitPrice = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.lab_Show = new System.Windows.Forms.Label();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_join = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab_Product
            // 
            this.Lab_Product.AutoSize = true;
            this.Lab_Product.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Product.Location = new System.Drawing.Point(80, 79);
            this.Lab_Product.Name = "Lab_Product";
            this.Lab_Product.Size = new System.Drawing.Size(89, 19);
            this.Lab_Product.TabIndex = 0;
            this.Lab_Product.Text = "產品名稱";
            // 
            // Lab_ProductUnitprice
            // 
            this.Lab_ProductUnitprice.AutoSize = true;
            this.Lab_ProductUnitprice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_ProductUnitprice.Location = new System.Drawing.Point(80, 152);
            this.Lab_ProductUnitprice.Name = "Lab_ProductUnitprice";
            this.Lab_ProductUnitprice.Size = new System.Drawing.Size(89, 19);
            this.Lab_ProductUnitprice.TabIndex = 1;
            this.Lab_ProductUnitprice.Text = "產品單價";
            // 
            // txt_Product
            // 
            this.txt_Product.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Product.Location = new System.Drawing.Point(202, 71);
            this.txt_Product.Name = "txt_Product";
            this.txt_Product.Size = new System.Drawing.Size(127, 27);
            this.txt_Product.TabIndex = 2;
            // 
            // txt_ProductUnitPrice
            // 
            this.txt_ProductUnitPrice.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ProductUnitPrice.Location = new System.Drawing.Point(202, 144);
            this.txt_ProductUnitPrice.Name = "txt_ProductUnitPrice";
            this.txt_ProductUnitPrice.Size = new System.Drawing.Size(127, 27);
            this.txt_ProductUnitPrice.TabIndex = 3;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(373, 63);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(120, 55);
            this.Btn_Add.TabIndex = 4;
            this.Btn_Add.Text = "讚讚";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // lab_Show
            // 
            this.lab_Show.AutoSize = true;
            this.lab_Show.BackColor = System.Drawing.Color.IndianRed;
            this.lab_Show.Location = new System.Drawing.Point(581, 85);
            this.lab_Show.Name = "lab_Show";
            this.lab_Show.Size = new System.Drawing.Size(33, 12);
            this.lab_Show.TabIndex = 5;
            this.lab_Show.Text = "label1";
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Location = new System.Drawing.Point(373, 144);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(120, 56);
            this.Btn_Insert.TabIndex = 6;
            this.Btn_Insert.Text = "Insert";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(373, 206);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(120, 56);
            this.Btn_Remove.TabIndex = 7;
            this.Btn_Remove.Text = "Remove";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(373, 288);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(120, 56);
            this.Btn_Clear.TabIndex = 8;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_join
            // 
            this.Btn_join.Location = new System.Drawing.Point(49, 271);
            this.Btn_join.Name = "Btn_join";
            this.Btn_join.Size = new System.Drawing.Size(120, 56);
            this.Btn_join.TabIndex = 9;
            this.Btn_join.Text = "加入不同資料型別";
            this.Btn_join.UseVisualStyleBackColor = true;
            this.Btn_join.Click += new System.EventHandler(this.Btn_join_Click);
            // 
            // Frm_M29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_join);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.lab_Show);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.txt_ProductUnitPrice);
            this.Controls.Add(this.txt_Product);
            this.Controls.Add(this.Lab_ProductUnitprice);
            this.Controls.Add(this.Lab_Product);
            this.Name = "Frm_M29";
            this.Text = "Frm_M29";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Product;
        private System.Windows.Forms.Label Lab_ProductUnitprice;
        private System.Windows.Forms.TextBox txt_Product;
        private System.Windows.Forms.TextBox txt_ProductUnitPrice;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label lab_Show;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_join;
    }
}