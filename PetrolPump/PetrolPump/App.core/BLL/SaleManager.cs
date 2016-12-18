using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using patrolPumpApp.App.core.DAL;
using patrolPumpApp.Models;

namespace patrolPumpApp.App.core.BLL
{
    
    public class SaleManager
    {
        private SaleGetway saleGetway =  new SaleGetway();

        public bool Add(Sale sale)
        {
            return saleGetway.Save(sale);
        }
    }
}