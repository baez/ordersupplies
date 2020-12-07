using Interfaces.ProcessManagement;
using System.Collections.Generic;
using Interfaces;

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
        public IList<IOrderProcess<T>> OrderProcesses { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void MoveToNextStep(IOrderProcess<T> orderProcess)
        {
            bool isDone = false;
            // do if it is not the last step
            // find the current step in the list of process steps
            // activate the next step
            // set the process status    
            foreach(OrderProcess<T> op in OrderProcesses)
            {
                while (op.CurrentStep != /*last step*/) //not sure here
                {
                    foreach (OrderProcess<T> step in OrderProcesses)
                    {
                        if (step == orderProcess)
                        {
                            Console.Writeline("Currently in step :", step);
                            if (!isDone)
                            {
                                orderProcess.Status = OrderProcessStatus.InProgress;
                            }
                            else if (isDone)
                            {
                                orderProcess.Status = OrderProcessStatus.Completed;
                            }
                        }
                    }
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
}
