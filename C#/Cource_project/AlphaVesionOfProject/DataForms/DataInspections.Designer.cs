namespace AlphaVesionOfProject.DataForms
{
    partial class DataInspections
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
            this.techinspectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectionsTableAdapter = new AlphaVesionOfProject.autotpDataSetTableAdapters.tech_inspectionsTableAdapter();
            this.inspectionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinspectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inspections";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inspectionidDataGridViewTextBoxColumn,
            this.carnumberDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.inspectiondateDataGridViewTextBoxColumn,
            this.mileageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.techinspectionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 44);
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
            // techinspectionsBindingSource
            // 
            this.techinspectionsBindingSource.DataMember = "tech_inspections";
            this.techinspectionsBindingSource.DataSource = this.autotpDataSet;
            // 
            // tech_inspectionsTableAdapter
            // 
            this.tech_inspectionsTableAdapter.ClearBeforeFill = true;
            // 
            // inspectionidDataGridViewTextBoxColumn
            // 
            this.inspectionidDataGridViewTextBoxColumn.DataPropertyName = "inspection_id";
            this.inspectionidDataGridViewTextBoxColumn.HeaderText = "inspection_id";
            this.inspectionidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.inspectionidDataGridViewTextBoxColumn.Name = "inspectionidDataGridViewTextBoxColumn";
            this.inspectionidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carnumberDataGridViewTextBoxColumn
            // 
            this.carnumberDataGridViewTextBoxColumn.DataPropertyName = "car_number";
            this.carnumberDataGridViewTextBoxColumn.HeaderText = "car_number";
            this.carnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carnumberDataGridViewTextBoxColumn.Name = "carnumberDataGridViewTextBoxColumn";
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
            this.conditionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            // 
            // inspectiondateDataGridViewTextBoxColumn
            // 
            this.inspectiondateDataGridViewTextBoxColumn.DataPropertyName = "inspection_date";
            this.inspectiondateDataGridViewTextBoxColumn.HeaderText = "inspection_date";
            this.inspectiondateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.inspectiondateDataGridViewTextBoxColumn.Name = "inspectiondateDataGridViewTextBoxColumn";
            // 
            // mileageDataGridViewTextBoxColumn
            // 
            this.mileageDataGridViewTextBoxColumn.DataPropertyName = "mileage";
            this.mileageDataGridViewTextBoxColumn.HeaderText = "mileage";
            this.mileageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mileageDataGridViewTextBoxColumn.Name = "mileageDataGridViewTextBoxColumn";
            // 
            // DataInspections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DataInspections";
            this.Text = "DataInspections";
            this.Load += new System.EventHandler(this.DataInspections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techinspectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private autotpDataSet autotpDataSet;
        private System.Windows.Forms.BindingSource techinspectionsBindingSource;
        private autotpDataSetTableAdapters.tech_inspectionsTableAdapter tech_inspectionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
    }
}