using BuildTLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var one = new Class1();
            // act
            var observed = one.One();
            var expected = 1;

            // assert
            Assert.AreEqual(expected, observed);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            var two = new Class1();
            // act
            var observed = two.Two();
            var expected = 2;

            // assert
            Assert.AreEqual(expected, observed);
        }
    }
}