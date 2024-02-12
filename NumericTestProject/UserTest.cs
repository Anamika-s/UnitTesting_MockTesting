using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericTestProject
{
    [TestFixture]
    internal class UserTest
    {
        [Test]
        public void Test()
        {
            // Arrange
            NumericLibrary.User userTest= new NumericLibrary.User();
            // Act
            string actual  = userTest.GetDiscount(50);
            // Assert
            Assert.AreEqual("Discount is 40%", actual);

        }
    }
}
