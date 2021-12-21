using Kata1Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProject1
{
    [TestClass]
    public class TextTest
    {
        [Fact]
        public int Validate_Text()
        {
            Text obj = new Text();

            int value = obj.Test1();

            Assert.AreEqual(value, 2);

            return 0;
        }

    }
}