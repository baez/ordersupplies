using System.Collections.Generic;
using System;

namespace Interfaces.ProcessManagement
{
    public interface IOrderProcess
    {
        ProcessStep CurrentStep { get; }

        OrderProcessStatus Status { get; }

        DateTime IncidentActivationTime { get; }

        int IncidentNumber { get; }

        void Cancel();

        void MoveToNextStep();
    }
}
