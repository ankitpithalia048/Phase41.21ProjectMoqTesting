using System;
using System.Collections.Generic;

namespace OopsSchoolData
{
    public class SchoolData
    {
        //Student
        List<Student> student = new List<Student>()
        {
            new Student(){ Name= "Ankit", ClassAndSection="10 A"},
            new Student() { Name = "Shas", ClassAndSection="10 A"},
            new Student() { Name = "Ramu", ClassAndSection="10 A"},

        };

        //Teacher
        List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher(){Name= "Ezil" , ClassAndSection="10 A"},
            new Teacher(){Name= "Patra" , ClassAndSection="11 A"},

        };

        //Subject
        List<Subject> subject = new List<Subject>() 
        { 
            new Subject(){SubjectCode = "100", SubjectName= "Maths"},
            new Subject(){SubjectCode = "110", SubjectName= "Physics"},

        };
        private readonly OffsetStudent offsetStudent;

        //Construtor
        public SchoolData(OffsetStudent _offsetStudent)
        {
            offsetStudent = _offsetStudent;
        }
        
        //Add Student
        public int AddStudent()
        {
            Student s2 = new Student() { Name = "Shyam", ClassAndSection = "10 A" };

            Student s1 = new Student() { Name = "Suraj", ClassAndSection = "10 A" };
            Student s3 = new Student() { Name = "Ash", ClassAndSection = "10 A" };

            student.Add(s1);
            student.Add(s2);
            student.Add(s3);

            return student.Count;
        }

        //Get Student
        public int GetStudent()
        {
            return student.Count;
        }

        //Remove a Student
        public int RemoveStudent(string name)
        {

            var res = student.Exists(x => x.Name == name);
            if (res)
            {
                var s = student.Find(x => x.Name.Contains(name));
                student.Remove(s);
                return student.Count;
                
            }
            return -1;

        }

        //Update Student
        public string UpdateStudent(string name)
        {

            var res = student.Exists(x => x.Name == name);
            if (res)
            {
                var s = student.Find(x => x.Name.Contains(name));
                student.Remove(s);
                student.Insert(0, new Student() { Name = "Ankit Updated", ClassAndSection = "11 A" });
                var res1 = student.Exists(x => x.Name == "Ankit Updated");
                if (res1)
                {
                    return "Value Updated";
                }
                return "Not updated";

            }
            return "Invalid name";

        }

        //Moq Used for Student
        public List<Student> GetStudentWithOffset()
        {
            return offsetStudent.Get();
        }

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


        /* ======================================= Subject Starting===========================================*/

        //Add Subject
        public int AddSubject(string Subjectname, string code)
        {
            Subject s1 = new Subject() { SubjectName = Subjectname, SubjectCode = code };
            subject.Add(s1);

            return student.Count;
        }

        //Get Subject
        public int GetSubject()
        {
            return subject.Count;
        }
    }
}
