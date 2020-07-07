using System;
using Xunit;
using static Lab02_UnitTests.Program;

namespace ATM_Unit_Tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void DoesViewBalanceReturnBalance()
        {
            decimal testBalance = 123;
            Balance = testBalance;
            Assert.Equal(testBalance, ViewBalance());
        }

        [Fact]
        public void DoesViewBalanceReturnNegativeBalance()
        {
            decimal testBalance = -5;
            Balance = testBalance;

            Assert.Equal(0, ViewBalance());
        }

        [Fact]
        public void CanWithdrawAmountFromBalance()
        {   
            //Arrange
            decimal testBalance = 500;
            Balance = testBalance;
            decimal testAmount = 100;

            //Act
            decimal value = Withdraw(testAmount);

            //Assert
            Assert.Equal(400, value);
        }

        [Fact]
        public void IsAmountGreaterThanBalance()
        {
            decimal testBalance = 100;
            Balance = testBalance;
            decimal testAmount = 500;

            decimal value = Withdraw(testAmount);

            Assert.Equal(100, value);
        }

        [Fact]
        public void IsWithdrawAmountGreaterThanZero()
        {
            decimal testBalance = 500;
            Balance = testBalance;
            decimal testAmount = 0;

            decimal value = Withdraw(testAmount);

            Assert.Equal(500, value);
        }
        
        [Fact]
        public void CanDepositAmountToBalance()
        {
            decimal testBalance = 500;
            Balance = testBalance;
            decimal testAmount = 100;

            decimal value = Deposit(testAmount);

            Assert.Equal(600, value);
        }

        
        [Fact]
        public void IsDepositAmountGreaterThanZero()
        {
            decimal testBalance = 500;
            Balance = testBalance;
            decimal testAmount = -100;

            decimal value = Deposit(testAmount);

            Assert.Equal(500, value);
        }
        
    }
}
