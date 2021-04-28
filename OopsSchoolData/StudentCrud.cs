using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSchoolData
{
    public class StudentCrud
    {
        //Student
        List<Student> student = new List<Student>()
        {
            new Student(){ Name= "Ankit", ClassAndSection="10 A"},
            new Student() { Name = "Shas", ClassAndSection="10 A"},
            new Student() { Name = "Ramu", ClassAndSection="10 A"},

        };

        private readonly OffsetStudent offsetStudent;

        //Construtor
        public StudentCrud(OffsetStudent _offsetStudent)
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

    }
}
