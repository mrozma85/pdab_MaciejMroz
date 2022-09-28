using Firma.Helpers;
using Firma.Model.BusinessLogic;
using Firma.Model.Entities;
using Firma.Model.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModel
{
    public class RaportPrzyjecTowarowViewModel : WorkspaceViewModel
    {
        
        #region Constructor
        public RaportPrzyjecTowarowViewModel()
        {
            base.DisplayName = "Raport przyjec";
            pdab = new PDABEntities1();
            DataOd = DateTime.Now;
            DataDo = DateTime.Now;
            Suma = 0;
        }
        #endregion
        #region Fields and properties
        private PDABEntities1 pdab;
        private DateTime _DataOd;
        public DateTime DataOd
        {
            get
            {
                return _DataOd;
            }
            set
            {
                if(_DataOd != value)
                {
                    _DataOd = value;
                    OnPropertyChanged(() => DataOd);
                }
            }
        }
        private DateTime _DataDo;
        public DateTime DataDo
        {
            get
            {
                return _DataDo;
            }
            set
            {
                if (_DataDo != value)
                {
                    _DataDo = value;
                    OnPropertyChanged(() => DataDo);
                }
            }
        }
        private int _IdProduktu;
        public int IdProduktu
        {
            get
            {
                return _IdProduktu;
            }
            set
            {
                if (_IdProduktu != value)
                {
                    _IdProduktu = value;
                    OnPropertyChanged(() => IdProduktu);
                }
            }
        }
        private Decimal? _Suma;
        public Decimal? Suma
        {
            get
            {
                return _Suma;
            }
            set
            {
                if (_Suma != value)
                {
                    _Suma= value;
                    OnPropertyChanged(() => Suma);
                }
            }
        }
        public IQueryable<KeyAndValue> TowaryComboBoxItems
        {
            get
            {
                return new ProduktA(pdab).GetTowaryKeyAndValue();
            }
        }
        #endregion
        #region Command
        private BaseCommand _WyswietlCommand;
        public ICommand WyswietlCommand
        {
            get
            {
                if (_WyswietlCommand == null)
                    _WyswietlCommand = new BaseCommand(() => wyswietlSumeClick());
                return _WyswietlCommand;
            }
        }
        #endregion
        #region Helpers
        private void wyswietlSumeClick()
        {
            Suma = new PrzyjeciaR(pdab).UtargOkresTowar(IdProduktu, DataOd, DataDo);
        }
        #endregion
    }
}
