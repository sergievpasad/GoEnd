namespace GoEnd;

public interface IMenuItemSelector<out T>
{
    public T Select();
}
