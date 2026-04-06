using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_Linq
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
