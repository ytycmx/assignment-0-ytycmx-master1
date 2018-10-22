using NUnit.Framework;

namespace HomeworkTest.UnitTests
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public static void ConstructorTest()
        {
            new Student("Name", "Surname", 12345);
        }

        [TestCase("John")]
        [TestCase("Alice")]
        public static void NamePropertyTest(string name)
        {
            var student = new Student(name, "Surname", 12345);

            Assert.AreEqual(name, student.Name);
            Assert.AreNotEqual(student.Name, student.Surname);
        }

        [TestCase("Doe")]
        [TestCase("Hume")]
        public static void SurnamePropertyTest(string surname)
        {
            var student = new Student("Name", surname, 12345);

            Assert.AreEqual(surname, student.Surname);
            Assert.AreNotEqual(student.Name, student.Surname);
        }

        [TestCase(9876540)]
        [TestCase(123)]
        public static void MetricNumberPropertyTest(int metricNo)
        {
            var student = new Student("Name", "Surname", metricNo);

            Assert.AreEqual(metricNo, student.MetriculationNumber);
        }
    }
}
