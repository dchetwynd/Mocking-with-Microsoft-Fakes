using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseOrdering
{
    public class Order
    {
        public Order(string itemName, int itemQuantity)
        {
            _itemName = itemName;
            _itemQuantity = itemQuantity;
            IsFilled = false;
        }

        public void Fill(IWarehouse warehouse)
        {
            if (warehouse.HasInventory(_itemName, _itemQuantity))
            {
                IsFilled = true;
                warehouse.Remove(_itemName, _itemQuantity);
            }
        }

        private string _itemName;
        private int _itemQuantity;

        public bool IsFilled { get; set; }
    }
}
