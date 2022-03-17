using System;
using Xunit;
using Unit_Testing;

namespace Test_Unit_Testing
{
    public class UnitTest1
    {
        [Fact]
        public void TestViewBalance1()
        {
            Assert.Equal(ATM.Balance , ATM.ViewBalance());
        }

        [Fact]
        public void TestViewBalance2()
        {
            ATM.Deposit("100");
            ATM.Withdraw("30");
            Assert.Equal(ATM.Balance, ATM.ViewBalance());
        }

        [Fact]
        public void TestDeposit1()
        {
            Assert.Equal(ATM.Balance + 15, ATM.Deposit("15"));
        }

        [Fact]
        public void TestDeposit2()
        {
            Assert.Equal(ATM.Balance + 110, ATM.Deposit("110"));
        }

        [Fact]
        public void TestWithdraw1()
        {
            ATM.Deposit("100");
            Assert.Equal(ATM.Balance - 136, ATM.Withdraw("136"));
        }

        [Fact]
        public void TestWithdraw2()
        {
            ATM.Deposit("100");
            Assert.Equal(ATM.Balance - 20, ATM.Withdraw("20"));
        }
    }
}
