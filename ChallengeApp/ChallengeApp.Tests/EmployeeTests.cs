using NuGet.Frameworks;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmployeeCollectOneGradeAsIntege_ShouldGetCorrectEqualMinMaxAverageScore()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(10);

            // assert
            var stat = emp1.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(10));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenEmployeeCollectOneGradeAsLong_ShouldGetCorrectEqualMinMaxAverageScore()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(10L);

            // assert
            var stat = emp1.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(10));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenEmployeeCollectOneGradeAsFloat_ShouldGetCorrectEqualMinMaxAverageScore()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(20.0f);

            // assert
            var stat = emp1.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(20));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenEmployeeCollectOneGradeAsDouble_ShouldGetCorrectEqualMinMaxAverageScore()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(20.0D);

            // assert
            var stat = emp1.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(20));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenEmployeeCollectOneGradeAsString_ShouldGetCorrectEqualMinMaxAverageScore()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade("40");

            // assert
            var stat = emp1.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(40));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenEmployeeCollectGradelessThan0_SzouldbeIgnored()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(10);
            emp1.AddGrade(-50);
            emp1.AddGrade(20);
            emp1.AddGrade(30);

            // assert
            var stat = emp1.GetStatistics();
            Assert.That(stat.Average, Is.EqualTo(20));

        }

        [Test]
        public void WhenEmployeeCollectGradeBiggerThan100_SzouldbeIgnored()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(10);
            emp1.AddGrade(120);
            emp1.AddGrade(20);
            emp1.AddGrade(30);

            // assert
            var stat = emp1.GetStatistics();
            Assert.That(stat.Average, Is.EqualTo(20));

        }

        [Test]
        public void WhenEmployeeCollectGrades_ShouldGetCorrectLowestGrade()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(10);
            emp1.AddGrade(30);
            emp1.AddGrade(50);


            // assert
            var stat = emp1.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(10));
        }

        [Test]
        public void WhenEmployeeCollectGrades_ShouldGetCorrectTheHighestGrade()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(60);
            emp1.AddGrade(20);
            emp1.AddGrade(40);

            var stat = emp1.GetStatistics();
            Assert.That(stat.Max, Is.EqualTo(60));
        }


        [Test]
        public void WhenEmployeeCollectGrades_ShouldGetCorrectAverageGrade()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(30);
            emp1.AddGrade(50);
            emp1.AddGrade(70);

            var stat = emp1.GetStatistics();
            Assert.That(stat.Average, Is.EqualTo(50));
        }


        [Test]
        public void WhenEmployeeCollectAverageGradesEqualOrMoreThan80Points_ShouldGetCorrectAverageLetterGrade_A()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(90);
            emp1.AddGrade(90);
            emp1.AddGrade(90);

            var stat = emp1.GetStatistics();
            Assert.That(stat.Average, Is.EqualTo(90));
            Assert.That(stat.AverageLetter, Is.EqualTo('A'));
        }

        [Test]
        public void WhenEmployeeCollectAverageGradesEqualOrMoreThan60Points_ShouldGetCorrectAverageLetterGrade_B()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(70);
            emp1.AddGrade(70);
            emp1.AddGrade(70);

            var stat = emp1.GetStatistics();
            Assert.That(stat.Average, Is.EqualTo(70));
            Assert.That(stat.AverageLetter, Is.EqualTo('B'));
        }

        [Test]
        public void WhenEmployeeCollectAverageGradesEqualOrMoreThan40Points_ShouldGetCorrectAverageLetterGrade_C()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(50);
            emp1.AddGrade(50);
            emp1.AddGrade(50);

            var stat = emp1.GetStatistics();
            Assert.That(stat.Average, Is.EqualTo(50));
            Assert.That(stat.AverageLetter, Is.EqualTo('C'));
        }

        [Test]
        public void WhenEmployeeCollectAverageGradesEqualOrMoreThan20Points_ShouldGetCorrectAverageLetterGrade_D()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(30);
            emp1.AddGrade(30);
            emp1.AddGrade(30);

            var stat = emp1.GetStatistics();
            Assert.That(stat.Average, Is.EqualTo(30));
            Assert.That(stat.AverageLetter, Is.EqualTo('D'));
        }

        [Test]
        public void WhenEmployeeCollectAverageGradesLessThan20Points_ShouldGetCorrectAverageLetterGrade_E()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.AddGrade(10);
            emp1.AddGrade(10);
            emp1.AddGrade(10);

            var stat = emp1.GetStatistics();
            Assert.That(stat.Average, Is.EqualTo(10));
            Assert.That(stat.AverageLetter, Is.EqualTo('E'));
        }

    }
}