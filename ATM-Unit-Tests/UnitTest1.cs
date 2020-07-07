using System;
using Xunit;
using static Lab02_UnitTests.Program;

namespace ATM_Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnFizzFor3()
        {
            string fizz = FizzBuzz(3);

            // assert
            Assert.Equal("3", fizz);
        }

    }
}
