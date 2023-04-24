using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string SurName { get; private set; }

        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }

        public void addGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {

                Console.WriteLine("Invalid grade value.");
            }

        }

        public void addGrade(String gradeValu)
        {
            if (float.TryParse(gradeValu, out float result))
            {
                this.addGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }

        }

        public void addGrade(double grade)
        {
            float floatGrade = (float)grade;
            grades.Add(floatGrade);
        }

        public void addGrade(int grade)
        {
            float floatGrade = grade;
            grades.Add(floatGrade);
        }

        public void addGrade(long grade)
        {
            float floatGrade = grade;
            grades.Add(floatGrade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            if (statistics.Average > 0 && this.grades.Count > 0)
            {
                statistics.Average /= this.grades.Count;

            } else
            {
                Console.WriteLine("Invalid average / grade.Count values");
            }
            
            return statistics;
        }
    }
}