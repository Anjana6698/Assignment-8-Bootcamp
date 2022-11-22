using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Product_Complaint_Registration.User
{
    public partial class viewcomplaint : System.Web.UI.Page
    {
        BAL.complaintBAL objprdtdl = new BAL.complaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objprdtdl.userViewComplaint();
                GridView1.DataBind();
            }
        }
    }
}