using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HelloPeteTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HelloPeteSaysHelloPete()
        {
            //arrange
            var util = new HelloPete.Utilities();
            string expected = "Hello Pete!";
            //act 

            var actual = util.HelloPete();
            //assert 
            Assert.AreEqual(expected, actual);
          
        }
    }
}
