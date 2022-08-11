using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            int ilksayi = Convert.ToInt32(TextBox1.Text);
            int sonsayi = Convert.ToInt32(TextBox2.Text);

            int sayi = ilksayi;
            bool durum = true;
            while (sayi < sonsayi)
            {
                sayi++;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        durum = false;
                    }
                }
                if (durum == true && sayi != 1)
                {
                    ListBox1.Items.Add(sayi.ToString());
                }
                durum = true;
            }

            //www.yazilimkodlama.com
            Label1.Text = "Ýki Sayý Arasýnda " + ListBox1.Items.Count.ToString() + " Tane Asal Sayý Var";
        }
    }
}