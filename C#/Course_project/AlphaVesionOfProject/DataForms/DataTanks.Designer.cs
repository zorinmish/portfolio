namespace AlphaVesionOfProject.DataForms
{
    partial class DataTanks
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
            this.tankidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fueltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumenowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumemaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autotpDataSet = new AlphaVesionOfProject.autotpDataSet();
            this.tanksTableAdapter = new AlphaVesionOfProject.autotpDataSetTableAdapters.tanksTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fuel tanks";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tankidDataGridViewTextBoxColumn,
            this.fueltypeDataGridViewTextBoxColumn,
            this.parkingidDataGridViewTextBoxColumn,
            this.volumenowDataGridViewTextBoxColumn,
            this.volumemaxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tanksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 217);
            this.dataGridView1.TabIndex = 3;
            // 
            // tankidDataGridViewTextBoxColumn
            // 
            this.tankidDataGridViewTextBoxColumn.DataPropertyName = "tank_id";
            this.tankidDataGridViewTextBoxColumn.HeaderText = "tank_id";
            this.tankidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tankidDataGridViewTextBoxColumn.Name = "tankidDataGridViewTextBoxColumn";
            this.tankidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fueltypeDataGridViewTextBoxColumn
            // 
            this.fueltypeDataGridViewTextBoxColumn.DataPropertyName = "fuel_type";
            this.fueltypeDataGridViewTextBoxColumn.HeaderText = "fuel_type";
            this.fueltypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fueltypeDataGridViewTextBoxColumn.Name = "fueltypeDataGridViewTextBoxColumn";
            // 
            // parkingidDataGridViewTextBoxColumn
            // 
            this.parkingidDataGridViewTextBoxColumn.DataPropertyName = "parking_id";
            this.parkingidDataGridViewTextBoxColumn.HeaderText = "parking_id";
            this.parkingidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.parkingidDataGridViewTextBoxColumn.Name = "parkingidDataGridViewTextBoxColumn";
            // 
            // volumenowDataGridViewTextBoxColumn
            // 
            this.volumenowDataGridViewTextBoxColumn.DataPropertyName = "volume_now";
            this.volumenowDataGridViewTextBoxColumn.HeaderText = "volume_now";
            this.volumenowDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.volumenowDataGridViewTextBoxColumn.Name = "volumenowDataGridViewTextBoxColumn";
            // 
            // volumemaxDataGridViewTextBoxColumn
            // 
            this.volumemaxDataGridViewTextBoxColumn.DataPropertyName = "volume_max";
            this.volumemaxDataGridViewTextBoxColumn.HeaderText = "volume_max";
            this.volumemaxDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.volumemaxDataGridViewTextBoxColumn.Name = "volumemaxDataGridViewTextBoxColumn";
            // 
            // tanksBindingSource
            // 
            this.tanksBindingSource.DataMember = "tanks";
            this.tanksBindingSource.DataSource = this.autotpDataSet;
            // 
            // autotpDataSet
            // 
            this.autotpDataSet.DataSetName = "autotpDataSet";
            this.autotpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tanksTableAdapter
            // 
            this.tanksTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fuel type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(156, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(348, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataTanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DataTanks";
            this.Text = "DataTanks";
            this.Load += new System.EventHandler(this.DataTanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private autotpDataSet autotpDataSet;
        private System.Windows.Forms.BindingSource tanksBindingSource;
        private autotpDataSetTableAdapters.tanksTableAdapter tanksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tankidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumenowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumemaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}