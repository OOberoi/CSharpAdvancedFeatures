using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        // Adding comment to trigger a push for CI
        [Test]
        public void Add()
        {
            int a = 5;
            int b = 6; 
            int actual = 5 * 6;
            Assert.AreEqual(30, actual);
        }

        public void Subtract()
        {
            int a = 25;
            int b = 15;

        }

        // Adding another comment to trigger a push
        [Test]
        public void Multiply()
        {
            int a = 10;
            int b = 20;
            int actual = a * b;
            Assert.AreEqual(200, actual);
        }

        //Forcing a push to trigger GitHub Actions on Push
        [Test]  
        public void Divide()
        {
            int a = 100;
            int b = 25;
            int actual = a / b;
            Assert.AreEqual(20, actual);
        }
    }
}