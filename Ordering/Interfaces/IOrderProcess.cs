using System.Collections.Generic;
using System;

namespace Interfaces.ProcessManagement
{
    public interface IOrderProcess<T>
    {
        List<IOrderStep<T>> Steps { get; set; }

        IOrderStep<T> CurrentStep { get; set; }

        OrderProcessStatus Status { get; set; }

        DateTime IncidentDate { get; set; }
        int IncidentNumber { get; set; }

    }
}
