using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseOrdering
{
    public interface IWarehouse
    {
        void Add(string itemName, int quantity);

        int GetInventory(string itemName);

        bool HasInventory(string itemName, int quantity);

        void Remove(string itemName, int quantity);
    }
}
