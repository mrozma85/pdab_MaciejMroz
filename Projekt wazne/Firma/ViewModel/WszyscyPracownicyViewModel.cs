using Firma.Helpers;
using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModel
{
    public class WszyscyPracownicyViewModel : WszystkieViewModel<PracownicyForAllView>
    {
        #region Constructor
        private BaseCommand _CreateDodajPracownikaCommand;
        public WszyscyPracownicyViewModel()
            : base("Adresy")
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
            List = new ObservableCollection<PracownicyForAllView>
                (
                     from pracownicy in pdab.Pracownicy
                     select new PracownicyForAllView
                     {
                         IdPracownika = pracownicy.IdPracownika,
                         Imie = pracownicy.Imie,
                         Nazwisko = pracownicy.Nazwisko,
                         Login = pracownicy.Login,
                         DataZatrudnienia = pracownicy.DataUrodzenia
                     }
                );
        }
        #endregion
    }
}