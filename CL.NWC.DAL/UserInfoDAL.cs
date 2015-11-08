using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL.NWC.Model;
using System.Data.OleDb;
using System.Data;

namespace CL.NWC.DAL
{
    public  class UserInfoDAL
    {
        private UserInfo DRToObj(DataRow dr)
        {
            UserInfo ui = new UserInfo();
            if (dr["RegisterDate"]==null||dr["RegisterDate"].ToString().Equals(""))
            {
                ui.RegisterDate = null;
            }
            else
            {
                ui.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
            }
            ui.Phone = dr["Phone"].ToString();
            ui.UserID=Convert.ToInt32( dr["UserID"]);
            if (dr["UserName"] == null || dr["UserName"].ToString().Equals(""))
            {
                ui.UserName = "";
            }
            else
            {
                ui.UserName = dr["UserName"].ToString();
            }

            if (dr["UserPwd"] == null || dr["UserPwd"].ToString().Equals(""))
            {
                ui.UserPwd = "";
            }
            else
            {
                ui.UserPwd = dr["UserPwd"].ToString();
            }
            return ui;
        }
    }
}
