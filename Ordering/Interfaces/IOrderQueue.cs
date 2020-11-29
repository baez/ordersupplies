namespace Interfaces.QueueManagement
{
    public interface IOrderQueue<T>
    {
        T Dequeue();

        void Enqueue(T item);

        T Peek();

        int Count();
    }
}
