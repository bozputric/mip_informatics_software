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
    public partial class fmPrijavaKvara : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        string inKorIme;
        string inLozinka;
        string inPort;
        string inSMTP;

        string inTo;
        string inCC;
        string inImePrezime;

        public fmPrijavaKvara()
        {
            InitializeComponent();

            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
            groupSetting.Enabled = false;
            btnSpremi.Enabled = false;

            string[] popisProdavaonica = File.ReadAllLines("p-popis.txt");
            foreach (var line in popisProdavaonica)
            {
                string[] tokens = line.Split('*');
                cbProdavaonice.Items.Add(tokens[0]);
            }

            string[] postavke = File.ReadAllLines("postavke.txt");
            foreach (var line in postavke)
            {
                string[] split = line.Split(';');
                tbUsername.Text = split[0];
                tbPassword.Text = split[1];
                tbPort.Text = split[2];
                tbSmtp.Text = split[3];
            }

            string[] primatelji = File.ReadAllLines("primatelji.txt");
            foreach (var line in primatelji)
            {
                string[] split2 = line.Split('*');
                tbTo.Text = split2[0];
                tbCC.Text = split2[1];
                tbImePrezime.Text = split2[2];
            }

            inKorIme = tbUsername.Text;
            inLozinka = tbPassword.Text;
            inPort = tbPort.Text;
            inSMTP = tbSmtp.Text;

            inTo = tbTo.Text;
            inCC = tbCC.Text;
            inImePrezime = tbImePrezime.Text;           
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbMessage.Text == "")
            {
                MessageBox.Show("Nije napisan mail!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Jeste li sigurni da želite poslati mail?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login = new NetworkCredential(tbUsername.Text, tbPassword.Text);
                client = new SmtpClient(tbSmtp.Text);
                client.Port = Convert.ToInt32(tbPort.Text);
                client.EnableSsl = chkSSL.Checked;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress(tbUsername.Text, tbImePrezime.Text, Encoding.UTF8) };
                msg.To.Add(new MailAddress(tbTo.Text));
                if (!string.IsNullOrEmpty(tbCC.Text))
                    foreach (var address in tbCC.Text.Split(','))
                    {
                        msg.CC.Add(new MailAddress(address));
                    }
                msg.Subject = tbSubject.Text;
                msg.Body = tbMessage.Text + Environment.NewLine;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending...";
                client.SendAsync(msg, userstate);

                string kvar = "";

                if (chkKvarInterneta.Checked && chkKvarTelefona.Checked == false)
                    kvar = "internet";
                if (chkKvarTelefona.Checked && chkKvarInterneta.Checked == false)
                {
                    kvar = "telefon";
                }
                if (chkKvarInterneta.Checked && chkKvarTelefona.Checked)
                    kvar = "Internet i telefon";

                var odabraniRedak = cbProdavaonice.SelectedIndex;
                string line = File.ReadLines("p-popis.txt").Skip(odabraniRedak).Take(1).First();
                string[] tokens = line.Split('*');
                string tekstStatusa = DateTime.Now.ToString() + "*" + tokens[0] + "*" + tokens[2] + "*" + tokens[3] + "*" + kvar;
                string staritekst = File.ReadAllText("status-prijava.txt");
                string novitekst = tekstStatusa + Environment.NewLine + staritekst;
                File.WriteAllText("status-prijava.txt", novitekst);
            }
        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0}{1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Tvoj mail je uspješno poslan.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDodajProdavaonicu_Click(object sender, EventArgs e)
        {
            var odabraniRedak = cbProdavaonice.SelectedIndex;

            string line = File.ReadLines("p-popis.txt").Skip(odabraniRedak).Take(1).First();

            string[] tokens = line.Split('*');

            if (chkKvarInterneta.Checked && chkKvarTelefona.Checked)
            {
                    tbMessage.Text = "Poštovani, " + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine + "<br />";
                    tbMessage.Text += "u prodavaonici P-" + cbProdavaonice.Text.Substring(13, 3) + " ne rade Internet i telefon. Molim provjeru i otklon kvara." + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[0] + Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[1] + Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[2] + Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[3] + Environment.NewLine + "<br />";
                    tbMessage.Text += "Kontakt broj na lokaciji: " + tbKontaktBroj.Text + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine + Environment.NewLine + "<br />";
                    tbMessage.Text += "S poštovanjem, " + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine;
                    tbMessage.Text += "<section1>" + "<p style=" + "\"" + "font-style:bold;" + "color:black;" + "font-family:calibri;" + "font-size:13px;" + "\"" + ">Božidar Putrić</p>" + "</section1>";
                    tbMessage.Text += "<section2>" + "<p style=" + "\"" + "color:#0039e6;" + "font-family:calibri;" + "font-size:11px;" +"\"" + ">Odjel informatike" + "<br />";
                    tbMessage.Text += "Mlin i pekare Sisak d.o.o." + "<br />";
                    tbMessage.Text += "44000 Sisak" + "<br />";
                    tbMessage.Text += "tel/fax: 044/515-104" + "<br />";
                    tbMessage.Text += "www.mip.hr" + "</p>" + "</section2>";

                tbSubject.Text = "Prijava kvara P-" + cbProdavaonice.Text.Substring(13, 3);

            }
            if (chkKvarInterneta.Checked && chkKvarTelefona.Checked == false)
            {
                    tbMessage.Text = "Poštovani, " + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine + "<br />";
                    tbMessage.Text += "u prodavaonici P-" + cbProdavaonice.Text.Substring(13, 3) + " ne radi Internet. Molim provjeru i otklon kvara." + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[0] + Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[1] + Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[2] + Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[3] + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine + Environment.NewLine + "<br />";
                    tbMessage.Text += "S poštovanjem, " + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine;
                tbMessage.Text += "<section1>" + "<p style=" + "\"" + "font-style:bold;" + "color:black;" + "font-family:calibri;" + "font-size:13px;" + "\"" + ">Božidar Putrić</p>" + "</section1>";
                tbMessage.Text += "<section2>" + "<p style=" + "\"" + "color:#0039e6;" + "font-family:calibri;" + "font-size:11px;" + "\"" + ">Odjel informatike" + "<br />";
                tbMessage.Text += "Mlin i pekare Sisak d.o.o." + "<br />";
                tbMessage.Text += "44000 Sisak" + "<br />";
                tbMessage.Text += "tel/fax: 044/515-104" + "<br />";
                tbMessage.Text += "www.mip.hr" + "</p>" + "</section2>";
                tbSubject.Text = "Prijava kvara P-" + cbProdavaonice.Text.Substring(13, 3);
            }
            if (chkKvarTelefona.Checked && chkKvarInterneta.Checked == false)
            {
                    tbMessage.Text = "Poštovani, " + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine + "<br />";
                    tbMessage.Text += "u prodavaonici P-" + cbProdavaonice.Text.Substring(13, 3) + " ne radi telefon. Molim provjeru i otklon kvara." + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[0] + Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[1] + Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[2] + Environment.NewLine + "<br />";
                    tbMessage.Text += tokens[3] + Environment.NewLine + "<br />";
                    tbMessage.Text += "Kontakt broj na lokaciji: " + tbKontaktBroj.Text + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine + Environment.NewLine + "<br />";
                    tbMessage.Text += "S poštovanjem, " + Environment.NewLine + "<br />";
                    tbMessage.Text += Environment.NewLine;
                tbMessage.Text += "<section1>" + "<p style=" + "\"" + "font-style:bold;" + "color:black;" + "font-family:calibri;" + "font-size:13px;" + "\"" + ">Božidar Putrić</p>" + "</section1>";
                tbMessage.Text += "<section2>" + "<p style=" + "\"" + "color:#0039e6;" + "font-family:calibri;" + "font-size:11px;" + "\"" + ">Odjel informatike" + "<br />";
                tbMessage.Text += "Mlin i pekare Sisak d.o.o." + "<br />";
                tbMessage.Text += "44000 Sisak" + "<br />";
                tbMessage.Text += "tel/fax: 044/515-104" + "<br />";
                tbMessage.Text += "www.mip.hr" + "</p>" + "</section2>";
                tbSubject.Text = "Prijava kvara P-" + cbProdavaonice.Text.Substring(13, 3);
            }
            if (cbProdavaonice.SelectedItem == null)
            {
                MessageBox.Show("Nije odabrana prodavaonica!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (chkKvarInterneta.Checked == false && chkKvarTelefona.Checked == false)
            {
                MessageBox.Show("Nije označen kvar!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIzadi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupSetting.Enabled = true;
            btnSpremi.Enabled = true;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "" || tbPassword.Text == "" || tbPort.Text == "" || tbSmtp.Text == "") 
            {
                MessageBox.Show("Niste unijeli sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string novoKorIme = File.ReadAllText("postavke.txt");
                novoKorIme = novoKorIme.Replace(inKorIme, tbUsername.Text);
                File.WriteAllText("postavke.txt", novoKorIme);

                string novaLozinka = File.ReadAllText("postavke.txt");
                novaLozinka = novaLozinka.Replace(inLozinka, tbPassword.Text);
                File.WriteAllText("postavke.txt", novaLozinka);

                string noviPort = File.ReadAllText("postavke.txt");
                noviPort = noviPort.Replace(inPort, tbPort.Text);
                File.WriteAllText("postavke.txt", noviPort);

                string noviSMTP = File.ReadAllText("postavke.txt");
                noviSMTP = noviSMTP.Replace(inSMTP, tbSmtp.Text);
                File.WriteAllText("postavke.txt", noviSMTP);

                groupSetting.Enabled = false;
                btnSpremi.Enabled = false;
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            var odabraniRedak = cbProdavaonice.SelectedIndex;

            string line = File.ReadLines("p-popis.txt").Skip(odabraniRedak).Take(1).First();

            string[] tokens = line.Split('*');

            if (chkKvarInterneta.Checked && chkKvarTelefona.Checked)
            {
                tbMessage.Text = "Poštovani, " + Environment.NewLine;
                tbMessage.Text += Environment.NewLine;
                tbMessage.Text += "u prodavaonici P-" + cbProdavaonice.Text.Substring(13, 3) + " ne rade Internet i telefon. Molim provjeru i otklon kvara." + Environment.NewLine;
                tbMessage.Text += Environment.NewLine;
                tbMessage.Text += tokens[0] + Environment.NewLine;
                tbMessage.Text += tokens[1] + Environment.NewLine;
                tbMessage.Text += tokens[2] + Environment.NewLine;
                tbMessage.Text += tokens[3] + Environment.NewLine;
                tbMessage.Text += "Kontakt broj na lokaciji: " + tbKontaktBroj.Text + Environment.NewLine;
                tbSubject.Text = "Prijava kvara P-" + cbProdavaonice.Text.Substring(13, 3); 
                Clipboard.SetText(tbMessage.Text);

            }
            if (chkKvarInterneta.Checked && chkKvarTelefona.Checked == false)
            {
                tbMessage.Text = "Poštovani, " + Environment.NewLine;
                tbMessage.Text += Environment.NewLine;
                tbMessage.Text += "u prodavaonici P-" + cbProdavaonice.Text.Substring(13, 3) + " ne radi Internet. Molim provjeru i otklon kvara." + Environment.NewLine;
                tbMessage.Text += Environment.NewLine;
                tbMessage.Text += tokens[0] + Environment.NewLine;
                tbMessage.Text += tokens[1] + Environment.NewLine;
                tbMessage.Text += tokens[2] + Environment.NewLine;
                tbMessage.Text += tokens[3] + Environment.NewLine;
                tbSubject.Text = "Prijava kvara P-" + cbProdavaonice.Text.Substring(13, 3);
                Clipboard.SetText(tbMessage.Text);
            }
            if (chkKvarTelefona.Checked && chkKvarInterneta.Checked == false)
            {
                tbMessage.Text = "Poštovani, " + Environment.NewLine;
                tbMessage.Text += Environment.NewLine;
                tbMessage.Text += "u prodavaonici P-" + cbProdavaonice.Text.Substring(13, 3) + " ne radi telefon. Molim provjeru i otklon kvara." + Environment.NewLine;
                tbMessage.Text += Environment.NewLine;
                tbMessage.Text += tokens[0] + Environment.NewLine;
                tbMessage.Text += tokens[1] + Environment.NewLine;
                tbMessage.Text += tokens[2] + Environment.NewLine;
                tbMessage.Text += tokens[3] + Environment.NewLine;
                tbMessage.Text += "Kontakt broj na lokaciji: " + tbKontaktBroj.Text + Environment.NewLine;
                tbSubject.Text = "Prijava kvara P-" + cbProdavaonice.Text.Substring(13, 3);
                Clipboard.SetText(tbMessage.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbTo.Text == "" || tbCC.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string noviTo = File.ReadAllText("primatelji.txt");
                noviTo = noviTo.Replace(inTo, tbTo.Text);
                File.WriteAllText("primatelji.txt", noviTo);

                string noviCC = File.ReadAllText("primatelji.txt");
                noviCC = noviCC.Replace(inCC, tbCC.Text);
                File.WriteAllText("primatelji.txt", noviCC);

                string novoImePrezime = File.ReadAllText("primatelji.txt");
                novoImePrezime = novoImePrezime.Replace(inImePrezime, tbImePrezime.Text);
                File.WriteAllText("primatelji.txt", novoImePrezime);
                btnSpremi.Enabled = false;
            }
            tbTo.BackColor = Color.LightGreen;
            tbCC.BackColor = Color.LightGreen;
            tbImePrezime.BackColor = Color.LightGreen;
            tbTo.ReadOnly = true;
            tbCC.ReadOnly = true;
            tbImePrezime.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnSpremi2.Enabled = true;
            tbCC.ReadOnly = false;
            tbTo.ReadOnly = false;
            tbImePrezime.ReadOnly = false;
            tbTo.BackColor = Color.LightCoral;
            tbCC.BackColor = Color.LightCoral;
            tbImePrezime.BackColor = Color.LightCoral;
        }
    }
}