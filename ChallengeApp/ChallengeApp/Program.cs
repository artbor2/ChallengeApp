using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

EmployeeInFile empF = new EmployeeInFile("Jan", "Kowalski");
empF.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs e)
{
    Console.WriteLine("Dodano nową ocenę");
}

Console.WriteLine("Proszę podać kolejną ocenę pracownika, aby zakończyć wpisz 'q': ");
while (true)
{
    Console.Write(": ");
    String input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else if (input == "")
    {
        continue;
    }
    try
    {
        empF.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched {ex.Message}");
    }

}

var statistics = empF.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");
Console.WriteLine($"Avg: {statistics.Average}");
Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");