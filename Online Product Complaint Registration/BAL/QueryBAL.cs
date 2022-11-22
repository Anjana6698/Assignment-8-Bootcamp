using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Online_Product_Complaint_Registration.BAL
{
    public class QueryBAL
    {
        DAL.QueryDAL objprdtdl = new DAL.QueryDAL();
        public int _productid;
        public string _productname;
        public int _userid;
        private string _querymsg;
        private string _queryrply;
        private string _queryid;

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
        public string productname
        {
            get
            {
                return _productname;
            }
            set
            {
                _productname = value;
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
        public string querymsg
        {
            get
            {
                return _querymsg;
            }
            set
            {
                _querymsg = value;
            }
        }
        public string queryrply
        {
            get
            {
                return _queryrply;
            }
            set
            {
                _queryrply = value;
            }
        }
        public string queryid
        {
            get
            {
                return _queryid;
            }
            set
            {
                _queryid = value;
            }
        }

        public int query_reg()
        {
            return objprdtdl.queryReg(this);
        }
        public DataTable ProductValues()
        {
            return objprdtdl.Product_list();
        }
        public DataTable viewQueries()
        {
            return objprdtdl.view_query(this);
        }

        //public DataTable userViewComplaint()
        //{
        //    return objdptdl.user_view_reply();
        //}

        public int giveReply()
        {
            return objprdtdl.give_reply(this);
        }

    }
}