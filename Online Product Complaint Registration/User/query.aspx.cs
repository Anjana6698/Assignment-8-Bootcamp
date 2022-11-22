using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Online_Product_Complaint_Registration.User
{
    public partial class query : System.Web.UI.Page
    {
        BAL.QueryBAL objprdtdl = new BAL.QueryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                name_bind();
            }
        }
        public void name_bind()
        {
            DataTable prod = objprdtdl.ProductValues();
            DropDownList1.DataSource = objprdtdl.ProductValues();
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "name";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("-- Select --", "0"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprdtdl.productid = Convert.ToInt32(DropDownList1.SelectedIndex);
            objprdtdl.userid = Convert.ToInt32(Session["userid"]);
            objprdtdl.queryrply = null;
            objprdtdl.querymsg = TextBox1.Text;
            int i = objprdtdl.query_reg();
            if (i == 1)
            {
                Response.Write("<script>alert('Query Registered Successfully');</script>");
            }
        }
    }
}