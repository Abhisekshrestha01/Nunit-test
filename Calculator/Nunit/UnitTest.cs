using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Library
{
    [TestFixture]
    class UnitTest
    {
        [TestCase]
        public void Addition_test()
        {//Arrange Section - We initialize variables and set its values
            int expectedresult = 24;
            int num1 = 20;
            int num2 = 4;

            //Act Section - We invoke tge mehotds we want tot test
            int actualresult = CalculationOperation.Add(num1, num2);

            //Assert Section - We verify the method we want to verify if the method behaves as per expected
            Assert.AreEqual(expectedresult, actualresult);
            Console.WriteLine("This is the test method");

        }
        
    }
}
