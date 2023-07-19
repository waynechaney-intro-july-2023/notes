using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculatorTests
    {
        [Fact]
        public void EmptyStringReturnsZero()
        {
            //Given
            var calculator = new StringCalculator();

            //When
            var result = calculator.Add("");

            Assert.Equal(0, result);
        }
     }
}
