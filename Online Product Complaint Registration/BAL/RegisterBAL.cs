using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Online_Product_Complaint_Registration.BAL
{
    public class RegisterBAL
    {
        DAL.RegisterDAL objprdtdl = new DAL.RegisterDAL();
        private string _usrname;
        private string _usraddress;
        private string _usrgender;
        private string _usremail;
        private string _usrphone;
        private string _usrpswd;
        private string _username;
        private object _usrlid;
        private object _usrid;
        public string usrname
        {
            get
            {
                return _usrname;
            }
            set
            {
                _usrname = value;
            }
        }
        public string usraddress
        {
            get
            {
                return _usraddress;
            }
            set
            {
                _usraddress = value;
            }
        }
        public string usrgender
        {
            get
            {
                return _usrgender;
            }
            set
            {
                _usrgender = value;
            }
        }
        public string usremail
        {
            get
            {
                return _usremail;
            }
            set
            {
                _usremail = value;
            }
        }
        public string usrphone
        {
            get
            {
                return _usrphone;
            }
            set
            {
                _usrphone = value;
            }
        }
        public string usrpswd
        {
            get
            {
                return _usrpswd;
            }
            set
            {
                _usrpswd = value;
            }
        }
        public object usrlid
        {
            get
            {
                return _usrlid;
            }
            set
            {
                _usrlid = value;
            }
        }
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public object usrid
        {
            get
            {
                return _usrid;
            }
            set
            {
                _usrid = value;
            }
        }
        public object user_login_insert()
        {
            return objprdtdl.userlogin(this);
        }
        
        public int usr_reg()
        {
            return objprdtdl.usr_reg(this);
        }
        public DataTable viewusers()
        {
            return objprdtdl.view_users();
        }


        public int confirmuser()
        {
            return objprdtdl.confirm_user(this);
        }
        public DataTable usrlogin()
        {
            return objprdtdl.usr_login(this);
        }

    }
}