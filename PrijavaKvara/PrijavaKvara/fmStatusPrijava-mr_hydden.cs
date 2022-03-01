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
    public partial class fmStatusPrijava : Form
    {
        public fmStatusPrijava()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void fmStatusPrijava_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Datum prijave", typeof(string));
            table.Columns.Add("Prodavaonica", typeof(string));
            table.Columns.Add("Adresa", typeof(string));
            table.Columns.Add("Kontakt", typeof(string));
            table.Columns.Add("Kvar", typeof(string));

            dataGridView1.DataSource = table;

            string[] lines = File.ReadAllLines("status-prijava.txt");
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
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string index = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            string[] linije = File.ReadAllLines("status-prijava.txt");

            int brojLinija = linije.Count() + 1;


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

            File.WriteAllText("status-prijava.txt", finalno);

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
