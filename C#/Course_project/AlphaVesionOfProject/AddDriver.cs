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
    public partial class AddDriver : Form
    {
        readonly bool edit;
        private int c;
        private DateTime t;
        // 1 - edit, 0 - add;
        public AddDriver()
        {
            edit = false;
            InitializeComponent();
        }

        public AddDriver(int code,  string name, DateTime DOB, string phone, string address)
        {
            edit = true;
            t = DOB;
            c = code;
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = phone;
            textBox3.Text = address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit)
                {
                    driversTableAdapter.UpdateQuery(Convert.ToString(textBox1.Text),
                        dateTimePicker1.Text, Convert.ToString(textBox2.Text),
                        Convert.ToString(textBox3.Text), c
                        );
                }
                else
                {
                    driversTableAdapter.Insert(Convert.ToString(textBox1.Text),
                        Convert.ToDateTime(dateTimePicker1.Text), Convert.ToString(textBox2.Text),
                        Convert.ToString(textBox3.Text));
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

        private void AddDriver_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.autotpDataSet.drivers);
            if (edit) dateTimePicker1.Value = t;
        }
    }
}
