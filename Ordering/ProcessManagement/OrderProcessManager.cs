using Interfaces.ProcessManagement;
using System.Collections.Generic;
using Interfaces;
using System;
using Interfaces.QueueManagement;

namespace ProcessManagement
{
    /*
     *        |<-----------------|
     *        |                  |
     *    OrderPlacement --> OrderReview --> Purchasing --> Complete
     *    
     *    // process status: Done, InProgress, Cancelled
     *    
     *    Create a WPF Application and Add a UI form to view Order Processes and their Status
     *    
     * */

    public class OrderProcessManager : IOrderProcessManager
    {
        public IList<IOrderProcess> OrderProcesses { get; set; }

        public OrderProcessManager()
        {

        }

        public void MoveToNextStep(IOrderProcess orderProcess)
        {
            foreach(OrderProcess op in OrderProcesses)
            {
                if (op.IncidentNumber == orderProcess.IncidentNumber)
                {
                    op.MoveToNextStep();
                    break;
                }
     
            }
        }
    }
}
