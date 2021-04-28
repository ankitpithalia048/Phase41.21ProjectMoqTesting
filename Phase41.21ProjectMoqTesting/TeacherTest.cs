using NUnit.Framework;
using OopsSchoolData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase41._21ProjectMoqTesting
{
    [TestFixture]
    class TeacherTest
    {
        private TeacherCrud teacherCrud;
        List<Teacher> teacher = new List<Teacher>();


        [SetUp]
        public void Setup()
        {

            teacherCrud = new TeacherCrud();
        }

        /*===============================Teacher Starting =========================*/
        [Test]
        public void AddTeacher_Test()
        {
            var name = "Dheeraj";
            var ClassAndSection = "11 A";
            var ExpectedResult = 3;

            var result = teacherCrud.AddTeacher(name, ClassAndSection);
            Assert.AreEqual(ExpectedResult, result);
        }

        [Test]
        public void GetTeacher_Test()
        {
            var expectedStudent = 2;
            var result = teacherCrud.GetTeacher();
            Assert.AreEqual(expectedStudent, result);
        }

        [Test]
        public void RemoveTeacher_Test()
        {

            var name = "Patra";
            var expectedStudent = 1;
            var result = teacherCrud.RemoveTeacher(name);
            Assert.AreEqual(expectedStudent, result);
        }

        [Test]
        public void UpdateTeacher_Test()
        {

            var name = "Patra";
            var expectedStudent = "Value Updated";
            var result = teacherCrud.UpdateTeacher(name);
            Assert.AreEqual(expectedStudent, result);
        }



    }
}
