//2979
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               Label1.Text = "Looged in time:" + " " + Request.Cookies["Logintime"].Value.ToString();

            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            Response.Redirect("LoginPage.aspx");
        }
    }
}