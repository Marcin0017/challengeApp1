using challengeApp1;

Employee employee1 = new Employee("Adam", "XYZ", 31);
Employee employee2 = new Employee("Monika", "XYZ", 54);
Employee employee3 = new Employee("Zuzia", "XYZ", 43);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(6);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(2);
employee2.AddScore(6);

employee3.AddScore(10);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(3);
employee3.AddScore(4);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }    
}
Console.WriteLine(" Najwieksza ilość punktów: " + employeeWithMaxResult.name + " " + employeeWithMaxResult.surname + " Wiek " + employeeWithMaxResult.age + " uzyskał (-a) najwięcej punktów: " + maxResult);




