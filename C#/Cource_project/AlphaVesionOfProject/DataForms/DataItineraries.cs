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
    public partial class DataItineraries : Form
    {
        public DataItineraries()
        {
            InitializeComponent();
        }

        private void DataItineraries_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.itineraries". При необходимости она может быть перемещена или удалена.
            this.itinerariesTableAdapter.Fill(this.autotpDataSet.itineraries);

        }
    }
}
