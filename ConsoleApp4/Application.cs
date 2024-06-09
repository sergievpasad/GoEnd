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
        CheckThePassword us = new CheckThePassword();
        ReadNumbers readNumbers = new ReadNumbers();
        Continue next = new Continue();
        us.CheckPaswword();
        ConsoleKey key = ConsoleKey.Z ;
        while (key != ConsoleKey.Escape)
        {
            
            Operation operation = (Operation)menu.Show().ItemSelector.Select();
            double result = operation.Run(readNumbers.ReadNums(operation.NumCount));
            Console.WriteLine($"Результат: {result}");
            next.ContinueWrite();
            key =Console.ReadKey().Key;
            Console.Clear();
        }                
    }
}
