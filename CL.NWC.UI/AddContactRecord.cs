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
    public partial class AddContactRecord : Form
    {
        public AddContactRecord()
        {
            InitializeComponent();
        }
        int proID = 0;
        public void SetData(object sender, EventArgs e)
        {
            frmEventArgs fea = e as frmEventArgs;
            Project pro = fea.obj as Project;
            StringBuilder sb = new StringBuilder();
            txtProject.Text = "工长名称:" + pro.ForemanName + "   施工地址:" + pro.Address + "   业务员姓名:" + pro.UserName + "     建档日期:" + pro.RecordDate.ToString();
            proID = pro.ProjectID;
        }

        private void btnSureAdd_Click(object sender, EventArgs e)
        {
            ContactRecord cr = new ContactRecord();
            if (proID == 0)
            {
                Common.MessageBoxShow("不好意思出错了");
            }
            cr.ProjectID = proID;
            cr.UserID = Convert.ToInt32(cmbUser.SelectedValue);
            cr.Content = txtContactRecord.Text;
            cr.RecordDate = dtRecord.Value;
            if (ContactRecordBLL.AddContactRecord(cr))
            {
                Common.MessageBoxShow("添加成功",false);
                this.Close();
            }
            else
            {
                Common.MessageBoxShow("不好意思出错了");
            }
        }

        private void AddContactRecord_Load(object sender, EventArgs e)
        {
            BindUser();
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
