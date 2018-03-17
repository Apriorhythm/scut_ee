using System;
using System.Collections.Generic;
using System.Text;

namespace S2011_1._0
{
    public class Busline
    {
        public String BlNo { get; set; }
        public String Start { get; set; }
        public String End { get; set; }
        public String Distance { get; set; }

        public void SetValue(String a, String b, String c, String d)
        {
            this.BlNo = a;
            this.Start = b;
            this.End = c;
            this.Distance = d;
        }
    }
}
