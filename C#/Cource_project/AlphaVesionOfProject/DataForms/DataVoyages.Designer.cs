namespace AlphaVesionOfProject.DataForms
{
    partial class DataVoyages
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
            this.voyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voyagesTableAdapter = new AlphaVesionOfProject.autotpDataSetTableAdapters.voyagesTableAdapter();
            this.voyageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itineraryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voyagesBindingSource)).BeginInit();
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
            this.label1.Text = "Voyages";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voyageidDataGridViewTextBoxColumn,
            this.itineraryidDataGridViewTextBoxColumn,
            this.driveridDataGridViewTextBoxColumn,
            this.carnumberDataGridViewTextBoxColumn,
            this.timestartDataGridViewTextBoxColumn,
            this.timeendDataGridViewTextBoxColumn,
            this.fuelstartDataGridViewTextBoxColumn,
            this.fuelendDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.voyagesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 58);
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
            // voyagesBindingSource
            // 
            this.voyagesBindingSource.DataMember = "voyages";
            this.voyagesBindingSource.DataSource = this.autotpDataSet;
            // 
            // voyagesTableAdapter
            // 
            this.voyagesTableAdapter.ClearBeforeFill = true;
            // 
            // voyageidDataGridViewTextBoxColumn
            // 
            this.voyageidDataGridViewTextBoxColumn.DataPropertyName = "voyage_id";
            this.voyageidDataGridViewTextBoxColumn.HeaderText = "voyage_id";
            this.voyageidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.voyageidDataGridViewTextBoxColumn.Name = "voyageidDataGridViewTextBoxColumn";
            this.voyageidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itineraryidDataGridViewTextBoxColumn
            // 
            this.itineraryidDataGridViewTextBoxColumn.DataPropertyName = "itinerary_id";
            this.itineraryidDataGridViewTextBoxColumn.HeaderText = "itinerary_id";
            this.itineraryidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itineraryidDataGridViewTextBoxColumn.Name = "itineraryidDataGridViewTextBoxColumn";
            // 
            // driveridDataGridViewTextBoxColumn
            // 
            this.driveridDataGridViewTextBoxColumn.DataPropertyName = "driver_id";
            this.driveridDataGridViewTextBoxColumn.HeaderText = "driver_id";
            this.driveridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.driveridDataGridViewTextBoxColumn.Name = "driveridDataGridViewTextBoxColumn";
            // 
            // carnumberDataGridViewTextBoxColumn
            // 
            this.carnumberDataGridViewTextBoxColumn.DataPropertyName = "car_number";
            this.carnumberDataGridViewTextBoxColumn.HeaderText = "car_number";
            this.carnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carnumberDataGridViewTextBoxColumn.Name = "carnumberDataGridViewTextBoxColumn";
            // 
            // timestartDataGridViewTextBoxColumn
            // 
            this.timestartDataGridViewTextBoxColumn.DataPropertyName = "time_start";
            this.timestartDataGridViewTextBoxColumn.HeaderText = "time_start";
            this.timestartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timestartDataGridViewTextBoxColumn.Name = "timestartDataGridViewTextBoxColumn";
            // 
            // timeendDataGridViewTextBoxColumn
            // 
            this.timeendDataGridViewTextBoxColumn.DataPropertyName = "time_end";
            this.timeendDataGridViewTextBoxColumn.HeaderText = "time_end";
            this.timeendDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeendDataGridViewTextBoxColumn.Name = "timeendDataGridViewTextBoxColumn";
            // 
            // fuelstartDataGridViewTextBoxColumn
            // 
            this.fuelstartDataGridViewTextBoxColumn.DataPropertyName = "fuel_start";
            this.fuelstartDataGridViewTextBoxColumn.HeaderText = "fuel_start";
            this.fuelstartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fuelstartDataGridViewTextBoxColumn.Name = "fuelstartDataGridViewTextBoxColumn";
            // 
            // fuelendDataGridViewTextBoxColumn
            // 
            this.fuelendDataGridViewTextBoxColumn.DataPropertyName = "fuel_end";
            this.fuelendDataGridViewTextBoxColumn.HeaderText = "fuel_end";
            this.fuelendDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fuelendDataGridViewTextBoxColumn.Name = "fuelendDataGridViewTextBoxColumn";
            // 
            // DataVoyages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DataVoyages";
            this.Text = "DataVoyages";
            this.Load += new System.EventHandler(this.DataVoyages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voyagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private autotpDataSet autotpDataSet;
        private System.Windows.Forms.BindingSource voyagesBindingSource;
        private autotpDataSetTableAdapters.voyagesTableAdapter voyagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn voyageidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itineraryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelendDataGridViewTextBoxColumn;
    }
}