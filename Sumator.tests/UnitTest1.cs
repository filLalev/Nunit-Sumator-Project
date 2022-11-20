using NUnit.Framework;

namespace Sumator.tests
{
    public class Tests
    {
        
        [Test]
        public void Test_Sum_Positive()
        {
            int result = Sumator.Sum(new int[] { 5, 7 });
            Assert.That(result==12);
            
        }
        [Test]
        public void Test_Sum_OneNumber()
        {
            int result = Sumator.Sum(new int[] { 5 });
            Assert.That(result==5);


        }
        [Test]
        public void Test_Sum_Nonumber()
        {
            int result = Sumator.Sum(new int[] {  });
            Assert.That(result==0);


        }
    }
}