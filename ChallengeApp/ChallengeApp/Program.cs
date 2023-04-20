using ChallengeApp;

Employee employee = new Employee("Jan", "Kowalski");
employee.addGrade(3);
employee.addGrade(6);
employee.addGrade(4);
employee.addGrade(5);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2} ");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");