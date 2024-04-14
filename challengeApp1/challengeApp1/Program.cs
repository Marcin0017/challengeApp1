using challengeApp1;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("Aby zobaczyć wyniki naciśni 'q' ");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee1();

while (true)
{
    Console.WriteLine("Podaj kolejną ocene pracownika");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
