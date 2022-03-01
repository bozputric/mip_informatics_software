namespace PrijavaKvara
{
    partial class fmPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPocetna));
            this.btnPrijavaKvara = new System.Windows.Forms.Button();
            this.btnTrgovineInfo = new System.Windows.Forms.Button();
            this.btnEmailovi = new System.Windows.Forms.Button();
            this.btnMobiteliTelefoni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrijavaKvara
            // 
            this.btnPrijavaKvara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrijavaKvara.BackgroundImage")));
            this.btnPrijavaKvara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrijavaKvara.Location = new System.Drawing.Point(83, 313);
            this.btnPrijavaKvara.Name = "btnPrijavaKvara";
            this.btnPrijavaKvara.Size = new System.Drawing.Size(170, 140);
            this.btnPrijavaKvara.TabIndex = 0;
            this.btnPrijavaKvara.UseVisualStyleBackColor = true;
            this.btnPrijavaKvara.Click += new System.EventHandler(this.btnPrijavaKvara_Click);
            // 
            // btnTrgovineInfo
            // 
            this.btnTrgovineInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrgovineInfo.BackgroundImage")));
            this.btnTrgovineInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrgovineInfo.Location = new System.Drawing.Point(83, 136);
            this.btnTrgovineInfo.Name = "btnTrgovineInfo";
            this.btnTrgovineInfo.Size = new System.Drawing.Size(170, 140);
            this.btnTrgovineInfo.TabIndex = 1;
            this.btnTrgovineInfo.UseVisualStyleBackColor = true;
            this.btnTrgovineInfo.Click += new System.EventHandler(this.btnTrgovineInfo_Click);
            // 
            // btnEmailovi
            // 
            this.btnEmailovi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmailovi.BackgroundImage")));
            this.btnEmailovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmailovi.Location = new System.Drawing.Point(310, 136);
            this.btnEmailovi.Name = "btnEmailovi";
            this.btnEmailovi.Size = new System.Drawing.Size(170, 140);
            this.btnEmailovi.TabIndex = 2;
            this.btnEmailovi.UseVisualStyleBackColor = true;
            this.btnEmailovi.Click += new System.EventHandler(this.btnEmailovi_Click);
            // 
            // btnMobiteliTelefoni
            // 
            this.btnMobiteliTelefoni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMobiteliTelefoni.BackgroundImage")));
            this.btnMobiteliTelefoni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMobiteliTelefoni.Location = new System.Drawing.Point(536, 136);
            this.btnMobiteliTelefoni.Name = "btnMobiteliTelefoni";
            this.btnMobiteliTelefoni.Size = new System.Drawing.Size(170, 140);
            this.btnMobiteliTelefoni.TabIndex = 3;
            this.btnMobiteliTelefoni.UseVisualStyleBackColor = true;
            this.btnMobiteliTelefoni.Click += new System.EventHandler(this.btnMobiteliTelefoni_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(83, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "STATUS PRIJAVA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(697, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMobiteliTelefoni);
            this.Controls.Add(this.btnEmailovi);
            this.Controls.Add(this.btnTrgovineInfo);
            this.Controls.Add(this.btnPrijavaKvara);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrijavaKvara;
        private System.Windows.Forms.Button btnTrgovineInfo;
        private System.Windows.Forms.Button btnEmailovi;
        private System.Windows.Forms.Button btnMobiteliTelefoni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}