using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Online_Product_Complaint_Registration.DAL
{
    public class RegisterDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public RegisterDAL()
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
        public object userlogin(BAL.RegisterBAL obj)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tbl_login values('" + obj.username + "','" + obj.usrpswd + "','Not confirmed','User');select @@IDENTITY";


            object id = cmd.ExecuteScalar();
            return id;
        }
        public int usr_reg(BAL.RegisterBAL obj)
        {


            string s = "insert into Registration values('" + obj.usrname + "','" + obj.usraddress + "','" + obj.usremail + "','" + obj.usrphone + "','" + obj.usrgender +"','"+obj.usrid + "')";

            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable view_users()
        {
            string qry = "select s.*,l.* from Registration s inner join tbl_login l on s.uId=l.uId where l.status='not confirmed' and l.usertype='User'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int confirm_user(BAL.RegisterBAL obj)
        {

            string s = "update tbl_login set status='confirmed' where uId=" + obj.usrid + "";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable usr_login(BAL.RegisterBAL obj)
        {
            
           string s = "select s.*,l.* from Registration s inner join tbl_login l on s.uId=l.Uid  WHERE l.username='" + obj.username + "' AND password='" + obj.usrpswd + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}