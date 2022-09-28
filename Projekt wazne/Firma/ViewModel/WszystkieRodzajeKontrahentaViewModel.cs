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
    public class WszystkieRodzajeKontrahentaViewModel : WszystkieViewModel<Rodzaj1KontrahentaForAllView>
    {
        #region Constructor
        public WszystkieRodzajeKontrahentaViewModel()
            : base("Rodzaje kontrahentow")
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
            List = new ObservableCollection<Rodzaj1KontrahentaForAllView>
                (
                    from rodzajKontrahenta in pdab.RodzajKontrahenta
                    select new Rodzaj1KontrahentaForAllView
                    {
                        IdRodzajKontrahenta = rodzajKontrahenta.IdRodzajKontrahenta,
                    }
                );
        }
        #endregion
    }
}