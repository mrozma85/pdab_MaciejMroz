using Firma.Model.Entities;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class NowyKontrahent1ViewModel : JedenViewModel<Kontrahent>
    {
        #region Constructor
        public NowyKontrahent1ViewModel()
            : base("Nowy kontrahent")
        {
            item = new Kontrahent();
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
        public string NIP
        {
            get
            {
                return item.NIP;
            }
            set
            {
                if (item.NIP != value)
                {
                    item.NIP = value;
                    base.OnPropertyChanged(() => NIP);
                }
            }
        }
        public string REGON
        {
            get
            {
                return item.REGON;
            }
            set
            {
                if (item.REGON != value)
                {
                    item.REGON = value;
                    base.OnPropertyChanged(() => REGON);
                }
            }
        }
        public string TelefonKomorkowy1
        {
            get
            {
                return item.TelefonKomorkowy1;
            }
            set
            {
                if (item.TelefonKomorkowy1 != value)
                {
                    item.TelefonKomorkowy1 = value;
                    base.OnPropertyChanged(() => TelefonKomorkowy1);
                }
            }
        }
        public string TelefonKomorkowy2
        {
            get
            {
                return item.TelefonKomorkowy2;
            }
            set
            {
                if (item.TelefonKomorkowy2 != value)
                {
                    item.TelefonKomorkowy2 = value;
                    base.OnPropertyChanged(() => TelefonKomorkowy2);
                }
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            pdabEntities.Kontrahent.Add(item);
            pdabEntities.SaveChanges();
        }
        #endregion
    }
}