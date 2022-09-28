using Firma.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Model.BusinessLogic
{
    public class PrzyjeciaR : DatabaseClass
    {
        #region Constructor
        public PrzyjeciaR(PDABEntities1 pdab)
            : base(pdab)
        {
        }
        #endregion
        #region BusinessFunction
        public decimal? UtargOkresTowar(int IdProduktu, DateTime DataOd, DateTime DataDo)
        {
            return
               (
                    from pozycja in pdab.PozycjaPrzyjeciaZewnetrznegoTowaru
                    where
                        pozycja.IdProduktu == IdProduktu &&
                        pozycja.DataCzasDodania >= DataOd &&
                        pozycja.DataCzasDodania <= DataDo
                    select pozycja.Ilosc*1
                ).Sum();
        }
        #endregion

    }
}
