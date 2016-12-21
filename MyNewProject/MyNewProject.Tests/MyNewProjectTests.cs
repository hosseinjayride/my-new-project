using NUnit.Framework;

namespace MyNewProject.Tests
{
    [TestFixture]
    public class MyNewProjectTests
    {
        [Test]
        public void Values_Should_Be_The_Same()
        {
            Assert.AreEqual("The value should be this", "This is the actual value");
        }
    }
}
