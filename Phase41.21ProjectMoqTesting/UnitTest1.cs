using Moq;
using NUnit.Framework;
using OopsSchoolData;
using System.Collections.Generic;

namespace Phase41._21ProjectMoqTesting
{
    [TestFixture]
    public class Tests
    {
        private SchoolData School;
        List<Student> students = new List<Student>();
        
        List<Teacher> teacher = new List<Teacher>();

        [SetUp]
        public void Setup()
        {
            Mock<OffsetStudent> mockobjString = new Mock<OffsetStudent>();
            mockobjString.Setup(m => m.Get()).Returns(students) ;
            School = new SchoolData(mockobjString.Object);
        }

        [Test]
        public void AddStudent_Test()
        {
           
            var ExpectedResult = 6;

            var result = School.AddStudent();
            Assert.AreEqual(ExpectedResult, result);
        }

        [Test]
        public void RemoveStudent_Test()
        {
            
            var name = "Ankit";
            var expectedStudent = 2;
            var result = School.RemoveStudent(name);
            Assert.AreEqual(expectedStudent, result);
        }

        [Test]
        public void UpdateStudent_Test()
        {
            
            var name = "Ankit";
            var expectedStudent = "Value Updated";
            var result = School.UpdateStudent(name);
            Assert.AreEqual(expectedStudent, result);
        }

        [Test]
        public void GetStudent_Test()
        {
            var expectedStudent = 3;
            var result = School.GetStudent();
            Assert.AreEqual(expectedStudent, result);
        }

        //Mock Data
        [Test]
        public void GetStudenWithMockt_Test()
        {
            List<Student> expectedStudent = new List<Student>();
            var result = School.GetStudentWithOffset();
            Assert.AreEqual(expectedStudent, result);
        }


        [Test]
        public void AddTeacher_Test()
        {
            var name = "Dheeraj";
            var ClassAndSection = "11 A";
            var ExpectedResult = 2;

            var result = School.AddTeacher(name, ClassAndSection);
            Assert.AreEqual(ExpectedResult, result);
        }

        [Test]
        public void GetTeacher_Test()
        {
            var expectedStudent = 1;
            var result = School.GetTeacher();
            Assert.AreEqual(expectedStudent, result);
        }

        [Test]
        public void AddSubject_Test()
        {
            var name = "Maths";
            var code = "110";
            var ExpectedResult = 3;

            var result = School.AddSubject(name, code);
            Assert.AreEqual(ExpectedResult, result);
        }

        [Test]
        public void GetSubject_Test()
        {
            var expectedres = 2;
            var result = School.GetSubject();
            Assert.AreEqual(expectedres, result);
        }
    }
}