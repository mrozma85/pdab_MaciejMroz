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
    public class WszyscyKontrahenciViewModel : WszystkieViewModel<KontrahentForAllView>
    {
        #region Constructor
        public WszyscyKontrahenciViewModel()
            : base("Kontrahenci")
        {
        }
        #endregion
        #region Sort And Find
        public override void Sort()
        {
            if (SortField == "Nazwa")
                List = new ObservableCollection<KontrahentForAllView>(List.OrderBy(item => item.Nazwa));
        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Nazwa"};
        }
        public override void Find()
        {
            if (FindField == "Nazwa")
                List = new ObservableCollection<KontrahentForAllView>(List.Where
                                                        (item => item.Nazwa != null && item.Nazwa.StartsWith(FindTextBox)));
        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Nazwa" }; ;
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<KontrahentForAllView>
                (
                    from kontrahent in pdab.Kontrahent
                    select new KontrahentForAllView
                    {
                        IdKontrahenta = kontrahent.IdKontrahenta,
                        Nazwa = kontrahent.Nazwa,
                        KontrahentNazwa = kontrahent.RodzajKontrahenta.Nazwa,
                    }
                );
        }
        #endregion
    }
}