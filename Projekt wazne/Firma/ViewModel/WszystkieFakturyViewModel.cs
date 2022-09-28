using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class WszystkieFakturyViewModel : WszystkieViewModel<FakturaForAllView>
    {
        #region Constructor
        public WszystkieFakturyViewModel()
            : base("Faktury")
        {
        }
        #endregion
        #region Sort And Find
        public override void Sort()
        {

        }
        public override List<string> getComboboxSortList()
        {
            return null;
        }
        public override void Find()
        {

        }
        public override List<string> getComboboxFindList()
        {
            return null;
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<FakturaForAllView>
                (
                    from faktura in pdab.Faktura
                    select new FakturaForAllView
                    {
                        IdFaktury = faktura.IdFaktury,
                        Numer = faktura.Numer,
                        DataCzasWystawienia = faktura.DataCzasWystawienia,
                        KontrahentNazwa = faktura.Kontrahent.Nazwa,
                        KontrahentNip = faktura.Kontrahent.NIP,
                        KontrahentAdres = faktura.Kontrahent.Adres.Miejscowosc + " ul. " + faktura.Kontrahent.Adres.Ulica,
                        TerminPlatności = faktura.TerminPlatnosci,
                        FormaPlatnosciNazwa = faktura.FormaPlatnosci.Nazwa
                    }
                );
        }
        #endregion
    }
}