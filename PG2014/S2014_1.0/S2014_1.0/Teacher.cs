using System;
using System.Collections.Generic;
using System.Text;

namespace S2014_1._0
{
    public class Teacher
    {
        public String TNo { get; set; }
        public String TName { get; set; }
        public String DeptName { get; set; }
        public String RNo { get; set; }

        public void SetValue(String a, String b, String c, String d)
        {
            this.TNo = a;
            this.TName = b;
            this.DeptName = c;
            this.RNo = d;
        }
    }
}
