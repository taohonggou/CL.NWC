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
        public event EventHandler myEvt;
        private void Main_Load(object sender, EventArgs e)
        {
            dgvContactRecord.AutoGenerateColumns = false;
            BindDgvProject();
        }

        /// <summary>
        /// 显示添加添加工程窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            AddProject pro = new AddProject();
            pro.evtClosing += pro_evtClosing;
            //pro.Owner = this;
            //pro.FormClosing += BindDgvProject;
            pro.ShowDialog();
        }

        void pro_evtClosing(object sender, EventArgs e)
        {
            //Common.MessageBoxShow("fasdfasd");
            BindDgvProject();
        }
        //delegate ss
        public void BindDgvProject()
        {
            List<Project> list = ProjectBLL.LoadProject();
            dgvProject.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string formanName = txtFormanName.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            DateTime? dt = null;
            if (dtRecordJD.Checked)
            {
                dt = dtRecordJD.Value;
            }
            List<Project> list = ProjectBLL.Search(formanName, address, phone, dt, 1);
            dgvProject.DataSource = list;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.projectsTableAdapter.FillBy(this.cL_NWCDataSet.Projects);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgvProject_SelectionChanged(object sender, EventArgs e)
        {
            ShowContactRecord();
        }

        private void ShowContactRecord()
        {
            string proID = dgvProject.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(proID))
            {
                MessageBox.Show("没有工程ID");
                return;
            }
            List<ContactRecord> list = ContactRecordBLL.GetContactRecordByProIDAndUserID(int.Parse(proID), 1);
            dgvContactRecord.DataSource = list;
        }

        private void 修改工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string proID = dgvProject.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(proID))
            {
                Common.MessageBoxShow("没有工程ID");
            }
            Project pro = ProjectBLL.GetProjectByProID(int.Parse(proID));
            if (pro == null)
            {
                Common.MessageBoxShow("没有工程");
            }
            frmEventArgs fea = new frmEventArgs();
            fea.obj = pro;
            
            AddProject ap=new AddProject();
            this.myEvt += new EventHandler(ap.SetData);
            if (myEvt!=null)
            {
                myEvt(this, fea);
            }
            ap.FormClosing += ap_FormClosing;
            ap.ShowDialog();
        }

        void ap_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindDgvProject();
        }

        private void 添加跟进记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string proID = dgvProject.CurrentRow.Cells[0].Value.ToString();
            Project pro = ProjectBLL.GetProjectByProID(int.Parse(proID));
            if (pro == null)
            {
                MessageBox.Show("不好意思出错了");
                return;
            }
            AddContactRecord acr = new AddContactRecord();
            frmEventArgs fea = new frmEventArgs();
            fea.obj = pro;
            this.myEvt += new EventHandler(acr.SetData);
            if (this.myEvt != null)
            {
                this.myEvt(this, fea);
            }
            acr.FormClosed += acr_FormClosed;
            acr.Show();
        }

        void acr_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowContactRecord();
        }

        private void 删除工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string proID = dgvProject.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(proID);
        }


    }
}
