using System;
using System.Collections.Generic;
using System.Text;

namespace S2017_4._0
{
    public class Group
    {
        public String GroupNo { get; set; }
        public String GroupName { get; set; }
        public String DeptNo { get; set; }
        public String Month { get; set; }
        public String Number { get; set; }

        public void SetValue(String a, String b, String c, String d, String e)
        {
            this.GroupNo = a;
            this.GroupName = b;
            this.DeptNo = c;
            this.Month = d;
            this.Number = e;
        }

    }
}
