using SeminarskiRad.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskiRad
{
    public class Statistika
    {
        public Statistika()
        {
            Id = Guid.NewGuid();
        }

        public Statistika(Guid id, string naziv, int godina)
        {
            Id = id;
            Naziv = naziv;
            Godina = godina;
        }

        public Statistika(string naziv, int godina, List<MjesecniZapis> mjesecniZapisi)
        {
            Id = Guid.NewGuid();
            Naziv = naziv;
            Godina = godina;
            MjesecniZapisi = mjesecniZapisi;
        }

        public Guid Id { get; set; }

        public string Naziv { get; set; }

        public int Godina { get; set; }

        public DateTime Datum { get; set; }

        public List<MjesecniZapis> MjesecniZapisi { get; set; }

        public double ProsjecanMjesecniPrihod()
        {
            return MjesecniZapisi
                .Where(mj  => mj.Prihodi != 0)
                .Average(mj => mj.Prihodi);
        }

        public double NajvisiMjesecniPrihod()
        {
            return MjesecniZapisi
                .Where(mj => mj.Prihodi != 0)
                .Max(mj => mj.Prihodi);
        }

        public double NajniziMjesecniPrihod()
        {
            return MjesecniZapisi
                .Where(mj => mj.Prihodi != 0)
                .Min(mj => mj.Prihodi);
        }

        public double UkupanGodisnjiPrihod()
        {
            return MjesecniZapisi
                .Sum(mj => mj.Prihodi);
        }

        public double UkupanGodisnjiTrosak()
        {
            return MjesecniZapisi
                .Sum(mj => mj.UkupanTrosak());
        }

        public double ProsjecanMjesecniTrosak()
        {
            return MjesecniZapisi
                .Where(mj => mj.UkupanTrosak() != 0)
                .Average(mj => mj.UkupanTrosak());
        }

        public double NajniziMjesecniTrosak()
        {
            return MjesecniZapisi
                .Where(mj => mj.UkupanTrosak() != 0)
                .Min(mj => mj.UkupanTrosak());
        }

        public double NajvisiMjesecniTrosak()
        {
            return MjesecniZapisi
                .Where(mj => mj.UkupanTrosak() != 0)
                .Max(mj => mj.UkupanTrosak());
        }

        public string OdnosPrihodaITroskova()
        {
            int ukupanPrihod = (int)Math.Round(MjesecniZapisi
                .Max(mj => mj.Prihodi), MidpointRounding.AwayFromZero);
            int ukupanTrosak = (int)Math.Round(MjesecniZapisi
                .Max(mj => mj.UkupanTrosak()), MidpointRounding.AwayFromZero);
            int djeljitelj = NajveciZajednickiDjelitelj(ukupanPrihod, ukupanTrosak);

            return string.Format("{0}:{1}", ukupanPrihod / djeljitelj, ukupanTrosak / djeljitelj);
        }

        private int NajveciZajednickiDjelitelj(int djeljenik, int djelitelj)
        {
            if (djelitelj == 0)
            {
                return djeljenik;
            }
            else
            {
                return NajveciZajednickiDjelitelj(djelitelj, djeljenik % djelitelj);
            }
        }

        public string ZastupljenostPoKategorijama()
        {
            double ukupanTrosak = UkupanGodisnjiTrosak();
            double ukupanTrosakNajma = MjesecniZapisi.Sum(mj => mj.Najam);
            double ukupanTrosakRezija = MjesecniZapisi.Sum(mj => mj.Rezije);
            double ukupanTrosakPrehrane = MjesecniZapisi.Sum(mj => mj.Prehrana);
            double ukupanTrosakInterneta = MjesecniZapisi.Sum(mj => mj.Internet);
            double ukupanTrosakTransporta = MjesecniZapisi.Sum(mj => mj.Transport);
            double ukupanTrosakOsiguranja = MjesecniZapisi.Sum(mj => mj.Osiguranje);
            double ukupanTrosakOstalog = MjesecniZapisi.Sum(mj => mj.Ostalo);

            Dictionary<string, double> troskovi = new Dictionary<string, double>()
            {
                { "Udio troška najma: ", ukupanTrosakNajma },
                { "Udio troška režija: ", ukupanTrosakRezija  },
                { "Udio troška prehrane: ", ukupanTrosakPrehrane },
                { "Udio troška interneta: ", ukupanTrosakInterneta },
                { "Udio troška transporta: ", ukupanTrosakTransporta },
                { "Udio troška osiguranja: ", ukupanTrosakOsiguranja },
                { "Udio ostalih troškova: ", ukupanTrosakOstalog}
            };

            troskovi = troskovi.OrderByDescending(tr => tr.Value)
                .ToDictionary(tr => tr.Key, tr => tr.Value);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (KeyValuePair<string, double> par in troskovi)
            {
                if (par.Value != 0)
                {
                    stringBuilder.AppendLine(par.Key + Math.Round(par.Value / ukupanTrosak * 100, 2).ToString() + " %");
                }
            }

            return stringBuilder.ToString();
        }

        public string Ispis()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Prihodi: ");
            stringBuilder.AppendLine("Prosiječni mjesečni prihod: " + Math.Round(ProsjecanMjesecniPrihod(), 2));
            stringBuilder.AppendLine("Minimalni mjesečni prihod: " + Math.Round(NajniziMjesecniPrihod()));
            stringBuilder.AppendLine("Maksimalan mjesečni prihod: " + Math.Round(NajvisiMjesecniPrihod()));
            stringBuilder.AppendLine("Ukupan godišnji prihod: " + Math.Round(UkupanGodisnjiPrihod()));
            stringBuilder.AppendLine("--------------------------------");
            stringBuilder.AppendLine("Troškovi: ");
            stringBuilder.AppendLine("Prosječni mjesečni trošak: " + Math.Round(ProsjecanMjesecniTrosak()));
            stringBuilder.AppendLine("Minimalna mjesečna potrošnja: " + Math.Round(NajniziMjesecniTrosak()));
            stringBuilder.AppendLine("Maksimalan mjesečni trošak: " + Math.Round(NajvisiMjesecniTrosak()));
            stringBuilder.AppendLine("Ukupna godišnja potrošnja: " + Math.Round(UkupanGodisnjiTrosak()));
            stringBuilder.AppendLine("Omjer prihoda i troškova: " + OdnosPrihodaITroskova());
            stringBuilder.AppendLine("--------------------------------");
            stringBuilder.AppendLine("Zastupljenost po kategorijama: ");
            stringBuilder.AppendLine(ZastupljenostPoKategorijama());

            return stringBuilder.ToString();
        }

        public void Izbrisi()
        {
            string connectionString = Settings.Default.DatabaseConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = string.Format("DELETE FROM Statistika WHERE Id = '{0}'", Id.ToString());
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
