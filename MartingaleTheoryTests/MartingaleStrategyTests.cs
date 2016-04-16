using MartingaleTheory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MartingaleTheoryTests.Tests
{
    [TestClass]
    public class MartingaleStrategyTests
    {
        MartingaleStrategy _martingaleStrategy;

        [TestMethod]
        public void CalculateTenthRecoveryCostTest()
        {
            double initialTradeAmount = 1;
            double payoutPercentage = 0.85;
            int numberOfRecoveries = 10;

            _martingaleStrategy = new MartingaleStrategy(initialTradeAmount, payoutPercentage, numberOfRecoveries);

            double expectedLoss = 4347;
            double expectedTradeAmount = 2350;
            int expectedRecoveryNumber = 10;

            Recovery lastRecovery = _martingaleStrategy.Recoveries.Last();

            Assert.AreEqual(expectedRecoveryNumber, lastRecovery.RecoveryNumber);
            Assert.AreEqual(expectedLoss, lastRecovery.CummulativeLoss);
            Assert.AreEqual(expectedTradeAmount, lastRecovery.TradeAmount);
            
        }

        [TestMethod]
        public void CalculateFirstRecoveryCostTest()
        {
            double initialTradeAmount = 1;
            double payoutPercentage = 0.85;
            int numberOfRecoveries = 1;

            _martingaleStrategy = new MartingaleStrategy(initialTradeAmount, payoutPercentage, numberOfRecoveries);

            double expectedLoss = 3;
            double expectedTradeAmount = 2;
            int expectedRecoveryNumber = 1;

            Recovery firstRecovery = _martingaleStrategy.Recoveries.First();

            Assert.AreEqual(expectedRecoveryNumber, firstRecovery.RecoveryNumber);
            Assert.AreEqual(expectedLoss, firstRecovery.CummulativeLoss);
            Assert.AreEqual(expectedTradeAmount, firstRecovery.TradeAmount);

        }

    }
}
