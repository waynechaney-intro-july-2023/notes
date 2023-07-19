using Xunit;
using Xunit.Sdk;

namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Given
            int a = 10; int b = 20; int answer; 
            //When
            answer = a + b;//System Under Test 

            Assert.Equal(30, answer);  
        }

        public void CanAddAnyTwoIntegers(int a, int b, int expected)
        {

            int answer = a + b;
            Assert.Equal(expected, answer);
        }
        public void FormattingMyName(string first, string last, string expected)
        {
            string fullName = Utils.FormatName(first, last);
            Assert.Equal(expected, fullName);
        }
    }
}