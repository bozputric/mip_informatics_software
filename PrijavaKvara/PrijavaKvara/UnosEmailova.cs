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
    public partial class UnosEmailova : Form
    {
        public UnosEmailova()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite unijeti novi mail?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string stariTekst = File.ReadAllText("emailovi.txt");
                string linija = tbPrezimeIme.Text + "ž" + tbEmail.Text + "ž" + tbLozinka.Text;
                string noviTekst = stariTekst + Environment.NewLine + linija;
                File.WriteAllText("emailovi.txt", noviTekst);

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

                MessageBox.Show("Mail je uspješno unesen!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
