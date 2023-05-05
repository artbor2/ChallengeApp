using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                try
                {
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(grade);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be written");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                throw new Exception($"Invalid grade value ({grade}) [to low value or to big]");
            }
        }
        public override void AddGrade(char grade)
        {
            grade = Char.ToUpper(grade);

            switch (grade)
            {
                case 'A':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }



        public override void AddGrade(double grade)
        {
            float floatGrade = (float)grade;
            this.AddGrade(floatGrade);
        }

        public override void AddGrade(int grade)
        {
            float floatGrade = grade;
            this.AddGrade(floatGrade);
        }

 

        private List<float> ReadNumbers(string fileName)
        {
            var list = new List<float>();

            try
            {
                using (var reader = File.OpenText(fileName))
                {
                    if (File.Exists(fileName))
                    {
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            try
                            {
                                var number = float.Parse(line);
                                if (number >= 0 && number <= 100)
                                {
                                    list.Add(number);
                                }
                                else
                                {
                                    throw new Exception($"Invalid grade value ({number}) - from file");                                }     
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                line = reader.ReadLine();
                                continue;
                            }
                            line = reader.ReadLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something bad has happened when reading file");
                Console.WriteLine(ex.Message);
            }
            return list;
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            List<float> grades = ReadNumbers(fileName);

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= grades.Count;

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




