using Boolean.CSharp.Main;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Bank _core;

        public CoreTests()
        {
            _core = new Bank();

        }

        [Test]
        public void CreateCurrent()
        {
            Bank bank = new Bank();
            User user = new User();

            bool actualResults = bank.CreateCurrentAccount(user);
            Assert.That(actualResults);

        }
        [Test]
        public void CreateSavings()
        {
            Bank bank = new Bank();
            User customner = new User();

            bool actualResults = bank.CreateSavingsAccount(customner);
            Assert.That(actualResults);
        }
        [Test]
        public void Deposit()
        {
            Bank bank = new Bank();

            double newBalance = bank.Deposit(1000, 100);
            double expectedBalance = 1100;

            Assert.AreEqual(expectedBalance, newBalance);

        }
        [Test]
        public void withdraw()
        {
            Bank bank = new Bank();

            double newBalance = bank.withDraw(1000,100);
            double expectedBalance = 900;
            Assert.AreEqual(expectedBalance, newBalance);
        }
        
    }
}