using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException: Exception
    {
        // Setup a standard constructor, inheriting from base exception
        public FraudException(): base() { }

        //  Overloaded exception
        public FraudException(string message)
            // Also inheriting from base
            : base(message) { }

    }
}
