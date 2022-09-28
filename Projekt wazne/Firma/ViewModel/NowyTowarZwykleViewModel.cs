using Firma.Model.Entities;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class NowyTowarZwykleViewModel : JedenViewModel<Towar>
    {
        #region Constructor
        public NowyTowarZwykleViewModel()
            : base("Nowy towar")
        {
            item = new Towar();
        }
        #endregion
        #region Properties
        public int? Kod
        {
            get
            {
                return item.Kod;
            }
            set
            {
                if (item.Kod != value)
                {
                    item.Kod = value;
                    base.OnPropertyChanged(() => Kod);
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
        public string Uwagi
        {
            get
            {
                return item.Uwagi;
            }
            set
            {
                if (item.Uwagi != value)
                {
                    item.Uwagi = value;
                    base.OnPropertyChanged(() => Uwagi);
                }
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            pdabEntities.Towar.Add(item);
            //pdabEntities.Configuration.ValidateOnSaveEnabled = false;
            pdabEntities.SaveChanges();
        }
        #endregion
    }
}
