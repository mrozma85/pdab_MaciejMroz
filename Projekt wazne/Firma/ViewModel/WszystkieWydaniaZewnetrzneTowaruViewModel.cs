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
    public class WszystkieWydaniaZewnetrzneTowaruViewModel : WszystkieViewModel<WydanieZewnetrzneTowaruForAllView>
    {
        #region Constructor
        public WszystkieWydaniaZewnetrzneTowaruViewModel()
            : base("Wydanie Zewnetrzne")
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
            List = new ObservableCollection<WydanieZewnetrzneTowaruForAllView>
                (
                    from wydanieZewnetrzneTowaru in pdab.WydanieZewnetrzneTowaru
                    select new WydanieZewnetrzneTowaruForAllView
                    {
                        Numer = wydanieZewnetrzneTowaru.Numer,
                        DataCzasWydania = wydanieZewnetrzneTowaru.DataCzasWydania,
                        IdFaktury = wydanieZewnetrzneTowaru.IdFaktury,
                        IdKontrahenta = wydanieZewnetrzneTowaru.IdKontrahenta
                    }
                );
        }
        #endregion


    }
}

