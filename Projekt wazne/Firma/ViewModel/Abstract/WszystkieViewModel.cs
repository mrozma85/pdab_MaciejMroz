using Firma.Helpers;
using Firma.Model.Entities;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModel.Abstract
{
    public abstract class WszystkieViewModel<T> : WorkspaceViewModel
    {
        #region Fields
        protected readonly PDABEntities1 pdab;
        private BaseCommand _LoadCommand;
        private BaseCommand _AddCommand;
        private BaseCommand _SortCommand;
        private BaseCommand _FindCommand;
        private ObservableCollection<T> _List;
        #endregion
        #region Properties
        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new BaseCommand(() => Load());
                }
                return _LoadCommand;
            }
        }
        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand == null)
                {
                    _AddCommand = new BaseCommand(() => Add());
                }
                return _AddCommand;
            }
        }
        //sortowanie
        public string SortField { get; set; }
        public List<string> SortComboboxItems
        {
            get
            {
                return getComboboxSortList();
            }
        }
        public ICommand SortCommand
        {
            get
            {
                if (_SortCommand == null)
                {
                    _SortCommand = new BaseCommand(() => Sort());
                }
                return _SortCommand;
            }
        }
        //filtrowanie
        public string FindField { get; set; }
        public List<string> FindComboboxItems
        {
            get
            {
                return getComboboxFindList();
            }
        }
        public ICommand FindCommand
        {
            get
            {
                if (_FindCommand == null)
                {
                    _FindCommand = new BaseCommand(() => Find());
                }
                return _FindCommand;
            }
        }

        public string FindTextBox { get; set; }

        public ObservableCollection<T> List
        {
            get
            {
                if (_List == null)
                    Load();
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }
        #endregion
        #region Constructor
        public WszystkieViewModel(String displayName)
        {
            base.DisplayName = displayName;
            pdab = new PDABEntities1();
        }
        #endregion
        #region Helpers
        public abstract void Load();
        private void Add()
        {
            Messenger.Default.Send(DisplayName + " Add");
        }
        public abstract void Sort();
        public abstract List<string> getComboboxSortList();
        public abstract void Find();
        public abstract List<string> getComboboxFindList();
        #endregion

    }
}