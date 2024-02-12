using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericTestProject
{
    [TestFixture]
    internal class CustomerTest
    {
        [Test]
        public void AddCustometTest()
        {


            //create the object
            // which function to by pass
            Mock<NumericLibrary.EMail> obj = new Mock<NumericLibrary.EMail>();
            // Setup the moq
            obj.Setup(x => x.SendEmail()).Returns(true);
            NumericLibrary.Customer customer = new NumericLibrary.Customer();
            bool isInserted = customer.AddCustomer(obj.Object);
            Assert.AreEqual(isInserted, true);


        }
    }
}
