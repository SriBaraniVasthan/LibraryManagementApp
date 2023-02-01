//2979
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class ViewcurrentTrasactionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
      
    
        void Binddata(List<Book> listUser)
        {
            gvr_trans.DataSource = listUser;
            gvr_trans.DataBind();

        }
          

          protected void txt_userid_TextChanged(object sender, EventArgs e)
          {
              Book objBook = new Book();
              DBclass objDB = new DBclass();
              List<Book> listUser = new List<Book>();
              int UserID = int.Parse(txt_userid.Text);
              listUser = objDB.viewSelUserDetails(UserID);
              Binddata(listUser);
          }




          protected void gvr_trans_RowDeleting(object sender, GridViewDeleteEventArgs e)
          {
              DBclass obj = new DBclass();
              GridViewRow gvr = gvr_trans.Rows[e.RowIndex];

              Label lbl = gvr.FindControl("Label2") as Label;
              string TransNo = lbl.Text;
              bool flag = obj.RemoveTrans(TransNo);
              if (flag)
                  ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Transaction ID is removed successfully')", true);
              else
                  ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Invalid Transaction ID ')", true);
              Book objBook = new Book();
              DBclass objDB = new DBclass();
              List<Book> listUser = new List<Book>();
              int UserID = int.Parse(txt_userid.Text);
              listUser = objDB.viewSelUserDetails(UserID);
              gvr_trans.DataSource = listUser;
              gvr_trans.DataBind();
          }

    }
}