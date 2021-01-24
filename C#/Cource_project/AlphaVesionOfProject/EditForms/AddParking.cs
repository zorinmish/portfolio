using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaVesionOfProject.EditForms
{
    public partial class AddParking : Form
    {
        private bool edit;
        private int id_p;
        public AddParking()
        {
            edit = false;
            InitializeComponent();
        }

        public AddParking(int id, string p_name, decimal p_size, string phone)
        {
            edit = true;
            InitializeComponent();
            id_p = id;
            textBox1.Text = p_name;
            textBox2.Text = Convert.ToString(p_size);
            textBox3.Text = phone;
        }

        private void AddParking_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.parkings". При необходимости она может быть перемещена или удалена.
            this.parkingsTableAdapter.Fill(this.autotpDataSet.parkings);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(textBox2.Text) < 0) throw new Exception();
                if (edit)
                {
                    parkingsTableAdapter.UpdateQuery(textBox1.Text, Convert.ToDecimal(textBox2.Text),
                        textBox3.Text, id_p
                        );
                }
                else
                {
                    parkingsTableAdapter.Insert(textBox1.Text, Convert.ToDecimal(textBox2.Text),
                        textBox3.Text);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
