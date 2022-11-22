using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Product_Complaint_Registration.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        BAL.RegisterBAL objctd1 = new BAL.RegisterBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        } 
        protected void Button1_Click(object sender, EventArgs e)
        {
            objctd1.username = TextBox1.Text;
            objctd1.usrpswd = TextBox2.Text;
            DataTable dt = objctd1.usrlogin();

            if (dt.Rows.Count == 1)
            {

                if (dt.Rows[0]["usertype"].ToString() == "admin")
                {
                    Response.Redirect("../Admin/Home.aspx");
                }
                else if (dt.Rows[0]["usertype"].ToString() == "User")
                {
                    if (dt.Rows[0]["status"].ToString() == "confirmed")
                    {
                        Response.Redirect("../User/user.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Wait for confirmation');</script>");
                    }
                }
            }
        }
    }
    }
    

                    
                        
                    
                        
       
