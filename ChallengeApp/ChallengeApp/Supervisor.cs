
using System.Diagnostics;
using System.Net.WebSockets;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name { get; private set; }

        public string SurName { get; private set; }

        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
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

                throw new Exception("Invalid grade value");
            }
        }
        public void AddGrade(double grade)
        {
            float floatGrade = (float)grade;
            this.AddGrade(floatGrade);
        }

        public void AddGrade(int grade)
        {
            float floatGrade = grade;
            this.AddGrade(floatGrade);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public void AddGrade(string grade)
        {
            float sign = 0; // '-' -> -5, '+' -> + 5

            if (grade[0] == '-')
            {
                grade = grade.Substring(1);
                sign = -5;

            }
            else if (grade[grade.Length - 1] == '-')
            {
                grade = (grade.Substring(0, grade.Length - 1));
                sign = -5;
            }
            else if (grade[0] == '+')
            {
                grade = grade.Substring(1);
                sign = +5;
            }
            else if (grade[grade.Length - 1] == '+')
            {
                grade = (grade.Substring(0, grade.Length - 1));
                sign = +5;
            }

            switch (grade)
            {
                case "6":
                    this.grades.Add(100 + sign);
                    break;
                case "5":
                    this.grades.Add(80 + sign);
                    break;
                case "4":
                    this.grades.Add(60 + sign);
                    break;
                case "3":
                    this.grades.Add(40 + sign);
                    break;
                case "2":
                    this.grades.Add(20 + sign);
                    break;
                case "1":
                    this.grades.Add(0 + sign);
                    break;
                default:
                    throw new Exception("Wrong letter");


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
