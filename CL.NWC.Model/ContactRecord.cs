﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.NWC.Model
{
    public class ContactRecord
    {
        public int RecordID { get; set; }
        public int UserID { get; set; }
        public string salesmanName { get; set; }
        public UserInfo UserInfo { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
        public string Content { get; set; }
        public DateTime? RecordDate { get; set; }
    }
}
