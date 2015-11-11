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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cL_NWCDataSet = new CL.NWC.UI.CL_NWCDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new CL.NWC.UI.CL_NWCDataSetTableAdapters.ProjectsTableAdapter();
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
            this.predictCompleteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cL_NWCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.predictCompleteDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projectsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 603);
            this.dataGridView1.TabIndex = 0;
            // 
            // cL_NWCDataSet
            // 
            this.cL_NWCDataSet.DataSetName = "CL_NWCDataSet";
            this.cL_NWCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.cL_NWCDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // foremanNameDataGridViewTextBoxColumn
            // 
            this.foremanNameDataGridViewTextBoxColumn.DataPropertyName = "ForemanName";
            this.foremanNameDataGridViewTextBoxColumn.HeaderText = "ForemanName";
            this.foremanNameDataGridViewTextBoxColumn.Name = "foremanNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // recordDateDataGridViewTextBoxColumn
            // 
            this.recordDateDataGridViewTextBoxColumn.DataPropertyName = "RecordDate";
            this.recordDateDataGridViewTextBoxColumn.HeaderText = "RecordDate";
            this.recordDateDataGridViewTextBoxColumn.Name = "recordDateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // scheduleDataGridViewTextBoxColumn
            // 
            this.scheduleDataGridViewTextBoxColumn.DataPropertyName = "Schedule";
            this.scheduleDataGridViewTextBoxColumn.HeaderText = "Schedule";
            this.scheduleDataGridViewTextBoxColumn.Name = "scheduleDataGridViewTextBoxColumn";
            // 
            // shuiDateDataGridViewTextBoxColumn
            // 
            this.shuiDateDataGridViewTextBoxColumn.DataPropertyName = "ShuiDate";
            this.shuiDateDataGridViewTextBoxColumn.HeaderText = "ShuiDate";
            this.shuiDateDataGridViewTextBoxColumn.Name = "shuiDateDataGridViewTextBoxColumn";
            // 
            // niDateDataGridViewTextBoxColumn
            // 
            this.niDateDataGridViewTextBoxColumn.DataPropertyName = "NiDate";
            this.niDateDataGridViewTextBoxColumn.HeaderText = "NiDate";
            this.niDateDataGridViewTextBoxColumn.Name = "niDateDataGridViewTextBoxColumn";
            // 
            // muDateDataGridViewTextBoxColumn
            // 
            this.muDateDataGridViewTextBoxColumn.DataPropertyName = "MuDate";
            this.muDateDataGridViewTextBoxColumn.HeaderText = "MuDate";
            this.muDateDataGridViewTextBoxColumn.Name = "muDateDataGridViewTextBoxColumn";
            // 
            // youDateDataGridViewTextBoxColumn
            // 
            this.youDateDataGridViewTextBoxColumn.DataPropertyName = "YouDate";
            this.youDateDataGridViewTextBoxColumn.HeaderText = "YouDate";
            this.youDateDataGridViewTextBoxColumn.Name = "youDateDataGridViewTextBoxColumn";
            // 
            // predictCompleteDateDataGridViewTextBoxColumn
            // 
            this.predictCompleteDateDataGridViewTextBoxColumn.DataPropertyName = "PredictCompleteDate";
            this.predictCompleteDateDataGridViewTextBoxColumn.HeaderText = "PredictCompleteDate";
            this.predictCompleteDateDataGridViewTextBoxColumn.Name = "predictCompleteDateDataGridViewTextBoxColumn";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 710);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cL_NWCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CL_NWCDataSet cL_NWCDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private CL_NWCDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn predictCompleteDateDataGridViewTextBoxColumn;
    }
}