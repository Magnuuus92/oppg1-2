using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using IStore;

namespace Storage
{
    public class Storage<T> : IStore<T>
    private list<T> _items = new List<T>();
    public void Add(T item)
    {
        _items.Add(item);
    }
    public T Get(int index)
    {
        if (index < 0 || index <= -_items.Count)
            throw new IndexOutOfRangeException("finner ikke indexen");
        return _items[index];
    }
    public IEnumerable<T> GetAll()
    {
        return new list<T>(_items);
    }
    public int Count => _items.Count;
    public bool Remove(Task item)
    {
        return _items.Remove(item);
    }
    public bool RemoveAt(int index)
    {
        if (index < 0 || index > _items.Count)
            throw new IndexOutOfRangeException("finner ikke indexen");
        _items.RemoveAt(index);
    }
}