using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoEnd
{
    public class Application
    {
        public Application(
            IWindsorContainer container,
            IOperationProvider operationProvider,
            IMenu menu)
        {
            this.container = container;
            this.operationProvider = operationProvider;
            this.menu = menu;
        }

        private IWindsorContainer container;
        private IOperationProvider operationProvider;
        private IMenu menu;
        private IEnumerable<Operation> operations;

        public void Run()
        {
            operations = operationProvider.Get();
            menu.Show(operations.ToArray());
            Operation operation = menu.TakeOper(operations.ToArray());
            operation.Run(10, 5);
        }
    }
}
