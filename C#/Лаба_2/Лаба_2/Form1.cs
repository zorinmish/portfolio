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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аТП_accessDataSet2.Parkings". При необходимости она может быть перемещена или удалена.
            this.parkingsTableAdapter.Fill(this.ATP.Parkings);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аТП_accessDataSet2.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.ATP.Cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аТП_accessDataSet2.Drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.ATP.Drivers);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            carsTableAdapter.Update(ATP);
            driversTableAdapter.Update(ATP);
            parkingsTableAdapter.Update(ATP);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorCountItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorCountItem2_Click(object sender, EventArgs e)
        {

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = driversBindingSource;
            dataGridView1.DataSource = driversBindingSource;
            label1.Text = "Drivers";
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = carsBindingSource;
            dataGridView1.DataSource = carsBindingSource;
            label1.Text = "Cars";
        }

        private void parkingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = parkingsBindingSource;
            dataGridView1.DataSource = parkingsBindingSource;
            label1.Text = "Parkings";
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carsTableAdapter.Update(ATP);
            driversTableAdapter.Update( ATP);
            parkingsTableAdapter.Update(ATP);
            var rs = new CDForm();
            rs.ShowDialog();
            driversTableAdapter.Fill(ATP.Drivers);
            carsTableAdapter.Fill(ATP.Cars);
            parkingsTableAdapter.Fill(ATP.Parkings);
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
