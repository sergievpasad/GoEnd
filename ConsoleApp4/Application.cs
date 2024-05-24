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
        Operation operation = (Operation)menu.Show().ItemSelector.Select();
        double result = operation.Run(10, 5);
        Console.WriteLine($"Результат: {result}");
    }
}
