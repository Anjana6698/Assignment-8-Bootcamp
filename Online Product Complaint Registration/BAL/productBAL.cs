using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Online_Product_Complaint_Registration.BAL
{

    public class productBAL
    {
        DAL.productDAL objprdtdl = new DAL.productDAL();

        private string _product;
        public string _productid;
        public string tbl_product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
            }
        }
        public string productid
        {
            get
            {
                return _productid;
            }
            set
            {
                _productid = value;
            }
        }

        public int insertproduct()
        {
            return objprdtdl.insert_tbl_product(this);
        }



        public DataTable viewproduct()
        {
            return objprdtdl.view_product();
        }
        public int updateProduct()
        {
            return objprdtdl.Update_Product(this);
        }
        public int deleteProduct()
        {
            return objprdtdl.Delete_Product(this);
        }






    }
}