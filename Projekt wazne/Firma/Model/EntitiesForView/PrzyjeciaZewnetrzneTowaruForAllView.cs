using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class PrzyjeciaZewnetrzneTowaruForAllView
    {
        public int IdPrzyjeciaZewnetrznego { get; set; }
        public DateTime? DataCzasPrzyjecia { get; set; }
        public DateTime? DataCzasZatwierdzenia { get; set; }
        public int? IdPracownikaWystawiajacego { get; set; }
        public int? IdPracownikaZatwierdzajacego { get; set; }
        public int? IdPracownikaPrzyjmujacego { get; set; }
        public int? IdKontrahenta { get; set; }
        public int? IdZamowienia { get; set; }
        public string Numer { get; set; }
        public string Uwagi { get; set; }
        public int? IdPracownikaModyfikujacego { get; set; }
        public DateTime? DataCzasModyfikacji { get; set; }
        public bool CzyAktywny { get; set; }
    }
}
