using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem
{
    public class User
    {

        int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}