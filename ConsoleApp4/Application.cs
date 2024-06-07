using System.Reflection.Metadata.Ecma335;

namespace GoEnd;

public class Application
{
    public Application(
        IMenu<IOperation> menu)
    {
        this.menu = menu;
    }

    private IMenu<IOperation> menu;

    public void Run()
    {
        Console.Write("Введите пароль: ");
        ConsoleKey key = Console.ReadKey().Key;
        if (key == ConsoleKey.Z)
        {
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.X)
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.C)
                {
                    Console.Clear();
                    while (key != ConsoleKey.Escape)
                    {
                        ReadNumbers readNumbers = new ReadNumbers();
                        Operation operation = (Operation)menu.Show().ItemSelector.Select();
                        double result = operation.Run(readNumbers.ReadNums(operation.NumCount));
                        Console.WriteLine($"Результат: {result}");
                        key = Console.ReadKey().Key;
                        Console.Clear();
                    }
                }
            }
        }
    }
}
