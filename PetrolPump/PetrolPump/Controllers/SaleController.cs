using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using patrolPumpApp.App.core.BLL;
using patrolPumpApp.Models;
using PetrolPump.App.core.BLL;

namespace PetrolPump.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale

        ItemManager itemManager =  new ItemManager();
        public ActionResult Index()
        {

            ViewBag.Items = itemManager.GetItemList();
            return View();
        }
        SaleManager saleManager = new SaleManager();
        [HttpPost]
        public void SalePost(Sale sale, string ItemId)
        {
            sale.Item.ItemId = ItemId;
            
            sale.SellDate =DateTime.Now;

            saleManager.Add(sale);





        }
    }
}