using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoEnd
{
    public interface IOperationProvider
    {
        public IEnumerable<Operation> Get();
    }
}

