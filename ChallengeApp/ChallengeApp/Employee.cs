namespace ChallengeApp
{
    public class Employee : Person
    {
        
        public int EmployeeId { get; private set; }

        private const float GradeMin = 0;
        private const float GradeMax = 100;
        
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, char sex)
            : base(name, surname, sex)
        {
            EmployeeId++;
        }

        public void AddGrade(float grade)
        {
            if (grade >= GradeMin && grade <= GradeMax)
            {
                this.grades.Add(grade);
            }
            else
            {

                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(char grade)
        {
            switch(grade)
            {
                case 'A':
                case 'a':
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
                throw new Exception("String is not float");
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