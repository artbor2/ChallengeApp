using NuGet.Frameworks;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmployeyCollectScores_ShouldGetScoresSum()
        {
            // arrange

            var user = new Employee("Ewa", "UdaBuda#124jestemChuda", 23);
            user.AddScore(5);
            user.AddScore(5);
            user.AddScore(-5);
            user.AddScore(8);
            user.AddScore(7);

            // act
            var result = user.Result;

            // assert
            Assert.That(result, Is.EqualTo(20));
        }
        [Test]
        public void WhenEmployeeGetNegativeScoreEnteredAsPositiveNumber()
        {
            // Arrannage
            var emp1 = new Employee("Jan", "Kowalski", 21);
            emp1.AddScore(2);
            emp1.AddScore(3);
            emp1.AddScore(5);

            // Act
            emp1.subtractScore(5);

            // Asert
            Assert.AreEqual(emp1.Result, 5); 

        }
        [Test]
        public void WhenEmployeeGetNegativeScoreEnteredAsNegativeNumber()
        {
            var emp = new Employee("Adam", "Malinowski", 23);
            emp.AddScore(2);
            emp.AddScore(5);
            emp.subtractScore(-5);

            Assert.AreEqual(emp.Result, 2);
        }
        [Test]
        public void WhenEmployeeGetZeroPoints_AddScore_method()
        {
            var emp = new Employee("Jan", "Kowalski", 33);
            emp.AddScore(5);

            emp.AddScore(0);

            Assert.AreEqual(emp.Result, 5);
        }
        [Test]
        public void WhenEmployeeGetZeroPoints_Substract_method()
        {
            var emp = new Employee("Jan", "Abacki", 33);
            emp.AddScore(5);

            emp.subtractScore(0);

            AssetTargetFallbackFramework.Equals(emp.Result, 5); 
        }

    }
}