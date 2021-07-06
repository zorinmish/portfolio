using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlphaVesionOfProject.DataForms
{
    public partial class DataParkings : Form
    {
        public DataParkings()
        {
            InitializeComponent();
        }

        private void DataParkings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.parkings". При необходимости она может быть перемещена или удалена.
            this.parkingsTableAdapter.Fill(this.autotpDataSet.parkings);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var win = new EditForms.AddParking();
            win.ShowDialog();
            parkingsTableAdapter.Fill(autotpDataSet.parkings);
            autotpDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var st = new autotpDataSet.parkingsDataTable();
            parkingsTableAdapter.FillBy(st,
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new EditForms.AddParking(
            Convert.ToInt32(row[0]),
            Convert.ToString(row[1]),
            Convert.ToDecimal(row[2]),
            Convert.ToString(row[3])
            );
            edt.ShowDialog();
            dataGridView1.DataSource = parkingsBindingSource;
            parkingsTableAdapter.Fill(autotpDataSet.parkings);
            autotpDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                parkingsTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
                );
                dataGridView1.DataSource = parkingsBindingSource;
                parkingsTableAdapter.Fill(autotpDataSet.parkings);
                autotpDataSet.AcceptChanges();
            }
        }

        private void countByClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                var win = new Stats.Stats_class();
                win.ShowDialog();
            } else
            {
                int t = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var win = new Stats.Stats_class(t);
                win.ShowDialog();
            }
            
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var win = new Stats.ListCarsParking(t);
            win.ShowDialog();
        }

        private void suppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var win = new Stats.Stats_supplies(t);
            win.ShowDialog();
        }

        private void fuelInTanksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var win = new Stats.Stats_fuel(t);
            win.ShowDialog();
        }

        private void mileageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var win = new Stats.Stats_mileage(t);
            win.ShowDialog();
        }
    }
}
