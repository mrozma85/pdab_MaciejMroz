using Firma.Model.Entities;
using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class NowyPracownikViewModel : JedenViewModel<Pracownicy>
    {
        #region Constructor
        public NowyPracownikViewModel()
            : base("Nowy pracownik")
        {
            item = new Pracownicy();
        }
        #endregion
        #region Properties
        public string Imie
        {
            get
            {
                return item.Imie;
            }
            set
            {
                if (item.Imie != value)
                {
                    item.Imie = value;
                    base.OnPropertyChanged(() => Imie);
                }
            }
        }
        public string Nazwisko
        {
            get
            {
                return item.Nazwisko;
            }
            set
            {
                if (item.Nazwisko != value)
                {
                    item.Nazwisko = value;
                    base.OnPropertyChanged(() => Nazwisko);
                }
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            pdabEntities.Pracownicy.Add(item);
            pdabEntities.SaveChanges();
        }
        #endregion
    }
}
