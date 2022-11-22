using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Online_Product_Complaint_Registration.DAL
{
    public class productDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public productDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }



        public int insert_tbl_product(BAL.productBAL obj)
        {
            string qry = "insert into tbl_product values('" + obj.tbl_product + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }



        public DataTable view_product()
        {
            string qry = "select * from tbl_product";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Update_Product(BAL.productBAL obj)
        {
            string s = "update tbl_product  set name='" + obj.tbl_product + "' where pid='" + obj._productid + "'"; 
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int Delete_Product(BAL.productBAL obj) 
        { 
            string s = "Delete from tbl_product  where pid='" + obj._productid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery(); 
        }


    }
}