using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Product_Complaint_Registration.Admin
{
   
    public partial class confirm : System.Web.UI.Page
    {
        BAL.RegisterBAL objprdtdl = new BAL.RegisterBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objprdtdl.viewusers();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s = GridView1.DataKeys[e.RowIndex].Value.ToString();
            objprdtdl.usrid=s;
           
            int i = objprdtdl.confirmuser();
            GridView1.DataSource = objprdtdl.viewusers();
            GridView1.DataBind();
        }
    }
}