using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace patrolPumpApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
    }
}