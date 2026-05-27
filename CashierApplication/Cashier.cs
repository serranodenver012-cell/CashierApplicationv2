using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public class Cashier : UserAccount
    {
        public Cashier(string name, string uName, string password)
           : base(name, uName, password)
        {
        }

        public override bool validateLogin(string uName, string password)
        {
            return base.validateLogin(uName, password);
        }
    }

}
