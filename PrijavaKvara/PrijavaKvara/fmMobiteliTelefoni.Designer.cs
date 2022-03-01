namespace PrijavaKvara
{
    partial class fmMobiteliTelefoni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMobiteliTelefoni));
            this.cbMobiteliTelefoni = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDugiBroj = new System.Windows.Forms.TextBox();
            this.tbKratkiBroj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPopisInternihKorisnika = new System.Windows.Forms.ComboBox();
            this.tbInterniBroj = new System.Windows.Forms.TextBox();
            this.tbKratkiInterniBroj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMobiteliTelefoni
            // 
            this.cbMobiteliTelefoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMobiteliTelefoni.FormattingEnabled = true;
            this.cbMobiteliTelefoni.Location = new System.Drawing.Point(30, 62);
            this.cbMobiteliTelefoni.Name = "cbMobiteliTelefoni";
            this.cbMobiteliTelefoni.Size = new System.Drawing.Size(203, 24);
            this.cbMobiteliTelefoni.TabIndex = 2;
            this.cbMobiteliTelefoni.Text = "==Odaberi korisnika==";
            this.cbMobiteliTelefoni.SelectedIndexChanged += new System.EventHandler(this.cbMobiteliTelefoni_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(25, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mobiteli";
            // 
            // tbDugiBroj
            // 
            this.tbDugiBroj.Location = new System.Drawing.Point(30, 92);
            this.tbDugiBroj.Name = "tbDugiBroj";
            this.tbDugiBroj.Size = new System.Drawing.Size(203, 20);
            this.tbDugiBroj.TabIndex = 20;
            // 
            // tbKratkiBroj
            // 
            this.tbKratkiBroj.Location = new System.Drawing.Point(30, 118);
            this.tbKratkiBroj.Name = "tbKratkiBroj";
            this.tbKratkiBroj.Size = new System.Drawing.Size(203, 20);
            this.tbKratkiBroj.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(292, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Telefoni";
            // 
            // cbPopisInternihKorisnika
            // 
            this.cbPopisInternihKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPopisInternihKorisnika.FormattingEnabled = true;
            this.cbPopisInternihKorisnika.Location = new System.Drawing.Point(297, 62);
            this.cbPopisInternihKorisnika.Name = "cbPopisInternihKorisnika";
            this.cbPopisInternihKorisnika.Size = new System.Drawing.Size(203, 24);
            this.cbPopisInternihKorisnika.TabIndex = 23;
            this.cbPopisInternihKorisnika.Text = "==Odaberi korisnika==";
            this.cbPopisInternihKorisnika.SelectedIndexChanged += new System.EventHandler(this.cbPopisInternihKorisnika_SelectedIndexChanged);
            // 
            // tbInterniBroj
            // 
            this.tbInterniBroj.Location = new System.Drawing.Point(297, 92);
            this.tbInterniBroj.Name = "tbInterniBroj";
            this.tbInterniBroj.Size = new System.Drawing.Size(203, 20);
            this.tbInterniBroj.TabIndex = 24;
            // 
            // tbKratkiInterniBroj
            // 
            this.tbKratkiInterniBroj.Location = new System.Drawing.Point(297, 118);
            this.tbKratkiInterniBroj.Name = "tbKratkiInterniBroj";
            this.tbKratkiInterniBroj.Size = new System.Drawing.Size(203, 20);
            this.tbKratkiInterniBroj.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Izlaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmMobiteliTelefoni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbKratkiInterniBroj);
            this.Controls.Add(this.tbInterniBroj);
            this.Controls.Add(this.cbPopisInternihKorisnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKratkiBroj);
            this.Controls.Add(this.tbDugiBroj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMobiteliTelefoni);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmMobiteliTelefoni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobiteli i Telefoni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbMobiteliTelefoni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDugiBroj;
        private System.Windows.Forms.TextBox tbKratkiBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPopisInternihKorisnika;
        private System.Windows.Forms.TextBox tbInterniBroj;
        private System.Windows.Forms.TextBox tbKratkiInterniBroj;
        private System.Windows.Forms.Button button1;
    }
}