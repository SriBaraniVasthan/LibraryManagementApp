using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem
{
    public class Book
    {

        int bookID;

        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }
        DateTime issueDate;

        public DateTime IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }

        DateTime returnDate;

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        int transactionID;

        public int TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
    }
}