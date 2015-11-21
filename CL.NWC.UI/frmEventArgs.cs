using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.NWC.UI
{
    public class frmEventArgs:EventArgs
    {
        public object obj { get; set; }
        public int flag { get; set; }
    }
}
