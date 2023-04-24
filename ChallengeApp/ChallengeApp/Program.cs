using ChallengeApp;

Employee employee = new Employee("Jan", "Kowalski");
employee.addGrade("Adam");
employee.addGrade("4000  ,11");
employee.addGrade(2);
employee.addGrade(3);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2} ");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");