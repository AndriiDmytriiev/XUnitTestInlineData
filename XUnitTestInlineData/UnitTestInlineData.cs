
using NSubstitute;
using System;
using Assert = Xunit.Assert;
namespace XUnitTestInlineData
{

    public class MethodTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        public void TestAMethod(int number, string expected)
        {
            var mock = Substitute.For<Random>();
            mock.Next(1, 100).Returns(number);

            Assert.Equal(expected, GetFizzBuzz(mock));



            GetFizzBuzz(new Random());

        }


        public string GetFizzBuzz(Random random)
        {

            int number = ResInt(random);

            if (number % 3 == 0 && number % 5 == 0)
            {

                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
        public int ResInt(Random random)
        {


            //int resrandom = random.Next(1, 100);
            // Create a mock object


            // Configure the method to return an integer value


            // Now when the method is called, it will return 42
            int result = random.Next(1, 100);
            return result;
        }
    }


}