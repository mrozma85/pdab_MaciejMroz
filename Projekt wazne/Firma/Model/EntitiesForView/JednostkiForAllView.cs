using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class JednostkiForAllView
    {
        public int IdJednostkiMiaryTowaru { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Parametry { get; set; }
        public string Uwagi { get; set; }
        public bool CzyAktywny { get; set; }
    }
}
