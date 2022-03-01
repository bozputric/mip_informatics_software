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
    public partial class fmOtpisOpreme : Form
    {
        public fmOtpisOpreme()
        {
            InitializeComponent();

            string[] popisProdavaonica = File.ReadAllLines("p-popis.txt");
            foreach (var line in popisProdavaonica)
            {
                string[] tokens = line.Split('*');
                cbProdavaonice.Items.Add(tokens[0]);
            }

            cbKolicinaOpreme.SelectedIndex = 0;
        }

        private void btnIzradi_Click(object sender, EventArgs e)
        {
            fmPrintOtpis forma = new fmPrintOtpis();

            forma.Naziv = tbNazivInformatickeOpreme.Text;
            forma.Kolicina = cbKolicinaOpreme.SelectedItem.ToString();
            forma.Mjesto = tbMjestoNastankaOtpisa.Text;
            forma.InventurniBroj = tbInventurniBroj.Text;
            string uzrok0 = "";

            if (checkBox1.Checked)
            {
                uzrok0 = uzrok0 + checkBox1.Text + ", ";
            }
            if (checkBox2.Checked)
            {
                uzrok0 = uzrok0 + checkBox2.Text + ", ";
            }
            if (checkBox3.Checked)
            {
                uzrok0 = uzrok0 + checkBox3.Text + ", ";
            }
            if (checkBox4.Checked)
            {
                uzrok0 = uzrok0 + checkBox4.Text + ", ";
            }
            if (checkBox5.Checked)
            {
                uzrok0 = uzrok0 + checkBox5.Text + ", ";
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
            {
                uzrok0 = tbOstalo.Text;
            }

            

            forma.Uzrok = uzrok0;
            forma.Prilog = tbPrilogZapisniku.Text;

            forma.ShowDialog();
        }

        private void cbProdavaonice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = cbProdavaonice.SelectedItem.ToString();
            string[] linije = File.ReadAllLines("p-popis.txt");

            foreach (var line in linije)
            {
                string[] tokens = line.Split('*');
                if (tokens[0].Contains(index))
                {
                    tbMjestoNastankaOtpisa.Clear();
                    tbMjestoNastankaOtpisa.Text = tokens[0] + " - " + tokens[2];
                }
                else
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString();
            string otpis = date + "*" + tbMjestoNastankaOtpisa.Text + "*" + tbNazivInformatickeOpreme.Text + "*" + cbKolicinaOpreme.SelectedItem.ToString();
            string staritekst = File.ReadAllText("evidencija-otpisa.txt");
            string novitekst = otpis + Environment.NewLine + staritekst;
            File.WriteAllText("evidencija-otpisa.txt", novitekst);

            MessageBox.Show("Otpis je dodan u evidenciju!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
