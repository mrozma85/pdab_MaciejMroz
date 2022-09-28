using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class KontrahentForAllView
    {
        public int IdKontrahenta { get; set; }
        public string Nazwa { get; set; }
        public int IdGrupy { get; set; }
        public int IdRodzajKontrahenta { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public string TelefonKomorkowy1 { get; set; }
        public string TelefonKomorkowy2 { get; set; }
        public int IdPracownikaModyfikujacego { get; set; }
        public DateTime DataCzasModyfikacji { get; set; }
        public string Uwagi { get; set; }
        public string KontrahentNazwa { get; set; }

    }
}
