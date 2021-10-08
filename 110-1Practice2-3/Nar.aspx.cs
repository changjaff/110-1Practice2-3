using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_3
{
    public partial class Nar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int num = 153;  //原始指定數值
            int num_new, rem, sum = 0;  //num_new為複製一個原始數值、 rem為辨識第幾位數(餘數)、 sum 為儲存加總結果

            num_new = num;

            while (num_new != 0)
            {
                rem = num_new % 10;  //算出第幾位數
                sum = sum + (rem * rem * rem); // 算出相乘幾次方並加總
                num_new = num_new / 10; //去掉一位數
            }
            //以上重覆到各數算完為止(<=0)

            if (sum == num)
            {
                Response.Write("True");
            }  
            else
            {
                Response.Write("Flase");
            }
            //辦別是否 符合阿姆斯壯數 規則  






        }
    }
}