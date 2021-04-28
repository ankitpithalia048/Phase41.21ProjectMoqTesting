using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSchoolData
{
    public class SubjectCrud
    {

        //Subject
        List<Subject> subject = new List<Subject>()
        {
            new Subject(){SubjectCode = "100", SubjectName= "Maths"},
            new Subject(){SubjectCode = "110", SubjectName= "Physics"},

        };


        /* ======================================= Subject Starting===========================================*/

        //Add Subject
        public int AddSubject(string Subjectname, string code)
        {
            Subject s1 = new Subject() { SubjectName = Subjectname, SubjectCode = code };
            subject.Add(s1);

            return subject.Count;
        }

        //Get Subject
        public int GetSubject()
        {
            return subject.Count;
        }

        //Update Subject
        public string UpdateSubject(string name)
        {

            var res = subject.Exists(x => x.SubjectName == name);
            if (res)
            {
                var s = subject.Find(x => x.SubjectName.Contains(name));
                subject.Remove(s);
                subject.Insert(0, new Subject() { SubjectName = "Maths", SubjectCode = "101" });
                var res1 = subject.Exists(x => x.SubjectCode == "101");
                if (res1)
                {
                    return "Value Updated";
                }
                return "Not updated";

            }
            return "Invalid name";

        }
    }
}
