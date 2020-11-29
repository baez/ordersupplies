using System.Collections.Generic;

namespace Interfaces.ProcessManagement
{
    public interface IOrderProcessManager<T>
    {
        IList<IOrderProcess<T>> OrderProcesses { get; set; }

        void MoveToNextStep(IOrderProcess<T> orderProcess);
    }
}
