using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using SeminarskiRad.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SeminarskiRad
{
    public partial class StatsForm : Form
    {
        public static StatsForm MainForm { get; set; }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public StatsForm()
        {
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            MainForm = this;
            PrikaziStatistike();
            
        }

        public void PictuteBoxDetails_Click(Statistika statistika)
        {
            string connectionString = Settings.Default.DatabaseConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = string.Format("SELECT * FROM MjesecniZapis WHERE Id_Statistike = '{0}'", statistika.Id);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<MjesecniZapis> mjesecniZapisi = new List<MjesecniZapis>();
            while (sqlDataReader.Read())
            {
                MjesecniZapis mjesecniZapis = new MjesecniZapis
                {
                    RedniBroj = sqlDataReader.GetInt32(1),
                    Prihodi = decimal.ToDouble(sqlDataReader.GetDecimal(2)),
                    Najam = decimal.ToDouble(sqlDataReader.GetDecimal(3)),
                    Rezije = decimal.ToDouble(sqlDataReader.GetDecimal(4)),
                    Prehrana = decimal.ToDouble(sqlDataReader.GetDecimal(5)),
                    Internet = decimal.ToDouble(sqlDataReader.GetDecimal(6)),
                    Transport = decimal.ToDouble(sqlDataReader.GetDecimal(7)),
                    Osiguranje = decimal.ToDouble(sqlDataReader.GetDecimal(8)),
                    Ostalo = decimal.ToDouble(sqlDataReader.GetDecimal(9))
                };

                mjesecniZapisi.Add(mjesecniZapis);
            }

            sqlDataReader.Close();
            sqlCommand.Dispose();
            sqlConnection.Close();

            statistika.MjesecniZapisi = mjesecniZapisi;
            DetailsForm detailsForm = new DetailsForm(statistika);
            detailsForm.Show();

            Hide();
        }

        public void PictureBoxExport_Click(Statistika statistika)
        {
            Izvoz(statistika.Id);
        }

        public void PictureBoxDelete_Click(Statistika statistika)
        {
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite izbrisati statistiku?", "Brisanje statistike", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                statistika.Izbrisi();
                PrikaziStatistike();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            StatForm statForm = new StatForm();
            statForm.Show();
            
            Hide();
        }

        private List<Statistika> DohvatiStatistike()
        {
            List<Statistika> listaStatistika = new List<Statistika>();

            string connectionString = Settings.Default.DatabaseConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "SELECT * FROM Statistika";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Statistika statistika = new Statistika()
                {
                    Id = Guid.Parse(sqlDataReader.GetString(0)),
                    Naziv = sqlDataReader.GetString(1),
                    Godina = sqlDataReader.GetInt32(2),
                    Datum = sqlDataReader.GetDateTime(3)
                };

                listaStatistika.Add(statistika);
            }

            listaStatistika = listaStatistika
                .OrderByDescending(stat => stat.Datum)
                .ToList();

            sqlDataReader.Close();
            sqlCommand.Dispose();

            sqlConnection.Close();

            return listaStatistika;
        }

        public void PrikaziStatistike()
        {
            FlStats.Controls.Clear();

            List<Statistika> statistike = DohvatiStatistike();
            int counter = 0;
            statistike.ForEach(stat =>
            {
                Panel panel = new Panel
                {
                    Name = "PnlStat" + counter.ToString(),
                    Height = 50,
                    Width = FlStats.Width - 27,
                    BackColor = Color.DarkBlue,
                    Margin = new Padding(0, 0, 0, 10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label label = new Label
                {
                    Name = "LbStat" + counter.ToString(),
                    Text = stat.Naziv,
                    Location = new Point(20, 12),
                    ForeColor = Color.White,
                    Font = new Font("Century Gothic", 12),
                    MaximumSize = new Size(260, 50)
                };

                Label dateTimeLabel = new Label
                {
                    Name = "LbDateTime" + counter.ToString(),
                    Text = stat.Datum.ToString("dd.MM.yyyy HH:mm:ss"),
                    Location = new Point(300, 12),
                    ForeColor = Color.White,
                    Font = new Font("Century Gothic", 12),
                    AutoSize = true,
                };

                PictureBox pictureBoxExport = new PictureBox
                {
                    Name = "PbExport" + counter.ToString(),
                    Size = new Size(32, 32),
                    Location = new Point(520, 9),
                    Image = Resources.export,
                    Cursor = Cursors.Hand
                };

                pictureBoxExport.Click += delegate
                {
                    PictureBoxExport_Click(stat);
                };

                PictureBox pictureBoxDetails = new PictureBox
                {
                    Name = "PbDetalis" + counter.ToString(),
                    Size = new Size(32, 32),
                    Location = new Point(580, 9),
                    Image = Resources.details,
                    Cursor = Cursors.Hand
                };

                pictureBoxDetails.Click += delegate
                {
                    PictuteBoxDetails_Click(stat);
                };

                PictureBox pictureBoxDelete = new PictureBox
                {
                    Name = "PbDelete" + counter.ToString(),
                    Size = new Size(32, 32),
                    Location = new Point(640, 9),
                    Image = Resources.delete,
                    Cursor = Cursors.Hand
                };

                pictureBoxDelete.Click += delegate
                {
                    PictureBoxDelete_Click(stat);
                };

                panel.Controls.AddRange(new Control[]
                {
                        label,
                        dateTimeLabel,
                        pictureBoxExport,
                        pictureBoxDetails,
                        pictureBoxDelete
                });

                FlStats.Controls.Add(panel);
                counter++;
            });
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StatsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void Izvoz(Guid id)
        {
            string connectionString = Settings.Default.DatabaseConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = string.Format("SELECT RedniBroj,Prihodi,Rezije,Prehrana,Internet,Transport,Osiguranje,Ostalo FROM MjesecniZapis WHERE Id_Statistike = '{0}' ORDER BY RedniBroj", id.ToString());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlDataAdapter.Dispose();
            sqlConnection.Close();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx"
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = AppDomain.CurrentDomain.GetData("DataDirectory").ToString() + @"\Resources\pattern.xlsx";
                    XLWorkbook workbook = new XLWorkbook(path);
                    workbook.TryGetWorksheet("Sheet1", out IXLWorksheet worksheet);
                    worksheet.Cell(1, 1).InsertTable(dataTable);
                    workbook.SaveAs(saveFileDialog.FileName);

                    MessageBox.Show("Izvoz je završen!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
