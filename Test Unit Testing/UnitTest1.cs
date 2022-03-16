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
            Assert.Equal(Program.Balance , Program.ViewBalance());
        }

        [Fact]
        public void TestViewBalance2()
        {
            Program.Deposit("100");
            Program.Withdraw("30");
            Assert.Equal(Program.Balance, Program.ViewBalance());
        }

        [Fact]
        public void TestDeposit1()
        {
            Assert.Equal(Program.Balance + 15, Program.Deposit("15"));
        }

        [Fact]
        public void TestDeposit2()
        {
            Assert.Equal(Program.Balance + 30, Program.Deposit("30"));
        }

        [Fact]
        public void TestWithdraw1()
        {
            Program.Deposit("100");
            Assert.Equal(Program.Balance - 15, Program.Withdraw("15"));
        }

        [Fact]
        public void TestWithdraw2()
        {
            Program.Deposit("100");
            Assert.Equal(Program.Balance - 30, Program.Withdraw("30"));
        }
    }
}
