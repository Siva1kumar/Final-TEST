using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvcdress.Models
{
    
    
        public partial class Mall
        {
            public int Mall_id { get; set; }
            public string Mall_name { get; set; }
            public string dress_type { get; set; }
            public decimal dress_price { get; set; }
            public string dress_size { get; set; }
        }
    
}