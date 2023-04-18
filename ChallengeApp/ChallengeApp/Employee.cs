namespace ChallengeApp
{
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        
        private List<int> employeePoints = new List<int>();

        public Employee(string name, string lastName, int age)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
        }

        public int Result
        {
            get
            {
                return this.employeePoints.Sum();
            }
        }
        public void AddScore(int score)
        {
            this.employeePoints.Add(score);

        }

        public void subtractScore(int score)
        {
            if (score >= 0)
            {
                score *= -1;
                this.employeePoints.Add(score);
            } else if (score < 0)
            {
                this.employeePoints.Add(score);
           }
        }
    }
}
