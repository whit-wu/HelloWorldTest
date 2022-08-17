namespace HelloWorldTestProj
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Hello hello = new Hello();

            var result = hello.HelloThere();

            Assert.Equal("General Kenobi!", result);
        }
    }
}