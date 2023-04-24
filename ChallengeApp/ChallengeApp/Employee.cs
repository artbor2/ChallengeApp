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

        public void AddGrade(double grade)
        {
            float floatGrade = (float)grade;
            grades.Add(floatGrade);
        }

        public void AddGrade(int grade)
        {
            float floatGrade = grade;
            grades.Add(floatGrade);
        }

        public void AddGrade(long grade)
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

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();    
            statistics.Average = 0;
            statistics.Max = this.grades[0];
            statistics.Min = this.grades[0];

            for (int i = 0; i < this.grades.Count; i++)
            {
                if (this.grades[i] >  statistics.Max)
                {
                    statistics.Max = this.grades[i];

                }
                
                if (this.grades[i] < statistics.Min)
                {
                    statistics.Min = this.grades[i];
                }
                statistics.Average += this.grades[i];
            }
            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (float grade in this.grades) {
                if (grade > statistics.Max)
                {
                    statistics.Max = grade;
                }

                if(grade < statistics.Min) 
                {
                    statistics.Min = grade;
                }
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            do
            {
                if (this.grades[index] > statistics.Max)
                {
                    statistics.Max = this.grades[index];
                }

                if (this.grades[index] < statistics.Min)
                {
                    statistics.Min = this.grades[index];
                }

                statistics.Average += this.grades[index];
                
                index++;

            } while (index < this.grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                if (this.grades[index] > statistics.Max)
                {
                    statistics.Max = this.grades[index];
                }

                if (this.grades[index] < statistics.Min)
                {
                    statistics.Min = this.grades[index];
                }

                statistics.Average += this.grades[index];

                index++;
            } 

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}