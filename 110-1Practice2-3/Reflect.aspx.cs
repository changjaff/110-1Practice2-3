using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_3
{
    public partial class Reflect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int M = 663166;  //要判斷的數值
            int M2 = 0; // 儲存原始數值
            int rev_M = 0; //辨識第幾位數(餘數)
            int sum = 0; //計算後的餘數

            M2 = M;


            while (M != 0)
            {
                sum = M % 10;
                rev_M = rev_M * 10 + sum;
                M = M / 10;
            }

            if (M2 == rev_M)
                Response.Write("True");
            else
                Response.Write("Flase");


        }
    }
}