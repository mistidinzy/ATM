using System;
using Xunit;

namespace ATM.Tests
{
    public class UnitTest1
    {
        [Fact]
<<<<<<< Updated upstream
        public void Test1()
        {
            int zero = 1 - 2;
            int num = 7 / zero;
=======
        public void GetBalance_Returns_Zero_Balance_For_New_Account()
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
            bankaccount.Deposit(30);

            // Assert
            decimal newBalance = bankaccount.GetBalance();
            Assert.Equal(30, newBalance);
        }

        [Fact]
        public void Throws_If_Negative_Deposit()
        {
            // Arrange
            BankAccount bankaccount = new BankAccount();

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                // Act
                bankaccount.Deposit(-1);
            });
        }

        [Fact]
        public void Withdraw_Subtracts_From_Balance()
        {
            //Arrange
            BankAccount bankaccount = new BankAccount();
            bankaccount.Deposit(3);
            //Act
            bankaccount.Withdraw(1);

            //Assert
            decimal newBalance = bankaccount.GetBalance();
            Assert.Equal(2, newBalance);
>>>>>>> Stashed changes
        }


        [Fact]
        public void Withdraw_Amount_Is_More_Than_Balance()
        {
            // Arrange
            BankAccount bankaccount = new BankAccount();
            bankaccount.Deposit(3);

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                bankaccount.Withdraw(1);
            }
            );
        }

    } //nothing outside of here
}
