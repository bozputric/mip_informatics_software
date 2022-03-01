namespace PrijavaKvara
{
    partial class fmHardwareEvidencija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmHardwareEvidencija));
            this.cbProdavaonice = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lbStvari = new System.Windows.Forms.ListBox();
            this.datagridKvarovi = new System.Windows.Forms.DataGridView();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKvarovi)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProdavaonice
            // 
            this.cbProdavaonice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdavaonice.FormattingEnabled = true;
            this.cbProdavaonice.Location = new System.Drawing.Point(48, 58);
            this.cbProdavaonice.Name = "cbProdavaonice";
            this.cbProdavaonice.Size = new System.Drawing.Size(230, 24);
            this.cbProdavaonice.TabIndex = 0;
            this.cbProdavaonice.Text = "==Odaberi prodavaonicu==";
            this.cbProdavaonice.SelectedIndexChanged += new System.EventHandler(this.cbProdavaonice_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(284, 142);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(65, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lbStvari
            // 
            this.lbStvari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStvari.FormattingEnabled = true;
            this.lbStvari.ItemHeight = 16;
            this.lbStvari.Items.AddRange(new object[] {
            "Računalo",
            "Monitor",
            "Veliki printer",
            "POS printer",
            "Ladica za novac",
            "Skener",
            "Tipkovnica",
            "Miš"});
            this.lbStvari.Location = new System.Drawing.Point(48, 88);
            this.lbStvari.Name = "lbStvari";
            this.lbStvari.Size = new System.Drawing.Size(230, 132);
            this.lbStvari.TabIndex = 2;
            // 
            // datagridKvarovi
            // 
            this.datagridKvarovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridKvarovi.Location = new System.Drawing.Point(355, 88);
            this.datagridKvarovi.Name = "datagridKvarovi";
            this.datagridKvarovi.ReadOnly = true;
            this.datagridKvarovi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridKvarovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridKvarovi.Size = new System.Drawing.Size(570, 263);
            this.datagridKvarovi.TabIndex = 3;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(891, 379);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 8;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(355, 357);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(117, 23);
            this.btnUkloni.TabIndex = 10;
            this.btnUkloni.Text = "Ukloni označeni kvar";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Prikaži sve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(355, 59);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 24);
            this.button7.TabIndex = 28;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Hardware evidencija";
            // 
            // fmHardwareEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 414);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.datagridKvarovi);
            this.Controls.Add(this.lbStvari);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbProdavaonice);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "fmHardwareEvidencija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware evidencija";
            this.Load += new System.EventHandler(this.fmHardwareEvidencija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridKvarovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProdavaonice;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lbStvari;
        private System.Windows.Forms.DataGridView datagridKvarovi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
    }
}