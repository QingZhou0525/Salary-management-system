namespace 工资管理系统
{
    partial class 打印工资条预览
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(打印工资条预览));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月基本工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月奖惩工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月工资总结DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职位DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工资表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gongziDataSet26 = new 工资管理系统.gongziDataSet26();
            this.工资表TableAdapter = new 工资管理系统.gongziDataSet26TableAdapters.工资表TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet26)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.时间DataGridViewTextBoxColumn,
            this.员工编号DataGridViewTextBoxColumn,
            this.员工姓名DataGridViewTextBoxColumn,
            this.月基本工资DataGridViewTextBoxColumn,
            this.月奖惩工资DataGridViewTextBoxColumn,
            this.月工资总结DataGridViewTextBoxColumn,
            this.职位DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.工资表BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(669, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // 时间DataGridViewTextBoxColumn
            // 
            this.时间DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.时间DataGridViewTextBoxColumn.DataPropertyName = "时间";
            this.时间DataGridViewTextBoxColumn.HeaderText = "时间";
            this.时间DataGridViewTextBoxColumn.Name = "时间DataGridViewTextBoxColumn";
            // 
            // 员工编号DataGridViewTextBoxColumn
            // 
            this.员工编号DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.员工编号DataGridViewTextBoxColumn.DataPropertyName = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.HeaderText = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.Name = "员工编号DataGridViewTextBoxColumn";
            // 
            // 员工姓名DataGridViewTextBoxColumn
            // 
            this.员工姓名DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.员工姓名DataGridViewTextBoxColumn.DataPropertyName = "员工姓名";
            this.员工姓名DataGridViewTextBoxColumn.HeaderText = "员工姓名";
            this.员工姓名DataGridViewTextBoxColumn.Name = "员工姓名DataGridViewTextBoxColumn";
            // 
            // 月基本工资DataGridViewTextBoxColumn
            // 
            this.月基本工资DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.月基本工资DataGridViewTextBoxColumn.DataPropertyName = "月基本工资";
            this.月基本工资DataGridViewTextBoxColumn.HeaderText = "月基本工资（元）";
            this.月基本工资DataGridViewTextBoxColumn.Name = "月基本工资DataGridViewTextBoxColumn";
            // 
            // 月奖惩工资DataGridViewTextBoxColumn
            // 
            this.月奖惩工资DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.月奖惩工资DataGridViewTextBoxColumn.DataPropertyName = "月奖惩工资";
            this.月奖惩工资DataGridViewTextBoxColumn.HeaderText = "月奖惩工资（元）";
            this.月奖惩工资DataGridViewTextBoxColumn.Name = "月奖惩工资DataGridViewTextBoxColumn";
            // 
            // 月工资总结DataGridViewTextBoxColumn
            // 
            this.月工资总结DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.月工资总结DataGridViewTextBoxColumn.DataPropertyName = "月工资总结";
            this.月工资总结DataGridViewTextBoxColumn.HeaderText = "月工资总结（元）";
            this.月工资总结DataGridViewTextBoxColumn.Name = "月工资总结DataGridViewTextBoxColumn";
            // 
            // 职位DataGridViewTextBoxColumn
            // 
            this.职位DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.职位DataGridViewTextBoxColumn.DataPropertyName = "职位";
            this.职位DataGridViewTextBoxColumn.HeaderText = "职位";
            this.职位DataGridViewTextBoxColumn.Name = "职位DataGridViewTextBoxColumn";
            // 
            // 工资表BindingSource
            // 
            this.工资表BindingSource.DataMember = "工资表";
            this.工资表BindingSource.DataSource = this.gongziDataSet26;
            // 
            // gongziDataSet26
            // 
            this.gongziDataSet26.DataSetName = "gongziDataSet26";
            this.gongziDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 工资表TableAdapter
            // 
            this.工资表TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "导入到Excel中后打印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 打印工资条预览
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "打印工资条预览";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印工资条预览";
            this.Load += new System.EventHandler(this.打印工资条预览_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet26)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gongziDataSet26 gongziDataSet26;
        private System.Windows.Forms.BindingSource 工资表BindingSource;
        private gongziDataSet26TableAdapters.工资表TableAdapter 工资表TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月基本工资DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月奖惩工资DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月工资总结DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职位DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}