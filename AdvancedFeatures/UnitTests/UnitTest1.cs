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
    }
}