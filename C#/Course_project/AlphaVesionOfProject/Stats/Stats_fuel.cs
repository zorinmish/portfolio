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
    public partial class Stats_fuel : Form
    {
        const string ConnectionString = "Data Source=INSPIRON;Initial Catalog=autotp;Integrated Security=True";
        public Stats_fuel()
        {
            InitializeComponent();
        }
        public Stats_fuel(int parking_id)
        {
            InitializeComponent();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select tanks.fuel_type as Fuel_types, sum(tanks.volume_now) as Volume_now from tanks " +
                "inner join parkings on parkings.parking_id = tanks.parking_id " +
                "where parkings.parking_id = '{0}' " +
                "group by tanks.fuel_type", parking_id);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void Stats_fuel_Load(object sender, EventArgs e)
        {

        }
    }
}
