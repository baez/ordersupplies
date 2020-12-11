using Interfaces.QueueManagement;
using System.Collections.Generic;

namespace Interfaces.ProcessManagement
{
    public interface IOrderProcessManager<T>
    {
        IList<IOrderProcess> OrderProcesses { get; set; }

        void MoveToNextStep(IOrderProcess orderProcess);
    }
}
