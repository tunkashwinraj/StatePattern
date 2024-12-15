using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_1262774
{
    class SilverState : BaseState
    {
        public SilverState(double bal, CheckingAccount acct)
        {
            this.Balance = bal;
            this.Account = acct;
        }
        public SilverState(BaseState state)
        {
            this.Account = state.Account;
            this.Balance = state.Balance;
        }

        public override void WithDrawMoney(double amt)
        {
            Balance = Balance - amt - 1; // $1 transaction fee for Silver
                                         
            CheckStateChange();
        }
        public override void DepositMoney(double amt)
        {
            Balance = Balance + amt;
            CheckStateChange();
        }
        public override void AddInterest()
        {
            // no interest in silver state
        }
        public override string ToString()
        {
            return "balance = " + Balance.ToString() + "\n" +
            "State = SilverState";
        }
    }
}
