using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Product_Complaint_Registration.User
{
    public partial class Reg : System.Web.UI.Page
    {
         BAL.RegisterBAL objprdtd1 = new BAL.RegisterBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprdtd1.usrname =  TextBox1.Text;
            objprdtd1 .usraddress = TextBox4.Text;
            objprdtd1.usremail = TextBox2.Text;
            objprdtd1.usrphone = TextBox3.Text;



            string gender = string.Empty;
            if (RadioButton1.Checked)
            {
                gender = "Male";
            }
            else if (RadioButton2.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Others";
            }
            objprdtd1.usrgender = gender;

            objprdtd1.username = TextBox4.Text;
            objprdtd1.usrpswd = TextBox5.Text;
            object ob = objprdtd1.user_login_insert();
            objprdtd1.usrid = ob;
            int j = objprdtd1.usr_reg();
            
            Response.Write("<script>alert('Invalid Credentials');</script>");
            Response.Redirect("../Guest/Firstform.aspx");
        }
        }
    }

    
