using System;
using System.Collections.Generic;
using System.Text;

namespace S2011_1._0
{
    public class Timetable
    {
        public String BlNo { get; set; }
        public String DNo { get; set; }
        public String BNo { get; set; }
        public String FirstLaunch { get; set; }

        public void SetValue(String a, String b, String c, String d)
        {
            this.BlNo = a;
            this.DNo = b;
            this.BNo = c;
            this.FirstLaunch = d;
        }
    }
}
