using System;
using System.Collections.Generic;
using System.Text;

namespace S2013
{
    public class Teacher
    {
        public String TNo { get; set; }
        public String TName { get; set; }
        public String Gender { get; set; }

        public void SetValue(String a, String b, String c)
        {
            this.TNo = a;
            this.TName = b;
            this.Gender = c;
        }
    }
}
