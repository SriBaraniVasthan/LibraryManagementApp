//2979
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class ReturnBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<User> listUser = new List<User>();
                DBclass objDB = new DBclass();
                listUser = objDB.UserDdl();
                ddl_User.DataSource = listUser;
                ddl_User.DataTextField = "UserName";
                ddl_User.DataValueField = "UserID";
                ddl_User.DataBind();
                ddl_User.Items.Insert(0, "select");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Book objBook= new Book();
            DBclass objDB = new DBclass();
            objBook.UserID = int.Parse(ddl_User.SelectedItem.Value);
            objBook.BookID = int.Parse(TextBox1.Text);
            objBook.ReturnDate = (Calendar1.SelectedDate);
            Session["bookId"] = objBook.BookID;
            int i = objDB.Update(objBook);
            objBook.IssueDate = DateTime.Now;
            TimeSpan difference = objBook.IssueDate - objBook.ReturnDate;
            Double days = difference.TotalDays;
            //int i;
            //if (days<3)
            //{
            //    i = objDB.Update(objBook); 
            //}
            //else
            //{

            //}

            if (i > 0)
            {
                Response.Redirect("Success.aspx");
            }

        

        }
    }
}