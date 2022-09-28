using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.EntitiesForView
{
    public class PracownicyForAllView
    {
        public int IdPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public DateTime? DataUrodzenia { get; set; }
        public DateTime? DataZatrudnienia { get; set; }
    }
}
