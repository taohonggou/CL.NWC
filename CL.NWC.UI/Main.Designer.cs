namespace CL.NWC.UI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foremanNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shuiDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.youDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predictCompleteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加跟进记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cL_NWCDataSet = new CL.NWC.UI.CL_NWCDataSet();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtRecordJD = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtForemanName = new System.Windows.Forms.Label();
            this.txtFormanName = new System.Windows.Forms.TextBox();
            this.dgvContactRecord = new System.Windows.Forms.DataGridView();
            this.RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectsTableAdapter = new CL.NWC.UI.CL_NWCDataSetTableAdapters.ProjectsTableAdapter();
            this.删除工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.cmsProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cL_NWCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToOrderColumns = true;
            this.dgvProject.AllowUserToResizeRows = false;
            this.dgvProject.AutoGenerateColumns = false;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIDDataGridViewTextBoxColumn,
            this.Column2,
            this.foremanNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.recordDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.Column1,
            this.shuiDateDataGridViewTextBoxColumn,
            this.niDateDataGridViewTextBoxColumn,
            this.muDateDataGridViewTextBoxColumn,
            this.youDateDataGridViewTextBoxColumn,
            this.WanDate,
            this.predictCompleteDateDataGridViewTextBoxColumn});
            this.dgvProject.ContextMenuStrip = this.cmsProject;
            this.dgvProject.DataSource = this.projectsBindingSource;
            this.dgvProject.Location = new System.Drawing.Point(26, 80);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.ReadOnly = true;
            this.dgvProject.RowHeadersVisible = false;
            this.dgvProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProject.RowTemplate.Height = 23;
            this.dgvProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProject.Size = new System.Drawing.Size(1204, 324);
            this.dgvProject.TabIndex = 0;
            this.dgvProject.SelectionChanged += new System.EventHandler(this.dgvProject_SelectionChanged);
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserName";
            this.Column2.HeaderText = "业务员姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // foremanNameDataGridViewTextBoxColumn
            // 
            this.foremanNameDataGridViewTextBoxColumn.DataPropertyName = "ForemanName";
            this.foremanNameDataGridViewTextBoxColumn.HeaderText = "工长姓名";
            this.foremanNameDataGridViewTextBoxColumn.Name = "foremanNameDataGridViewTextBoxColumn";
            this.foremanNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "联系方式";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recordDateDataGridViewTextBoxColumn
            // 
            this.recordDateDataGridViewTextBoxColumn.DataPropertyName = "RecordDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.recordDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.recordDateDataGridViewTextBoxColumn.HeaderText = "建档时间";
            this.recordDateDataGridViewTextBoxColumn.Name = "recordDateDataGridViewTextBoxColumn";
            this.recordDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SchedeleName";
            this.Column1.HeaderText = "施工进度";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // shuiDateDataGridViewTextBoxColumn
            // 
            this.shuiDateDataGridViewTextBoxColumn.DataPropertyName = "ShuiDate";
            this.shuiDateDataGridViewTextBoxColumn.HeaderText = "水";
            this.shuiDateDataGridViewTextBoxColumn.Name = "shuiDateDataGridViewTextBoxColumn";
            this.shuiDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // niDateDataGridViewTextBoxColumn
            // 
            this.niDateDataGridViewTextBoxColumn.DataPropertyName = "NiDate";
            this.niDateDataGridViewTextBoxColumn.HeaderText = "泥";
            this.niDateDataGridViewTextBoxColumn.Name = "niDateDataGridViewTextBoxColumn";
            this.niDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // muDateDataGridViewTextBoxColumn
            // 
            this.muDateDataGridViewTextBoxColumn.DataPropertyName = "MuDate";
            this.muDateDataGridViewTextBoxColumn.HeaderText = "木";
            this.muDateDataGridViewTextBoxColumn.Name = "muDateDataGridViewTextBoxColumn";
            this.muDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // youDateDataGridViewTextBoxColumn
            // 
            this.youDateDataGridViewTextBoxColumn.DataPropertyName = "YouDate";
            this.youDateDataGridViewTextBoxColumn.HeaderText = "油";
            this.youDateDataGridViewTextBoxColumn.Name = "youDateDataGridViewTextBoxColumn";
            this.youDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WanDate
            // 
            this.WanDate.DataPropertyName = "WanDate";
            this.WanDate.HeaderText = "完";
            this.WanDate.Name = "WanDate";
            this.WanDate.ReadOnly = true;
            // 
            // predictCompleteDateDataGridViewTextBoxColumn
            // 
            this.predictCompleteDateDataGridViewTextBoxColumn.DataPropertyName = "PredictCompleteDate";
            this.predictCompleteDateDataGridViewTextBoxColumn.HeaderText = "预计终结日期";
            this.predictCompleteDateDataGridViewTextBoxColumn.Name = "predictCompleteDateDataGridViewTextBoxColumn";
            this.predictCompleteDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmsProject
            // 
            this.cmsProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改工程ToolStripMenuItem,
            this.添加跟进记录ToolStripMenuItem,
            this.删除工程ToolStripMenuItem});
            this.cmsProject.Name = "cmsProject";
            this.cmsProject.Size = new System.Drawing.Size(153, 92);
            // 
            // 修改工程ToolStripMenuItem
            // 
            this.修改工程ToolStripMenuItem.Name = "修改工程ToolStripMenuItem";
            this.修改工程ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改工程ToolStripMenuItem.Text = "修改工程";
            this.修改工程ToolStripMenuItem.Click += new System.EventHandler(this.修改工程ToolStripMenuItem_Click);
            // 
            // 添加跟进记录ToolStripMenuItem
            // 
            this.添加跟进记录ToolStripMenuItem.Name = "添加跟进记录ToolStripMenuItem";
            this.添加跟进记录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.添加跟进记录ToolStripMenuItem.Text = "添加跟进记录";
            this.添加跟进记录ToolStripMenuItem.Click += new System.EventHandler(this.添加跟进记录ToolStripMenuItem_Click);
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.cL_NWCDataSet;
            // 
            // cL_NWCDataSet
            // 
            this.cL_NWCDataSet.DataSetName = "CL_NWCDataSet";
            this.cL_NWCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(26, 29);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddProject.TabIndex = 1;
            this.btnAddProject.Text = "添加工程";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtRecordJD);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtForemanName);
            this.groupBox1.Controls.Add(this.txtFormanName);
            this.groupBox1.Location = new System.Drawing.Point(117, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // dtRecordJD
            // 
            this.dtRecordJD.Checked = false;
            this.dtRecordJD.Location = new System.Drawing.Point(734, 26);
            this.dtRecordJD.Name = "dtRecordJD";
            this.dtRecordJD.ShowCheckBox = true;
            this.dtRecordJD.Size = new System.Drawing.Size(128, 21);
            this.dtRecordJD.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(982, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "筛选";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "建档日期:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "联系电话:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(477, 26);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "施工地址:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(261, 25);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 21);
            this.txtAddress.TabIndex = 0;
            // 
            // txtForemanName
            // 
            this.txtForemanName.AutoSize = true;
            this.txtForemanName.Location = new System.Drawing.Point(6, 29);
            this.txtForemanName.Name = "txtForemanName";
            this.txtForemanName.Size = new System.Drawing.Size(59, 12);
            this.txtForemanName.TabIndex = 1;
            this.txtForemanName.Text = "客户姓名:";
            // 
            // txtFormanName
            // 
            this.txtFormanName.Location = new System.Drawing.Point(65, 25);
            this.txtFormanName.Name = "txtFormanName";
            this.txtFormanName.Size = new System.Drawing.Size(100, 21);
            this.txtFormanName.TabIndex = 0;
            // 
            // dgvContactRecord
            // 
            this.dgvContactRecord.AllowUserToOrderColumns = true;
            this.dgvContactRecord.AllowUserToResizeRows = false;
            this.dgvContactRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordID,
            this.salesmanName,
            this.Content,
            this.RecordDate});
            this.dgvContactRecord.Location = new System.Drawing.Point(26, 432);
            this.dgvContactRecord.Name = "dgvContactRecord";
            this.dgvContactRecord.RowTemplate.Height = 23;
            this.dgvContactRecord.Size = new System.Drawing.Size(1204, 273);
            this.dgvContactRecord.TabIndex = 3;
            // 
            // RecordID
            // 
            this.RecordID.DataPropertyName = "RecordID";
            this.RecordID.HeaderText = "记录编号";
            this.RecordID.Name = "RecordID";
            this.RecordID.Visible = false;
            // 
            // salesmanName
            // 
            this.salesmanName.DataPropertyName = "salesmanName";
            this.salesmanName.HeaderText = "业务员姓名";
            this.salesmanName.Name = "salesmanName";
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.HeaderText = "跟进内容";
            this.Content.Name = "Content";
            // 
            // RecordDate
            // 
            this.RecordDate.DataPropertyName = "RecordDate";
            this.RecordDate.HeaderText = "跟进日期";
            this.RecordDate.Name = "RecordDate";
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // 删除工程ToolStripMenuItem
            // 
            this.删除工程ToolStripMenuItem.Name = "删除工程ToolStripMenuItem";
            this.删除工程ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除工程ToolStripMenuItem.Text = "删除工程";
            this.删除工程ToolStripMenuItem.Click += new System.EventHandler(this.删除工程ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 764);
            this.Controls.Add(this.dgvContactRecord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.dgvProject);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.cmsProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cL_NWCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProject;
        private CL_NWCDataSet cL_NWCDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private CL_NWCDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label txtForemanName;
        private System.Windows.Forms.TextBox txtFormanName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtRecordJD;
        private System.Windows.Forms.DataGridView dgvContactRecord;
        private System.Windows.Forms.ContextMenuStrip cmsProject;
        private System.Windows.Forms.ToolStripMenuItem 修改工程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加跟进记录ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foremanNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shuiDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn youDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predictCompleteDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 删除工程ToolStripMenuItem;
    }
}