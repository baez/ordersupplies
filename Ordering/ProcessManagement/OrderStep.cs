using Interfaces.ProcessManagement;
using Interfaces.QueueManagement;
using System;

namespace ProcessManagement
{
    public class OrderStep<T> : IOrderStep<T>
    {
        // add step activation datetime

        public IOrderQueue<T> OrderQueue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IOrderQueue<T> IOrderStep<T>.OrderQueue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
