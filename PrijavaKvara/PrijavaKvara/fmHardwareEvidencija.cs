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
    public partial class fmHardwareEvidencija : Form
    {
        public fmHardwareEvidencija()
        {
            InitializeComponent();

            string[] popisProdavaonica = File.ReadAllLines("p-popis.txt");
            foreach (var line in popisProdavaonica)
            {
                string[] tokens = line.Split('*');
                cbProdavaonice.Items.Add(tokens[0]);
            }
        }
        DataTable table = new DataTable();
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmHardwareEvidencija_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Datum zamjene", typeof(string));
            table.Columns.Add("Prodavaonica", typeof(string));
            table.Columns.Add("Adresa", typeof(string));
            table.Columns.Add("Kvar", typeof(string));

            datagridKvarovi.DataSource = table;

            string[] lines = File.ReadAllLines("evidencija-kvarova.txt");
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

            datagridKvarovi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            btnDodaj.Enabled = false;
            button7.Enabled = false;
        }

        private void cbProdavaonice_SelectedIndexChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
            btnDodaj.Enabled = true;
            string index = cbProdavaonice.SelectedItem.ToString();
            string[] lines = File.ReadAllLines("evidencija-kvarova.txt");
            string[] values;

            table.Rows.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('*');

                if (values[1] == index)
                {
                    values = lines[i].ToString().Split('*');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    table.Rows.Add(row);
                }
                else
                {

                }
            }
            datagridKvarovi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
                string index = cbProdavaonice.SelectedItem.ToString();
                string stariTekst = File.ReadAllText("evidencija-kvarova.txt");
                string[] linije = File.ReadAllLines("p-popis.txt");
                string text = "";
                string NoviTekst = "";
                var dateAndTime = DateTime.Now;

                foreach (var line in linije)
                {
                    string[] values2 = line.Split('*');

                    if (values2[0] == index)
                    {
                        text = dateAndTime.ToString() + "*" + values2[0] + "*" + values2[2] + "*" + lbStvari.GetItemText(lbStvari.SelectedItem);
                    }
                    else
                    {

                    }
                    NoviTekst = stariTekst + Environment.NewLine + text;
                }
                File.WriteAllText("evidencija-kvarova.txt", NoviTekst);
                var lines = File.ReadAllLines("evidencija-kvarova.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
                File.WriteAllLines("evidencija-kvarova.txt", lines);

            string index2 = cbProdavaonice.SelectedItem.ToString();
            string[] lines2 = File.ReadAllLines("evidencija-kvarova.txt");
            string[] values;

            table.Rows.Clear();

            for (int i = 0; i < lines2.Length; i++)
            {
                values = lines2[i].ToString().Split('*');

                if (values[1] == index)
                {
                    values = lines2[i].ToString().Split('*');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    table.Rows.Add(row);
                }
                else
                {

                }
            }
            datagridKvarovi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            string index = datagridKvarovi.SelectedRows[0].Cells[0].Value.ToString();
            string[] linije = File.ReadAllLines("evidencija-kvarova.txt");

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

            File.WriteAllText("evidencija-kvarova.txt", finalno);

            if (this.datagridKvarovi.SelectedRows.Count > 0)
            {
                datagridKvarovi.Rows.RemoveAt(this.datagridKvarovi.SelectedRows[0].Index);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ((DataTable)datagridKvarovi.DataSource).Rows.Clear();
            datagridKvarovi.DataSource = table;

            string[] lines = File.ReadAllLines("evidencija-kvarova.txt");
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

            datagridKvarovi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnDodaj.Enabled = true;
            string index = cbProdavaonice.SelectedItem.ToString();
            string[] lines = File.ReadAllLines("evidencija-kvarova.txt");
            string[] values;

            table.Rows.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('*');

                if (values[1] == index)
                {
                    values = lines[i].ToString().Split('*');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    table.Rows.Add(row);
                }
                else
                {

                }
            }
            datagridKvarovi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridKvarovi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
