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
            emp1.addGrade(1);
            emp1.addGrade(3);
            emp1.addGrade(5);


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
            emp1.addGrade(6);
            emp1.addGrade(2);
            emp1.addGrade(4);

            var stat = emp1.GetStatistics();
            Assert.AreEqual(6, stat.Max);
        }

        [Test]
        public void WhenEmployeeCollectGrades__ShouldGetCorrectAverageGrade()
        {
            // arrange
            var emp1 = new Employee("Jan Kowalski", "asdf1234");

            // act
            emp1.addGrade(3);
            emp1.addGrade(5);
            emp1.addGrade(7);

            var stat = emp1.GetStatistics();
            Assert.AreEqual(5, stat.Average);
        }

        [Test]
        public void WhenEmployeeGetGradeAsInt_ShouldGetCorrectMaxValue()
        {
            var emp = new Employee("Adam", "1x2abc=");

            emp.addGrade(5);
            emp.addGrade(2);

            Assert.AreEqual(5, emp.GetStatistics().Max);
        }

        [Test]
        public void WhenEmployeeGetGradeAsLong_ShouldGetCorrectMaxValue()
        {
            var emp = new Employee("Adam", "1x2abc=");

            emp.addGrade(5L);
            emp.addGrade(3L);

            Assert.AreEqual(5, emp.GetStatistics().Max);
        }

        [Test]
        public void WhenEmployeeGetGradeAsFloatg_ShouldGetCorrectMaxValue()
        {
            var emp = new Employee("Adam", "1x2abc=");

            emp.addGrade(5.0);
            emp.addGrade(3.0);

            Assert.AreEqual(5, emp.GetStatistics().Max);
        }

        [Test]
        public void WhenEmployeeGetGradeAsDoble_ShouldGetCorrectMaxValue()
        {
            var emp = new Employee("Adam", "1x2abc=");

            emp.addGrade(5.0D);
            emp.addGrade(3.0D);

            Assert.AreEqual(5, emp.GetStatistics().Max);
        }

        [Test]
        public void WhenEmployeeGetGradeAsString_ShouldGetCorrectMaxValue()
        {
            var emp = new Employee("Adam", "1x2abc=");

            emp.addGrade("5");
            emp.addGrade("4");

            Assert.AreEqual(5, emp.GetStatistics().Max);
        }


    }
}