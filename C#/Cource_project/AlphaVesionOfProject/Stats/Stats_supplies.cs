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
    public partial class Stats_supplies : Form
    {
        const string ConnectionString = "Data Source=INSPIRON;Initial Catalog=autotp;Integrated Security=True";
        public Stats_supplies()
        {
            InitializeComponent();
        }
        public Stats_supplies(int parking_id)
        {
            InitializeComponent();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select supplies.fuel_type as Fuel_types, sum(supplies.volume) as Volume from supplies " +
                "inner join tanks on tanks.tank_id = supplies.tank_id " +
                "inner join parkings on parkings.parking_id = tanks.parking_id " +
                "where parkings.parking_id = '{0}' " +
                "group by supplies.fuel_type", parking_id);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void Stats_supplies_Load(object sender, EventArgs e)
        {

        }
    }
}
