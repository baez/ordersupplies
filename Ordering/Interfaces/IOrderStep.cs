using Interfaces.QueueManagement;

namespace Interfaces.ProcessManagement
{
    public interface IOrderStep<T>
    {
        IOrderQueue<T> OrderQueue { get; set; }

    }
}
