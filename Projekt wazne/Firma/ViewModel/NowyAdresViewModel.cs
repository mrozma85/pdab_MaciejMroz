using Firma.Model.Entities;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class NowyAdresViewModel : JedenViewModel<Adres>
    {
        #region Constructor
        public NowyAdresViewModel()
            : base("Nowy adres")
        {
            item = new Adres();
        }
        #endregion
        #region Properties
        public string Miejscowosc
        {
            get
            {
                return item.Miejscowosc;
            }
            set
            {
                if (item.Miejscowosc != value)
                {
                    item.Miejscowosc = value;
                    base.OnPropertyChanged(() => Miejscowosc);
                }
            }
        }
        public string Ulica
        {
            get
            {
                return item.Ulica;
            }
            set
            {
                if (item.Ulica != value)
                {
                    item.Ulica = value;
                    base.OnPropertyChanged(() => Ulica);
                }
            }
        }
        public string NrDomu
        {
            get
            {
                return item.NrDomu;
            }
            set
            {
                if (item.NrDomu != value)
                {
                    item.NrDomu = value;
                    base.OnPropertyChanged(() => NrDomu);
                }
            }
        }
        public string NrLokalu
        {
            get
            {
                return item.NrLokalu;
            }
            set
            {
                if (item.NrLokalu != value)
                {
                    item.NrLokalu = value;
                    base.OnPropertyChanged(() => NrLokalu);
                }
            }
        }
        public string Kod
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
        public string Miasto
        {
            get
            {
                return item.Miasto;
            }
            set
            {
                if (item.Miasto != value)
                {
                    item.Miasto = value;
                    base.OnPropertyChanged(() => Miasto);
                }
            }
        }
        public string Poczta
        {
            get
            {
                return item.Poczta;
            }
            set
            {
                if (item.Poczta != value)
                {
                    item.Poczta = value;
                    base.OnPropertyChanged(() => Poczta);
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
            pdabEntities.Adres.Add(item);
            pdabEntities.SaveChanges();
        }
        #endregion
    }
}