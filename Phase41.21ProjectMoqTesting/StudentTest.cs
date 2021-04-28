using Moq;
using NUnit.Framework;
using OopsSchoolData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase41._21ProjectMoqTesting
{
    [TestFixture]
    class StudentTest
    {
        private StudentCrud studentCrud;
        List<Student> students = new List<Student>();


        [SetUp]
        public void Setup()
        {
            Mock<OffsetStudent> mockobjString = new Mock<OffsetStudent>();
            mockobjString.Setup(m => m.Get()).Returns(students);
            studentCrud = new StudentCrud(mockobjString.Object);
        }

        [Test]
        public void AddStudent_Test()
        {
            var ExpectedResult = 6;
            var result = studentCrud.AddStudent();
            Assert.AreEqual(ExpectedResult, result);
        }

        [Test]
        public void RemoveStudent_Test()
        {

            var name = "Ankit";
            var expectedStudent = 2;
            var result = studentCrud.RemoveStudent(name);
            Assert.AreEqual(expectedStudent, result);
        }

        [Test]
        public void UpdateStudent_Test()
        {

            var name = "Ankit";
            var expectedStudent = "Value Updated";
            var result = studentCrud.UpdateStudent(name);
            Assert.AreEqual(expectedStudent, result);
        }

        [Test]
        public void GetStudent_Test()
        {
            var expectedStudent = 3;
            var result = studentCrud.GetStudent();
            Assert.AreEqual(expectedStudent, result);
        }

        //Mock Data
        [Test]
        public void GetStudenWithMockt_Test()
        {
            List<Student> expectedStudent = new List<Student>();
            var result = studentCrud.GetStudentWithOffset();
            Assert.AreEqual(expectedStudent, result);
        }
    }
}
