using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;

namespace Online_Product_Complaint_Registration.BAL
{
   
    public class complaintBAL
    {
        DAL.complaintDAL objprdtdl = new DAL.complaintDAL();
        public int _productid;
        public int _userid;
        private string _cmpmsg;
        private string _cmpsts;
        private string _cmpdate;
        private object _cid;

        public int productid
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
        public int userid
        {
            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
            }
        }
        public string cmpmsg
        {
            get
            {
                return _cmpmsg;
            }
            set
            {
                _cmpmsg = value;
            }
        }
        public string cmpsts
        {
            get
            {
                return _cmpsts;
            }
            set
            {
                _cmpsts = value;
            }
        }
        public string cmpdate
        {
            get
            {
                return _cmpdate;
            }
            set
            {
                _cmpdate = value;
            }
        }
        public object cid
        {
            get
            {
                return _cid;
            }
            set
            {
                _cid = value;
            }
        }
        public int complaint_reg()
        {
            return objprdtdl.complaintReg(this);
        }
        public DataTable ProductValues()
        {
            return objprdtdl.Product_list();
        }


        public DataTable UsersList()
        {
            return objprdtdl.users_list();
        }
        public DataTable viewComplaints()
        {
            return objprdtdl.view_complaints(this);
        }
        public int updateStatus()
        {
            return objprdtdl.Update_Status(this);
        }
        public DataTable userViewComplaint()
        {
            return objprdtdl.user_view_complaints();
        }



    }
    }
