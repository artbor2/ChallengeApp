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

        public void AddGrade(float grade)
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


        public void AddGrade(int intGrade)
        {
            float floatGrade = intGrade;
            this.AddGrade(floatGrade);
        }

        public void AddGrade(long intGrade)
        {
            float floatGrade = intGrade;
            this.AddGrade(floatGrade);
        }

        public void AddGrade(double longGrade)
        {
            float floatGrade = (float)longGrade;
            this.AddGrade(floatGrade);
        }

        public void AddGrade(String gradeValu)
        {
            if (float.TryParse(gradeValu, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }

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
            statistics.Average /= this.grades.Count;

            statistics = ScorePointToLetterGrade(statistics);
            return statistics;
        }

        private Statistics ScorePointToLetterGrade(Statistics statistics)
        {
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}