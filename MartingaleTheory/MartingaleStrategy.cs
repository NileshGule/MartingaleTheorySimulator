using System;
using System.Collections.Generic;

namespace MartingaleTheory
{
    public class MartingaleStrategy
    {
        public MartingaleStrategy(double initialTradeAmount, double payoutPercentage, int numberOfRecoveries)
        {
            double profitPerTrade = initialTradeAmount * payoutPercentage;

            double currentTradeAmount = initialTradeAmount;

            double cummulativeLoss = initialTradeAmount;

            Recoveries = new List<Recovery>();

            for (int currentRecovery = 1; currentRecovery <= numberOfRecoveries; currentRecovery++)
            {
                currentTradeAmount = Math.Round((cummulativeLoss + profitPerTrade) / payoutPercentage, MidpointRounding.AwayFromZero);

                cummulativeLoss += currentTradeAmount;

                Recovery nextRecory = new Recovery(currentRecovery, currentTradeAmount, cummulativeLoss);

                Recoveries.Add(nextRecory);
            }
        }
        
        public List<Recovery> Recoveries { get; private set; }
    }
}
