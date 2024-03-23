namespace challengeApp1.Tests
{
    public class TypeTests
    {
        [Test]
        public void MethosGetStatisticsMin()
        {
            var employee = new Employee1("Adam", "XYZ");

            employee.AddGrade(33);
            employee.AddGrade(45);
            employee.AddGrade(21);

            var ststistics = employee.GetStatistics();

            Assert.AreEqual(21, ststistics.Min);
            Assert.AreEqual(45, ststistics.Max);
            Assert.AreEqual(33, ststistics.Average);

        }

        [Test]
        public void MethosGetStatisticsMax()
        {
            var employee = new Employee1("Adam", "XYZ");

            employee.AddGrade(12);
            employee.AddGrade(-10);
            employee.AddGrade(31);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(-10, statistics.Min);
            Assert.AreEqual(31, statistics.Max);
            Assert.AreEqual(11, statistics.Average);
        }

    }

}
