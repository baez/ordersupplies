using Interfaces.ProcessManagement;
using Interfaces.QueueManagement;
using System;

namespace ProcessManagement
{
    public class OrderStep<T> : IOrderStep<T>
    {
        // add step activation datetime

        public IOrderQueue<T> OrderQueue { get; set; }

        //add property for datetime - call it step activation time
        //add a constructor and set activation time, 
        public DateTime ActivationTime { get; set; }

        //3 more steps classes
        /*
         * follow the create order step
         * 
         */
    }
}
