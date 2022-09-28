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
    public class WszystkiePrzyjeciaZewnetrzneTowaruViewModel : WszystkieViewModel<PrzyjeciaZewnetrzneTowaruForAllView>
    {
        #region Constructor
        public WszystkiePrzyjeciaZewnetrzneTowaruViewModel()
            : base("Przyjecia Zewnetrzne")
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
            List = new ObservableCollection<PrzyjeciaZewnetrzneTowaruForAllView>
                (
                    from przyjecieZewnetrzneTowaru in pdab.PrzyjecieZewnetrzneTowaru
                    select new PrzyjeciaZewnetrzneTowaruForAllView
                    {
                        Numer = przyjecieZewnetrzneTowaru.Numer,
                        IdKontrahenta = przyjecieZewnetrzneTowaru.IdKontrahenta,
                        DataCzasPrzyjecia = przyjecieZewnetrzneTowaru.DataCzasPrzyjecia,
                        IdZamowienia = przyjecieZewnetrzneTowaru.IdZamowienia
                    }
                );
        }
        #endregion
    }
}
