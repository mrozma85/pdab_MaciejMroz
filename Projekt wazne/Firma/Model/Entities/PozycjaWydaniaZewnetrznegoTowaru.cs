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
    
    public partial class PozycjaWydaniaZewnetrznegoTowaru
    {
        public int IdPozycjiWydaniaZewnetrznego { get; set; }
        public Nullable<int> IdWydaniaZewnetrzenegoTowaru { get; set; }
        public Nullable<int> IdTowarJednostkiMiaryTowaru { get; set; }
        public Nullable<double> Ilosc { get; set; }
        public Nullable<int> IdLokalizacji { get; set; }
        public Nullable<int> IdPracownikaDodajacego { get; set; }
        public Nullable<System.DateTime> DataCzasDodania { get; set; }
        public Nullable<int> IdPracownikaModyfikujacego { get; set; }
        public Nullable<System.DateTime> DataCzasModyfikacji { get; set; }
        public Nullable<int> IdPracownikaKasujacego { get; set; }
        public Nullable<System.DateTime> DataCzasKasowania { get; set; }
        public string Uwagi { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
        public Nullable<int> IdProduktu { get; set; }
    
        public virtual Towar Towar { get; set; }
        public virtual WydanieZewnetrzneTowaru WydanieZewnetrzneTowaru { get; set; }
    }
}
