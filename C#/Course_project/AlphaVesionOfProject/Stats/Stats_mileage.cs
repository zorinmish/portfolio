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

namespace AlphaVesionOfProject.Stats
{
    public partial class Stats_mileage : Form
    {
        const string ConnectionString = "Data Source=INSPIRON;Initial Catalog=autotp;Integrated Security=True";
        public Stats_mileage()
        {
            InitializeComponent();
        }
        public Stats_mileage(int parking_id)
        {
            InitializeComponent();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select tech_inspections.car_number, max(tech_inspections.mileage) from cars " +
                "inner join parkings on parkings.parking_id = cars.parking_id " +
                "inner join tech_pass on tech_pass.car_number = cars.car_number " +
                "inner join tech_inspections on tech_inspections.car_number = tech_pass.car_number " +
                "where parkings.parking_id = '{0}' " +
                "group by tech_inspections.car_number", parking_id);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void Stats_mileage_Load(object sender, EventArgs e)
        {

        }
    }
}
