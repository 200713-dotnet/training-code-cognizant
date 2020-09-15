using System.Collections.Generic;

namespace StackDemo
{
  public class Stackup<T>
  {
    private LinkedList<T> _ll = new LinkedList<T>();

    public void Push(T o)
    {
      _ll.AddLast(o);
    }

    public void Pop(out T result)
    {
      result = _ll.Last.Value;
      _ll.RemoveLast();
    }

    public bool Contain(T o)
    {
      return _ll.Find(o) != null;
    }

    public T Peek()
    {
      return _ll.Last.Value;
    }
  }
}
