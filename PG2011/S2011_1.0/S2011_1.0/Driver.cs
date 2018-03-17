using System;
using System.Collections.Generic;
using System.Text;

namespace S2011_1._0
{
    public class Driver
    {
        public String DNo { get; set; }
        public String DName { get; set; }
        public String Gender { get; set; }
        public String Age { get; set; }
        public String Phone { get; set; }
        public String Password { get; set; }

        public void SetValue(String a, String b, String c, String d, String e, String f)
        {
            this.DNo = a;
            this.DName = b;
            this.Gender = c;
            this.Age = d;
            this.Phone = e;
            this.Password = f;
        }
    }
}
