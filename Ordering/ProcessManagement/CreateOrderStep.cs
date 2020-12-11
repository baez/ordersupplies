using Interfaces.ProcessManagement;
using Interfaces.QueueManagement;
using QueueManagement;
using System;

namespace ProcessManagement
{
    public class CreateOrderStep<T> : IOrderStep<T>
    {
        // add step activation datetime (a field - timestamp)
        public IOrderQueue<T> OrderQueue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IOrderQueue<T> IOrderStep<T>.OrderQueue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CreateOrderStep()
        {
            OrderQueue = new OrderQueue<T>();
        }

        public DateTime Add(TimeSpan value)
        {
            throw new NotImplementedException();
        }
    }
}
