using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace patrolPumpApp.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string CarNo { get; set; }
        public Item Item { get; set; }
        public double Unit  { get; set; }
        public double Amount  { get; set; }
        public DateTime SellDate  { get; set; }


        public Sale()
        {
            this.Item =  new Item();
        }

    }
}