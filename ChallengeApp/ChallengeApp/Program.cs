using ChallengeApp;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

Console.Write("Oceniamy pracownika (1) lub kierownika (2): ");
var choosen = Console.ReadLine();

if (choosen == "1")
{
    Console.Write("Podaj imię pracownika: ");
    var name = Console.ReadLine();

    Console.Write("Podaj nazwisko pracownika: ");
    var surname = Console.ReadLine();

    Employee employee = new Employee(name, surname);
    Boolean runApp = true;
    while (runApp)
    {
        Console.Write("Podaj kolejną ocenę lub 'end' aby zakończyć dodawanie ocen: ");
        var input = Console.ReadLine();
        if (input == "end")
        {
            runApp = false;

        }
        else
        {
            try
            {
                employee.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }

    }
    var statistics = employee.GetStatistics();
    Console.WriteLine();
    Console.WriteLine($"Min:{statistics.Min}");
    Console.WriteLine($"Max:{statistics.Max}");
    Console.WriteLine($"Avg: {statistics.Average}");
    Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");


}

else if (choosen == "2")
{
    Console.Write("Podaj imię kierownika: ");
    var name = Console.ReadLine();

    Console.Write("Podaj nazwisko kierownika: ");
    var surname = Console.ReadLine();

    Employee employee = new Employee(name, surname);

    Boolean runApp = true;
    Supervisor supervisor = new Supervisor(name, surname);

    while (runApp)
    {
        Console.Write("Podaj kolejną ocenę lub 'end' aby zakończyć dodawanie ocen: ");
        var input = Console.ReadLine();
        if (input == "end")
        {
            runApp = false;

        }
        else
        {
            try
            {
                supervisor.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }

    }
    var statistics = supervisor.GetStatistics();
    Console.WriteLine();
    Console.WriteLine($"Min:{statistics.Min}");
    Console.WriteLine($"Max:{statistics.Max}");
    Console.WriteLine($"Avg: {statistics.Average}");
    Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");
}