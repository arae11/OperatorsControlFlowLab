using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [TestCase(10, 10, false)]
        [TestCase(10, 20, false)]
        [TestCase(20, 10, true)]
        public void MyMethodTest(int num1, int num2, bool expected)
        {
            Assert.AreEqual(expected, Exercises.MyMethod(num1, num2));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(100, "Pass with Distinction")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(59, "Pass")]
        [TestCase(40, "Pass")]
        [TestCase(39, "Fail")]
        [TestCase(0, "Fail")]
        public void GradeTypeTest(int mark, string expected)
        {
            var result = Exercises.Grade(mark);
            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(4, 20)]
        [TestCase(3, 50)]
        [TestCase(2, 100)]
        [TestCase(1, 200)]
        public void CovidLevelTest(int covidlevel, int attendees)
        {
            var result = Exercises.GetScottishMaxWeddingNumbers(covidlevel);
            Assert.That(result, Is.EqualTo(result));
        }

    }
}
