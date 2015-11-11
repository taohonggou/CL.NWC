using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL.NWC.BLL;
using CL.NWC.Model;

namespace CL.NWC.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“cL_NWCDataSet.Projects”中。您可以根据需要移动或删除它。
            this.projectsTableAdapter.Fill(this.cL_NWCDataSet.Projects);
            ProjectBLL.LoadProject();    
        }


    }
}
