namespace CL.NWC.UI
{
    partial class AddContactRecord
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
            this.btnSureAdd = new System.Windows.Forms.Button();
            this.labProject = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.txtContactRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtRecord = new System.Windows.Forms.DateTimePicker();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSureAdd
            // 
            this.btnSureAdd.Location = new System.Drawing.Point(159, 323);
            this.btnSureAdd.Name = "btnSureAdd";
            this.btnSureAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSureAdd.TabIndex = 0;
            this.btnSureAdd.Text = "确认添加";
            this.btnSureAdd.UseVisualStyleBackColor = true;
            this.btnSureAdd.Click += new System.EventHandler(this.btnSureAdd_Click);
            // 
            // labProject
            // 
            this.labProject.AutoSize = true;
            this.labProject.Location = new System.Drawing.Point(23, 9);
            this.labProject.Name = "labProject";
            this.labProject.Size = new System.Drawing.Size(53, 12);
            this.labProject.TabIndex = 1;
            this.labProject.Text = "工程信息";
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(76, 94);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 20);
            this.cmbUser.TabIndex = 2;
            // 
            // txtContactRecord
            // 
            this.txtContactRecord.Location = new System.Drawing.Point(25, 130);
            this.txtContactRecord.Multiline = true;
            this.txtContactRecord.Name = "txtContactRecord";
            this.txtContactRecord.Size = new System.Drawing.Size(366, 172);
            this.txtContactRecord.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "记录人:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "跟进时间:";
            // 
            // dtRecord
            // 
            this.dtRecord.Location = new System.Drawing.Point(268, 94);
            this.dtRecord.Name = "dtRecord";
            this.dtRecord.ShowCheckBox = true;
            this.dtRecord.Size = new System.Drawing.Size(123, 21);
            this.dtRecord.TabIndex = 4;
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(25, 34);
            this.txtProject.Multiline = true;
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(366, 54);
            this.txtProject.TabIndex = 5;
            // 
            // AddContactRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 358);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.dtRecord);
            this.Controls.Add(this.txtContactRecord);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labProject);
            this.Controls.Add(this.btnSureAdd);
            this.Name = "AddContactRecord";
            this.Text = "AddContactRecord";
            this.Load += new System.EventHandler(this.AddContactRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSureAdd;
        private System.Windows.Forms.Label labProject;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.TextBox txtContactRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtRecord;
        private System.Windows.Forms.TextBox txtProject;
    }
}