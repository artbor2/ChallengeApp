using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.Write("Podaj imię pracownika: ");
var name = Console.ReadLine();
Console.Write("Podaj nazwisko pracownika: ");
var surname = Console.ReadLine();
var employee = new Employee(name, surname);
Console.WriteLine();

Boolean runApp = true;
while (runApp)
{
    Console.Write("Podaj kolejną ocenę pracownika lub 'end' aby zakończyć dodawanie ocen: ");
    var input = Console.ReadLine();
    if (input == "end")
    {
        runApp = false;

    } else
    {
        employee.AddGrade(input);
    }
    
}
var statistics = employee.GetStatistics();
Console.WriteLine();

Console.WriteLine($"Min:{statistics.Min}");  
Console.WriteLine($"Max:{statistics.Max}");
Console.WriteLine($"Avg: { statistics.Average}");
Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");