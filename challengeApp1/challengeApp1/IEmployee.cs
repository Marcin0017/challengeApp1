namespace challengeApp1
{
    public interface IEmployee
    {
        string Surname { get; }
        string Name { get; }

        void AddGrade(float grade);

        void AddGrade(int grade);

        void AddGrade(double grade);

        void AddGrade(char grade);

        void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "6-":
                case "-6":
                    AddGrade(95);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "-5":
                case "5-":
                    AddGrade(75);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "-4":
                case "4-":
                    AddGrade(55);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "3-":
                case "-3":
                    AddGrade(35);
                    break;
                case "2+":
                case "+2":
                    AddGrade(25);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "-2":
                case "2-":
                    AddGrade(15);
                    break;
                case "1+":
                case "+1":
                    AddGrade(5);
                    break;
                default:
                    throw new Exception("Number should be between 6(max) 1(min)");
            }
        }
        Statistics GetStatistics();
    }
}
