using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSchoolData
{
    public class OffsetStudent
    {
        List<Student> s = new List<Student>();
        public virtual List<Student> Get()
        {
            return s;
        }
    }
}
