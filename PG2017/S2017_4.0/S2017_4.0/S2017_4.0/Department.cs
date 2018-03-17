using System;
using System.Collections.Generic;
using System.Text;

namespace S2017_4._0
{
    public class Department
    {
        String DeptNo { get; set; }
        String DeptName { get; set; }

        public void SetValue(String a, String b)
        {
            this.DeptNo = a;
            this.DeptName = b;
        }

    }
}
