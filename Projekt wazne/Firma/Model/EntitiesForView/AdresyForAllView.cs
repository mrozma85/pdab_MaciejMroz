using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class AdresyForAllView
    {
        public int IdAdresu { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string NrLokalu { get; set; }
        public string Kod { get; set; }
        public string Miasto { get; set; }
        public string Poczta { get; set; }
        public int IdPracownikaModyfikujacego { get; set; }
        public DateTime DataCzasModyfikacji { get; set; }
        public string Uwagi { get; set; }
        public bool CzyAktywny { get; set; }
    }
}
