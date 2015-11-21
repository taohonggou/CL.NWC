using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL.NWC.Model;
using System.Data;
using System.Data.OleDb;

namespace CL.NWC.DAL
{
    public class ContactRecordDAL
    {
        private static List< ContactRecord> DTToObj(DataTable dt)
        {
            if (dt==null)
            {
                return null;
            }
            List<ContactRecord> list = new List<ContactRecord>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                ContactRecord cr = new ContactRecord();
                if (dt.Rows[i]["Content"] == null || dt.Rows[i]["Content"].ToString().Equals(""))
                {
                    cr.Content = "";
                }
                else
                {
                    cr.Content = dt.Rows[i]["Content"].ToString();
                }
                if (dt.Rows[i]["RecordDate"] == null || dt.Rows[i]["RecordDate"].ToString().Equals(""))
                {
                    cr.RecordDate = null;
                }
                else
                {
                    cr.RecordDate = Convert.ToDateTime(dt.Rows[i]["RecordDate"]);
                }
                cr.ProjectID = Convert.ToInt32(dt.Rows[i]["ProjectID"]);
                cr.Project = ProjectDAL.GetProjectByProID(cr.ProjectID);
                
                cr.RecordID = Convert.ToInt32(dt.Rows[i]["RecordID"]);
                cr.UserID = Convert.ToInt32(dt.Rows[i]["UserID"]);
                cr.UserInfo = UserInfoDAL.GetUserByUserID(cr.UserID);
                cr.salesmanName = cr.UserInfo.UserName;
                list.Add(cr);
            }
            return list;
        }

        public static List<ContactRecord> GetContactRecordByProIDAndUserID(int proID,int userID)
        {
            string sql = "select * from ContactRecord where userID=@userID and ProjectID=@ProjectID order by RecordDate desc ";
            OleDbParameter[] param = { 
                                     new OleDbParameter("@userID",userID),
                                     new OleDbParameter("@ProjectID",proID)
                                     };
            DataTable dt = AccSqlHelper.ExecuteTable(sql, param);
            return DTToObj(dt);
        }

        public static int AddContactRecord(ContactRecord cr)
        {
            string sql = "insert into ContactRecord (UserID,ProjectID,Content,RecordDate) values (@UserID,@ProjectID,@Content,@RecordDate)";
            OleDbParameter[] param = { 
                                     new OleDbParameter("@UserID",OleDbType.Integer){Value=cr.UserID},
                                     new OleDbParameter("@ProjectID",OleDbType.Integer){Value=cr.ProjectID},
                                     new OleDbParameter("@Content",OleDbType.VarChar){Value=cr.Content},
                                     new OleDbParameter("@RecordDate",OleDbType.DBDate){Value=cr.RecordDate}
                                     };
            return AccSqlHelper.ExecuteNonQuery(sql, param);
        }
    }
}
