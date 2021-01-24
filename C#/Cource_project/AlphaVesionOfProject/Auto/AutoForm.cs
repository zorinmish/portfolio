using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaVesionOfProject.Auto
{
    public partial class AutoForm : Form
    {
        const string ConnectionString = "Data Source=INSPIRON;Initial Catalog=autotp;Integrated Security=True";
        private const string password = "behappy@14";
        public AutoForm()
        {
            InitializeComponent();
        }

        private void AutoForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.voyages". При необходимости она может быть перемещена или удалена.
            this.voyagesTableAdapter.Fill(this.autotpDataSet.voyages);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autotpDataSet.parkings". При необходимости она может быть перемещена или удалена.
            this.parkingsTableAdapter.Fill(this.autotpDataSet.parkings);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                var st = new autotpDataSet.voyagesDataTable();
                voyagesTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                double am = Convert.ToDouble(row[6]) - Convert.ToDouble(row[7]);
                string nu = Convert.ToString(row[3]);
                MailAddress fromAddress = new MailAddress("zorinmish@gmail.com", "Administration");
                MailAddress toAddress = new MailAddress(textBox1.Text, "You");
                MailMessage message = new MailMessage(fromAddress, toAddress);
                string s = String.Format("Автомобиль с номером '{0}' потратил {1} литров топлива", nu,am);
                message.Body = s;
                message.Subject = "Уведомление о потраченном топливе";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromAddress.Address, password);

                smtpClient.Send(message);

                MessageBox.Show("Successfully delivered!");
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
            
        }
    }
}
