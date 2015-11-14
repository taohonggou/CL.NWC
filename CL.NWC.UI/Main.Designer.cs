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
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cL_NWCDataSet = new CL.NWC.UI.CL_NWCDataSet();
            this.projectsTableAdapter = new CL.NWC.UI.CL_NWCDataSetTableAdapters.ProjectsTableAdapter();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foremanNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shuiDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.youDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predictCompleteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFormanName = new System.Windows.Forms.TextBox();
            this.txtForemanName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecordDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cL_NWCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToOrderColumns = true;
            this.dgvProject.AutoGenerateColumns = false;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.foremanNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.recordDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.scheduleDataGridViewTextBoxColumn,
            this.shuiDateDataGridViewTextBoxColumn,
            this.niDateDataGridViewTextBoxColumn,
            this.muDateDataGridViewTextBoxColumn,
            this.youDateDataGridViewTextBoxColumn,
            this.WanDate,
            this.predictCompleteDateDataGridViewTextBoxColumn});
            this.dgvProject.DataSource = this.projectsBindingSource;
            this.dgvProject.Location = new System.Drawing.Point(32, 80);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersVisible = false;
            this.dgvProject.RowTemplate.Height = 23;
            this.dgvProject.Size = new System.Drawing.Size(1204, 603);
            this.dgvProject.TabIndex = 0;
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
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(32, 27);
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
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "业务员";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // foremanNameDataGridViewTextBoxColumn
            // 
            this.foremanNameDataGridViewTextBoxColumn.DataPropertyName = "ForemanName";
            this.foremanNameDataGridViewTextBoxColumn.HeaderText = "工长姓名";
            this.foremanNameDataGridViewTextBoxColumn.Name = "foremanNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "联系方式";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // recordDateDataGridViewTextBoxColumn
            // 
            this.recordDateDataGridViewTextBoxColumn.DataPropertyName = "RecordDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.recordDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.recordDateDataGridViewTextBoxColumn.HeaderText = "建档时间";
            this.recordDateDataGridViewTextBoxColumn.Name = "recordDateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // scheduleDataGridViewTextBoxColumn
            // 
            this.scheduleDataGridViewTextBoxColumn.DataPropertyName = "SchedeleName";
            this.scheduleDataGridViewTextBoxColumn.HeaderText = "施工进度";
            this.scheduleDataGridViewTextBoxColumn.Name = "scheduleDataGridViewTextBoxColumn";
            // 
            // shuiDateDataGridViewTextBoxColumn
            // 
            this.shuiDateDataGridViewTextBoxColumn.DataPropertyName = "ShuiDate";
            this.shuiDateDataGridViewTextBoxColumn.HeaderText = "水";
            this.shuiDateDataGridViewTextBoxColumn.Name = "shuiDateDataGridViewTextBoxColumn";
            // 
            // niDateDataGridViewTextBoxColumn
            // 
            this.niDateDataGridViewTextBoxColumn.DataPropertyName = "NiDate";
            this.niDateDataGridViewTextBoxColumn.HeaderText = "泥";
            this.niDateDataGridViewTextBoxColumn.Name = "niDateDataGridViewTextBoxColumn";
            // 
            // muDateDataGridViewTextBoxColumn
            // 
            this.muDateDataGridViewTextBoxColumn.DataPropertyName = "MuDate";
            this.muDateDataGridViewTextBoxColumn.HeaderText = "木";
            this.muDateDataGridViewTextBoxColumn.Name = "muDateDataGridViewTextBoxColumn";
            // 
            // youDateDataGridViewTextBoxColumn
            // 
            this.youDateDataGridViewTextBoxColumn.DataPropertyName = "YouDate";
            this.youDateDataGridViewTextBoxColumn.HeaderText = "油";
            this.youDateDataGridViewTextBoxColumn.Name = "youDateDataGridViewTextBoxColumn";
            // 
            // WanDate
            // 
            this.WanDate.DataPropertyName = "WanDate";
            this.WanDate.HeaderText = "完";
            this.WanDate.Name = "WanDate";
            // 
            // predictCompleteDateDataGridViewTextBoxColumn
            // 
            this.predictCompleteDateDataGridViewTextBoxColumn.DataPropertyName = "PredictCompleteDate";
            this.predictCompleteDateDataGridViewTextBoxColumn.HeaderText = "预计终结日期";
            this.predictCompleteDateDataGridViewTextBoxColumn.Name = "predictCompleteDateDataGridViewTextBoxColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRecordDate);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtForemanName);
            this.groupBox1.Controls.Add(this.txtFormanName);
            this.groupBox1.Location = new System.Drawing.Point(123, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // txtFormanName
            // 
            this.txtFormanName.Location = new System.Drawing.Point(61, 25);
            this.txtFormanName.Name = "txtFormanName";
            this.txtFormanName.Size = new System.Drawing.Size(100, 21);
            this.txtFormanName.TabIndex = 0;
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
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(232, 25);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 21);
            this.txtAddress.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "施工地址:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(477, 26);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 0;
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
            // txtRecordDate
            // 
            this.txtRecordDate.Location = new System.Drawing.Point(667, 26);
            this.txtRecordDate.Name = "txtRecordDate";
            this.txtRecordDate.Size = new System.Drawing.Size(100, 21);
            this.txtRecordDate.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "建档日期:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(976, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "筛选";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.dgvProject);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cL_NWCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProject;
        private CL_NWCDataSet cL_NWCDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private CL_NWCDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foremanNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shuiDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn youDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn predictCompleteDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecordDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label txtForemanName;
        private System.Windows.Forms.TextBox txtFormanName;
        private System.Windows.Forms.Button btnSearch;
    }
}