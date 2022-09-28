using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class WydanieZewnetrzneTowaruForAllView
    {
        public int IdWydaniaZewnetrznegoTowaru { get; set; }
        public DateTime? DataCzasWydania { get; set; }
        public DateTime? DataCzasZatwierdzenia { get; set; }
        public DateTime? DataCzasOdebrania { get; set; }
        public int? IdPracownikaWystawiajacego { get; set; }
        public int? IdPracownikaZatwierdzajacego { get; set; }
        public int? IdPracownikaWydajacego { get; set; }
        public int? IdKontrahenta { get; set; }
        public string Numer { get; set; }
        public int? IdFaktury { get; set; }
        public string Uwagi { get; set; }
        public bool CzyAktywny { get; set; }
        public int? IdProduktu { get; set; }
    }
}
