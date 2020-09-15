namespace StackDemo
{
  public class LinkedListDemo<T> // current node
  {
    private LinkedListDemo<T> _prior; // previous node

    private LinkedListDemo<T> _head; // first node
    private LinkedListDemo<T> _tail; // last node

    public T Last { get; private set; }

    public void AddLast(T o) // actual/real, and default/null
    {
      // input validation
      var lld = new LinkedListDemo<T>();

      lld._prior = this;
      lld.Last = o;
    }

    public LinkedListDemo<T> RemoveLast(out T result)
    {
      result = Last;

      // think about the head node
      return this._prior;
    }

    public T Find(T o)
    {
      if (Last.Equals(o))
      {
        return Last;
      }

      if (_prior != null)
      {
        _prior.Find(o);
      }

      return default(T);
    }
  }
}
