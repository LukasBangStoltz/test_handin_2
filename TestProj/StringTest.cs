using ConsoleApp1;
using Assert = Xunit.Assert;

namespace TestProj
{
    public class StringTest
    {
        [Fact]
        public void TestReverse()
        {
            
            Assert.Equal("ccbbaa", Functions.ReverseString("aabbcc")); 
        }
        [Fact]
        public void TestLower()
        {

            Assert.Equal("aaaaaabbbbcccc", Functions.LowerString("AAAAaaBBBBcccc"));
        }
        [Fact]
        public void TestUpper()
        {

            Assert.Equal("AABBCC", Functions.CapitalizeString("aabbcc"));
        }
    }
}