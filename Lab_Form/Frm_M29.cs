using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M29 : Form
    {
        public Frm_M29()
        {
            InitializeComponent();
        }
        ArrayList IsProduct = new ArrayList();
        int count;

        private void Btn_Add_Click(object sender, EventArgs e)
        {

            Product pro;
            pro.Name = txt_Product.Text;
            pro.UnitPrice=decimal.Parse(txt_ProductUnitPrice.Text);
            IsProduct.Add(pro);
            lab_Show.Text = "產品\n--------";
            decimal totalPrice = 0;
            //for (int i = 0; i < IsProduct.Count; i++)
            //{

            //    lab_Show.Text += $"名稱{((Product)IsProduct[i]).Name}," +
            //        $"單價{((Product)IsProduct[i]).UnitPrice}\n";
            //    totalPrice += ((Product)IsProduct[i]).UnitPrice;
            //}
            //lab_Show.Text += $"-------\n產品數量:{IsProduct.Count}"+$"平均價格{totalPrice/IsProduct.Count}";
            //foreach(Product pro in IsProduct)
        }
        public void ShowProducts()
        {
            lab_Show.Text = "產品\n--------";
            decimal totalPrice = 0;
            for (int i = 0; i < IsProduct.Count; i++)
            {

                lab_Show.Text += $"名稱{((Product)IsProduct[i]).Name}," +
                    $"單價{((Product)IsProduct[i]).UnitPrice}\n";
                totalPrice += ((Product)IsProduct[i]).UnitPrice;
            }

            lab_Show.Text += $"-------\n產品數量:{IsProduct.Count}";
            if(IsProduct.Count > 0)
            {
               lab_Show.Text+= $"平均價格{totalPrice / IsProduct.Count}";
            }
        }






        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = txt_Product.Text;
            pro.UnitPrice = decimal.Parse(txt_ProductUnitPrice.Text);
            IsProduct.Insert(0, pro);
            ShowProducts();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            IsProduct.RemoveAt(0);
            ShowProducts();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            IsProduct.Clear();
            ShowProducts();
        }

        private void Btn_join_Click(object sender, EventArgs e)
        {
            IsProduct.Add("string");
            IsProduct.Add("100");
            ShowProducts();
        }
    }
}
