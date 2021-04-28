using Moq;
using NUnit.Framework;
using OopsSchoolData;
using System.Collections.Generic;

namespace Phase41._21ProjectMoqTesting
{
    [TestFixture]
    public class SubjectTest
    {
        private SubjectCrud School;


        [SetUp]
        public void Setup()
        {
         
            School = new SubjectCrud();
        }


        /*==================================Subject Starting ===========================*/
        [Test]
        public void AddSubject_Test()
        {
            var name = "Chemistry";
            var code = "120";
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
        [Test]
        public void UpdateSubject_Test()
        {

            var name = "Maths";
            var expectedStudent = "Value Updated";
            var result = School.UpdateSubject(name);
            Assert.AreEqual(expectedStudent, result);
        }

    }
}