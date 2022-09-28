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
    public class WszystkieStawkiVatZakupuViewModel : WszystkieViewModel<RodzajKontrahentaForAllView>
    {
        #region Constructor
        public WszystkieStawkiVatZakupuViewModel()
            : base("Stawki Vat Zakupu")
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
        List = new ObservableCollection<RodzajKontrahentaForAllView>
            (
                from stawkiVatZakupu in pdab.StawkiVatZakupu
                select new RodzajKontrahentaForAllView
                {
                    Nazwa = stawkiVatZakupu.Nazwa,
                    Wartosc = stawkiVatZakupu.Wartosc,
                    DataCzasDodania = stawkiVatZakupu.DataCzasDodania,
                }
            );
    }
    #endregion
}
}
