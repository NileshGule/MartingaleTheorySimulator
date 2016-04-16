using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheory
{
    public class Recovery
    {
        public int RecoveryNumber { get; private set; }
        public double TradeAmount { get; private set; }
        public double CummulativeLoss { get; private set; }

        public Recovery(int recoveryNumber, double tradeAmount, double cumulativeLoss)
        {
            RecoveryNumber = recoveryNumber;
            TradeAmount = tradeAmount;
            CummulativeLoss = cumulativeLoss;
        }
    }
}
