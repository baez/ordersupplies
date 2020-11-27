using Interfaces.QueueManagement;

namespace QueueManagement
{
    // Harman and Abbe : 
    // I created the IQueue interface for you.
    // Please implement the Queue constructor and functions 
    // 

    public class OrderQueue<T> : IOrderQueue<T>
    {
        public OrderQueue()
        {

        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public T Dequeue()
        {
            throw new System.NotImplementedException();
        }

        public void Enqueue(T item)
        {
            throw new System.NotImplementedException();
        }

        public T Peek()
        {
            throw new System.NotImplementedException();
        }
    }
}
