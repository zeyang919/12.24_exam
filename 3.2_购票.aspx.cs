using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _12._24_exam
{
    public partial class 购票 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["电影"] = RadioButtonList1.SelectedItem.Text;
            int price = Convert.ToInt32(RadioButtonList1.SelectedValue);
            DateTime date1 = Convert.ToDateTime(TextBox1.Text);
            int number = Convert.ToInt32(DropDownList1.SelectedValue);
            Session["number"] = number;
            if (date1.DayOfWeek == DayOfWeek.Sunday || date1.DayOfWeek == DayOfWeek.Saturday || date1.DayOfWeek == DayOfWeek.Friday)
            {
                Session["日期"] = "周末票";
                Session["money"] = (price + 20) * number;

            }
            else
            {
                Session["日期"] = "非周末票";
                Session["money"] = price * number;
            }
            Response.Redirect("3.2_购票订单详情.aspx");
        }
    }
}