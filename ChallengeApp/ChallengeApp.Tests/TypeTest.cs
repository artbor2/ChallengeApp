using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void CompareTwoIntegerVariablesTest()
        {
            int number1 = 33;
            int number2 = 33;

            Assert.AreEqual(number1, number2);  
        }

        [Test]
        public void CompareTwoFloatVariablesTest()
        {
            float number1 = 3.14f;
            float number2 = 3.14f;

            Assert.AreEqual(number1, number2);
        }
        
        [Test]
        public void CompareTwoStringVariablesTest()
        {
            string textOne = "abc";
            string textTwo = "abc";
            
            Assert.AreEqual(textOne, textTwo);
        }

        [Test]
        public void CompareTwoUserClassObjects() 
        {
            var user1 = GetUser("Jan");
            var user2 = GetUser("Jan");              

            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void CompareTwoUserClassFields()
        {
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            Assert.AreEqual(user1.Login, user2.Login);
        }



        private User GetUser(string name)
        {
            return new User(name);   
        }
    }
}
