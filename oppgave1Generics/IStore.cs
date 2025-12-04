using Systems.Collections;

namespace IStore
{
    public interface IStore
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