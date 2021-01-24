namespace AlphaVesionOfProject.DataForms
{
    partial class DataSupplies
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
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliesTableAdapter = new AlphaVesionOfProject.autotpDataSetTableAdapters.suppliesTableAdapter();
            this.supplyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fueltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tankidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplyidDataGridViewTextBoxColumn,
            this.fueltypeDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.supplydateDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.tankidDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.suppliesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 60);
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
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "supplies";
            this.suppliesBindingSource.DataSource = this.autotpDataSet;
            // 
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // supplyidDataGridViewTextBoxColumn
            // 
            this.supplyidDataGridViewTextBoxColumn.DataPropertyName = "supply_id";
            this.supplyidDataGridViewTextBoxColumn.HeaderText = "supply_id";
            this.supplyidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplyidDataGridViewTextBoxColumn.Name = "supplyidDataGridViewTextBoxColumn";
            this.supplyidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fueltypeDataGridViewTextBoxColumn
            // 
            this.fueltypeDataGridViewTextBoxColumn.DataPropertyName = "fuel_type";
            this.fueltypeDataGridViewTextBoxColumn.HeaderText = "fuel_type";
            this.fueltypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fueltypeDataGridViewTextBoxColumn.Name = "fueltypeDataGridViewTextBoxColumn";
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            // 
            // supplydateDataGridViewTextBoxColumn
            // 
            this.supplydateDataGridViewTextBoxColumn.DataPropertyName = "supply_date";
            this.supplydateDataGridViewTextBoxColumn.HeaderText = "supply_date";
            this.supplydateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplydateDataGridViewTextBoxColumn.Name = "supplydateDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "supplier";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // tankidDataGridViewTextBoxColumn
            // 
            this.tankidDataGridViewTextBoxColumn.DataPropertyName = "tank_id";
            this.tankidDataGridViewTextBoxColumn.HeaderText = "tank_id";
            this.tankidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tankidDataGridViewTextBoxColumn.Name = "tankidDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // DataSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DataSupplies";
            this.Text = "DataSupplies";
            this.Load += new System.EventHandler(this.DataSupplies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private autotpDataSet autotpDataSet;
        private System.Windows.Forms.BindingSource suppliesBindingSource;
        private autotpDataSetTableAdapters.suppliesTableAdapter suppliesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tankidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}