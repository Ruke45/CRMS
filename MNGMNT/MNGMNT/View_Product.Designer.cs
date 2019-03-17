namespace MNGMNT
{
    partial class View_Product
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cRMSDataSet2 = new MNGMNT.CRMSDataSet2();
            this.viewProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewProductTableAdapter = new MNGMNT.CRMSDataSet2TableAdapters.ViewProductTableAdapter();
            this.portfolioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.launchedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancledReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLifeCycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 31);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product / View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.portfolioIDDataGridViewTextBoxColumn,
            this.productOwnerDataGridViewTextBoxColumn,
            this.nameofProductDataGridViewTextBoxColumn,
            this.launchedDateDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.productStatusDataGridViewTextBoxColumn,
            this.productDurationDataGridViewTextBoxColumn,
            this.cancledReasonDataGridViewTextBoxColumn,
            this.productLifeCycleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewProductBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 354);
            this.dataGridView1.TabIndex = 5;
            // 
            // cRMSDataSet2
            // 
            this.cRMSDataSet2.DataSetName = "CRMSDataSet2";
            this.cRMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewProductBindingSource
            // 
            this.viewProductBindingSource.DataMember = "ViewProduct";
            this.viewProductBindingSource.DataSource = this.cRMSDataSet2;
            // 
            // viewProductTableAdapter
            // 
            this.viewProductTableAdapter.ClearBeforeFill = true;
            // 
            // portfolioIDDataGridViewTextBoxColumn
            // 
            this.portfolioIDDataGridViewTextBoxColumn.DataPropertyName = "PortfolioID";
            this.portfolioIDDataGridViewTextBoxColumn.HeaderText = "PortfolioID";
            this.portfolioIDDataGridViewTextBoxColumn.Name = "portfolioIDDataGridViewTextBoxColumn";
            this.portfolioIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productOwnerDataGridViewTextBoxColumn
            // 
            this.productOwnerDataGridViewTextBoxColumn.DataPropertyName = "ProductOwner";
            this.productOwnerDataGridViewTextBoxColumn.HeaderText = "ProductOwner";
            this.productOwnerDataGridViewTextBoxColumn.Name = "productOwnerDataGridViewTextBoxColumn";
            // 
            // nameofProductDataGridViewTextBoxColumn
            // 
            this.nameofProductDataGridViewTextBoxColumn.DataPropertyName = "NameofProduct";
            this.nameofProductDataGridViewTextBoxColumn.HeaderText = "NameofProduct";
            this.nameofProductDataGridViewTextBoxColumn.Name = "nameofProductDataGridViewTextBoxColumn";
            // 
            // launchedDateDataGridViewTextBoxColumn
            // 
            this.launchedDateDataGridViewTextBoxColumn.DataPropertyName = "LaunchedDate";
            this.launchedDateDataGridViewTextBoxColumn.HeaderText = "LaunchedDate";
            this.launchedDateDataGridViewTextBoxColumn.Name = "launchedDateDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // productStatusDataGridViewTextBoxColumn
            // 
            this.productStatusDataGridViewTextBoxColumn.DataPropertyName = "ProductStatus";
            this.productStatusDataGridViewTextBoxColumn.HeaderText = "ProductStatus";
            this.productStatusDataGridViewTextBoxColumn.Name = "productStatusDataGridViewTextBoxColumn";
            // 
            // productDurationDataGridViewTextBoxColumn
            // 
            this.productDurationDataGridViewTextBoxColumn.DataPropertyName = "ProductDuration";
            this.productDurationDataGridViewTextBoxColumn.HeaderText = "ProductDuration";
            this.productDurationDataGridViewTextBoxColumn.Name = "productDurationDataGridViewTextBoxColumn";
            // 
            // cancledReasonDataGridViewTextBoxColumn
            // 
            this.cancledReasonDataGridViewTextBoxColumn.DataPropertyName = "CancledReason";
            this.cancledReasonDataGridViewTextBoxColumn.HeaderText = "CancledReason";
            this.cancledReasonDataGridViewTextBoxColumn.Name = "cancledReasonDataGridViewTextBoxColumn";
            // 
            // productLifeCycleDataGridViewTextBoxColumn
            // 
            this.productLifeCycleDataGridViewTextBoxColumn.DataPropertyName = "ProductLifeCycle";
            this.productLifeCycleDataGridViewTextBoxColumn.HeaderText = "ProductLifeCycle";
            this.productLifeCycleDataGridViewTextBoxColumn.Name = "productLifeCycleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // View_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1068, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "View_Product";
            this.Text = "View_Product";
            this.Load += new System.EventHandler(this.View_Product_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CRMSDataSet2 cRMSDataSet2;
        private System.Windows.Forms.BindingSource viewProductBindingSource;
        private CRMSDataSet2TableAdapters.ViewProductTableAdapter viewProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn portfolioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn launchedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancledReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productLifeCycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}