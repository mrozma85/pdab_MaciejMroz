using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class ZmianyCenTowarowForAllView
    {
        public int IdZmianaCenyTowaru { get; set; }
        public int? IdJednostkiMiaryTowaru { get; set; }
        public DateTime? DataCzasObowiazywaniaOd { get; set; }
        public DateTime? DataCzasObowiazywaniaDo { get; set; }
        public int? CenaNettoSprzedazyTowaru { get; set; }
    }
}
