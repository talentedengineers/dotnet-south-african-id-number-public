namespace DotNetSouthAfricanIdNumber.Tests
{
    [TestClass]
    public class SouthAfricanIdNumberTest
    {
        [TestMethod]
        public void Validate()
        {
            Assert.AreEqual(true, SouthAfricanIdNumber.Validate("7111207908102"));
        }
    }
}