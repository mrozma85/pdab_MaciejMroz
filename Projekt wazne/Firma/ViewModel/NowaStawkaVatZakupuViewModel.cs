using Firma.Model.Entities;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class NowaStawkaVatZakupuViewModel : JedenViewModel<StawkiVatZakupu>
    {
        #region Constructor
        public NowaStawkaVatZakupuViewModel()
            : base("Nowa stawka vat zakupu")
        {
            item = new StawkiVatZakupu();
        }
        #endregion
        #region Properties
        public string Nazwa
        {
            get
            {
                return item.Nazwa;
            }
            set
            {
                if (item.Nazwa != value)
                {
                    item.Nazwa = value;
                    base.OnPropertyChanged(() => Nazwa);
                }
            }
        }
        public int? Wartosc
        {
            get
            {
                return item.Wartosc;
            }
            set
            {
                if (item.Wartosc != value)
                {
                    item.Wartosc = value;
                    base.OnPropertyChanged(() => Wartosc);
                }
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            pdabEntities.StawkiVatZakupu.Add(item);
            pdabEntities.SaveChanges();
        }
        #endregion
    }
}