using System.Collections.Generic;

namespace Interfaces.ProcessManagement
{
    public interface IOrderProcess<T>
    {
        List<IOrderStep<T>> Steps { get; set; }

        IOrderStep<T> CurrentStep { get; set; }

        OrderProcessStatus Status { get; set; }

    }
}
