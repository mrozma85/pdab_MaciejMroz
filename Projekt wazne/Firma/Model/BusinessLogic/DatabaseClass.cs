using Firma.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.BusinessLogic
{
    public class DatabaseClass
    {
        #region
        protected readonly PDABEntities1 pdab;
        #endregion
        #region Constructor
        public DatabaseClass(PDABEntities1 pdab)
        {
            this.pdab = pdab;
        }
        #endregion
    }
}
