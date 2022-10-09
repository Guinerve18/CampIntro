using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        public int id { get; set; }
        public int categoryId { get; set; }
        public string? ProductName { get; set; }
        //Birim Fiyatı
        public double unitPrice { get; set; }
        //Stok Adedi
        public int unitsInStock { get; set; }
        
    }
}