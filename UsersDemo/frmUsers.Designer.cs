namespace UsersDemo
{
    partial class frmUsers
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblusersclass = new System.Windows.Forms.Label();
            this.cmbusersclass = new System.Windows.Forms.ComboBox();
            this.btnusersclass = new System.Windows.Forms.Button();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnxg = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.gupusers = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblbz = new System.Windows.Forms.Label();
            this.lbllb = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtbz = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.cmblb = new System.Windows.Forms.ComboBox();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.romark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.gupusers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusersclass
            // 
            this.lblusersclass.AutoSize = true;
            this.lblusersclass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusersclass.Location = new System.Drawing.Point(12, 23);
            this.lblusersclass.Name = "lblusersclass";
            this.lblusersclass.Size = new System.Drawing.Size(53, 12);
            this.lblusersclass.TabIndex = 0;
            this.lblusersclass.Text = "用户类别";
            // 
            // cmbusersclass
            // 
            this.cmbusersclass.FormattingEnabled = true;
            this.cmbusersclass.Location = new System.Drawing.Point(88, 20);
            this.cmbusersclass.Name = "cmbusersclass";
            this.cmbusersclass.Size = new System.Drawing.Size(121, 20);
            this.cmbusersclass.TabIndex = 1;
            // 
            // btnusersclass
            // 
            this.btnusersclass.Location = new System.Drawing.Point(228, 17);
            this.btnusersclass.Name = "btnusersclass";
            this.btnusersclass.Size = new System.Drawing.Size(75, 23);
            this.btnusersclass.TabIndex = 2;
            this.btnusersclass.Text = "查询";
            this.btnusersclass.UseVisualStyleBackColor = true;
            this.btnusersclass.Click += new System.EventHandler(this.btnusersclass_Click);
            // 
            // dgvuser
            // 
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.username,
            this.usersex,
            this.userage,
            this.romark,
            this.classname});
            this.dgvuser.Location = new System.Drawing.Point(0, 66);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.RowTemplate.Height = 23;
            this.dgvuser.Size = new System.Drawing.Size(548, 150);
            this.dgvuser.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(30, 244);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "新增";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnxg
            // 
            this.btnxg.Location = new System.Drawing.Point(167, 243);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(75, 23);
            this.btnxg.TabIndex = 5;
            this.btnxg.TabStop = false;
            this.btnxg.Text = "修改";
            this.btnxg.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(292, 243);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(429, 243);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 7;
            this.btnno.Text = "退出";
            this.btnno.UseVisualStyleBackColor = true;
            // 
            // gupusers
            // 
            this.gupusers.Controls.Add(this.cmblb);
            this.gupusers.Controls.Add(this.cmbsex);
            this.gupusers.Controls.Add(this.txtage);
            this.gupusers.Controls.Add(this.txtbz);
            this.gupusers.Controls.Add(this.txtname);
            this.gupusers.Controls.Add(this.lbllb);
            this.gupusers.Controls.Add(this.lblbz);
            this.gupusers.Controls.Add(this.lblage);
            this.gupusers.Controls.Add(this.lblsex);
            this.gupusers.Controls.Add(this.lblname);
            this.gupusers.Controls.Add(this.txtid);
            this.gupusers.Controls.Add(this.lblid);
            this.gupusers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gupusers.Location = new System.Drawing.Point(39, 305);
            this.gupusers.Name = "gupusers";
            this.gupusers.Size = new System.Drawing.Size(495, 153);
            this.gupusers.TabIndex = 8;
            this.gupusers.TabStop = false;
            this.gupusers.Text = "用户信息";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(16, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(65, 12);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "用户编号：";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(87, 27);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 21);
            this.txtid.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(222, 35);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(65, 12);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "用户姓名：";
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(16, 73);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(59, 12);
            this.lblsex.TabIndex = 3;
            this.lblsex.Text = "用户性别:";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(222, 73);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(65, 12);
            this.lblage.TabIndex = 4;
            this.lblage.Text = "用户年龄：";
            // 
            // lblbz
            // 
            this.lblbz.AutoSize = true;
            this.lblbz.Location = new System.Drawing.Point(16, 116);
            this.lblbz.Name = "lblbz";
            this.lblbz.Size = new System.Drawing.Size(35, 12);
            this.lblbz.TabIndex = 5;
            this.lblbz.Text = "备注:";
            // 
            // lbllb
            // 
            this.lbllb.AutoSize = true;
            this.lbllb.Location = new System.Drawing.Point(223, 116);
            this.lbllb.Name = "lbllb";
            this.lbllb.Size = new System.Drawing.Size(59, 12);
            this.lbllb.TabIndex = 6;
            this.lbllb.Text = "用户类别:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(293, 30);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 7;
            // 
            // txtbz
            // 
            this.txtbz.Location = new System.Drawing.Point(87, 107);
            this.txtbz.Name = "txtbz";
            this.txtbz.Size = new System.Drawing.Size(100, 21);
            this.txtbz.TabIndex = 8;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(293, 64);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 21);
            this.txtage.TabIndex = 9;
            // 
            // cmbsex
            // 
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Location = new System.Drawing.Point(87, 64);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(100, 20);
            this.cmbsex.TabIndex = 10;
            // 
            // cmblb
            // 
            this.cmblb.FormattingEnabled = true;
            this.cmblb.Location = new System.Drawing.Point(293, 107);
            this.cmblb.Name = "cmblb";
            this.cmblb.Size = new System.Drawing.Size(100, 20);
            this.cmblb.TabIndex = 11;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "用户编号";
            this.userid.Name = "userid";
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "用户姓名";
            this.username.Name = "username";
            // 
            // usersex
            // 
            this.usersex.DataPropertyName = "usersex";
            this.usersex.HeaderText = "用户性别";
            this.usersex.Name = "usersex";
            // 
            // userage
            // 
            this.userage.DataPropertyName = "userage";
            this.userage.HeaderText = "用户年龄";
            this.userage.Name = "userage";
            // 
            // romark
            // 
            this.romark.DataPropertyName = "romark";
            this.romark.HeaderText = "备注";
            this.romark.Name = "romark";
            // 
            // classname
            // 
            this.classname.DataPropertyName = "classname";
            this.classname.HeaderText = "用户类别";
            this.classname.Name = "classname";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 470);
            this.Controls.Add(this.gupusers);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnxg);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvuser);
            this.Controls.Add(this.btnusersclass);
            this.Controls.Add(this.cmbusersclass);
            this.Controls.Add(this.lblusersclass);
            this.Name = "frmUsers";
            this.Text = "用户管理系统";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.gupusers.ResumeLayout(false);
            this.gupusers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusersclass;
        private System.Windows.Forms.ComboBox cmbusersclass;
        private System.Windows.Forms.Button btnusersclass;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.GroupBox gupusers;
        private System.Windows.Forms.Label lbllb;
        private System.Windows.Forms.Label lblbz;
        public System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ComboBox cmblb;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtbz;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersex;
        private System.Windows.Forms.DataGridViewTextBoxColumn userage;
        private System.Windows.Forms.DataGridViewTextBoxColumn romark;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
    }
}

