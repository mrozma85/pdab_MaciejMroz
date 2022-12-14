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
    public class WszystkieFormyPlatnosciViewModel : WszystkieViewModel<FormaPlatnosciForAllView>
    {
        #region Constructor
        public WszystkieFormyPlatnosciViewModel()
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
            List = new ObservableCollection<FormaPlatnosciForAllView>
                (
                     from formaPlatnosci in pdab.FormaPlatnosci
                     select new FormaPlatnosciForAllView
                     {
                         IdFormyPlatnosci = formaPlatnosci.IdFormyPlatnosci,
                         Nazwa = formaPlatnosci.Nazwa,
                     }
                );
        }
        #endregion
    }
}
