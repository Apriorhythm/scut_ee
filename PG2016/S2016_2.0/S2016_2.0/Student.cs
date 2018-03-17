using System;
using System.Collections.Generic;
using System.Text;

namespace S2016_2._0
{
    public class Student
    {
        public String SNo { get; set; }
        public String SName { get; set; }
        public String Date { get; set; }
        public String classNo { get; set; }


        public void SetValue(String a, String b, String c, String d)
        {
            this.SNo = a;
            this.SName = b;
            this.Date = c;
            this.classNo = d;
        }
    }
}
