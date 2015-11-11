using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL.NWC.Model;
using CL.NWC.BLL;

namespace CL.NWC.UI
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            ShowDate();
            cmbSchedule.SelectedItem = "还没开工";
        }
        //给时间控件显示默认时间
        private void ShowDate()
        {
            DateTimePicker dt = new DateTimePicker();
            DateTime date = dt.MinDate;
            dtMuDate.Value = date;
            dtNiDate.Value = date;
            dtPredictCompleteDate.Value = date;
            
            dtShuiDate.Value = date;
            dtYouDate.Value = date;
        }

        int [] aaa={-1,1,2,3,4,0};
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Project pro = new Project();
            pro.Address = txtAddress.Text;
            pro.ForemanName = txtForemanName.Text;
            if (dtMuDate.Value==dtMuDate.MinDate)
            {
                pro.MuDate = null;
            }
            else
            {
                pro.MuDate = dtMuDate.Value;
            }

            if (dtNiDate.Value == dtNiDate.MinDate)
            {
                pro.NiDate = null;
            }
            else
            {
                pro.NiDate = dtNiDate.Value;
            }
            pro.Phone = txtPhone.Text;

            if (dtPredictCompleteDate.Value == dtPredictCompleteDate.MinDate)
            {
                pro.PredictCompleteDate = null;
            }
            else
            {
                pro.PredictCompleteDate = dtPredictCompleteDate.Value;
            }
            if (dtRecordDate.Value == dtRecordDate.MinDate)
            {
                pro.RecordDate = null;
            }
            else
            {
                pro.RecordDate = dtRecordDate.Value;
            }
            
            pro.Schedule = aaa[cmbSchedule.SelectedIndex];
            if (dtShuiDate.Value == dtShuiDate.MinDate)
            {
                pro.ShuiDate = null;
            }
            else
            {
                pro.ShuiDate = dtShuiDate.Value;
            }
            
            pro.UserID = 1;
            if (dtYouDate.Value == dtYouDate.MinDate)
            {
                pro.YouDate = null;
            }
            else
            {
                pro.YouDate = dtYouDate.Value;
            }
            
            if (ProjectBLL.AddProject(pro))
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}
