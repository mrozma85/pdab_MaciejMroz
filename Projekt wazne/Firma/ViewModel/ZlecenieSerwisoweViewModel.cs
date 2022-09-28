using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    class ZlecenieSerwisoweViewModel : WorkspaceViewModel //Bo wszystkie ViewModele obsługujące zakładki bedą dziedziczyć po WorkspaceViewModel
    {
        #region Constructor
        public ZlecenieSerwisoweViewModel()
        {
            base.DisplayName = "Zlecenie serwisowe"; //Tu decydujemy jak nazywa się zakładka, DisplayName jest odziedziczone z WorkspaceViewModel przez BaseViewModel
        }
        #endregion
    }
}