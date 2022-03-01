using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaKvara
{
    public partial class fmEvidencijaOtpisa : Form
    {
        public fmEvidencijaOtpisa()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private void fmEvidencijaOtpisa_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Datum otpisa", typeof(string));
            table.Columns.Add("Mjesto nastanka otpisa", typeof(string));
            table.Columns.Add("Otp. oprema", typeof(string));
            table.Columns.Add("Kolicina", typeof(string));

            dataGridView1.DataSource = table;

            string[] lines = File.ReadAllLines("evidencija-otpisa.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('*');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            string index = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            string[] linije = File.ReadAllLines("evidencija-otpisa.txt");

            string testt = "";
            string finalno = "";

            for (int i = 0; i < linije.Length; i++)
            {
                if (linije[i].Contains(index) == false)
                {
                    testt = linije[i];
                    finalno = finalno + testt + Environment.NewLine;
                }
                else
                {

                }
            }
            File.WriteAllText("evidencija-otpisa.txt", finalno);

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
