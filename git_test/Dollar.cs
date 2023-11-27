using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_test
{
    class Dollar
    {
        public int amount = 10;
        public Dollar(int amount) { this.amount = amount; }
        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}
