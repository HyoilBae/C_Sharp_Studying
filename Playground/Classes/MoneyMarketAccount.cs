using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    public class MoneyMarketAccount : BankAccount
    {
        public void DebitFee(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                OnOverdrawn(new OverdrawnEventArgs(Balance, amount));
            }
        }
    }
}
