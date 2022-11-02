namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(1 == 1);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(2== 2);
        }

        [Theory]
        [InlineData(2,2)]
        [InlineData(1,1)]
        public void Test3(int a, int b)
        {
            Assert.True(a == b);
        }
    }
}