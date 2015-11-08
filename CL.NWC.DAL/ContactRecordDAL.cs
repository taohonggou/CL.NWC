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
        private ContactRecord DRToObj(DataRow dr)
        {
            ContactRecord cr = new ContactRecord();
            if (dr["Content"]==null||dr["Content"].ToString().Equals(""))
            {
                cr.Content = "";
            }
            else
            {
                cr.Content = dr["Content"].ToString();
            }
            if (dr["RecordDate"] == null || dr["RecordDate"].ToString().Equals(""))
            {
                cr.RecordDate = null;
            }
            else
            {
                cr.RecordDate =Convert.ToDateTime( dr["RecordDate"]);
            }
            cr.ProjectID = Convert.ToInt32(dr["ProjectID"]);
            cr.RecordID = Convert.ToInt32(dr["RecordID"]);
            cr.UserID = Convert.ToInt32(dr["UserID"]);
            return cr;
        }
    }
}
