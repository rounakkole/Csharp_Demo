using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdditionOfNumbers;
namespace TestAddition
{
    [TestClass]
    public class UnitTest1
    {
        private Program program = new Program();//1000
        //public UnitTest1()
        //{
        //    program =  new Program();//2000
        //}
        [TestMethod]
        public void TestMethod1()
        {
            //A-> Arrangement  A->Act  A->Assert
            //Arrangement
            program = new Program();
            //Act
            var result = program.Add(5, 10);
            Assert.AreEqual(16, result);
        }
    }


}