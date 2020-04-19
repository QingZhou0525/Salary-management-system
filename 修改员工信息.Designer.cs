namespace 工资管理系统
{
    partial class 修改员工信息
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(修改员工信息));
            this.员工信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gongziDataSet7 = new 工资管理系统.gongziDataSet7();
            this.yuangongxinxiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gongziDataSet = new 工资管理系统.gongziDataSet();
            this.yuangongxinxiTableAdapter = new 工资管理系统.gongziDataSetTableAdapters.yuangongxinxiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.员工信息表TableAdapter = new 工资管理系统.gongziDataSet7TableAdapters.员工信息表TableAdapter();
            this.gongziDataSet14 = new 工资管理系统.gongziDataSet14();
            this.员工信息表BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.员工信息表TableAdapter1 = new 工资管理系统.gongziDataSet14TableAdapters.员工信息表TableAdapter();
            this.dgvYuangong = new System.Windows.Forms.DataGridView();
            this.员工姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出生日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.家庭地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职位DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入职时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.员工信息表BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gongziDataSet17 = new 工资管理系统.gongziDataSet17();
            this.员工信息表BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gongziDataSet15 = new 工资管理系统.gongziDataSet15();
            this.员工信息表TableAdapter2 = new 工资管理系统.gongziDataSet15TableAdapters.员工信息表TableAdapter();
            this.员工信息表TableAdapter3 = new 工资管理系统.gongziDataSet17TableAdapters.员工信息表TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuangongxinxiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息表BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuangong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息表BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息表BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // 员工信息表BindingSource
            // 
            this.员工信息表BindingSource.DataMember = "员工信息表";
            this.员工信息表BindingSource.DataSource = this.gongziDataSet7;
            this.员工信息表BindingSource.CurrentChanged += new System.EventHandler(this.员工信息表BindingSource_CurrentChanged);
            // 
            // gongziDataSet7
            // 
            this.gongziDataSet7.DataSetName = "gongziDataSet7";
            this.gongziDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yuangongxinxiBindingSource
            // 
            this.yuangongxinxiBindingSource.DataMember = "yuangongxinxi";
            this.yuangongxinxiBindingSource.DataSource = this.gongziDataSet;
            // 
            // gongziDataSet
            // 
            this.gongziDataSet.DataSetName = "gongziDataSet";
            this.gongziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yuangongxinxiTableAdapter
            // 
            this.yuangongxinxiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(335, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "保存修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(596, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 员工信息表TableAdapter
            // 
            this.员工信息表TableAdapter.ClearBeforeFill = true;
            // 
            // gongziDataSet14
            // 
            this.gongziDataSet14.DataSetName = "gongziDataSet14";
            this.gongziDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 员工信息表BindingSource1
            // 
            this.员工信息表BindingSource1.DataMember = "员工信息表";
            this.员工信息表BindingSource1.DataSource = this.gongziDataSet14;
            // 
            // 员工信息表TableAdapter1
            // 
            this.员工信息表TableAdapter1.ClearBeforeFill = true;
            // 
            // dgvYuangong
            // 
            this.dgvYuangong.AllowUserToAddRows = false;
            this.dgvYuangong.AutoGenerateColumns = false;
            this.dgvYuangong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYuangong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.员工姓名DataGridViewTextBoxColumn,
            this.员工编号DataGridViewTextBoxColumn,
            this.出生日期DataGridViewTextBoxColumn,
            this.身份证号DataGridViewTextBoxColumn,
            this.电话DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.家庭地址DataGridViewTextBoxColumn,
            this.部门DataGridViewTextBoxColumn,
            this.职位DataGridViewTextBoxColumn,
            this.入职时间,
            this.Column1});
            this.dgvYuangong.DataSource = this.员工信息表BindingSource3;
            this.dgvYuangong.Location = new System.Drawing.Point(12, 29);
            this.dgvYuangong.Name = "dgvYuangong";
            this.dgvYuangong.RowTemplate.Height = 23;
            this.dgvYuangong.Size = new System.Drawing.Size(965, 364);
            this.dgvYuangong.TabIndex = 3;
            this.dgvYuangong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYuangong_CellContentClick_1);
            // 
            // 员工姓名DataGridViewTextBoxColumn
            // 
            this.员工姓名DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.员工姓名DataGridViewTextBoxColumn.DataPropertyName = "员工姓名";
            this.员工姓名DataGridViewTextBoxColumn.HeaderText = "员工姓名";
            this.员工姓名DataGridViewTextBoxColumn.Name = "员工姓名DataGridViewTextBoxColumn";
            // 
            // 员工编号DataGridViewTextBoxColumn
            // 
            this.员工编号DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.员工编号DataGridViewTextBoxColumn.DataPropertyName = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.HeaderText = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.Name = "员工编号DataGridViewTextBoxColumn";
            // 
            // 出生日期DataGridViewTextBoxColumn
            // 
            this.出生日期DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.出生日期DataGridViewTextBoxColumn.DataPropertyName = "出生日期";
            this.出生日期DataGridViewTextBoxColumn.HeaderText = "出生日期";
            this.出生日期DataGridViewTextBoxColumn.Name = "出生日期DataGridViewTextBoxColumn";
            // 
            // 身份证号DataGridViewTextBoxColumn
            // 
            this.身份证号DataGridViewTextBoxColumn.DataPropertyName = "身份证号";
            this.身份证号DataGridViewTextBoxColumn.HeaderText = "身份证号";
            this.身份证号DataGridViewTextBoxColumn.Name = "身份证号DataGridViewTextBoxColumn";
            this.身份证号DataGridViewTextBoxColumn.Width = 120;
            // 
            // 电话DataGridViewTextBoxColumn
            // 
            this.电话DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.电话DataGridViewTextBoxColumn.DataPropertyName = "电话";
            this.电话DataGridViewTextBoxColumn.HeaderText = "电话";
            this.电话DataGridViewTextBoxColumn.Name = "电话DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 家庭地址DataGridViewTextBoxColumn
            // 
            this.家庭地址DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.家庭地址DataGridViewTextBoxColumn.DataPropertyName = "家庭地址";
            this.家庭地址DataGridViewTextBoxColumn.HeaderText = "家庭地址";
            this.家庭地址DataGridViewTextBoxColumn.Name = "家庭地址DataGridViewTextBoxColumn";
            // 
            // 部门DataGridViewTextBoxColumn
            // 
            this.部门DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.部门DataGridViewTextBoxColumn.DataPropertyName = "部门";
            this.部门DataGridViewTextBoxColumn.HeaderText = "部门";
            this.部门DataGridViewTextBoxColumn.Name = "部门DataGridViewTextBoxColumn";
            // 
            // 职位DataGridViewTextBoxColumn
            // 
            this.职位DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.职位DataGridViewTextBoxColumn.DataPropertyName = "职位";
            this.职位DataGridViewTextBoxColumn.HeaderText = "职位";
            this.职位DataGridViewTextBoxColumn.Name = "职位DataGridViewTextBoxColumn";
            // 
            // 入职时间
            // 
            this.入职时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.入职时间.DataPropertyName = "入职时间";
            this.入职时间.HeaderText = "入职时间";
            this.入职时间.Name = "入职时间";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "员工姓名";
            this.Column1.HeaderText = "删除";
            this.Column1.Name = "Column1";
            this.Column1.Text = "删除";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 35;
            // 
            // 员工信息表BindingSource3
            // 
            this.员工信息表BindingSource3.DataMember = "员工信息表";
            this.员工信息表BindingSource3.DataSource = this.gongziDataSet17;
            // 
            // gongziDataSet17
            // 
            this.gongziDataSet17.DataSetName = "gongziDataSet17";
            this.gongziDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 员工信息表BindingSource2
            // 
            this.员工信息表BindingSource2.DataMember = "员工信息表";
            this.员工信息表BindingSource2.DataSource = this.gongziDataSet15;
            // 
            // gongziDataSet15
            // 
            this.gongziDataSet15.DataSetName = "gongziDataSet15";
            this.gongziDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 员工信息表TableAdapter2
            // 
            this.员工信息表TableAdapter2.ClearBeforeFill = true;
            // 
            // 员工信息表TableAdapter3
            // 
            this.员工信息表TableAdapter3.ClearBeforeFill = true;
            // 
            // 修改员工信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 529);
            this.Controls.Add(this.dgvYuangong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "修改员工信息";
            this.Text = "修改员工信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.员工信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuangongxinxiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息表BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuangong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息表BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息表BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gongziDataSet gongziDataSet;
        private System.Windows.Forms.BindingSource yuangongxinxiBindingSource;
        private gongziDataSetTableAdapters.yuangongxinxiTableAdapter yuangongxinxiTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private gongziDataSet7 gongziDataSet7;
        private System.Windows.Forms.BindingSource 员工信息表BindingSource;
        private gongziDataSet7TableAdapters.员工信息表TableAdapter 员工信息表TableAdapter;
        private gongziDataSet14 gongziDataSet14;
        private System.Windows.Forms.BindingSource 员工信息表BindingSource1;
        private gongziDataSet14TableAdapters.员工信息表TableAdapter 员工信息表TableAdapter1;
        private System.Windows.Forms.DataGridView dgvYuangong;
        private gongziDataSet15 gongziDataSet15;
        private System.Windows.Forms.BindingSource 员工信息表BindingSource2;
        private gongziDataSet15TableAdapters.员工信息表TableAdapter 员工信息表TableAdapter2;
        private gongziDataSet17 gongziDataSet17;
        private System.Windows.Forms.BindingSource 员工信息表BindingSource3;
        private gongziDataSet17TableAdapters.员工信息表TableAdapter 员工信息表TableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家庭地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职位DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入职时间;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}