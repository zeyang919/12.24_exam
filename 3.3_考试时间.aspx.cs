using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace _12._24_exam
{
    public partial class _3__3_考试时间 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            string exam = ConfigurationManager.AppSettings["exam"];
            DateTime examtime = Convert.ToDateTime(exam);
            TimeSpan timeSpan =  examtime- today;
            Response.Write("今天是" + today.ToLongDateString()+"。<br>");
            Response.Write("考试时间是" + examtime.ToLongDateString() + "。<br>");
            Response.Write("还剩" + timeSpan.Days+"天，努力！");
            
        }
    }
}