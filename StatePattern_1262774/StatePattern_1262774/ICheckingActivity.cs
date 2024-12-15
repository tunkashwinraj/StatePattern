using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_1262774
{
    interface ICheckingActivity
    {
        void WithDrawMoney(double amt); // may cause to change state
        void DepositMoney(double amt); // may cause to change state
        void AddInterest(); // may cause to change state
    }

}
