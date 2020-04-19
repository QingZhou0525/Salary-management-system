namespace 工资管理系统
{
    partial class 工资查询
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(工资查询));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月基本工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月奖惩工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月工资总结DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工资表BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gongziDataSet24 = new 工资管理系统.gongziDataSet24();
            this.工资表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gongziDataSet12 = new 工资管理系统.gongziDataSet12();
            this.工资表TableAdapter = new 工资管理系统.gongziDataSet12TableAdapters.工资表TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.员工信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gongziDataSet13 = new 工资管理系统.gongziDataSet13();
            this.员工信息表TableAdapter = new 工资管理系统.gongziDataSet13TableAdapters.员工信息表TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.工资表TableAdapter1 = new 工资管理系统.gongziDataSet24TableAdapters.工资表TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资表BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.时间DataGridViewTextBoxColumn,
            this.员工编号DataGridViewTextBoxColumn,
            this.员工姓名DataGridViewTextBoxColumn,
            this.月基本工资DataGridViewTextBoxColumn,
            this.月奖惩工资DataGridViewTextBoxColumn,
            this.月工资总结DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.工资表BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(942, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // 时间DataGridViewTextBoxColumn
            // 
            this.时间DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.时间DataGridViewTextBoxColumn.DataPropertyName = "时间";
            this.时间DataGridViewTextBoxColumn.HeaderText = "时间";
            this.时间DataGridViewTextBoxColumn.Name = "时间DataGridViewTextBoxColumn";
            this.时间DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 员工编号DataGridViewTextBoxColumn
            // 
            this.员工编号DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.员工编号DataGridViewTextBoxColumn.DataPropertyName = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.HeaderText = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.Name = "员工编号DataGridViewTextBoxColumn";
            this.员工编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 员工姓名DataGridViewTextBoxColumn
            // 
            this.员工姓名DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.员工姓名DataGridViewTextBoxColumn.DataPropertyName = "员工姓名";
            this.员工姓名DataGridViewTextBoxColumn.HeaderText = "员工姓名";
            this.员工姓名DataGridViewTextBoxColumn.Name = "员工姓名DataGridViewTextBoxColumn";
            this.员工姓名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 月基本工资DataGridViewTextBoxColumn
            // 
            this.月基本工资DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.月基本工资DataGridViewTextBoxColumn.DataPropertyName = "月基本工资";
            this.月基本工资DataGridViewTextBoxColumn.HeaderText = "月基本工资(元)";
            this.月基本工资DataGridViewTextBoxColumn.Name = "月基本工资DataGridViewTextBoxColumn";
            this.月基本工资DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 月奖惩工资DataGridViewTextBoxColumn
            // 
            this.月奖惩工资DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.月奖惩工资DataGridViewTextBoxColumn.DataPropertyName = "月奖惩工资";
            this.月奖惩工资DataGridViewTextBoxColumn.HeaderText = "月奖惩工资(元)";
            this.月奖惩工资DataGridViewTextBoxColumn.Name = "月奖惩工资DataGridViewTextBoxColumn";
            this.月奖惩工资DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 月工资总结DataGridViewTextBoxColumn
            // 
            this.月工资总结DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.月工资总结DataGridViewTextBoxColumn.DataPropertyName = "月工资总结";
            this.月工资总结DataGridViewTextBoxColumn.HeaderText = "月工资总结(元)";
            this.月工资总结DataGridViewTextBoxColumn.Name = "月工资总结DataGridViewTextBoxColumn";
            this.月工资总结DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 工资表BindingSource1
            // 
            this.工资表BindingSource1.DataMember = "工资表";
            this.工资表BindingSource1.DataSource = this.gongziDataSet24;
            // 
            // gongziDataSet24
            // 
            this.gongziDataSet24.DataSetName = "gongziDataSet24";
            this.gongziDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 工资表BindingSource
            // 
            this.工资表BindingSource.DataMember = "工资表";
            this.工资表BindingSource.DataSource = this.gongziDataSet12;
            // 
            // gongziDataSet12
            // 
            this.gongziDataSet12.DataSetName = "gongziDataSet12";
            this.gongziDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 工资表TableAdapter
            // 
            this.工资表TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(139, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(448, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "员工编号：";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.员工信息表BindingSource;
            this.comboBox1.DisplayMember = "员工编号";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(515, 442);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "员工姓名";
            // 
            // 员工信息表BindingSource
            // 
            this.员工信息表BindingSource.DataMember = "员工信息表";
            this.员工信息表BindingSource.DataSource = this.gongziDataSet13;
            // 
            // gongziDataSet13
            // 
            this.gongziDataSet13.DataSetName = "gongziDataSet13";
            this.gongziDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 员工信息表TableAdapter
            // 
            this.员工信息表TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy年MM月";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 442);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // 工资表TableAdapter1
            // 
            this.工资表TableAdapter1.ClearBeforeFill = true;
            // 
            // 工资查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "工资查询";
            this.Text = "工资查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.本月工资管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资表BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gongziDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gongziDataSet12 gongziDataSet12;
        private System.Windows.Forms.BindingSource 工资表BindingSource;
        private gongziDataSet12TableAdapters.工资表TableAdapter 工资表TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private gongziDataSet13 gongziDataSet13;
        private System.Windows.Forms.BindingSource 员工信息表BindingSource;
        private gongziDataSet13TableAdapters.员工信息表TableAdapter 员工信息表TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月基本工资DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月奖惩工资DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月工资总结DataGridViewTextBoxColumn;
        private gongziDataSet24 gongziDataSet24;
        private System.Windows.Forms.BindingSource 工资表BindingSource1;
        private gongziDataSet24TableAdapters.工资表TableAdapter 工资表TableAdapter1;
    }
}