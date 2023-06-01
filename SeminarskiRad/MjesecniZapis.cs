using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskiRad
{
    public class MjesecniZapis
    {
        public MjesecniZapis() 
        {

        }

        public MjesecniZapis(int redniBroj, double prihodi, double najam, double rezije, double prehrana, double internet, double transport, double osiguranje, double ostalo)
        {
            Id = Guid.NewGuid();
            RedniBroj = redniBroj;
            Prihodi = prihodi;
            Najam = najam;
            Rezije = rezije;
            Prehrana = prehrana;
            Internet = internet;
            Transport = transport;
            Osiguranje = osiguranje;
            Ostalo = ostalo;
        }

        public Guid Id { get; set; }

        public int RedniBroj { get; set; }

        public double Prihodi { get; set; }

        public double Najam { get; set; }

        public double Rezije { get; set; }

        public double Prehrana { get; set; }

        public double Internet { get; set; }

        public double Transport { get; set; }

        public double Osiguranje { get; set; }

        public double Ostalo { get; set; }

        public double UkupanTrosak()
        {
            return Najam + Rezije + Prehrana + Internet + Transport + Osiguranje + Ostalo;
        }

        public override bool Equals(object obj)
        {
            MjesecniZapis mjesecniZapis = (MjesecniZapis)obj;

            return mjesecniZapis.Prihodi.Equals(Prihodi) && mjesecniZapis.Najam.Equals(Najam) &&
                mjesecniZapis.Rezije.Equals(Rezije) && mjesecniZapis.Prehrana.Equals(Prehrana) &&
                mjesecniZapis.Internet.Equals(Internet) && mjesecniZapis.Transport.Equals(Transport) &&
                mjesecniZapis.Osiguranje.Equals(Osiguranje) && mjesecniZapis.Ostalo.Equals(Ostalo);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
