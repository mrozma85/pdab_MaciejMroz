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
    public class WszystkiePozycjePrzyjecZewnetrznychTowaruViewModel : WszystkieViewModel<PozycjePrzyjecZewnetrznychTowaruForAllView>
    {
        #region Constructor
        public WszystkiePozycjePrzyjecZewnetrznychTowaruViewModel()
            : base("Pozycje Przyjec Zewnetrznych")
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
            List = new ObservableCollection<PozycjePrzyjecZewnetrznychTowaruForAllView>
                (
                from pozycjaPrzyjeciaZewnetrznegoTowaru in pdab.PozycjaPrzyjeciaZewnetrznegoTowaru
                select new PozycjePrzyjecZewnetrznychTowaruForAllView
                {
                    IdProduktu = pozycjaPrzyjeciaZewnetrznegoTowaru.IdProduktu,
                    Ilosc = pozycjaPrzyjeciaZewnetrznegoTowaru.Ilosc,
                    CenaNettoZakupu = pozycjaPrzyjeciaZewnetrznegoTowaru.CenaNettoZakupu,
                    IdStawkiVatZakupu = pozycjaPrzyjeciaZewnetrznegoTowaru.StawkiVatZakupu.Wartosc,
                    DataCzasDodania = pozycjaPrzyjeciaZewnetrznegoTowaru.DataCzasDodania,
                }

                );
        }
        #endregion
    }
}