using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL.NWC.Model;
using System.Data;
using System.Data.SqlClient;

namespace CL.NWC.DAL
{
    public class ProjectDAL
    {
        public static List<Project> LoadProject()
        {
            List<Project> list = new List<Project>();
            string sql = "select * from Projects ";
            DataTable dt = AccSqlHelper.ExecuteTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(DRToProject(dr));
            }
            return list;
        }

        public static Project DRToProject(DataRow dr)
        {
            Project pro = new Project();
            if (dr["Address"] == null || dr["Address"].ToString().Equals(""))
            {
                pro.Address = "";
            }
            else
            {
                pro.Address = dr["Address"].ToString();
            }

            if (dr["Phone"] == null || dr["Phone"].ToString().Equals(""))
            {
                pro.Phone = "";
            }
            else
            {
                pro.Phone = dr["Phone"].ToString();
            }
            if (dr["ForemanName"] == null || dr["ForemanName"].ToString().Equals(""))
            {
                pro.ForemanName = "";
            }
            else
            {
                pro.ForemanName = dr["ForemanName"].ToString();
            }

            if (dr["MuDate"] == null || dr["MuDate"].ToString().Equals(""))
            {
                pro.MuDate = null;
            }
            else
            {
                pro.MuDate = Convert.ToDateTime(dr["MuDate"]);
            }

            if (dr["ShuiDate"] == null || dr["ShuiDate"].ToString().Equals(""))
            {
                pro.ShuiDate = null;
            }
            else
            {
                pro.ShuiDate = Convert.ToDateTime(dr["ShuiDate"]);
            }
            if (dr["RecordDate"] == null || dr["RecordDate"].ToString().Equals(""))
            {
                pro.RecordDate = null;
            }
            else
            {
                pro.RecordDate = Convert.ToDateTime(dr["RecordDate"]);
            }
            if (dr["PredictCompleteDate"] == null || dr["PredictCompleteDate"].ToString().Equals(""))
            {
                pro.PredictCompleteDate = null;
            }
            else
            {
                pro.PredictCompleteDate = Convert.ToDateTime(dr["PredictCompleteDate"]);
            } 
            if (dr["NiDate"] == null || dr["NiDate"].ToString().Equals(""))
            {
                pro.NiDate = null;
            }
            else
            {
                pro.NiDate = Convert.ToDateTime(dr["NiDate"]);
            }
            if (dr["YouDate"] == null || dr["YouDate"].ToString().Equals(""))
            {
                pro.YouDate = null;
            }
            else
            {
                pro.YouDate = Convert.ToDateTime(dr["YouDate"]);
            }

            if (dr["YouDate"] == null || dr["YouDate"].ToString().Equals(""))
            {
                pro.YouDate = null;
            }
            else
            {
                pro.YouDate = Convert.ToDateTime(dr["YouDate"]);
            }
            pro.UserID = Convert.ToInt32(dr["UserID"]);
            pro.Schedule = Convert.ToInt32(dr["Schedule"]);
            pro.ProjectID = Convert.ToInt32(dr["ProjectID"]);
            return pro;
        }
    }
}
