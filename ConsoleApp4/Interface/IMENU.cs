using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoEnd
{
    public interface IMenu
    {
        public void Show(Operation[] operations);
        public Operation TakeOper(Operation[] operations);
    }

}
