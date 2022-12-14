//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Firma.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class StawkiVatZakupu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StawkiVatZakupu()
        {
            this.PozycjaPrzyjeciaZewnetrznegoTowaru = new HashSet<PozycjaPrzyjeciaZewnetrznegoTowaru>();
        }
    
        public int IdStawkiVatZakupu { get; set; }
        public string Nazwa { get; set; }
        public Nullable<int> Wartosc { get; set; }
        public Nullable<int> IdPracownikaDodajacego { get; set; }
        public Nullable<int> IdPracownikaModyfikujacego { get; set; }
        public Nullable<System.DateTime> DataCzasDodania { get; set; }
        public Nullable<System.DateTime> DataCzasModyfikacji { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PozycjaPrzyjeciaZewnetrznegoTowaru> PozycjaPrzyjeciaZewnetrznegoTowaru { get; set; }
    }
}
