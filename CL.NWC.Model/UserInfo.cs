using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.NWC.Model
{
   public  class UserInfo
    {
       public int UserID { get; set; }
       public string UserName { get; set; }
       public string UserPwd { get; set; }
       public string Phone { get; set;}
       public DateTime RegisterDate { get; set; }
    }
}
