namespace HelloWorldConsoleApp.Test
{
    public class MathDemoUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdditionTest()
        {
            int expectedResult = 6;
            MathDemo mathDemo = new MathDemo();
            int actualResult = mathDemo.Add(2, 4);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}