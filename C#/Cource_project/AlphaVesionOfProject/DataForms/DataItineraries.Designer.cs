namespace AlphaVesionOfProject.DataForms
{
    partial class DataItineraries
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
            this.itinerariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itinerariesTableAdapter = new AlphaVesionOfProject.autotpDataSetTableAdapters.itinerariesTableAdapter();
            this.itineraryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itinerariesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Itineraries";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itineraryidDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itinerariesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
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
            // itinerariesBindingSource
            // 
            this.itinerariesBindingSource.DataMember = "itineraries";
            this.itinerariesBindingSource.DataSource = this.autotpDataSet;
            // 
            // itinerariesTableAdapter
            // 
            this.itinerariesTableAdapter.ClearBeforeFill = true;
            // 
            // itineraryidDataGridViewTextBoxColumn
            // 
            this.itineraryidDataGridViewTextBoxColumn.DataPropertyName = "itinerary_id";
            this.itineraryidDataGridViewTextBoxColumn.HeaderText = "itinerary_id";
            this.itineraryidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itineraryidDataGridViewTextBoxColumn.Name = "itineraryidDataGridViewTextBoxColumn";
            this.itineraryidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "descr";
            this.descrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "distance";
            this.distanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            // 
            // DataItineraries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DataItineraries";
            this.Text = "DataItineraries";
            this.Load += new System.EventHandler(this.DataItineraries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itinerariesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private autotpDataSet autotpDataSet;
        private System.Windows.Forms.BindingSource itinerariesBindingSource;
        private autotpDataSetTableAdapters.itinerariesTableAdapter itinerariesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itineraryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
    }
}