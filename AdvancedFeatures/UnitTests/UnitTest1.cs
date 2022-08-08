using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add()
        {
            int a = 5;
            int b = 6;
            int actual = 5 * 6;
            Assert.AreEqual(30, actual);
        }
        public void Multiply()
        {
            int a = 10;
            int b = 20;
            int actual = a * b;
            Assert.AreEqual(200, actual);
        }
        public void Subtract()
        {
            int a = 15;
            int b = 7;
            int actual = a - b;
            Assert.AreEqual(8, actual);
        }
        public void Divide()
        {
            int a = 100;
            int b = 5;
            

        }
    }
}