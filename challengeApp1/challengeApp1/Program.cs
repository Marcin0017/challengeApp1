﻿using challengeApp1;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("Aby zobaczyć wyniki naciśni 'q' ");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Marcin", "XYZ");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nowa ocenę");
}

try
{
    EmployeeInFile emp = null;
    var name = emp.Surname;
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);

}
finally
{
    Console.WriteLine("Finally here");
}


while (true)
{
    Console.WriteLine("Podaj kolejną ocene pracownika");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

   try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }

}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
