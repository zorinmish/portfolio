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
using Word = Microsoft.Office.Interop.Word;

namespace AlphaVesionOfProject.DataForms
{
    public partial class DataCars : Form
    {
        private string tempfilename = @"C:\Univ\test\car_test.docx";
        const string ConnectionString = "Data Source=INSPIRON;Initial Catalog=autotp;Integrated Security=True";
        public DataCars()
        {
            InitializeComponent();
        }

        private void DataCars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.autotpDataSet.cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.tech_pass". При необходимости она может быть перемещена или удалена.
            this.tech_passTableAdapter.Fill(this.autotpDataSet.tech_pass);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new AddCar();
            edt.ShowDialog();
            dataGridView1.DataSource = techpassBindingSource;
            tech_passTableAdapter.Fill(autotpDataSet.tech_pass);
            autotpDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var st = new autotpDataSet.tech_passDataTable();
            tech_passTableAdapter.FillBy(st,
                Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
            var st1 = new autotpDataSet.carsDataTable();
            carsTableAdapter.FillBy(st1,
                Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            object[] row1 = st1.Rows[0].ItemArray;
            var edt = new AddCar(
            Convert.ToString(row[0]),
            Convert.ToString(row[1]),
            Convert.ToString(row[2]),
            Convert.ToDouble(row[3]),
            Convert.ToDouble(row[4]),
            Convert.ToString(row[5]),
            Convert.ToString(row[6]),
            Convert.ToInt32(row1[1])
            );
            edt.ShowDialog();
            dataGridView1.DataSource = techpassBindingSource;
            tech_passTableAdapter.Fill(autotpDataSet.tech_pass);
            autotpDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string num = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                carsTableAdapter.DeleteQuery(num);
                dataGridView1.DataSource = techpassBindingSource;
                tech_passTableAdapter.Fill(autotpDataSet.tech_pass);
                autotpDataSet.AcceptChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string car_class = textBox1.Text;
            string fuel_type = textBox3.Text;
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from tech_pass " +
                "where ((tech_pass.car_class like '%{0}%') AND (tech_pass.fuel_type like '%{1}%'))", car_class, fuel_type);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void byNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from tech_pass order by tech_pass.car_number");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void byDateOfBirthToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string x = textBox2.Text;
            string s = String.Format("select * from tech_pass where tech_pass.car_number like '%{0}%'", x);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var st = new autotpDataSet.tech_passDataTable();
            tech_passTableAdapter.FillBy(st,
                Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var wordApp = new Word.Application();
            //wordApp.Visible = false;
            try
            {
                var wordDocument = wordApp.Documents.Open(tempfilename);
                ReplaceWordStub("{number}", Convert.ToString(row[0]), wordDocument);
                ReplaceWordStub("{model}", Convert.ToString(row[1]), wordDocument);
                ReplaceWordStub("{color}", Convert.ToString(row[2]), wordDocument);
                ReplaceWordStub("{car_class}", Convert.ToString(row[6]), wordDocument);
                ReplaceWordStub("{fuel_type}", Convert.ToString(row[5]), wordDocument);
                ReplaceWordStub("{date}",DateTime.Now.ToString("d/M/yyyy"), wordDocument);

                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Word Documents (*.docx)|*.docx";

                sfd.FileName = "car_passport.docx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    wordDocument.SaveAs2(sfd.FileName);
                    MessageBox.Show("Done! File in the folder!");
                }
                //wordDocument.SaveAs(@"C:\Univ\test\result.docx");
                wordDocument.Close();
                
            }
            catch
            {
                MessageBox.Show("Done! File in the folder!");
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
