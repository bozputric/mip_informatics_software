using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text.xml;
using Font = iTextSharp.text.Font;
using iText.Layout.Font;
using iText.Html2pdf.Resolver.Font;

namespace PrijavaKvara
{
    public partial class fmIspisi : Form
    {
        public fmIspisi()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private void fmPopisPrintera_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Prodavaonica", typeof(string));
            table.Columns.Add("Adresa", typeof(string));
            table.Columns.Add("Printer", typeof(string));

            dataGridView1.DataSource = table;

            string[] lines = File.ReadAllLines("p-popis.txt");

            foreach (var line in lines)
            {
                string[] tokens = line.Split('*');
                table.Rows.Add(tokens[0], tokens[2], tokens[5]);
            }
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            FontProvider dfp = new DefaultFontProvider(true, true, false);

            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {

                            ErrorMessage = true;
                            MessageBox.Show("Nije moguće zapisati podatke u PDF :(" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());                  
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("PDF uspješno kreiran!", "info");

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Greška prilikom Exportanja :(" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");

            }
        }

        private void cbStoIspisati_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStoIspisati.SelectedIndex == 0)
            {
                table.Columns.Clear();
                table.Rows.Clear();
                table.Columns.Add("Prodavaonica", typeof(string));
                table.Columns.Add("Adresa", typeof(string));
                table.Columns.Add("Kontakt", typeof(string));

                dataGridView1.DataSource = table;

                string[] lines = File.ReadAllLines("p-popis.txt");

                foreach (var line in lines)
                {
                    string[] tokens = line.Split('*');
                    table.Rows.Add(tokens[0], tokens[2], tokens[3]);
                }
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (cbStoIspisati.SelectedIndex == 1)
            {
                table.Columns.Clear();
                table.Rows.Clear();
                table.Columns.Add("Prodavaonica", typeof(string));
                table.Columns.Add("Adresa", typeof(string));
                table.Columns.Add("Printer", typeof(string));

                dataGridView1.DataSource = table;

                string[] lines = File.ReadAllLines("p-popis.txt");

                foreach (var line in lines)
                {
                    string[] tokens = line.Split('*');
                    table.Rows.Add(tokens[0], tokens[2], tokens[5]);
                }
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (cbStoIspisati.SelectedIndex == 2)
            {
                table.Columns.Clear();
                table.Rows.Clear();
                table.Columns.Add("Prodavaonica", typeof(string));
                table.Columns.Add("Adresa", typeof(string));
                table.Columns.Add("IP Adresa", typeof(string));

                dataGridView1.DataSource = table;

                string[] lines = File.ReadAllLines("p-popis.txt");

                foreach (var line in lines)
                {
                    string[] tokens = line.Split('*');
                    table.Rows.Add(tokens[0], tokens[2], tokens[1]);
                }
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (cbStoIspisati.SelectedIndex == 3)
            {
                table.Columns.Clear();
                table.Rows.Clear();
                table.Columns.Add("Prodavaonica", typeof(string));
                table.Columns.Add("Adresa", typeof(string));
                table.Columns.Add("Videonadzor", typeof(string));

                dataGridView1.DataSource = table;

                string[] lines = File.ReadAllLines("p-popis.txt");

                foreach (var line in lines)
                {
                    string[] tokens = line.Split('*');
                    table.Rows.Add(tokens[0], tokens[2], tokens[4]);
                }
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (cbStoIspisati.SelectedIndex == 4)
            {
                table.Columns.Clear();
                table.Rows.Clear();
                table.Columns.Add("Prodavaonica", typeof(string));
                table.Columns.Add("Adresa", typeof(string));
                table.Columns.Add("Kontakt", typeof(string));
                table.Columns.Add("IP Adresa", typeof(string));
                table.Columns.Add("Videonadzor", typeof(string));
                table.Columns.Add("Printer", typeof(string));

                dataGridView1.DataSource = table;

                string[] lines = File.ReadAllLines("p-popis.txt");

                foreach (var line in lines)
                {
                    string[] tokens = line.Split('*');
                    table.Rows.Add(tokens[0], tokens[2], tokens[3], tokens[1], tokens[4], tokens[5]);
                }
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
