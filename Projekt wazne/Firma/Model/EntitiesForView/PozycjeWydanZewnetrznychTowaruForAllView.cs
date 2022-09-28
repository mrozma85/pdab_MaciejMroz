using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class PozycjeWydanZewnetrznychTowaruForAllView
    {
        public int IdPozycjiWydaniaZewnetrznego { get; set; }
        public int? IdWydaniaZewnetrzenegoTowaru { get; set; }
        public int? IdTowarJednostkiMiaryTowaru { get; set; }
        public double? Ilosc { get; set; }
        public int? IdLokalizacji { get; set; }
        public int? IdPracownikaDodajacego { get; set; }
        public DateTime? DataCzasDodania { get; set; }
        public int? IdPracownikaModyfikujacego { get; set; }
        public DateTime? DataCzasModyfikacji { get; set; }
        public int? IdPracownikaKasujacego { get; set; }
        public DateTime? DataCzasKasowania { get; set; }
        public string Uwagi { get; set; }
        public bool? CzyAktywny { get; set; }
        public int? IdProduktu { get; set; }
    }
}
