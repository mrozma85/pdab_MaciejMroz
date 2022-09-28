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
    public class WszystkieAdresyViewModel : WszystkieViewModel<AdresyForAllView>
    {
        #region Constructor
        public WszystkieAdresyViewModel()
            : base("Adresy")
        {
        }
        #endregion
        #region Sort And Find
        public override void Sort()
        {
            if (SortField == "Miasto")
                List = new ObservableCollection<AdresyForAllView>(List.OrderBy(item => item.Miasto));
            if (SortField == "Kod")
                List = new ObservableCollection<AdresyForAllView>(List.OrderBy(item => item.Kod));
            if (SortField == "Poczta")
                List = new ObservableCollection<AdresyForAllView>(List.OrderBy(item => item.Poczta));
            if (SortField == "Ulica")
                List = new ObservableCollection<AdresyForAllView>(List.OrderBy(item => item.Ulica));
        }
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "Miasto", "Kod", "Poczta", "Ulica" };
        }
        public override void Find()
        {
            if (FindField == "Miasto")
                List = new ObservableCollection<AdresyForAllView>(List.Where
                                                        (item => item.Miasto!= null && item.Miasto.StartsWith(FindTextBox)));
            if (FindField == "Kod")
                List = new ObservableCollection<AdresyForAllView>(List.Where
                                                        (item => item.Kod!= null && item.Kod.StartsWith(FindTextBox)));
            if (FindField == "Poczta")
                List = new ObservableCollection<AdresyForAllView>(List.Where
                                                        (item => item.Poczta!= null && item.Poczta.StartsWith(FindTextBox)));
            if (FindField == "Ulica")
                List = new ObservableCollection<AdresyForAllView>(List.Where
                                                        (item => item.Ulica!= null && item.Ulica.StartsWith(FindTextBox)));
        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Miejscowosc", "Kod", "Poczta", "Ulica" };
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<AdresyForAllView>
                (
                     from adres in pdab.Adres
                     select new AdresyForAllView
                     {
                         Ulica = adres.Ulica,
                         NrDomu = adres.NrDomu,
                         NrLokalu = adres.NrLokalu,
                         Kod = adres.Kod,
                         Miasto = adres.Miasto
                     }
                );
        }
        #endregion
    }
}
