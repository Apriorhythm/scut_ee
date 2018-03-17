using System;
using System.Collections.Generic;
using System.Text;

namespace S2009_1._0
{
    public class Product
    {
        public String ProductID { get; set; }
        public String ProductName { get; set; }
        public String SupplierName { get; set; }

        public void SetValue(String a, String b, String c)
        {
            this.ProductID = a;
            this.ProductName = b;
            this.SupplierName = c;
        }
    }
}
