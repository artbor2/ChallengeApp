using ChallengeApp;

List<Employee> employeesList = new List<Employee>();

Employee employee1 = new Employee("Jan", "Kowalski", 34);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(3);
employee1.AddScore(7);
employee1.AddScore(5);

Employee employee2 = new Employee("Adam", "Malinowski", 27);
employee2.AddScore(3);
employee2.AddScore(7);
employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(6);

Employee employee3 = new Employee("Tomasz", "Iksiński", 11);
employee3.AddScore(6);
employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(7);
employee3.AddScore(5);

employeesList.Add(employee1);
employeesList.Add(employee2);
employeesList.Add(employee3);

int maxScore = -1;
Employee best = null;
foreach (Employee employee in employeesList)
{
    if (employee.Result > maxScore)
    {   maxScore = employee.Result;
        best = employee;
    }
}
        
var answer = best.FirstName + " " + best.LastName + ", lat " + best.Age + ", " + best.Result;

Console.WriteLine(answer);