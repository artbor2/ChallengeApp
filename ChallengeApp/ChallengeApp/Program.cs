using ChallengeApp;

Employee employee = new Employee("Jan", "Kowalski");
employee.AddGrade(9f);
employee.AddGrade("4000  ,11");
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();
