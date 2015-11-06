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
   public  class ProjectDAL
    {
       public static List<Project> LoadProject()
       {
           List<Project> list=new List<Project>();
           //string sql = "select * from Project ";
           //DataTable dt= AccSqlHelper.ExecuteTable(sql);
           return list;
       }
    }
}
