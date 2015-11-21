using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL.NWC.Model;
using CL.NWC.DAL;

namespace CL.NWC.BLL
{
   public class ContactRecordBLL
    {
       public static List<ContactRecord> GetContactRecordByProIDAndUserID(int proID, int userID)
       {
           List<ContactRecord> list= ContactRecordDAL.GetContactRecordByProIDAndUserID(proID, userID);
           //list.ForEach(o => o.Project = ProjectDAL.GetProjectByProID(o.ProjectID));
           return list;
       }

       public static bool AddContactRecord(ContactRecord cr)
       {
           return ContactRecordDAL.AddContactRecord(cr) > 0;
       }

       //public static int DeleteContactRecordByProID(int proID)
       //{
       //     return 
       //}
    }
}
