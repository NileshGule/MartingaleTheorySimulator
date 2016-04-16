using MartingaleTheory;
using System;
using System.Collections.Generic;

namespace MartingaleConsoleClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double initialAmount = 1;
            double payoutPercentage = 0.70;
            int numberOfRecoveries = 10;
            MartingaleStrategy martingale = new MartingaleStrategy(initialAmount, payoutPercentage, numberOfRecoveries);

            List<Recovery> recoveries = martingale.Recoveries;

            foreach (Recovery recovery in recoveries)
            {
                Console.WriteLine("Recovery number : {0}, TradeAmount : {1}, CommulativeLoss : {2}", recovery.RecoveryNumber, recovery.TradeAmount, recovery.CummulativeLoss);
            }
        }
    }
}