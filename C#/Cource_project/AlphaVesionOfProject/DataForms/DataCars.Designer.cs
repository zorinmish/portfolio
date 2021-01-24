namespace AlphaVesionOfProject.DataForms
{
    partial class DataCars
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
            this.carnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fueltankvolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fueltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techpassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autotpDataSet = new AlphaVesionOfProject.autotpDataSet();
            this.tech_passTableAdapter = new AlphaVesionOfProject.autotpDataSetTableAdapters.tech_passTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new AlphaVesionOfProject.autotpDataSetTableAdapters.carsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techpassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnumberDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.carsizeDataGridViewTextBoxColumn,
            this.fueltankvolumeDataGridViewTextBoxColumn,
            this.fueltypeDataGridViewTextBoxColumn,
            this.carclassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.techpassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // carnumberDataGridViewTextBoxColumn
            // 
            this.carnumberDataGridViewTextBoxColumn.DataPropertyName = "car_number";
            this.carnumberDataGridViewTextBoxColumn.HeaderText = "car_number";
            this.carnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carnumberDataGridViewTextBoxColumn.Name = "carnumberDataGridViewTextBoxColumn";
            this.carnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carsizeDataGridViewTextBoxColumn
            // 
            this.carsizeDataGridViewTextBoxColumn.DataPropertyName = "car_size";
            this.carsizeDataGridViewTextBoxColumn.HeaderText = "car_size";
            this.carsizeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carsizeDataGridViewTextBoxColumn.Name = "carsizeDataGridViewTextBoxColumn";
            this.carsizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fueltankvolumeDataGridViewTextBoxColumn
            // 
            this.fueltankvolumeDataGridViewTextBoxColumn.DataPropertyName = "fuel_tank_volume";
            this.fueltankvolumeDataGridViewTextBoxColumn.HeaderText = "fuel_tank_volume";
            this.fueltankvolumeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fueltankvolumeDataGridViewTextBoxColumn.Name = "fueltankvolumeDataGridViewTextBoxColumn";
            this.fueltankvolumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fueltypeDataGridViewTextBoxColumn
            // 
            this.fueltypeDataGridViewTextBoxColumn.DataPropertyName = "fuel_type";
            this.fueltypeDataGridViewTextBoxColumn.HeaderText = "fuel_type";
            this.fueltypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fueltypeDataGridViewTextBoxColumn.Name = "fueltypeDataGridViewTextBoxColumn";
            this.fueltypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carclassDataGridViewTextBoxColumn
            // 
            this.carclassDataGridViewTextBoxColumn.DataPropertyName = "car_class";
            this.carclassDataGridViewTextBoxColumn.HeaderText = "car_class";
            this.carclassDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carclassDataGridViewTextBoxColumn.Name = "carclassDataGridViewTextBoxColumn";
            this.carclassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // techpassBindingSource
            // 
            this.techpassBindingSource.DataMember = "tech_pass";
            this.techpassBindingSource.DataSource = this.autotpDataSet;
            // 
            // autotpDataSet
            // 
            this.autotpDataSet.DataSetName = "autotpDataSet";
            this.autotpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tech_passTableAdapter
            // 
            this.tech_passTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cars";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.sortByToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNumberToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.sortByToolStripMenuItem.Text = "Sort";
            // 
            // byNumberToolStripMenuItem
            // 
            this.byNumberToolStripMenuItem.Name = "byNumberToolStripMenuItem";
            this.byNumberToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.byNumberToolStripMenuItem.Text = "By number";
            this.byNumberToolStripMenuItem.Click += new System.EventHandler(this.byNumberToolStripMenuItem_Click);
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.autotpDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(175, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 32);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(672, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Car class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(341, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Find car";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(464, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 35);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(363, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tech passport in Word";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(490, 396);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 32);
            this.textBox3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(372, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fuel type";
            // 
            // DataCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 510);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataCars";
            this.Text = "DataCars";
            this.Load += new System.EventHandler(this.DataCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techpassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotpDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private autotpDataSet autotpDataSet;
        private System.Windows.Forms.BindingSource techpassBindingSource;
        private autotpDataSetTableAdapters.tech_passTableAdapter tech_passTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltankvolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private autotpDataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNumberToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}