using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL.NWC.BLL;
using CL.NWC.Model;
using System.Windows.Forms;

namespace CL.NWC.UI
{
    public class Common
    {
        public static void MessageBoxShow(string msg)
        {
            MessageBox.Show(msg);
            return;
        }

        public static void MessageBoxShow(string msg,bool isReturn)
        {
            MessageBox.Show(msg);
            if (isReturn)
            {
                return;
            }
        }
    }
}
