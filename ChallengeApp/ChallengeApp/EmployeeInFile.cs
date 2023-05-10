namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

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

                        if (GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        }
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
                throw new Exception($"Invalid grade value ({grade}) [less than 0 or more than 100]");
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
                if (grade.Length > 1)
                {
                    throw new Exception("String is not float");
                }
                else
                {
                    this.AddGrade(grade[0]);
                }
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
                                    throw new Exception($"Invalid grade value ({number}) - from file");
                                }
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
            List<float> grades = ReadNumbers(fileName);
            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}