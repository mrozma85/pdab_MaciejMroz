using Firma.Helpers;
using Firma.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModel.Abstract
{
    public abstract class JedenViewModel<T> : WorkspaceViewModel
    {
        #region Fields
        protected PDABEntities1 pdabEntities;
        protected T item;
        #endregion
        #region Constructor
        public JedenViewModel(string displayName)
        {
            base.DisplayName = displayName;
            pdabEntities = new PDABEntities1();
        }
        #endregion
        #region Command
        private BaseCommand _SaveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new BaseCommand(() => SaveAndClose());
                return _SaveCommand;

            }
        }
        #endregion
        #region Helpers
        public abstract void Save();
        private void SaveAndClose()
        {
            Save();
            base.OnRequestClose();
        }
        #endregion
    }
}
