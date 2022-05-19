using CofeeMakerDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CofeeMakerTest
{


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrderACoffee_Should_return_Received_Message()
        {
            StarBucksStore store = new StarBucksStore(new StarBucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received.", result);
        }

        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingStub()
        {
            StarBucksStore store = new StarBucksStore(new StubStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your order is received.", result);
        }

        //Moq MOCK

        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingMock()
        {
            var service = new Mock<IMakeACoffee>();
            service.Setup(x => x.CheckIngredientAvailability()).Returns(true);
            service.Setup(x => x.CoffeeMaking(It.IsAny<int>(), It.IsAny<int>())).Returns("Your Order is received1.");
            //service.Setup(x => x.CheckIngredientAvailability()).Returns(true);
            IMakeACoffee value = service.Object;
            StarBucksStore store = new StarBucksStore(value);

            var result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received1.", result);

        }



    }

}