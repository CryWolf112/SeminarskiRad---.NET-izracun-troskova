using SeminarskiRad.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRad
{
    public partial class DetailsForm : Form
    {
        private readonly Statistika Statistika;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public DetailsForm(Statistika statistika)
        {
            InitializeComponent();

            Statistika = statistika;
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            LbPodaci.Text = Statistika.Ispis();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            StatsForm.MainForm.Close();
            Close();
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            StatsForm.MainForm.PrikaziStatistike();
            StatsForm.MainForm.Show();
            Close();
        }

        private void BtnIzbrisi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite izbrisati statistiku?", "Brisanje statistike", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Statistika.Izbrisi();
                StatsForm.MainForm.PrikaziStatistike();
                StatsForm.MainForm.Show();
                Close();
            }
        }

        private void DetailsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnIzvezi_Click(object sender, EventArgs e)
        {
            StatsForm.MainForm.Izvoz(Statistika.Id);
        }
    }
}
