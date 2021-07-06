using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaVesionOfProject.DataForms
{
    public partial class DataDrivers : Form
    {
        const string ConnectionString = "Data Source=INSPIRON;Initial Catalog=autotp;Integrated Security=True";
        private bool edit = true;
        public DataDrivers()
        {
            InitializeComponent();
        }

        private void DataDrivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.parkings". При необходимости она может быть перемещена или удалена.
            this.parkingsTableAdapter.Fill(this.autotpDataSet.parkings);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.autotpDataSet.drivers);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var win = new AddDriver();
            win.ShowDialog();
            driversTableAdapter.Fill(autotpDataSet.drivers);
            autotpDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var st = new autotpDataSet.driversDataTable();
            driversTableAdapter.FillBy(st, 
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new AddDriver(
            Convert.ToInt32(row[0]),
            Convert.ToString(row[1]),
            Convert.ToDateTime(row[2]),
            Convert.ToString(row[3]),
            Convert.ToString(row[4])
            );
            edt.ShowDialog();
            dataGridView1.DataSource = driversBindingSource;
            driversTableAdapter.Fill(autotpDataSet.drivers);
            autotpDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                driversTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
                );
                dataGridView1.DataSource = driversBindingSource;
                driversTableAdapter.Fill(autotpDataSet.drivers);
                autotpDataSet.AcceptChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parking_id= comboBox1.Text;
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select drivers.* from drivers " +
                "inner join voyages on voyages.driver_id = drivers.driver_id " +
                "inner join cars on cars.car_number = voyages.car_number " +
                "where cars.parking_id like '%{0}%'", parking_id);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            string parking_id = comboBox1.Text;
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select drivers.* from drivers " +
                "inner join voyages on voyages.driver_id = drivers.driver_id " +
                "inner join cars on cars.car_number = voyages.car_number " +
                "where cars.parking_id like '%{0}%'", parking_id);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from drivers order by drivers.name");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void byDateOfBirthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from drivers order by drivers.dob");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void byIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from drivers order by drivers.driver_id");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string x = textBox1.Text;
            string s = String.Format("select * from drivers where drivers.name like '%{0}%'", x);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var a1 = new DateTime(Convert.ToInt32(textBox2.Text), 1, 1);
            var a2 = new DateTime(Convert.ToInt32(textBox3.Text), 1, 1);
            var age1 = Convert.ToString(textBox2.Text);
            var age2 = Convert.ToString(textBox3.Text);
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from drivers " +
                "where ('{2}'-drivers.dob >= '{0}' AND '{2}'-drivers.dob <= '{1}')", a1, a2, today);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }
    }
}
