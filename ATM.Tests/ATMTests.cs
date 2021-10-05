using System;
using Xunit;

namespace ATM.Tests
{
    public class ATMTests
    {
        [Fact]
        public void GetBalance_Returns_Current_Balance()
        {
            // Arrange
            BankAccount checkBA = new BankAccount();

            // Act
            decimal result = checkBA.GetBalance();

            // Assert
            Assert.Equal(0, result);
        }
    }
}
