using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursova3.Models
{
    public class Order
    {
        public Order()
        {
            Guid = Guid.NewGuid();
        }

        public int OrderID { get; set; }
        public Guid Guid { get; set; }
    }
}