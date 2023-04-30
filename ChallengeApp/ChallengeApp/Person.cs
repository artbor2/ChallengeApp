namespace ChallengeApp
{
    public abstract class Person // : System.Object - base one class for all
    {
        protected string Name { get; private set; }
        protected string SurName { get; private set; }
        protected char Sex { get; private set; } = 'F';

        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.SurName = surname;
            this.Sex = sex;
        }
    }
}
