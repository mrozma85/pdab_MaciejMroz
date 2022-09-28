using Firma.Model.Entities;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class NowaFormaPlatnosciViewModel : JedenViewModel<FormaPlatnosci>
    {
        #region Constructor
        public NowaFormaPlatnosciViewModel()
            : base("Nowa forma platnosci")
        {
            item = new FormaPlatnosci();
        }
        #endregion
        #region Properties
        public int IdFormyPlatnosci
        {
            get
            {
                return item.IdFormyPlatnosci;
            }
            set
            {
                if (item.IdFormyPlatnosci != value)
                {
                    item.IdFormyPlatnosci = value;
                    base.OnPropertyChanged(() => IdFormyPlatnosci);
                }
            }
        }
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
        #endregion
        #region Helpers
        public override void Save()
        {
            pdabEntities.FormaPlatnosci.Add(item);
            pdabEntities.SaveChanges();
        }
        #endregion
    }
}