namespace GoEnd;

public abstract class Operation : IOperation
{
    public Operation(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract double Run(params double[] numbers);
}
