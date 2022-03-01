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
using System.Net;
using System.Net.Mail;

namespace PrijavaKvara
{
    public partial class fmEmailovi : Form
    {
        public fmEmailovi()
        {
            InitializeComponent();

            btnCopyEmail.Enabled = false;
            btnCopyLozinka.Enabled = false;
            btnSpremi.Enabled = false;
            btnIzbrisi.Enabled = false;
            button2.Enabled = false;

            var lines = File.ReadAllLines("emailovi.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines("emailovi.txt", lines);

            btnSpremi.Enabled = false;
            tbEmail.ReadOnly = true;
            tbLozinka.ReadOnly = true;

            //@"\\192.168.67.223\Informatika\app\emailovi.txt"
            string[] emailovistring = File.ReadAllLines("emailovi.txt");
            Array.Sort(emailovistring);
            File.WriteAllLines("emailovi.txt", emailovistring);
            string[] emailovistring2 = File.ReadAllLines("emailovi.txt");
            foreach (var line in emailovistring2)
            {
                string[] tokens = line.Split('ž');
                cbEmailovi.Items.Add(tokens[0]);
            }
        }

        private void cbEmailovi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tbLozinka.PasswordChar = '*';
            btnCopyEmail.Enabled = true;
            btnCopyLozinka.Enabled = true;
            btnSpremi.Enabled = true;
            btnIzbrisi.Enabled = true;
            button2.Enabled = true;

            var odabraniRedak = cbEmailovi.SelectedIndex;

            string line = File.ReadLines("emailovi.txt").Skip(odabraniRedak).Take(1).First();

            string[] tokens = line.Split('ž');
            tbEmail.Text = tokens[1];
            tbLozinka.Text = tokens[2];
        }

        private void btnCopyEmail_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbEmail.Text);
        }

        private void btnCopyLozinka_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbLozinka.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UnosEmailova forma = new UnosEmailova();
            forma.ShowDialog();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            btnCopyEmail.Enabled = false;
            btnCopyLozinka.Enabled = false;
            btnSpremi.Enabled = false;
            btnIzbrisi.Enabled = false;
            button2.Enabled = false;

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

            cbEmailovi.Items.Clear();
            cbEmailovi.Text = "==Odaberi korisnika==";

            var lines = File.ReadAllLines("emailovi.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines("emailovi.txt", lines);

            string[] emailovistring = File.ReadAllLines("emailovi.txt");
            Array.Sort(emailovistring);
            File.WriteAllLines("emailovi.txt", emailovistring);

            string[] emailovistring2 = File.ReadAllLines("emailovi.txt");
            foreach (var line in emailovistring2)
            {
                string[] tokens = line.Split('ž');
                cbEmailovi.Items.Add(tokens[0]);
            }

            tbEmail.ReadOnly = false;
            tbEmail.BackColor = Color.White;
            tbLozinka.ReadOnly = false;
            tbLozinka.BackColor = Color.White;
            btnSpremi.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbEmail.ReadOnly = false;
            tbEmail.BackColor = Color.LightCoral;
            tbLozinka.ReadOnly = false;
            tbLozinka.BackColor = Color.LightCoral;
            btnSpremi.Enabled = true;
            tbLozinka.PasswordChar = '\0';
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite ažurirati podatke?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string index = cbEmailovi.SelectedItem.ToString();
                string novaLinija = index + "ž" + tbEmail.Text + "ž" + tbLozinka.Text;
                string[] linije = File.ReadAllLines("emailovi.txt");
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
                File.WriteAllText("emailovi.txt", finalno);

                tbEmail.ReadOnly = true;
                tbEmail.BackColor = Color.LightGreen;
                tbLozinka.ReadOnly = true;
                tbLozinka.BackColor = Color.LightGreen;
                btnSpremi.Enabled = false;
                tbLozinka.PasswordChar = '*';
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izbrisati " + cbEmailovi.SelectedItem.ToString() + "?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnCopyEmail.Enabled = false;
                btnCopyLozinka.Enabled = false;
                btnSpremi.Enabled = false;
                btnIzbrisi.Enabled = false;
                button2.Enabled = false;

                string index = cbEmailovi.SelectedItem.ToString();
                string[] linije = File.ReadAllLines("emailovi.txt");
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
                File.WriteAllText("emailovi.txt", finalno);

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

                cbEmailovi.Items.Clear();
                cbEmailovi.Text = "==Odaberi prodavaonicu==";

                string[] popismailova = File.ReadAllLines("emailovi.txt");
                foreach (var line in popismailova)
                {
                    string[] tokens = line.Split('ž');
                    cbEmailovi.Items.Add(tokens[0]);
                }
                MessageBox.Show("Mail je uspješno izbrisan!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
