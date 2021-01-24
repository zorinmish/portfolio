using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaVesionOfProject
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = new DataForms.DataCars();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var s = new DataForms.DataDrivers();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var s = new DataForms.DataParkings();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var s = new DataForms.DataTanks();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var s = new DataForms.DataSupplies();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var s = new DataForms.DataSuppliers();
            s.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var s = new DataForms.DataInspections();
            s.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var s = new DataForms.DataVoyages();
            s.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var s = new DataForms.DataItineraries();
            s.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var s = new Auto.AutoForm();
            s.Show();
        }
    }
}
