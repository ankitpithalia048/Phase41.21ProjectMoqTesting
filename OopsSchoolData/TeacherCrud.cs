using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSchoolData
{
    public class TeacherCrud
    {
        //Teacher
        List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher(){Name= "Ezil" , ClassAndSection="10 A"},
            new Teacher(){Name= "Patra" , ClassAndSection="11 A"},

        };

        /*----------------- -----------------------Teacher Starting -----------------------------------------------*/

        //Add Teacher
        public int AddTeacher(string name, string _ClassAndSection)
        {
            Teacher s1 = new Teacher() { Name = name, ClassAndSection = _ClassAndSection };
            teacher.Add(s1);

            return teacher.Count;
        }
        //Get Teacher
        public int GetTeacher()
        {
            return teacher.Count;
        }

        //Remove a Teacher
        public int RemoveTeacher(string name)
        {

            var res = teacher.Exists(x => x.Name == name);
            if (res)
            {
                var s = teacher.Find(x => x.Name.Contains(name));
                teacher.Remove(s);
                return teacher.Count;

            }
            return -1;

        }

        //Update Teacher
        public string UpdateTeacher(string name)
        {

            var res = teacher.Exists(x => x.Name == name);
            if (res)
            {
                var s = teacher.Find(x => x.Name.Contains(name));
                teacher.Remove(s);
                teacher.Insert(0, new Teacher() { Name = "Patra Updated", ClassAndSection = "11 A" });
                var res1 = teacher.Exists(x => x.Name == "Patra Updated");
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
