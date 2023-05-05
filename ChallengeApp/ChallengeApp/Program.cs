using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

EmployeeInFile emp = new EmployeeInFile("Jan", "Kowalski");


emp.AddGrade(10);
emp.AddGrade("15"); // 15
emp.AddGrade('B');  // 80
emp.AddGrade(20);
emp.AddGrade(30);

var statistics = emp.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");
Console.WriteLine($"Avg: {statistics.Average}");
//Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");
