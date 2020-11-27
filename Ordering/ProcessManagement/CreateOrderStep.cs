using Interfaces;
using Interfaces.ProcessManagement;
using QueueManagement;
using System;

namespace ProcessManagement
{
    public class CreateOrderStep<T> : IOrderStep<T>
    {
        // add step activation datetime
        public IOrderQueue<T> OrderQueue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CreateOrderStep()
        {
            OrderQueue = new OrderQueue<T>();
        }

        
    }
}
