using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_1262774
{
    abstract class BaseState : ICheckingActivity
    {
        // the decision to move to another state
        // is managed by the individual state itself
        // The context i.e., CheckAccount in this
        // example maintains the current state of the
        // system
        // context has a reference to the current state
        // and state has a reference to the context
        // so that it can update the current state
        CheckingAccount account; // context
        public CheckingAccount Account
        {
            get { return account; }
            set { account = value; }
        }
        double balance; // so that state change can be determined
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        // ICheckingActivity members
        public abstract void WithDrawMoney(double amt);
        public abstract void DepositMoney(double amt);
        public abstract void AddInterest();
        public void CheckStateChange()
        {
            // decide what the next state will be
            if (balance < 0)
                account.State = new OverDrawState(this);
            if ((balance >= 0) && (balance < 1000))
                account.State = new SilverState(this);
            if ((balance >= 1000) && (balance < 5000))
                account.State = new GoldState(this);
            if (balance >= 5000)
                account.State = new PlatinumState(this);
        }
    }

}
