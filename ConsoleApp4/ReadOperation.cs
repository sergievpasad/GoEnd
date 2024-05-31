using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoEnd
{
    internal class ReadOperation : IReadOperation
    {
        public ReadOperation(int NumberOperation)
        {
            NumberOper = NumberOperation;
        }
        public int NumberOper {get;}

        public int TakeNumOper(int NumberOper)
        {
            return NumberOper;
        }

    }
}
