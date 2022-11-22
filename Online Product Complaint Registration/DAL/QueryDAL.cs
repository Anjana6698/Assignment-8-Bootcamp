using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Online_Product_Complaint_Registration.DAL
{
    public class QueryDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public QueryDAL()
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

        public int queryReg(BAL.QueryBAL obj)
        {
            string s = "insert into tbl_query  values('" + obj.userid + "','" + obj.productid + "','" + obj.querymsg + "','"+obj.queryrply+"','" + DateTime.Now.ToLongDateString().ToString() + "')";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable Product_list()
        {

            string qry = "select  * from tbl_product";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        public DataTable view_query(BAL.QueryBAL obj)
        {
            //string qry = "select r.*,d.* from tbl_complaint d INNER JOIN tbl_product r  ON r.pId=d.pId AND id='" + obj.usrid +"'";
            string qry = "select r.*,d.* from tbl_query d INNER JOIN tbl_product r  ON r.pId=d.pId";

            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int give_reply(BAL.QueryBAL obj)
        {
            string s = "update tbl_query  set reply='" + obj.queryrply + "' where qId='" + obj.queryid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

    }
}