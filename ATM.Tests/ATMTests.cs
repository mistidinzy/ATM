using System;
using Xunit;

namespace ATM.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int zero = 1 - 2;
            int num = 7 / zero;
        }
    }
}
