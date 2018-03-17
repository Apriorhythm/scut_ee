using System;
using System.Collections.Generic;
using System.Text;

namespace S2011_1._0
{
    public class Bus
    {
        public String BNo { get; set; }
        public String Producer { get; set; }

        public void SetValue(String a, String b)
        {
            this.BNo = a;
            this.Producer = b;
        }

    }
}
