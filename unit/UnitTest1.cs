using Azure_App_1.Module;
using System.Reflection.Metadata.Ecma335;

namespace unit
{
    public class UnitTest1
    {
        [Fact]
        public void DemoTest()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "value should be equal to 1");
        }
        [Fact]
        public void CheckAddFuntion()
        {
            functions func = new functions();
            int y = func.Add(3, 2);
            bool result = false;

            if (y == 5 ) result = true;
            Assert.True(result, "should be 5");
        }
    }
}