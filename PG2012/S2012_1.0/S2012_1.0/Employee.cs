using System;
using System.Collections.Generic;
using System.Text;

namespace S2012_1._0
{
    public class Employee
    {
        public String EmpNo { get; set; }
        public String EmpName { get; set; }
        public String Location { get; set; }

        public void SetValue(String a, String b, String c)
        {
            this.EmpNo = a;
            this.EmpName = b;
            this.Location = c;
        }
    }
}
