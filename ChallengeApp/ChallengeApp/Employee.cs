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

        public void addGrade(int grade)
        {
            this.grades.Add(grade);
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

            return statistics ;
        }
    }
}