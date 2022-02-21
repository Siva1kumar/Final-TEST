using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApplication.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}