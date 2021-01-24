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
    public partial class Stats_class : Form
    {
        const string ConnectionString = "Data Source=INSPIRON;Initial Catalog=autotp;Integrated Security=True";
        public Stats_class()
        {
            InitializeComponent();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select tech_pass.car_class as Classes, count(*) as Number from tech_pass group by tech_pass.car_class");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }
        public Stats_class(int parking_id)
        {
            InitializeComponent();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select tech_pass.car_class as Classes, count(*) as Number from tech_pass " +
                "inner join cars on cars.car_number = tech_pass.car_number " +
                "where cars.parking_id = '{0}' " +
                "group by tech_pass.car_class", parking_id);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void Stats_class_Load(object sender, EventArgs e)
        {

        }
    }
}
