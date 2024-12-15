using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_1262774
{
    class GoldState : BaseState
    {
        public GoldState(BaseState state)
        {
            this.Account = state.Account;
            this.Balance = state.Balance;
        }
        public override void WithDrawMoney(double amt)
        {
            Balance = Balance - amt;
            CheckStateChange();
        }
        public override void DepositMoney(double amt)
        {
            Balance = Balance + amt;
            CheckStateChange();
        }
        public override void AddInterest()
        {
            Balance = Balance + 0.03 * Balance; // 3% interest
            CheckStateChange();
        }

        public override string ToString()
        {
            return "balance = " + Balance.ToString() + "\n" +
            "State = GoldState";
        }
    }
}
