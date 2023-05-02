
namespace ChallengeApp.Tests
{
    public  class SupervisorTests
    {
        [Test]
        public void WhenAddGradeGetFloatNumber()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade(3.0);

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(3.0f));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }
        [Test]
        public void WhenAddGradeGetString_with_6()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("6");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(100));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_5()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("5");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(80));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_4()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("4");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(60));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_3()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("3");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(40));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_2()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("2");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(20));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_1()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("1");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(0));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_minus_6()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("-6");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(95));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_minus_5()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("-5");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(75));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_minus_4()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("-4");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(55));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_minus_3()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("-3");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(35));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_minus_2()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("-2");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(15));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_minus_1()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("-1");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(-5.0f));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_6_minus()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("6-");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(95));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_5_minus()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("5-");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(75));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_4_minus_()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("4-");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(55));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_3_minus()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("3-");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(35));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_2_minus()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("2-");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(15));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_1_minus()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("1-");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(-5.0f));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_plus_6()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("+6");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(105));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_plus_5()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("+5");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(85));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_plus_4()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("+4");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(65));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_plus_3()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("+3");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(45));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_plus_2()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("+2");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(25));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }

        [Test]
        public void WhenAddGradeGetString_with_plus_1()
        {
            var sup = new Supervisor("Jan Kowalski", "asdf1234");
            sup.AddGrade("+1");

            var stat = sup.GetStatistics();
            Assert.That(stat.Min, Is.EqualTo(5));
            Assert.That(stat.Min, Is.EqualTo(stat.Max));
            Assert.That(stat.Max, Is.EqualTo(stat.Average));
        }
    }
}
