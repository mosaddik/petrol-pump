using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using patrolPumpApp.Models;
using PetrolPump.App.core.DAL;

namespace PetrolPump.App.core.BLL
{
    public class ItemManager
    {
        ItemGetway itemGetway =  new ItemGetway();

        public List<Item> GetItemList()
        {
            return itemGetway.GETALL();
        }
    }
}