using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.NWC.Model
{
    public class Project
    {
        public int ProjectID { get; set; }
        public int UserID { get; set; }
        public string ForemanName { get; set; }
        public string Phone { get; set; }
        public int Schedule { get; set; }
        public string Address { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? ShuiDate { get; set; }
        public DateTime? NiDate { get; set; }
        public DateTime? MuDate { get; set; }
        public DateTime? YouDate { get; set; }
        public DateTime? PredictCompleteDate { get; set; }
    }
}
