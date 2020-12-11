using Interfaces.ProcessManagement;
using System.Collections.Generic;
using Interfaces;
using System;
using Interfaces.QueueManagement;

namespace ProcessManagement
{
    /*
     * 
     * 
     *        |<-----------------|
     *        |                  |
     *    OrderPlacement --> OrderReview --> Purchasing --> Complete
     *    
     *    // process status: Done, InProgress, Cancelled
     *    
     *    Create a WPF Application and Add a UI form to view Order Processes and their Status
     *    
     * */

    public class OrderProcessManager<T> : IOrderProcessManager<T>
    {
        //remove not implemented exceptions whenever you see it
        //add constructor to your class
        public IList<IOrderProcess> OrderProcesses { get; set; }

        public void MoveToNextStep(IOrderProcess orderProcess)
        {
            bool isDone = false;
            // do if it is not the last step
            // find the current step in the list of process steps
            // activate the next step
            // set the process status    
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

    //public class OrderProcess<T>
    //{
    //}

    //public class OrderProcessInstance<T> : OrderProcess
    //{
    //}


    //just testing to add a file2

    //while (op.CurrentStep != /*last step*/) //not sure here
    //            {
    //                foreach (OrderProcess<T> step in OrderProcesses)
    //                {
    //                    if (step == orderProcess)
    //                    {
    //                        Console.WriteLine("Currently in step :", step);
    //                        if (!isDone)
    //                        {
    //                            orderProcess.Status = OrderProcessStatus.InProgress;
    //                        }
    //                        else if (isDone)
    //                        {
    //                            orderProcess.Status = OrderProcessStatus.Completed;
    //                        }
    //                    }
    //                }
}
