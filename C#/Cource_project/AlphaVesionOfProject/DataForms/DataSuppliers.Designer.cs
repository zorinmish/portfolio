namespace AlphaVesionOfProject.DataForms
{
    partial class DataSuppliers
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autotpDataSet = new AlphaVesionOfProject.autotpDataSet();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new AlphaVesionOfProject.autotpDataSetTableAdapters.suppliersTableAdapter();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suppliers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.officeaddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.suppliersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 217);
            this.dataGridView1.TabIndex = 3;
            // 
            // autotpDataSet
            // 
            this.autotpDataSet.DataSetName = "autotpDataSet";
            this.autotpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "suppliers";
            this.suppliersBindingSource.DataSource = this.autotpDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "supplier";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // officeaddressDataGridViewTextBoxColumn
            // 
            this.officeaddressDataGridViewTextBoxColumn.DataPropertyName = "office_address";
            this.officeaddressDataGridViewTextBoxColumn.HeaderText = "office_address";
            this.officeaddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.officeaddressDataGridViewTextBoxColumn.Name = "officeaddressDataGridViewTextBoxColumn";
            // 
            // DataSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DataSuppliers";
            this.Text = "DataSuppliers";
            this.Load += new System.EventHandler(this.DataSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private autotpDataSet autotpDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private autotpDataSetTableAdapters.suppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeaddressDataGridViewTextBoxColumn;
    }
}