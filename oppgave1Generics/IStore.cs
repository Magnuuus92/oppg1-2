

namespace IStore
{
    public interface IStore<T>
    {
        void add(T item);
        T Get(int index);
        IEnumerable<T> GetAll();
        int Count { get; }
        bool Remove(T item);
        void RemoveAt(int index);
        void Clear();

    }


}