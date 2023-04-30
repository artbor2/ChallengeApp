using ChallengeApp;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.Write("Podaj imię pracownika: ");
var name = Console.ReadLine();

Console.Write("Podaj nazwisko pracownika: ");
var surname = Console.ReadLine();

Employee employee;
Console.Write("Podaj płeć pracownika[M/F]: ");
char sex = Console.ReadLine()[0];

employee = new Employee(name, surname, sex);
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
        try
        {
            

        } catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
        
    }
    
}
var statistics = employee.GetStatistics();
Console.WriteLine();

Console.WriteLine($"Min:{statistics.Min}");  
Console.WriteLine($"Max:{statistics.Max}");
Console.WriteLine($"Avg: { statistics.Average}");
Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");