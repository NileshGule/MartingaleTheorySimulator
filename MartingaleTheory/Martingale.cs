using System;

namespace MartingaleTheory
{
    public class Martingale
    {
        public Martingale(float initialBalance)
        {
            CurrentBalance = initialBalance;
        }

        public float CurrentBalance
        {
            get;

            private set;
        }

        public void UpdateBalance(float amount)
        {
            CurrentBalance += amount;
        }

        public float CalculateWinningTradeAmount(int tradeAmount, float payoutPercentage)
        {
            float winningAmount = tradeAmount * payoutPercentage;

            return tradeAmount + winningAmount;
        }
    }
}