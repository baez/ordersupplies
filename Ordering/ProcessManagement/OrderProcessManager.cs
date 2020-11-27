using Interfaces.ProcessManagement;

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
