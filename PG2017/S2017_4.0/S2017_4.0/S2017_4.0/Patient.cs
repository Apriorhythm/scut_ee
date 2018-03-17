using System;
using System.Collections.Generic;
using System.Text;

namespace S2017_4._0
{
    public class Patient
    {
        public String PID { get; set; }
        public String PName { get; set; }
        public String Date { get; set; }
        public String GroupNo { get; set; }

        public void SetValue(String a, String b, String c, String d)
        {
            this.PID = a;
            this.PName = b;
            this.Date = c;
            this.GroupNo = d;
        }

    }
}
