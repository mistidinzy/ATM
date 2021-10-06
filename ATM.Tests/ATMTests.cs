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
            BankAccount bankaccount = new BankAccount();

            // Act
            decimal result = bankaccount.GetBalance();

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Deposit_Adds_To_Balance()
        {
            // Arrange
            BankAccount bankaccount = new BankAccount();

            // Act
            bankaccount.Deposit(40);

            // Assert
            decimal newBalance = bankaccount.GetBalance();
            Assert.Equal(40, newBalance);
        }

        [Fact]
        public void Throws_Negative_Deposit()
        {
            // Arrange
            BankAccount bankaccount = new BankAccount();

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                bankaccount.Deposit(-10);
            });
        }
    }
}
