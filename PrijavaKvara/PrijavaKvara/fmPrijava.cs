using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaKvara
{
    public partial class fmPrijava : Form
    {
        public fmPrijava()
        {
            InitializeComponent();
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if(tbKorisnickoIme.Text == "admin" && tbLozinka.Text == "admin1")
            {
                this.Hide();
                fmPocetna pocetna = new fmPocetna();
                pocetna.ShowDialog();
            }
            else
                MessageBox.Show("Unijeli ste neispravno korisničko ime ili lozinku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
