using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApplication.Models
{
    public class Order
    {

  
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int PaymentTypeId { get; set; }
        public decimal FixedTotal { get; set; }

       
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}