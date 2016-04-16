using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MartingaleTheory.Tests
{
    [TestClass]
    public class MartingaleTests
    {
        Martingale martingale;

        [TestInitialize]
        public void Init()
        {
            martingale = new Martingale(1000);
        }
        [TestMethod]
        public void ConstructorInitializesCurrentBalanceTest()
        {
            Assert.AreEqual(1000,martingale.CurrentBalance);
        }

        [TestMethod]
        public void IncrementCurrentBalanceTest()
        {
            martingale.UpdateBalance(0.85f);

            Assert.AreEqual(1000.85f, martingale.CurrentBalance);
        }

        [TestMethod]
        public void CalculateWinningTradeAmountTest()
        {
            float winningAmount = martingale.CalculateWinningTradeAmount(1, 0.85f);

            Assert.AreEqual(1.85f, winningAmount);
        }
    }
}