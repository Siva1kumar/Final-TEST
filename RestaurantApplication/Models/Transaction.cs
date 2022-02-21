using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApplication.Models
{
    public class Transaction
    {
         
        public int TransactionId { get; set; }
        public int ItemId { get; set; }
        public decimal Quantity { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public Nullable<int> TypeId { get; set; }
    }
}
