using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class TowarForView
    {
        public int IdProduktu { get; set; }
        public int? Kod { get; set; }
        public string Nazwa { get; set; }
        public int? IdPracownikaDodajacego { get; set; }
        public int? IdPracownikaModyfikujacego { get; set; }
        public int? IdPracownikaKasujacego { get; set; }
        public DateTime? DataCZasDodania { get; set; }
        public DateTime? DataCZasModyfikacji { get; set; }
        public DateTime? DataCZasKasownia { get; set; }
        public string Uwagi { get; set; }
        public Boolean CzyAktywny { get; set; }
    }
}
