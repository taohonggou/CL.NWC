using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL.NWC.DAL;
using CL.NWC.Model;

namespace CL.NWC.BLL
{
     public  class ProjectBLL
    {

         public static List<Project> LoadProject()
         {
             return ProjectDAL.LoadProject();
         }

         public static bool AddProject(Project pro)
         {
             return ProjectDAL.AddProject(pro) > 0 ? true : false;
         }

         public static List<Project> Search(string fromanName, string address, string phone, DateTime? recordTime, int userID)
         {
             return ProjectDAL.Search(fromanName, address, phone, recordTime, userID);
         }

         public static Project GetProjectByProID(int proID)
         {
             return ProjectDAL.GetProjectByProID(proID);
         }

         public static bool UpdateProject(Project pro)
         {
             return ProjectDAL.UpdateProject(pro) > 0;
         }
    }
}
