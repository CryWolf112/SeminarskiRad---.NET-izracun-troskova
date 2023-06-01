using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRad
{
    public partial class StatForm : Form
    {
        private readonly Statistika Statistika = new Statistika();

        private int PageNumber = 0;

        private int LimitMjeseci;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public StatForm()
        {
            InitializeComponent();
        }
        private void StatForm_Load(object sender, EventArgs e)
        {
            Statistika.MjesecniZapisi = new List<MjesecniZapis>();

            List<int> godine = new List<int>();
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 20; i--)
            {
                godine.Add(i);
            }

            CbGodina.DataSource = godine;

            PnlDefault.BringToFront();
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite izaći? Trenutna statistika neće biti spremljena.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                StatsForm.MainForm.Show();
                Close();
            }
        }

        private void BtnSljedeca_Click(object sender, EventArgs e)
        {
            if (PageNumber == 0)
            {
                Statistika.Naziv = TbNaziv.Text;
                Statistika.Godina = Convert.ToInt32(CbGodina.Text);

                if (Statistika.Godina == DateTime.Now.Year)
                {
                    LimitMjeseci = DateTime.Now.Month - 1;
                }
                else
                {
                    LimitMjeseci = 12;
                }

                PnlAdd.BringToFront();
                BtnPrethodna.Show();
            }
            else
            {
                MjesecniZapis mjesecniZapis = new MjesecniZapis(
                    PageNumber,
                    !string.IsNullOrEmpty(TbPrihodi.Text) ? double.Parse(TbPrihodi.Text) : 0,
                    !string.IsNullOrEmpty(TbNajam.Text) ? double.Parse(TbNajam.Text) : 0,
                    !string.IsNullOrEmpty(TbRezije.Text) ? double.Parse(TbRezije.Text) : 0,
                    !string.IsNullOrEmpty(TbPrehrana.Text) ? double.Parse(TbPrehrana.Text) : 0,
                    !string.IsNullOrEmpty(TbInternet.Text) ? double.Parse(TbInternet.Text) : 0,
                    !string.IsNullOrEmpty(TbTransport.Text) ? double.Parse(TbTransport.Text) : 0,
                    !string.IsNullOrEmpty(TbOsiguranje.Text) ? double.Parse(TbOsiguranje.Text) : 0,
                    !string.IsNullOrEmpty(TbOstalo.Text) ? double.Parse(TbOstalo.Text) : 0);

                foreach (TextBox tb in PnlAdd.Controls.OfType<TextBox>())
                {
                    tb.Clear();
                }

                if (Statistika.MjesecniZapisi.Count < PageNumber)
                {
                    Statistika.MjesecniZapisi.Add(mjesecniZapis);
                }
                else
                {
                    MjesecniZapis postojeciMjesecniZapis = Statistika.MjesecniZapisi[PageNumber - 1];
                    
                    if (!postojeciMjesecniZapis.Equals(mjesecniZapis))
                    {
                        Statistika.MjesecniZapisi[PageNumber - 1] = mjesecniZapis;
                    } 

                    
                    if (Statistika.MjesecniZapisi.ElementAtOrDefault(PageNumber) != null)
                    {
                        MjesecniZapis sljedeciMjesecniZapis = Statistika.MjesecniZapisi[PageNumber];
                        TbPrihodi.Text = sljedeciMjesecniZapis.Prihodi.ToString();
                        TbNajam.Text = sljedeciMjesecniZapis.Najam.ToString();
                        TbRezije.Text = sljedeciMjesecniZapis.Rezije.ToString();
                        TbPrehrana.Text = sljedeciMjesecniZapis.Prehrana.ToString();
                        TbInternet.Text = sljedeciMjesecniZapis.Internet.ToString();
                        TbTransport.Text = sljedeciMjesecniZapis.Transport.ToString();
                        TbOsiguranje.Text = sljedeciMjesecniZapis.Osiguranje.ToString();
                        TbOstalo.Text = sljedeciMjesecniZapis.Ostalo.ToString();
                    }
                }

                if (PageNumber == LimitMjeseci - 1)
                {
                    BtnSljedeca.Text = "Završi";
                }
                else if (PageNumber == LimitMjeseci)
                {
                    string connectionString = Properties.Settings.Default.DatabaseConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();

                    string query = string.Format("INSERT INTO Statistika (Id, Naziv, Godina, Datum) VALUES ('{0}','{1}',{2},'{3}')",
                        Statistika.Id.ToString(), Statistika.Naziv, Statistika.Godina, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();

                    Statistika.MjesecniZapisi.ForEach(mj =>
                    {
                        query = string.Format("INSERT INTO MjesecniZapis (Id, RedniBroj, Prihodi, Najam, Rezije, Prehrana, Internet, Transport, Osiguranje, Ostalo, Id_Statistike) VALUES ('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},'{10}')",
                            mj.Id.ToString(), mj.RedniBroj, mj.Prihodi, mj.Najam, mj.Rezije, mj.Prehrana, mj.Internet, mj.Transport, mj.Osiguranje, mj.Ostalo, Statistika.Id);

                        sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                    });

                    sqlConnection.Close();

                    DetailsForm detailsForm = new DetailsForm(Statistika);
                    detailsForm.Show();

                    Close();
                }
            }

            PageNumber++;
            LbMonth.Text = string.Format("{0}, {1}.", CultureInfo.GetCultureInfo("hr-HR").DateTimeFormat.GetMonthName(PageNumber), Statistika.Godina);
        }

        private void BtnPrethodna_Click(object sender, EventArgs e)
        {
            if (PageNumber == 1)
            {
                PnlDefault.BringToFront();
                BtnPrethodna.Hide();
            }
            else
            {
                MjesecniZapis postojeciMjesecniZapis = Statistika.MjesecniZapisi[PageNumber - 2];
                TbPrihodi.Text = postojeciMjesecniZapis.Prihodi.ToString();
                TbNajam.Text = postojeciMjesecniZapis.Najam.ToString();
                TbRezije.Text = postojeciMjesecniZapis.Rezije.ToString();
                TbPrehrana.Text = postojeciMjesecniZapis.Prehrana.ToString();
                TbInternet.Text = postojeciMjesecniZapis.Internet.ToString();
                TbTransport.Text = postojeciMjesecniZapis.Transport.ToString();
                TbOsiguranje.Text = postojeciMjesecniZapis.Osiguranje.ToString();
                TbOstalo.Text = postojeciMjesecniZapis.Ostalo.ToString();

                BtnSljedeca.Text = "Sljedeća";
                LbMonth.Text = string.Format("{0}, {1}.", CultureInfo.GetCultureInfo("hr-HR").DateTimeFormat.GetMonthName(PageNumber - 1), Statistika.Godina);
            }

            PageNumber--;
        }

        private void TbNaziv_TextChanged(object sender, EventArgs e)
        {
            if (TbNaziv.Text.Length > 0)
            {
                BtnSljedeca.Show();
            }
            else
            {
                BtnSljedeca.Hide();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            StatsForm.MainForm.Close();
            Close();
        }

        private void StatForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && (e.KeyChar != '.' || tb.Text.Count(ch => ch == '.') > 0))
            {
                e.Handled = true;
            }
        }
    }
}
