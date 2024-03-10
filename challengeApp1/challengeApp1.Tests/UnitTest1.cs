namespace challengeApp1.Tests
{
    public class Tests
    {
        [Test]

        public void WhenUserCollectTwoScores_ShouldCorrectRTesult()
        {
            var user = new Employee("Adam", "XYZ", 33);
            user.AddScore(5);
            user.AddScore(6);

            var result = user.Result;

            Assert.AreEqual(11, result);
        }
        [Test]
        public void WhenUserCollectThreeScores_ShouldCorrectRTesult()
        {
            var user = new Employee("Monika", "XYZ", 44);
            user.AddScore(3);
            user.AddScore(5);
            user.AddScore(-2);

            var result = user.Result;

            Assert.AreEqual(6, result);

        }
        [Test]
        public void WhenUserCollectFourScores_ShouldCorrectRTesult()
        {
            var user = new Employee("Zuzia", "XYZ", 18);
            user.AddScore(-2);
            user.AddScore(1);
            user.AddScore(-5);
            user.AddScore(-4);

            var result = user.Result;

            Assert.AreEqual(-10, result);
        }

    }
}