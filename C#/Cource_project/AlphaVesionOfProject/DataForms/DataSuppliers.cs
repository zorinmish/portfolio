﻿using System;
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
    public partial class DataSuppliers : Form
    {
        public DataSuppliers()
        {
            InitializeComponent();
        }

        private void DataSuppliers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.autotpDataSet.suppliers);

        }
    }
}
