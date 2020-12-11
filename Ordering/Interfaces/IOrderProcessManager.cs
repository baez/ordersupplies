using System.Collections.Generic;

namespace Interfaces.ProcessManagement
{
    public interface IOrderProcessManager
    {
        IList<IOrderProcess> OrderProcesses { get; set; }

        void MoveToNextStep(IOrderProcess orderProcess);
    }
}
