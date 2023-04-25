using NuGet.Frameworks;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmployeeCollectGrades__ShouldGetCorrectLowestGrade()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(1);
            emp1.AddGrade(3);
            emp1.AddGrade(5);


            // assert
            var stat = emp1.GetStatistics();
            Assert.AreEqual(1, stat.Min);
        }
        [Test]
        public void WhenEmployeeCollectGrades__ShouldGetCorrectTheHighestGrade()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(6);
            emp1.AddGrade(2);
            emp1.AddGrade(4);

            var stat = emp1.GetStatistics();
            Assert.AreEqual(6, stat.Max);
        }

        [Test]
        public void WhenEmployeeCollectGrades__ShouldGetCorrectAverageGrade()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(3);
            emp1.AddGrade(5);
            emp1.AddGrade(7);

            var stat = emp1.GetStatistics();
            Assert.AreEqual(5, stat.Average);
        }
    }
}