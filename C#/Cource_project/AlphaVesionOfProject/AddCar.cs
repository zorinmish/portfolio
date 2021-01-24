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
    
    public partial class AddCar : Form
    {
        readonly bool edit;

        private string number, ft, cc, p; 
        public AddCar()
        {
            InitializeComponent();
            edit = false;
        }
        public AddCar(string num, string mod, string col, double size, double max_fuel,
            string fuel_type, string car_class, int parking)
        {
            edit = true;
            InitializeComponent();
            number = num;
            numberBox.Text = num;
            modelBox.Text = mod;
            colorBox.Text = col;
            sizeBox.Text = Convert.ToString(size);
            maxBox.Text = Convert.ToString(max_fuel);
            ft = Convert.ToString(fuel_type);
            cc = Convert.ToString(car_class);
            p = Convert.ToString(parking);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit)
                {
                    if (Convert.ToInt32(sizeBox.Text) < 0) throw new Exception();
                    if (Convert.ToInt32(maxBox.Text) < 0) throw new Exception();
                    carsTableAdapter.UpdateQuery(numberBox.Text,
                        Convert.ToInt32(comboBox1.Text),
                        number
                        );
                    tech_passTableAdapter.UpdateQuery(numberBox.Text, modelBox.Text,
                        colorBox.Text, Convert.ToInt32(sizeBox.Text),
                        Convert.ToDecimal(maxBox.Text), fuelBox.Text,
                        classBox.Text, number
                        );
                }
                else
                {
                    if (Convert.ToInt32(sizeBox.Text) < 0) throw new Exception();
                    if (Convert.ToInt32(maxBox.Text) < 0) throw new Exception();
                    carsTableAdapter.Insert(numberBox.Text,
                        Convert.ToInt32(comboBox1.Text));
                    tech_passTableAdapter.Insert(numberBox.Text, modelBox.Text,
                        colorBox.Text, Convert.ToInt32(sizeBox.Text),
                        Convert.ToDecimal(maxBox.Text), fuelBox.Text,
                        classBox.Text
                        );
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Incorrect data");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.tech_pass". При необходимости она может быть перемещена или удалена.
            this.tech_passTableAdapter.Fill(this.autotpDataSet.tech_pass);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.autotpDataSet.cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.parkings". При необходимости она может быть перемещена или удалена.
            this.parkingsTableAdapter.Fill(this.autotpDataSet.parkings);
            if (edit) fuelBox.Text = ft;
            if (edit) classBox.Text = cc;
            if (edit) comboBox1.Text = p;
        }

    }
}
