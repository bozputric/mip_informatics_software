namespace PrijavaKvara
{
    partial class fmPrijavaKvara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPrijavaKvara));
            this.btnSend = new System.Windows.Forms.Button();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbCC = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.groupSetting = new System.Windows.Forms.GroupBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.tbSmtp = new System.Windows.Forms.TextBox();
            this.lbSmtp = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.cbProdavaonice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajProdavaonicu = new System.Windows.Forms.Button();
            this.chkKvarInterneta = new System.Windows.Forms.CheckBox();
            this.chkKvarTelefona = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKontaktBroj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzadi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSpremi2 = new System.Windows.Forms.Button();
            this.tbImePrezime = new System.Windows.Forms.TextBox();
            this.groupSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Gold;
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(25, 16);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 89);
            this.btnSend.TabIndex = 0;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTo.Location = new System.Drawing.Point(166, 16);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(50, 16);
            this.lbTo.TabIndex = 1;
            this.lbTo.Text = "Prima:";
            // 
            // lbCC
            // 
            this.lbCC.AutoSize = true;
            this.lbCC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCC.Location = new System.Drawing.Point(163, 51);
            this.lbCC.Name = "lbCC";
            this.lbCC.Size = new System.Drawing.Size(53, 16);
            this.lbCC.TabIndex = 2;
            this.lbCC.Text = "Kopija:";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSubject.Location = new System.Drawing.Point(150, 86);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(66, 16);
            this.lbSubject.TabIndex = 3;
            this.lbSubject.Text = "Predmet:";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbMessage.Location = new System.Drawing.Point(58, 309);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(136, 16);
            this.lbMessage.TabIndex = 4;
            this.lbMessage.Text = "Pretpregled maila:";
            // 
            // tbTo
            // 
            this.tbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTo.Location = new System.Drawing.Point(221, 13);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(440, 22);
            this.tbTo.TabIndex = 5;
            // 
            // tbCC
            // 
            this.tbCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCC.Location = new System.Drawing.Point(221, 48);
            this.tbCC.Name = "tbCC";
            this.tbCC.ReadOnly = true;
            this.tbCC.Size = new System.Drawing.Size(440, 22);
            this.tbCC.TabIndex = 6;
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubject.Location = new System.Drawing.Point(221, 83);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(440, 22);
            this.tbSubject.TabIndex = 7;
            this.tbSubject.Text = "Prijava kvara P-";
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMessage.Location = new System.Drawing.Point(59, 328);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(746, 249);
            this.tbMessage.TabIndex = 8;
            // 
            // groupSetting
            // 
            this.groupSetting.Controls.Add(this.chkSSL);
            this.groupSetting.Controls.Add(this.tbSmtp);
            this.groupSetting.Controls.Add(this.lbSmtp);
            this.groupSetting.Controls.Add(this.tbPort);
            this.groupSetting.Controls.Add(this.lbPort);
            this.groupSetting.Controls.Add(this.tbUsername);
            this.groupSetting.Controls.Add(this.tbPassword);
            this.groupSetting.Controls.Add(this.lbPassword);
            this.groupSetting.Controls.Add(this.lbUsername);
            this.groupSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupSetting.Location = new System.Drawing.Point(61, 600);
            this.groupSetting.Name = "groupSetting";
            this.groupSetting.Size = new System.Drawing.Size(459, 106);
            this.groupSetting.TabIndex = 9;
            this.groupSetting.TabStop = false;
            this.groupSetting.Text = "Postavke";
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkSSL.Location = new System.Drawing.Point(215, 23);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(46, 17);
            this.chkSSL.TabIndex = 8;
            this.chkSSL.Text = "SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // tbSmtp
            // 
            this.tbSmtp.Location = new System.Drawing.Point(215, 72);
            this.tbSmtp.Name = "tbSmtp";
            this.tbSmtp.Size = new System.Drawing.Size(86, 20);
            this.tbSmtp.TabIndex = 7;
            this.tbSmtp.Text = "smtp.gmail.com";
            // 
            // lbSmtp
            // 
            this.lbSmtp.AutoSize = true;
            this.lbSmtp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSmtp.Location = new System.Drawing.Point(169, 75);
            this.lbSmtp.Name = "lbSmtp";
            this.lbSmtp.Size = new System.Drawing.Size(40, 13);
            this.lbSmtp.TabIndex = 6;
            this.lbSmtp.Text = "SMTP:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(69, 72);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(68, 20);
            this.tbPort.TabIndex = 5;
            this.tbPort.Text = "587";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPort.Location = new System.Drawing.Point(34, 75);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(29, 13);
            this.lbPort.TabIndex = 4;
            this.lbPort.Text = "Port:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(69, 20);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(121, 20);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.Text = "bozidar.putric";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(69, 46);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(121, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "helenasremixes0301";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPassword.Location = new System.Drawing.Point(7, 49);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUsername.Location = new System.Drawing.Point(2, 23);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(61, 13);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "User name:";
            // 
            // cbProdavaonice
            // 
            this.cbProdavaonice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdavaonice.FormattingEnabled = true;
            this.cbProdavaonice.Location = new System.Drawing.Point(221, 139);
            this.cbProdavaonice.Name = "cbProdavaonice";
            this.cbProdavaonice.Size = new System.Drawing.Size(179, 24);
            this.cbProdavaonice.TabIndex = 10;
            this.cbProdavaonice.Text = "=Odaberi prodavaonicu=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(116, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prodavaonica:";
            // 
            // btnDodajProdavaonicu
            // 
            this.btnDodajProdavaonicu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajProdavaonicu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajProdavaonicu.BackgroundImage")));
            this.btnDodajProdavaonicu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajProdavaonicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProdavaonicu.Location = new System.Drawing.Point(339, 248);
            this.btnDodajProdavaonicu.Name = "btnDodajProdavaonicu";
            this.btnDodajProdavaonicu.Size = new System.Drawing.Size(61, 52);
            this.btnDodajProdavaonicu.TabIndex = 12;
            this.btnDodajProdavaonicu.UseVisualStyleBackColor = false;
            this.btnDodajProdavaonicu.Click += new System.EventHandler(this.btnDodajProdavaonicu_Click);
            // 
            // chkKvarInterneta
            // 
            this.chkKvarInterneta.AutoSize = true;
            this.chkKvarInterneta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKvarInterneta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkKvarInterneta.Location = new System.Drawing.Point(235, 182);
            this.chkKvarInterneta.Name = "chkKvarInterneta";
            this.chkKvarInterneta.Size = new System.Drawing.Size(76, 20);
            this.chkKvarInterneta.TabIndex = 16;
            this.chkKvarInterneta.Text = "Internet";
            this.chkKvarInterneta.UseVisualStyleBackColor = true;
            // 
            // chkKvarTelefona
            // 
            this.chkKvarTelefona.AutoSize = true;
            this.chkKvarTelefona.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKvarTelefona.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkKvarTelefona.Location = new System.Drawing.Point(327, 182);
            this.chkKvarTelefona.Name = "chkKvarTelefona";
            this.chkKvarTelefona.Size = new System.Drawing.Size(74, 20);
            this.chkKvarTelefona.TabIndex = 17;
            this.chkKvarTelefona.Text = "Telefon";
            this.chkKvarTelefona.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(58, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kontakt broj na lokaciji:";
            // 
            // tbKontaktBroj
            // 
            this.tbKontaktBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKontaktBroj.Location = new System.Drawing.Point(221, 220);
            this.tbKontaktBroj.Name = "tbKontaktBroj";
            this.tbKontaktBroj.Size = new System.Drawing.Size(179, 22);
            this.tbKontaktBroj.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(175, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kvar:";
            // 
            // btnIzadi
            // 
            this.btnIzadi.BackColor = System.Drawing.Color.Transparent;
            this.btnIzadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzadi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzadi.Location = new System.Drawing.Point(718, 685);
            this.btnIzadi.Name = "btnIzadi";
            this.btnIzadi.Size = new System.Drawing.Size(87, 24);
            this.btnIzadi.TabIndex = 21;
            this.btnIzadi.Text = "IZLAZ";
            this.btnIzadi.UseVisualStyleBackColor = false;
            this.btnIzadi.Click += new System.EventHandler(this.btnIzadi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(504, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(423, 693);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 20);
            this.btnSpremi.TabIndex = 23;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(730, 583);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 24;
            this.btnCopy.Text = "Kopiraj";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(688, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 22);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSpremi2
            // 
            this.btnSpremi2.Location = new System.Drawing.Point(715, 85);
            this.btnSpremi2.Name = "btnSpremi2";
            this.btnSpremi2.Size = new System.Drawing.Size(73, 20);
            this.btnSpremi2.TabIndex = 26;
            this.btnSpremi2.Text = "Spremi";
            this.btnSpremi2.UseVisualStyleBackColor = true;
            this.btnSpremi2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbImePrezime
            // 
            this.tbImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbImePrezime.Location = new System.Drawing.Point(688, 12);
            this.tbImePrezime.Name = "tbImePrezime";
            this.tbImePrezime.Size = new System.Drawing.Size(100, 22);
            this.tbImePrezime.TabIndex = 27;
            // 
            // fmPrijavaKvara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 768);
            this.Controls.Add(this.tbImePrezime);
            this.Controls.Add(this.btnSpremi2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKontaktBroj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkKvarTelefona);
            this.Controls.Add(this.chkKvarInterneta);
            this.Controls.Add(this.btnDodajProdavaonicu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProdavaonice);
            this.Controls.Add(this.groupSetting);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbCC);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbCC);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.btnSend);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmPrijavaKvara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava kvara";
            this.groupSetting.ResumeLayout(false);
            this.groupSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbCC;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.GroupBox groupSetting;
        private System.Windows.Forms.TextBox tbSmtp;
        private System.Windows.Forms.Label lbSmtp;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.ComboBox cbProdavaonice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajProdavaonicu;
        private System.Windows.Forms.CheckBox chkKvarInterneta;
        private System.Windows.Forms.CheckBox chkKvarTelefona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKontaktBroj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzadi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSpremi2;
        private System.Windows.Forms.TextBox tbImePrezime;
    }
}

