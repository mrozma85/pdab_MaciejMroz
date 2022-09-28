using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Firma.ViewModel
{
    public class WszystkieTowaryViewModel : WszystkieViewModel<TowarForView>
    {
        #region Constructor
        public WszystkieTowaryViewModel()
            : base("Wszystkie towary")
        {
        }
        #endregion
        #region Sort And Find
        public override void Sort()
        {
            if (SortField == "Nazwa")
                List = new ObservableCollection<TowarForView>(List.OrderBy(item => item.Nazwa));

            if (SortField == "Kod")
                List = new ObservableCollection<TowarForView>(List.OrderBy(item => item.Kod));
        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Nazwa", "Kod"};
        }
        public override void Find()
        {
            if(FindField == "Nazwa")
            List = new ObservableCollection<TowarForView>(List.Where
                                                    (item => item.Nazwa != null && item.Nazwa.StartsWith(FindTextBox)));
        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Nazwa", "Kod" };
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<TowarForView>
                (
                    from towar in pdab.Towar
                    select new TowarForView
                    {
                        IdProduktu = towar.IdProduktu,
                        Kod = towar.Kod,
                        Nazwa = towar.Nazwa,
                        IdPracownikaDodajacego = towar.IdPracownikaDodajacego,
                        IdPracownikaKasujacego = towar.IdPracownikaKasujacego,
                        IdPracownikaModyfikujacego = towar.IdPracownikaModyfikujacego,
                        DataCZasDodania = towar.DataCZasDodania,
                        DataCZasKasownia = towar.DataCzasKasowania,
                        DataCZasModyfikacji = towar.DataCzasModyfikacji,
                        Uwagi = towar.Uwagi,
                        CzyAktywny = towar.CzyAktywny,
                    }
                );
        }
        #endregion
    }
}