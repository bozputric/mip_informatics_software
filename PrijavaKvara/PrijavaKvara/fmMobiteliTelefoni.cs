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
    public partial class fmMobiteliTelefoni : Form
    {
        public fmMobiteliTelefoni()
        {
            InitializeComponent();

            string[] mobitelistring = File.ReadAllLines("mobiteli.txt");
            foreach (var line in mobitelistring)
            {
                string[] tokens = line.Split('*');
                cbMobiteliTelefoni.Items.Add(tokens[0]);
            }

            string[] telefonistring = File.ReadAllLines("interni-telefoni.txt");
            foreach (var line in telefonistring)
            {
                string[] tokens = line.Split('*');
                cbPopisInternihKorisnika.Items.Add(tokens[0]);
            }
        }
        private void cbMobiteliTelefoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            var odabraniRedak = cbMobiteliTelefoni.SelectedIndex;

            string line = File.ReadLines("mobiteli.txt").Skip(odabraniRedak).Take(1).First();

            string[] tokens = line.Split('*');
            tbDugiBroj.Text = tokens[1];
            tbKratkiBroj.Text = tokens[2];
        }

        private void cbPopisInternihKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            var odabraniRedak = cbPopisInternihKorisnika.SelectedIndex;

            string line = File.ReadLines("interni-telefoni.txt").Skip(odabraniRedak).Take(1).First();

            string[] tokens = line.Split('*');
            tbInterniBroj.Text = tokens[1];
            tbKratkiInterniBroj.Text = tokens[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
