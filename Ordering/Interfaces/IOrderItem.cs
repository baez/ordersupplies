using System;

namespace Interfaces
{
    public interface IOrderItem
    {
        int ItemID { get; }
        string Name { get; set; }
        string ItemDescription { get; set; }
        double Price { get; set; }
        OrderItemCategory Category { get; set; }
    }
}
