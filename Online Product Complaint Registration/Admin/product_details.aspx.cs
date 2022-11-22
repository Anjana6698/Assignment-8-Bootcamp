using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Product_Complaint_Registration.Admin
{
    public partial class product_details : System.Web.UI.Page
    {
        BAL.productBAL objprdtdl = new BAL.productBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objprdtdl.viewproduct();
                GridView1.DataBind();
            
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            objprdtdl.tbl_product = TextBox1.Text;
            int i = objprdtdl.insertproduct();
            GridView1.DataSource = objprdtdl.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objprdtdl.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            objprdtdl.productid = id.ToString();
            objprdtdl.tbl_product = txt.Text;
            int i = objprdtdl.updateProduct();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprdtdl.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprdtdl.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objprdtdl.productid = id.ToString();
            int i = objprdtdl.deleteProduct();
            GridView1.DataSource = objprdtdl.viewproduct();
            GridView1.DataBind();
        }

      
    }
}