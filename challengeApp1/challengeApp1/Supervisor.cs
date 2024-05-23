namespace challengeApp1
{
    public class Supervisor : IEmployee
    {
        public string Name => "Adam";

        public string Surname => "Kazimielich";

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            return new Statistics();
        }
        public void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }
    }
}
