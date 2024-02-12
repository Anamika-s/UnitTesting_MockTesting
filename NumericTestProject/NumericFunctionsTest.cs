namespace NumericTestProject
{
    public class NumericFunctionsTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
        [Test]
        public void AddNumbers1()
        {
            // AAA
            // A > Arrange
            NumericLibrary.NumericFunctions numericFunctions = new NumericLibrary.NumericFunctions();
            // Act
            int res = numericFunctions.Add(10, 20);
            // Assert
            // Assert > expected , acrual
            Assert.AreEqual(10, res);   

        }

        [Test]
        public void AddNumbers2()
        {
            // AAA
            // A > Arrange
            NumericLibrary.NumericFunctions numericFunctions = new NumericLibrary.NumericFunctions();
            // Act
            int res = numericFunctions.Add(10, 20);
            // Assert
            // Assert > expected , acrual
            Assert.AreEqual(30, res);

        }
        [TestCase(10,20, 30)]
        [TestCase(20,20, 40)]
        [TestCase(30,40, 70)]

        public void AddNumbers(int no1, int no2, int expected)
        {
            // AAA
            // A > Arrange
            NumericLibrary.NumericFunctions numericFunctions = new NumericLibrary.NumericFunctions();
            // Act
            int res = numericFunctions.Add(no1, no2);
            // Assert
            // Assert > expected , acrual
            Assert.AreEqual(expected, res);

        }
    }
}