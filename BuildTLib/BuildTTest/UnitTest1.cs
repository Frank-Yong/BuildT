using BuildTLib;

namespace BuildTTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var one = new Class1();
            // act
            var observed = one.One();
            var expected = 1;

            // assert
            Assert.Equal(expected, observed);
        }

        [Fact]
        public void Test2()
        {
            // arrange
            var two = new Class1();
            // act
            var observed = two.Two();
            var expected = 2;

            // assert
            Assert.Equal(expected, observed);
        }
    }
}