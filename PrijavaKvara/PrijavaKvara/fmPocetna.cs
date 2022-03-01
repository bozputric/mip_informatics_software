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
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite ažurirati sve podatke?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    try
                    {
                    string emailovi = File.ReadAllText(@"\\192.168.67.223\Informatika\app\emailovi.txt");
                    string statusprijava = File.ReadAllText(@"\\192.168.67.223\Informatika\app\status-prijava.txt");
                    string internitelefoni = File.ReadAllText(@"\\192.168.67.223\Informatika\app\interni-telefoni.txt");
                    string mobiteli = File.ReadAllText(@"\\192.168.67.223\Informatika\app\mobiteli.txt");
                    string ppopis = File.ReadAllText(@"\\192.168.67.223\Informatika\app\p-popis.txt");
                    string evidencijakvarova = File.ReadAllText(@"\\192.168.67.223\Informatika\app\evidencija-kvarova.txt");

                    System.IO.File.WriteAllText("emailovi.txt", emailovi);          
                    System.IO.File.WriteAllText("status-prijava.txt", statusprijava);
                    System.IO.File.WriteAllText("interni-telefoni.txt", internitelefoni);
                    System.IO.File.WriteAllText("mobiteli.txt", mobiteli);
                    System.IO.File.WriteAllText("p-popis.txt", ppopis);
                    System.IO.File.WriteAllText("evidencija-kvarova.txt", evidencijakvarova);
                    MessageBox.Show("Podaci su uspješno ažurirani!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                catch
                    {
                        MessageBox.Show("Dogodila se pogreška :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }               
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            fmHardwareEvidencija forma = new fmHardwareEvidencija();
            forma.ShowDialog();
        }

        private void btnOtpis_Click(object sender, EventArgs e)
        {
            fmOtpisOpreme forma = new fmOtpisOpreme();
            forma.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fmEvidencijaOtpisa forma = new fmEvidencijaOtpisa();
            forma.ShowDialog();
        }

        private void btnPrintIspisi_Click(object sender, EventArgs e)
        {
            fmIspisi forma = new fmIspisi();
            forma.ShowDialog();
        }
    }
}
