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
    public class WszystkieJednostkiMiaryTowaryViewModel : WszystkieViewModel<JednostkiForAllView>
    {
        #region Constructor
        public WszystkieJednostkiMiaryTowaryViewModel()
            : base("Jednostki")
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
            List = new ObservableCollection<JednostkiForAllView>
                (
                     from jednostka in pdab.JednostkaMiaryTowaru
                     select new JednostkiForAllView
                     {
                         Nazwa = jednostka.Nazwa,
                         Opis = jednostka.Opis,
                         Parametry = jednostka.Parametry,
                     }
                );
        }
        #endregion
    }
}
