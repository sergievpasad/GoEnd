namespace GoEnd
{
    public class Menu : IMenu
    {
        public void Show(Operation[] operations)
        {
            Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
            for (int i = 0; i < operations.Length; i++)
            {
                Operation operation = operations[i];
                Console.WriteLine($"{i + 1}. {operation.Name}");

            }
            Console.Write("Выберите действие: ");
        }
        public Operation TakeOper(Operation[] operations)
        {
            return operations[Convert.ToInt32(Console.ReadLine()) - 1];
        }
    }
}