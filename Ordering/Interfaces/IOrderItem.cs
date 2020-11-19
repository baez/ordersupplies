using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.OrderManagement
{
    public interface IOrderItem
    {
        string Name { get; set; }
        string ItemDescription { get; set; }
        double Price { get; set; }
        DateTime DateLastOrdered { get; set; }
        string Category { get; set; }

    }
}
