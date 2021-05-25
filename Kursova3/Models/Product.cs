using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursova3.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsPrior { get; set; }
        public bool IsInStorage { get; set; }
    }
}