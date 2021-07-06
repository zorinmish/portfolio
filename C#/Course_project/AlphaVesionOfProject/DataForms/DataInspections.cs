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
    public partial class DataInspections : Form
    {
        public DataInspections()
        {
            InitializeComponent();
        }

        private void DataInspections_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.tech_inspections". При необходимости она может быть перемещена или удалена.
            this.tech_inspectionsTableAdapter.Fill(this.autotpDataSet.tech_inspections);

        }
    }
}
