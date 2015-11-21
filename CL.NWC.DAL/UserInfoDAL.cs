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
        private static List<UserInfo> DTToObj(DataTable dt)
        {
            if (dt==null)
            {
                return null;
            }
            List<UserInfo> list = new List<UserInfo>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                UserInfo ui = new UserInfo();
                if (dt.Rows[i]["RegisterDate"] == null || dt.Rows[i]["RegisterDate"].ToString().Equals(""))
                {
                    ui.RegisterDate = null;
                }
                else
                {
                    ui.RegisterDate = Convert.ToDateTime(dt.Rows[i]["RegisterDate"]);
                }
                ui.Phone = dt.Rows[i]["Phone"].ToString();
                ui.UserID = Convert.ToInt32(dt.Rows[i]["UserID"]);
                if (dt.Rows[i]["UserName"] == null || dt.Rows[i]["UserName"].ToString().Equals(""))
                {
                    ui.UserName = "";
                }
                else
                {
                    ui.UserName = dt.Rows[i]["UserName"].ToString();
                }

                if (dt.Rows[i]["UserPwd"] == null || dt.Rows[i]["UserPwd"].ToString().Equals(""))
                {
                    ui.UserPwd = "";
                }
                else
                {
                    ui.UserPwd = dt.Rows[i]["UserPwd"].ToString();
                }
                list.Add(ui);
            }
            return list;
        }

        public static List<UserInfo>  GetAllUser()
        {
            string sql = "select * from UserInfo";
            DataTable dt= AccSqlHelper.ExecuteTable(sql);
            return DTToObj(dt);
        }

        public static UserInfo GetUserByUserID(int userID)
        {
            string sql = "select * from Userinfo where userID="+userID;
            DataTable dt = AccSqlHelper.ExecuteTable(sql);
            List<UserInfo> list = DTToObj(dt);
            if (list==null)
            {
                return null;
            }
            else
            {
                return list[0];
            }
        }
    }
}
