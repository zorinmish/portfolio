using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Лаба_2
{
    public partial class CDForm : Form
    {
        public CDForm()
        {
            InitializeComponent();
        }

        private void parkingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.parkingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аТП_accessDataSet2);

        }

        private void CDForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аТП_accessDataSet2.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.аТП_accessDataSet2.Cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аТП_accessDataSet2.Parkings". При необходимости она может быть перемещена или удалена.
            this.parkingsTableAdapter.Fill(this.аТП_accessDataSet2.Parkings);

        }

        private void carsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int t = Convert.ToInt32(carsDataGridView.Rows[e.RowIndex].Cells[2].Value);
            
            //label1.Text = Convert.ToString(t);
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure?", "Change data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                parkingsBindingSource.EndEdit();
                parkingsTableAdapter.Update(аТП_accessDataSet2);
                carsTableAdapter.Update(аТП_accessDataSet2);
                this.Dispose();
            }
        }

       
    }
}
