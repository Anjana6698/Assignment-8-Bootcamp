using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Product_Complaint_Registration.Admin
{
    public partial class viewquery : System.Web.UI.Page
    {
        BAL.QueryBAL objprdtdl = new BAL.QueryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objprdtdl.viewQueries();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objprdtdl.viewQueries();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[8].Controls[0];
            objprdtdl.queryid = id.ToString();
            objprdtdl.queryrply = txt.Text;
            int i = objprdtdl.giveReply();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprdtdl.viewQueries();
            GridView1.DataBind();
        }
    }
}