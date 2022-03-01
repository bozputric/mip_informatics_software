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
    public partial class fmUnosTrgovine : Form
    {
        public fmUnosTrgovine()
        {
            InitializeComponent();
            btnUnesiProdavaonicu.Enabled = true;
        }

        private void btnUnesiProdavaonicu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite unesti novu prodavaonicu?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string stariTekst = File.ReadAllText("p-popis.txt");
                string linija = tbNazivProdavaonice.Text + "*" + tbIpAdresa.Text + "*" + tbAdresa.Text + "*" + tbKontakt.Text + "*" + tbVideonadzor.Text + "*" + tbPrinter.Text;
                string noviTekst = stariTekst + Environment.NewLine + linija;
                File.WriteAllText("p-popis.txt", noviTekst);

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

                MessageBox.Show("Trgovina je uspješno unesena!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
