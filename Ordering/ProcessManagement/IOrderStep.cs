using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagement
{
<<<<<<< HEAD:Ordering/ProcessManagement/OrderProcess.cs
    public class OrderProcess
    { 
        /*
         * approve/deny order
         * 
         */
=======
    public interface IOrderStep<T>
    {
        IOrderQueue<T> OrderQueue { get; set; }
>>>>>>> c83e7ff3afcb6d5e319b2c2d46024c623103fa80:Ordering/ProcessManagement/IOrderStep.cs
    }
}
