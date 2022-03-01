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
    public partial class fmPocetna : Form
    {
        public fmPocetna()
        {
            InitializeComponent();
        }

        private void btnPrijavaKvara_Click(object sender, EventArgs e)
        {
            fmPrijavaKvara prijavaKvara = new fmPrijavaKvara();
            prijavaKvara.ShowDialog();
        }

        private void btnTrgovineInfo_Click(object sender, EventArgs e)
        {
            fmTrgovineInfo trgovineInfo = new fmTrgovineInfo();
            trgovineInfo.ShowDialog(); 
        }

        private void btnEmailovi_Click(object sender, EventArgs e)
        {
            fmEmailovi emailovi = new fmEmailovi();
            emailovi.ShowDialog();
        }

        private void btnMobiteliTelefoni_Click(object sender, EventArgs e)
        {
            fmMobiteliTelefoni mobitelitelefini = new fmMobiteliTelefoni();
            mobitelitelefini.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmStatusPrijava statusprijava2 = new fmStatusPrijava();
            statusprijava2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
