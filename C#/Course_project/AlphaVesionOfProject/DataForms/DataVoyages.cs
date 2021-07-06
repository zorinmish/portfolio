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
    public partial class DataVoyages : Form
    {
        public DataVoyages()
        {
            InitializeComponent();
        }

        private void DataVoyages_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.voyages". При необходимости она может быть перемещена или удалена.
            this.voyagesTableAdapter.Fill(this.autotpDataSet.voyages);

        }
    }
}
