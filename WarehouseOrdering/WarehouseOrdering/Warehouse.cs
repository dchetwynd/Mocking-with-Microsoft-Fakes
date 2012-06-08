using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseOrdering
{
    public class Warehouse: IWarehouse
    {
        private Dictionary<string, int> Items = new Dictionary<string, int>();

        public void Add(string itemName, int quantity)
        {
            if (Items.ContainsKey(itemName))
                Items[itemName] += quantity;
            else
                Items.Add(itemName, quantity);
        }

        public int GetInventory(string itemName)
        {
            return Items.ContainsKey(itemName) ?
                Items[itemName] : 0;
        }

        public bool HasInventory(string itemName, int quantity)
        {
            return Items.ContainsKey(itemName) ?
                (Items[itemName] >= quantity) : false;
        }

        public void Remove(string itemName, int quantity)
        {
            if (HasInventory(itemName, quantity))
                Items[itemName] -= quantity;
        }
    }
}
