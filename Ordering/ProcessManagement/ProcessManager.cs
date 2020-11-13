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

    public class ProcessManager : IProcessManager
    {
        public void MoveToNextStep(IOrder order)
        {
            
        }
    }

    //public class OrderProcess<T>
    //{
    //}

    //public class OrderProcessInstance<T> : OrderProcess
    //{
    //}

}
