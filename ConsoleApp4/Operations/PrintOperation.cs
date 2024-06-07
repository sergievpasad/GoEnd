using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoEnd
{
    public abstract class PrintOperation:IOperation
    {
        public PrintOperation(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract void Run();
    }
}
