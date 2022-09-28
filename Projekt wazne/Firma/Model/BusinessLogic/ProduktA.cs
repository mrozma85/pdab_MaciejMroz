using Firma.Model.Entities;
using Firma.Model.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.BusinessLogic
{
    public class ProduktA : DatabaseClass
    {
        #region Constructor
        public ProduktA(PDABEntities1 pdab) 
            : base(pdab)
        {
        }
        #endregion
        #region GetDataFunction
        public IQueryable<KeyAndValue> GetTowaryKeyAndValue()
        {
            return 
                (
                    from towar in pdab.Towar
                    select new KeyAndValue
                    {
                        Key = towar.IdProduktu,
                        Value = towar.Nazwa
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
