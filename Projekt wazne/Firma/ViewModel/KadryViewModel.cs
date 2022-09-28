using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class KadryViewModel : WorkspaceViewModel //Bo wszystkie ViewModele obsługujące zakładki bedą dziedziczyć po WorkspaceViewModel
    {
        #region Constructor
        public KadryViewModel()
        {
            base.DisplayName = "Zarządzanie kadrą"; //Tu decydujemy jak nazywa się zakładka, DisplayName jest odziedziczone z WorkspaceViewModel przez BaseViewModel
        }
        #endregion
    }
}