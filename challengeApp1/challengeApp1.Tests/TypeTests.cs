namespace challengeApp1.Tests
{
    public class TypeTests
    {
        [Test]
        public void IntTest()
        {
            int number1 = 1;
            int number2 = 2;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void StringTest()
        {
            string name1 = "Marcin";
            string name2 = "Marcin";

            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void RederenceTest()
        {
            var employee1 = ("Adam", "XYZ", 33);
            var employee2 = ("Monika", "XYZ", 22);

            Assert.AreNotEqual(employee1, employee2);
        }
        [Test]
        public void IntAgeTest()
        {
            int age1 = 11;
            int age2 = 19;

            Assert.AreNotEqual(age1, age2);
        }
        private Employee GetUser(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    
    }

}
