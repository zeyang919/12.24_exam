using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _12._24_exam
{
    public partial class _3__2_购票订单详情 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["电影"].ToString();
            Label2.Text = Session["日期"].ToString();
            Label3.Text = Session["number"].ToString();
            Label4.Text = Session["money"].ToString();

        }
    }
}