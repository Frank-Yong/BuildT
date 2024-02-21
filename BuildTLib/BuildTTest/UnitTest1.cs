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
    }
}