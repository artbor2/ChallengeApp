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

        [Test]
        public void WhenEmployeeGetGradeAsInt_ShouldGetCorrectMaxValue()
        {
            var emp = new Employee("Adam", "1x2abc=");

            emp.AddGrade(5);
            emp.AddGrade(2);

            Assert.AreEqual(5, emp.GetStatistics().Max);
        }

        [Test]
        public void WhenEmployeeGetGradeAsLong_ShouldGetCorrectMaxValue()
        {
            var emp = new Employee("Adam", "1x2abc=");

            emp.AddGrade(5L);
            emp.AddGrade(3L);

            Assert.AreEqual(5, emp.GetStatistics().Max);
        }

        [Test]
        public void WhenEmployeeGetGradeAsFloatg_ShouldGetCorrectMaxValue()
        {
            var emp = new Employee("Adam", "1x2abc=");

            emp.AddGrade(5.0);
            emp.AddGrade(3.0);

            Assert.AreEqual(5, emp.GetStatistics().Max);
        }

        [Test]
        public void WhenEmployeeGetGradeAsDoble_ShouldGetCorrectMaxValue()
        {
            var emp = new Employee("Adam", "1x2abc=");

            emp.AddGrade(5.0D);
            emp.AddGrade(3.0D);

            Assert.AreEqual(5, emp.GetStatistics().Max);
        }

        [Test]
        public void WhenEmployeeGetGradeAsString_ShouldGetCorrectMaxValue()
        {
            var emp = new Employee("Adam", "1x2abc=");

            emp.AddGrade("5");
            emp.AddGrade("4");

            Assert.AreEqual(5, emp.GetStatistics().Max);
        }

        [Test]
        public void TestGetStatisticsWithFor()
        {
            var emp = new Employee("Adam", "1x2abc=");
            emp.AddGrade(1);
            emp.AddGrade(2D);
            emp.AddGrade(3.0f);
            emp.AddGrade(4.0D);
            emp.AddGrade("5");  // Min 1, Max 5, Avg 3

            var statistics = emp.GetStatisticsWithFor();

            Assert.AreEqual(5, statistics.Max);
            Assert.AreEqual(1, statistics.Min);
            Assert.AreEqual(3, statistics.Average);
        }

        [Test]
        public void TestGetStatisticsWithFoEach()
        {
            var emp = new Employee("Adam", "1x2abc=");
            emp.AddGrade(1);
            emp.AddGrade(2D);
            emp.AddGrade(3.0f);
            emp.AddGrade(4.0D);
            emp.AddGrade("5");  // Min 1, Max 5, Avg 3

            var statistics = emp.GetStatisticsWithForEach();

            Assert.AreEqual(5, statistics.Max);
            Assert.AreEqual(1, statistics.Min);
            Assert.AreEqual(3, statistics.Average);
        }

        [Test]
        public void TestGetStatisticsWithDoWhile()
        {
            var emp = new Employee("Adam", "1x2abc=");
            emp.AddGrade(1);
            emp.AddGrade(2D);
            emp.AddGrade(3.0f);
            emp.AddGrade(4.0D);
            emp.AddGrade("5");  // Min 1, Max 5, Avg 3

            var statistics = emp.GetStatisticsWithDoWhile();

            Assert.AreEqual(5, statistics.Max);
            Assert.AreEqual(1, statistics.Min);
            Assert.AreEqual(3, statistics.Average);
        }

        [Test]
        public void TestGetStatisticsWithWhile()
        {
            var emp = new Employee("Adam", "1x2abc=");
            emp.AddGrade(1);
            emp.AddGrade(2D);
            emp.AddGrade(3.0f);
            emp.AddGrade(4.0D);
            emp.AddGrade("5");  // Min 1, Max 5, Avg 3

            var statistics = emp.GetStatisticsWithWhile();

            Assert.AreEqual(5, statistics.Max);
            Assert.AreEqual(1, statistics.Min);
            Assert.AreEqual(3, statistics.Average);
        }


    }
}