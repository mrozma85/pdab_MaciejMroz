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
    public class WszystkieZmianyCenTowarowViewModel : WszystkieViewModel<ZmianyCenTowarowForAllView>
    {
        #region Constructor
        public WszystkieZmianyCenTowarowViewModel()
            : base("Zmiany Cen Towarow")
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
            List = new ObservableCollection<ZmianyCenTowarowForAllView>
                (
                    from zmianaCenyTowaru in pdab.ZmianaCenyTowaru
                    select new ZmianyCenTowarowForAllView
                    {
                        IdZmianaCenyTowaru = zmianaCenyTowaru.IdZmianaCenyTowaru,
                        IdJednostkiMiaryTowaru = zmianaCenyTowaru.IdJednostkiMiaryTowaru,
                        CenaNettoSprzedazyTowaru = zmianaCenyTowaru.CenaNettoSprzedazyTowaru,
                        DataCzasObowiazywaniaOd = zmianaCenyTowaru.DataCzasObowiazywaniaOd,
                        DataCzasObowiazywaniaDo = zmianaCenyTowaru.DataCzasObowiazywaniaDo,
                    }
                );
        }
        #endregion
    }
}
