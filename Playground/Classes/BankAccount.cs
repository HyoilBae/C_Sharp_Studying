using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    [Serializable]
    public class BankAccount
    {
        public event EventHandler<OverdrawnEventArgs> Overdrawn;

        public decimal Balance { get; set; }

        public void Credit(decimal amount) => Balance += amount;

        public void Debit(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                if (Overdrawn != null)
                    OnOverdrawn(new OverdrawnEventArgs(Balance, amount));
            }
        }

        protected virtual void OnOverdrawn(OverdrawnEventArgs args) => Overdrawn?.Invoke(this, args);
    }
}
