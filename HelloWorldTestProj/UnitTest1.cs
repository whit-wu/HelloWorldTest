namespace HelloWorldTestProj
{
    public class UnitTest1
    {
       
        [Fact]
        public void HelloThere_CallMethod_ReturnString()
        {
            // arrange
            Hello hello = new Hello();

            // act
            var result = hello.HelloThere();

            // assert   
            Assert.True(result.Count() > 0);
        }
    }
}
