namespace challengeApp1.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenEmployeeCollectGradesTestShouldReturnStatistics()
        {
            var employee = new EmployeeInMemory("Marcin", "XYZ");
            employee.AddGrade("C");
            employee.AddGrade("45");
            employee.AddGrade(132);
            employee.AddGrade(34);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(34, statistics.Min);
            Assert.AreNotEqual(132, statistics.Max);
            Assert.AreNotEqual('c', statistics.AverageLetter);

        }
        [Test]
        public void StatisticsTestWhenCharAsAverageLetterThenTestIsCorrect()
        {
            var employee = new EmployeeInMemory("Marcin", "XYZ");
            employee.AddGrade('a');
            employee.AddGrade('B');
            employee.AddGrade('c');
            employee.AddGrade('D');
            employee.AddGrade('e');

            var statistics = employee.GetStatistics();

            Assert.AreNotEqual('c', statistics.AverageLetter);

        }
    }

}
