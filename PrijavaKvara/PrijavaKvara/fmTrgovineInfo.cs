using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace PrijavaKvara
{
    public partial class fmTrgovineInfo : Form
    {
        public fmTrgovineInfo()
        {
            InitializeComponent();

            btnCopyIP.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            btnSpremi.Enabled = false;

            var lines = File.ReadAllLines("p-popis.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines("p-popis.txt", lines);

            tbAdresa.ReadOnly = true;
            tbIpAdresa.ReadOnly = true;
            tbKontakt.ReadOnly = true;
            tbPrinter.ReadOnly = true;
            tbVideonadzor.ReadOnly = true;
            btnSpremi.Enabled = false;
        }

        private void fmTrgovineInfo_Load(object sender, EventArgs e)
        {
            string[] popisTrgovineInfo = File.ReadAllLines("p-popis.txt");
            foreach (var line in popisTrgovineInfo)
            {
                string[] tokens = line.Split('*');
                cbTrgovineInfo.Items.Add(tokens[0]);
            }
        }

        private void cbTrgovineInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCopyIP.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            btnSpremi.Enabled = true;

            var odabraniRedak = cbTrgovineInfo.SelectedIndex;

            string line = File.ReadLines("p-popis.txt").Skip(odabraniRedak).Take(1).First();

            string[] tokens = line.Split('*');
            tbIpAdresa.Text = tokens[1];
            tbAdresa.Text = tokens[2];
            tbKontakt.Text = tokens[3];
            tbPrinter.Text = tokens[5];
            tbVideonadzor.Text = tokens[4];
        }

        private void btnCopyIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbIpAdresa.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cbTrgovineInfo.SelectedItem.ToString() + Environment.NewLine + tbAdresa.Text + Environment.NewLine + tbKontakt.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tbAdresa.ReadOnly = false;
            tbAdresa.BackColor = Color.LightCoral;
            tbIpAdresa.ReadOnly = false;
            tbIpAdresa.BackColor = Color.LightCoral;
            tbKontakt.ReadOnly = false;
            tbKontakt.BackColor = Color.LightCoral;
            tbPrinter.ReadOnly = false;
            tbPrinter.BackColor = Color.LightCoral;
            tbVideonadzor.ReadOnly = false;
            tbVideonadzor.BackColor = Color.LightCoral;
            btnSpremi.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fmUnosTrgovine unostrgovine = new fmUnosTrgovine();
            unostrgovine.ShowDialog();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
                string index = cbTrgovineInfo.SelectedItem.ToString();
                string novaLinija = index + "*" + tbIpAdresa.Text + "*" + tbAdresa.Text + "*" + tbKontakt.Text + "*" + tbVideonadzor.Text + "*" + tbPrinter.Text;
                string[] linije = File.ReadAllLines("p-popis.txt");
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
                        testt = novaLinija;
                        finalno = finalno + testt + Environment.NewLine;
                    }
                }
                File.WriteAllText("p-popis.txt", finalno);

                tbAdresa.ReadOnly = true;
                tbAdresa.BackColor = Color.LightGreen;
                tbIpAdresa.ReadOnly = true;
                tbIpAdresa.BackColor = Color.LightGreen;
                tbKontakt.ReadOnly = true;
                tbKontakt.BackColor = Color.LightGreen;
                tbPrinter.ReadOnly = true;
                tbPrinter.BackColor = Color.LightGreen;
                tbVideonadzor.ReadOnly = true;
                tbVideonadzor.BackColor = Color.LightGreen;
                btnSpremi.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izbrisati " + cbTrgovineInfo.SelectedItem.ToString() + "?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string index = cbTrgovineInfo.SelectedItem.ToString();
                string[] linije = File.ReadAllLines("p-popis.txt");
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
                File.WriteAllText("p-popis.txt", finalno);

                Action<Control.ControlCollection> func = null;
                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };

                func(Controls);

                cbTrgovineInfo.Items.Clear();
                cbTrgovineInfo.Text = "==Odaberi prodavaonicu==";

                string[] popisTrgovineInfo = File.ReadAllLines("p-popis.txt");
                foreach (var line in popisTrgovineInfo)
                {
                    string[] tokens = line.Split('*');
                    cbTrgovineInfo.Items.Add(tokens[0]);
                }

                MessageBox.Show("Trgovina je uspješno izbrisana!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnCopyIP.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            btnSpremi.Enabled = false;

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

            tbAdresa.BackColor = Color.White;
            tbIpAdresa.BackColor = Color.White;
            tbKontakt.BackColor = Color.White;
            tbPrinter.BackColor = Color.White;
            tbVideonadzor.BackColor = Color.White;

            var lines = File.ReadAllLines("p-popis.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines("p-popis.txt", lines);
            cbTrgovineInfo.Items.Clear();
            cbTrgovineInfo.Text = "==Odaberi prodavaonicu==";
            string[] popisTrgovineInfo = File.ReadAllLines("p-popis.txt");
            foreach (var line in popisTrgovineInfo)
            {
                string[] tokens = line.Split('*');
                cbTrgovineInfo.Items.Add(tokens[0]);
            }
        }

        private void btnCopyPrinter_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cbTrgovineInfo.SelectedItem.ToString() + Environment.NewLine + tbAdresa.Text + Environment.NewLine + tbPrinter.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fmIspisi forma = new fmIspisi();
            forma.ShowDialog();
        }
    }
}
