using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaKvara
{
    public partial class fmPrintOtpis : Form
    {
        public string Date, Naziv, Kolicina, Mjesto, InventurniBroj, VrijemeNastanka, Uzrok, Prilog;

        private void button1_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);

        }

        public fmPrintOtpis()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("dd/MM/yyyy");
        }
        
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private static Bitmap ResizeBitmap(Bitmap source, int factor)
        {
            Bitmap result = new Bitmap(source.Width * factor, source.Height * factor);
            result.SetResolution(source.HorizontalResolution * factor, source.VerticalResolution * factor);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(source, 0, 0, source.Width * factor, source.Height * factor);
            }
            return result;
        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }


        private void fmPrintOtpis_Load(object sender, EventArgs e)
        {
            label5.Text = Naziv;
            label6.Text = Kolicina;
            label7.Text = Mjesto;
            label8.Text = InventurniBroj;
            label9.Text = Date;
            label10.Text = Uzrok;
            label11.Text = Date;
            label14.Text = Prilog;

            //- Set the System.Drawing.Graphics object property InterpolationMode to High
            //System.Drawing.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

            //- Draw the original image into the target Graphics object scaling to the desired width and height
            System.Drawing.Rectangle rectDestination = new System.Drawing.Rectangle(0, 0, panel1.Width, (int)panel1.Height);

            //Set Image codec of JPEG type, the index of JPEG codec is "1"
            System.Drawing.Imaging.ImageCodecInfo codec = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()[1];

            //Set the parameters for defining the quality of the capture... here it is set to 100%
            System.Drawing.Imaging.EncoderParameters eParams = new System.Drawing.Imaging.EncoderParameters(1);

            eParams.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
        }
    }
}
