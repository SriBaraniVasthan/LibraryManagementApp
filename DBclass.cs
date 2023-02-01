using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManagementSystem
{
    public class DBclass
    {

        SqlConnection cn;
        SqlCommand cmd;       
        private SqlConnection EstConnection()
        {
            string connectStr = System.Configuration.ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            try
            {
                if (!string.IsNullOrEmpty(connectStr))
                {
                    return new SqlConnection(connectStr);
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }


        public List<User> UserDdl()
        {

            try
            {


                List<User> lst = new List<User>();
                cn = EstConnection();
                cn.Open();
                cmd = new SqlCommand("sp_UserDdl", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    User objUser = new User();
                    objUser.UserID = int.Parse(dr["UserID"].ToString());
                    objUser.UserName = dr["UserName"].ToString();

                    lst.Add(objUser);
                }

                return lst;


            }
            catch (Exception ex)
            {
                return null;

            }

            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();


            }
        }

        public int Update(Book objBook)
        {
            int i = 0;

            try
            {


                cn = EstConnection();
                cn.Open();
                cmd = new SqlCommand("sp_update",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BookID", objBook.BookID));
                cmd.Parameters.Add(new SqlParameter("@UserID", objBook.UserID));
                cmd.Parameters.Add(new SqlParameter("@ReturnDate", objBook.ReturnDate));
               
                i = cmd.ExecuteNonQuery();

                return i;

            }
            catch (Exception ex)
            {

                return 0;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }

        }


        public List<Book> viewSelUserDetails(int UserID)
        {
            Book objBook;
            List<Book> lst = new List<Book>();
            SqlDataAdapter da;

            try
            {
                cn = EstConnection();
                cmd = new SqlCommand();
                cmd.CommandText = "sp_GridData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet UserDS = new DataSet();
                da.Fill(UserDS);

                foreach (DataRow dr in UserDS.Tables[0].Rows)
                {
                    objBook = new Book();
                    objBook.TransactionID = int.Parse(dr["TransactionID"].ToString());
                    objBook.BookID = int.Parse(dr["BookID"].ToString());
                    objBook.ReturnDate = DateTime.Parse(dr["ReturnDate"].ToString());
                    lst.Add(objBook);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }

            return lst;

        }



        public bool RemoveTrans(string TransID)
        {
            try
            {
                cn = EstConnection();
                cn.Open();
                cmd = new SqlCommand("sp_RemoveTrans", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TransID", TransID));
                int i = cmd.ExecuteNonQuery();
                cn.Close();

                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

        }





    }
}