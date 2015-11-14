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
    public class ProjectDAL
    {
        public static List<Project> LoadProject()
        {
            List<Project> list = new List<Project>();
            string sql = "select * from Projects order by  RecordDate desc ";
            DataTable dt = AccSqlHelper.ExecuteTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(DRToProject(dr));
            }
            return list;
        }
        //-1还没有开工  0表示完工  1水  2泥  3木  4油
        public static string[] arrSchedule = { "完工", "水", "泥", "木", "油" };

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
            if (dr["WanDate"] == null || dr["WanDate"].ToString().Equals(""))
            {
                pro.WanDate = null;
            }
            else
            {
                pro.WanDate = Convert.ToDateTime(dr["WanDate"]);
            }
            pro.UserID = Convert.ToInt32(dr["UserID"]);
            pro.UserName = UserInfoDAL.GetUserByUserID(pro.UserID).UserName;
            pro.Schedule = Convert.ToInt32(dr["Schedule"]);
            pro.SchedeleName = pro.Schedule == -1 ? "还没有开工" : arrSchedule[pro.Schedule];
            pro.ProjectID = Convert.ToInt32(dr["ProjectID"]);
            return pro;
        }

        public static int AddProject(Project pro)
        {
            StringBuilder sqlStart = new StringBuilder();
            StringBuilder sqlEnd = new StringBuilder();
            sqlStart.Append("insert into projects (UserID,ForemanName,Phone,RecordDate,Address,Schedule ");
            sqlEnd.Append(" values (@UserID,@ForemanName,@Phone,@RecordDate,@Address,@Schedule");
            List<OleDbParameter> list = new List<OleDbParameter>();
            OleDbParameter[] param = { 
                           new OleDbParameter("@UserID",pro.UserID),
                           new OleDbParameter("@ForemanName",pro.ForemanName),
                           new OleDbParameter("@Phone",pro.Phone),
                           new OleDbParameter("@RecordDate",OleDbType.DBDate){Value=pro.RecordDate},
                           new OleDbParameter("@Address",pro.Address),
                           new OleDbParameter("@Schedule",pro.Schedule)
                                      };
            list.AddRange(param);
            if (!CheckDateIsNull(pro.ShuiDate))
            {
                sqlStart.Append(" ,ShuiDate ");
                sqlEnd.Append(" ,@ShuiDate ");
                list.Add(new OleDbParameter("@ShuiDate", pro.ShuiDate));
            }
            if (!CheckDateIsNull(pro.NiDate))
            {
                sqlStart.Append(" ,NiDate ");
                sqlEnd.Append(" ,@NiDate ");
                list.Add(new OleDbParameter("@NiDate", pro.NiDate));
            }
            if (!CheckDateIsNull(pro.MuDate))
            {
                sqlStart.Append(" ,MuDate ");
                sqlEnd.Append(" ,@MuDate ");
                list.Add(new OleDbParameter("@MuDate", pro.MuDate));
            }
            if (!CheckDateIsNull(pro.YouDate))
            {
                sqlStart.Append(" ,YouDate ");
                sqlEnd.Append(" ,@YouDate ");
                list.Add(new OleDbParameter("@YouDate", pro.YouDate));
            }
            if (!CheckDateIsNull(pro.WanDate))
            {
                sqlStart.Append(" ,WanDate ");
                sqlEnd.Append(" ,@WanDate ");
                list.Add(new OleDbParameter("@WanDate", pro.WanDate));
            }
            if (!CheckDateIsNull(pro.PredictCompleteDate))
            {
                sqlStart.Append(" ,PredictCompleteDate ");
                sqlEnd.Append(" ,@PredictCompleteDate ");
                list.Add(new OleDbParameter("@PredictCompleteDate", pro.PredictCompleteDate));
            }
            sqlStart.Append(" )");
            sqlEnd.Append(" )");
            string sql = sqlStart.Append(sqlEnd).ToString();
            OleDbParameter[] par = list.ToArray();
            return AccSqlHelper.ExecuteNonQuery(sql, par);
        }

        private static bool CheckDateIsNull(DateTime? dt)
        {
            return dt == null;
        }

        //public static List<Project> Search()
        //{

        //}
    }
}
