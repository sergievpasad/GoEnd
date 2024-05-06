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

    public class OperationProvider : IOperationProvider
    {
        private IEnumerable<Operation> operations;

        public OperationProvider(IEnumerable<Operation> operations)
        {
            this.operations = operations;
        }

        public IEnumerable<Operation> Get()
        {
            return operations;
        }
    }
}

