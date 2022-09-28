using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class PozycjePrzyjecZewnetrznychTowaruForAllView
    {
        public int IdPozycjiPrzyjeciaZewnetrznegoTowaru { get; set; }
        public int? IdPrzyjeciaZewnetrznego { get; set; }
        public int? IdProduktu { get; set; }
        public int IdTowarJednostkiMiaryTowaru { get; set; }
        public int? Ilosc { get; set; }
        public double? CenaNettoZakupu { get; set; }
        public int? IdStawkiVatZakupu { get; set; }
        public int? IdLokalizacji { get; set; }
        public int? IdPracownikaModyfikujacego { get; set; }
        public DateTime? DataCzasModyfikacji { get; set; }
        public int? IdPracownikaKasujacego { get; set; }
        public DateTime? DataCzasKasowania { get; set; }
        public int? IdPracownikaDodajacego { get; set; }
        public DateTime? DataCzasDodania { get; set; }
        public string Uwagi { get; set; }
        public bool CzyAktywny { get; set; }
    }
}
