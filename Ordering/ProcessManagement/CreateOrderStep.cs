using Interfaces.ProcessManagement;
using Interfaces.QueueManagement;
using QueueManagement;
using System;

namespace ProcessManagement
{
    public class CreateOrderStep<T> : OrderStep<T>, IOrderStep<T>
    {

        public CreateOrderStep()
        {
            OrderQueue = new OrderQueue<T>();
        }

        //call the base constructor (orderstep)
    }
}
