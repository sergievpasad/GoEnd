namespace GoEnd;

public interface IOperationProvider
{
    public IEnumerable<Operation> Get();
}
