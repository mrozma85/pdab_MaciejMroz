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
    public class WszystkiePozycjeWydanZewnetrznychTowaruViewModel : WszystkieViewModel<PozycjeWydanZewnetrznychTowaruForAllView>
    {
        #region Constructor
        public WszystkiePozycjeWydanZewnetrznychTowaruViewModel()
            : base("Pozycje Wydan Zewnetrznych")
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
            List = new ObservableCollection<PozycjeWydanZewnetrznychTowaruForAllView>
                (
                    from pozycjaWydaniaZewnetrznegoTowaru in pdab.PozycjaWydaniaZewnetrznegoTowaru
                    select new PozycjeWydanZewnetrznychTowaruForAllView
                    {
                        IdWydaniaZewnetrzenegoTowaru = pozycjaWydaniaZewnetrznegoTowaru.IdWydaniaZewnetrzenegoTowaru,
                        IdProduktu = pozycjaWydaniaZewnetrznegoTowaru.IdProduktu,
                        Ilosc = pozycjaWydaniaZewnetrznegoTowaru.Ilosc,
                        IdLokalizacji = pozycjaWydaniaZewnetrznegoTowaru.IdLokalizacji
                    }

                );
        }
        #endregion
    }
}