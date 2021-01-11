using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountSim;

namespace BankAccountTests
{
    [TestClass]
    public class UnitTest1
    {
        BankAccount bankAccount = new BankAccount(1000, 0);

        [TestMethod]
        public void TestDeposit()
        {
            bankAccount.deposit(500);
            Assert.AreEqual(bankAccount.Balance, 1500, 0.01);
        }

        [TestMethod]
        public void TestWithdraw()
        {
            bankAccount.withdraw(500);
            Assert.AreEqual(bankAccount.Balance, 500, 0.01);
        }

        [TestMethod]
        public void TestCredit()
        {
            bankAccount.Credit(500);
            Assert.AreEqual(bankAccount.Balance, 1500, 0.01);
            Assert.AreEqual(bankAccount.CreditBalance, 650, 0.01);
        }

        [TestMethod]
        public void TestCreditDeposit()
        {
            bankAccount.Credit(500);
            bankAccount.deposit(670);
            Assert.AreEqual(bankAccount.Balance, 1520, 0.01);
            Assert.AreEqual(bankAccount.CreditBalance, 0, 0.01);
        }
    }
}
