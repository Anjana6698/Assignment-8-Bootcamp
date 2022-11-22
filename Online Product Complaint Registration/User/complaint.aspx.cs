using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Product_Complaint_Registration.User
{
    public partial class complaint : System.Web.UI.Page
    {
        BAL.complaintBAL objprdtdl = new BAL.complaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                productid_bind();

                Label6.Text = DateTime.Now.ToLongDateString().ToString();
            }
        }
        public void productid_bind()
        {
            DataTable prod = objprdtdl.ProductValues();
            DropDownList2.DataSource = objprdtdl.ProductValues();
            DropDownList2.DataTextField = "pid";
            DropDownList2.DataValueField = "pid";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("-- Select --", "0"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprdtdl.productid = Convert.ToInt32(DropDownList2.SelectedValue);
            objprdtdl.userid = Convert.ToInt32(Session["userid"]);
            objprdtdl.cmpmsg = TextBox1.Text;
            int i = objprdtdl.complaint_reg();
            if (i == 1)
            {
                Response.Write("<script>alert('Complaint Registered Successfully');</script>");
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Complaint Registered Successfully" + "');");
            }
        }
    }
}


    
