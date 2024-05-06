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

    public sealed class Menu : IMenu
    {
        public void Show(Operation[] operations)
        {
            Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
            for (int i = 0; i < operations.Length; i++)
            {
                Operation operation = operations[i];
                Console.WriteLine($"{i + 1}. {operation.Name}");
            }
        }
        public Operation TakeOper(Operation[] operations)
        {
            Console.Write("Выберите действие: ");
            return operations[Convert.ToInt32(Console.ReadLine()) - 1];
        }
    }

}
