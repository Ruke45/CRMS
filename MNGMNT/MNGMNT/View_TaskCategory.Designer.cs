namespace MNGMNT
{
    partial class View_TaskCategory
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
            this.cRMSDataSet3 = new MNGMNT.CRMSDataSet3();
            this.tblTaskCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTaskCategoryTableAdapter = new MNGMNT.CRMSDataSet3TableAdapters.tblTaskCategoryTableAdapter();
            this.taskCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaskCategoryBindingSource)).BeginInit();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskCategoryIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTaskCategoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // cRMSDataSet3
            // 
            this.cRMSDataSet3.DataSetName = "CRMSDataSet3";
            this.cRMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTaskCategoryBindingSource
            // 
            this.tblTaskCategoryBindingSource.DataMember = "tblTaskCategory";
            this.tblTaskCategoryBindingSource.DataSource = this.cRMSDataSet3;
            // 
            // tblTaskCategoryTableAdapter
            // 
            this.tblTaskCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // taskCategoryIdDataGridViewTextBoxColumn
            // 
            this.taskCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "TaskCategoryId";
            this.taskCategoryIdDataGridViewTextBoxColumn.HeaderText = "TaskCategoryId";
            this.taskCategoryIdDataGridViewTextBoxColumn.Name = "taskCategoryIdDataGridViewTextBoxColumn";
            this.taskCategoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Controls.Add(this.label7);
            this.panel17.Location = new System.Drawing.Point(12, 12);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(601, 31);
            this.panel17.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Settings - New Task Category";
            // 
            // View_TaskCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(625, 344);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_TaskCategory";
            this.Text = "View_Task Category";
            this.Load += new System.EventHandler(this.View_TaskCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaskCategoryBindingSource)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CRMSDataSet3 cRMSDataSet3;
        private System.Windows.Forms.BindingSource tblTaskCategoryBindingSource;
        private CRMSDataSet3TableAdapters.tblTaskCategoryTableAdapter tblTaskCategoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskCategoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label7;
    }
}