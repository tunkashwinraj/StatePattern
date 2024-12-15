using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern_1262774
{
    class OverDrawState : BaseState
    {
        double overdrawFee = 0;
        double overdrawLimit = -100;

        public OverDrawState(BaseState state)
        {
            overdrawFee = 20;
            this.Account = state.Account;
            this.Balance = state.Balance;
        }
        public override void WithDrawMoney(double amt)
        {
            Balance = Balance - overdrawFee;
            if ((Balance - amt) < overdrawLimit)
                Balance = Balance - amt;
            else
                MessageBox.Show("cannot withdraw, limit reached");
        }
        public override void DepositMoney(double amt)
        {
            Balance = Balance + amt;
            CheckStateChange();
        }
        public override void AddInterest()
        {
            // no interest in overdraw state
        }
        public override string ToString()
        {
            return "balance = " + Balance.ToString() + "\n" +
            "State = OverDrawState";
        }
    }
}
