using challengeApp1;

var employee = new Employee1("Adam", "Kazimielich");
employee.AddGrade(9);
employee.AddGrade(5);
employee.AddGrade(10);
employee.AddGrade(3f);
employee.AddGrade("XYZ");

var statistics1 = employee.GetStatisticsWithForEach();
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine();

var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine();

var statistics3 = employee.GetStatisticsWithWhile();
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine();

var statistics4 = employee.GetStatisticsWithDoWhile();
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine();