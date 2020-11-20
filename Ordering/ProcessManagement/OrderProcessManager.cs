using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagement
{
    /*
     * 
     * 
     *        |<-----------------|
     *        |                  |
     *    OrderPlacement --> OrderReview --> Purchasing --> Complete
     * */

    public class OrderProcessManager<T> : IOrderProcessManager<T>
    {
        public void MoveToNextStep(IOrderProcess<T> order)
        {
            
        }
    }

    //public class OrderProcess<T>
    //{
    //}

    //public class OrderProcessInstance<T> : OrderProcess
    //{
    //}


    //just testing to add a file2
}
