using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class RodzajKontrahentaForAllView
    {
        public int IdStawkiVatZakupu { get; set; }
        public string Nazwa { get; set; }
        public int? Wartosc { get; set; }
        public int? IdPracownikaDodajacego { get; set; }
        public int? IdPracownikaModyfikujacego { get; set; }
        public DateTime? DataCzasDodania { get; set; }
        public DateTime? DataCzasModyfikacji { get; set; }
        public bool CzyAktywny { get; set; }
    }
}
