using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class FakturaForAllView
    {
        public int IdFaktury { get; set; }
        public string Numer { get; set; }
        public DateTime? DataCzasWystawienia { get; set; }
        public string LokalizacjaNazwa { get; set; }
        public string KontrahentNazwa { get; set; }
        public string KontrahentNip { get; set; }
        public string KontrahentAdres { get; set; }
        public DateTime? TerminPlatności { get; set; }
        public string FormaPlatnosciNazwa { get; set; }
    }
}
