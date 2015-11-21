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
        public event EventHandler evtClosing;
        int flag = 0;//0为添加   1为修改
        public Project project = null;
        
        public void SetData(object sender, EventArgs e)
        {
            frmEventArgs fea = e as frmEventArgs;
            Project pro = fea.obj as Project ;
            project = pro;
            BindUser();
            txtForemanName.Text = pro.ForemanName;
            txtAddress.Text = pro.Address;
            txtPhone.Text = pro.Phone;
            cmbUser.SelectedText = pro.UserName;
            flag = 1; 
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            if (flag==1)
            {
                LoadChangeProject();
            }
            else
            {
                BindUser();
            }
        }

        /// <summary>
        /// 窗体加载时处理时间问题
        /// </summary>
        private void LoadChangeProject()
        {
            if (project.RecordDate != null)
            {
                dtRecordDate.Checked = true;
                dtRecordDate.Value = (DateTime)project.RecordDate;
            }
            if (project.ShuiDate != null)
            {
                dtRecordDate.Checked = true;
                dtShuiDate.Value = (DateTime)project.ShuiDate;
            }
            if (project.MuDate != null)
            {
                dtMuDate.Checked = true;
                dtMuDate.Value = (DateTime)project.MuDate;
            } if (project.NiDate != null)
            {
                dtNiDate.Checked = true;
                dtNiDate.Value = (DateTime)project.NiDate;
            }
            if (project.WanDate != null)
            {
                dtWanDate.Checked = true;
                dtWanDate.Value = (DateTime)project.WanDate;
            }
            if (project.YouDate != null)
            {
                dtYouDate.Checked = true;
                dtYouDate.Value = (DateTime)project.YouDate;
            }
            if (project.PredictCompleteDate != null)
            {
                dtPredictCompleteDate.Checked = true;
                dtPredictCompleteDate.Value = (DateTime)project.PredictCompleteDate;
            }
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
            pro.Schedule = -1;
            pro.ForemanName = txtForemanName.Text.Trim();
           
            
            pro.Phone = txtPhone.Text;

            if (dtPredictCompleteDate.Checked)
            {
                pro.PredictCompleteDate = dtPredictCompleteDate.Value;
            }
            if (dtRecordDate.Checked )
            {
                pro.RecordDate = dtRecordDate.Value;
            }
            if (dtShuiDate.Checked)
            {
                pro.Schedule = 1;
                pro.ShuiDate = dtShuiDate.Value;
            }
            if (dtNiDate.Checked)
            {
                pro.Schedule = 2;
                pro.NiDate = dtNiDate.Value;
            }
            if (dtMuDate.Checked)
            {
                pro.Schedule = 3;
                pro.MuDate = dtMuDate.Value;
            }
            pro.UserID =(int)cmbUser.SelectedValue;
            if (dtYouDate.Checked)
            {
                pro.Schedule = 4;
                pro.YouDate = dtYouDate.Value;
            }
            if (dtWanDate.Checked)
            {
                pro.WanDate = dtWanDate.Value;
            }
            if (flag==1)
            {
                pro.ProjectID = project.ProjectID;
                if (ProjectBLL.UpdateProject(pro))
                {
                    
                    Common.MessageBoxShow("修改成功");
                }
                else
                {
                    Common.MessageBoxShow("修改失败");
                }
            }
            else
            {
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

        //将用户与控件绑定
        private void BindUser()
        {
            List<UserInfo> list = UserInfoBLL.GetAllUser();
            cmbUser.DataSource = list;
            cmbUser.DisplayMember = "UserName";
            cmbUser.ValueMember = "UserID";
            cmbUser.SelectedItem = list[0];
        }

        private void AddProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Main m = this.Owner as Main;
            //m.BindDgvProject();
            if (evtClosing != null)
            {
                evtClosing(this, e);
            }
        }
    }
}
