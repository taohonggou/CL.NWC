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
            BindUser();
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

        int [] jinDu={-1,1,2,3,4,0};
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Project pro = new Project();
            pro.Address = txtAddress.Text.Trim() ;
            if (txtForemanName.Text=="")
            {
                MessageBox.Show("没有输入工长姓名");
                txtForemanName.Focus();
                return;
            }
            pro.ForemanName = txtForemanName.Text.Trim();
            if (dtMuDate.Checked)
            {
                pro.MuDate = dtMuDate.Value;
            }
            if (dtNiDate.Checked)
            {
                pro.NiDate = dtNiDate.Value;
            }
            pro.Phone = txtPhone.Text;

            if (dtPredictCompleteDate.Checked)
            {
                pro.PredictCompleteDate = dtPredictCompleteDate.Value;
            }
            if (dtRecordDate.Checked )
            {
                pro.RecordDate = dtRecordDate.Value;
            }
            pro.Schedule = jinDu[cmbSchedule.SelectedIndex];
            if (dtShuiDate.Checked)
            {
                pro.ShuiDate = dtShuiDate.Value;
            }
            
            pro.UserID =(int)cmbUser.SelectedValue;
            if (dtYouDate.Checked)
            {
                pro.YouDate = dtYouDate.Value;
            }
            if (dtWanDate.Checked)
            {
                pro.WanDate = dtWanDate.Value;
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

        //将用户与控件绑定
        private void BindUser()
        {
            List<UserInfo> list = UserInfoBLL.GetAllUser();
            cmbUser.DataSource = list;
            cmbUser.DisplayMember = "UserName";
            cmbUser.ValueMember = "UserID";
            cmbUser.SelectedItem = list[0];
        }
    }
}
