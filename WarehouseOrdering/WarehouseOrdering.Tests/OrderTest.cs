using System;
using NUnit.Framework;
using WarehouseOrdering.Fakes;

namespace WarehouseOrdering.Tests
{
    [TestFixture]
    public class OrderTest
    {
        [Test]
        public void WarehouseStockRemovedWhenSufficientStockAvailableForOrder()
        {
            Order order = new Order("milk", 20);
            Warehouse warehouse = new Warehouse();
            warehouse.Add("milk", 50);

            order.Fill(warehouse);

            Assert.That(warehouse.GetInventory("milk"), Is.EqualTo(30));
        }

        [Test]
        public void WarehouseStockNotRemovedWhenInsufficientStockAvailableForOrder()
        {
            Order order = new Order("milk", 20);
            Warehouse warehouse = new Warehouse();
            warehouse.Add("milk", 15);

            order.Fill(warehouse);

            Assert.That(warehouse.GetInventory("milk"), Is.EqualTo(15));
        }

        [Test]
        public void OrderIsFilledForSufficientStockInWarehouse()
        {
            Order order = new Order("milk", 20);

            var warehouse = new StubIWarehouse()
            {
                HasInventoryStringInt32 = (itemName, quantity) =>
                {
                    return true;
                },

                RemoveStringInt32 = (itemName, quantity) =>
                {
                    return;
                }
            };

            order.Fill(warehouse);

            Assert.True(order.IsFilled);
        }

        [Test]
        public void OrderIsNotFilledForInsufficientStockInWarehouse()
        {
            Order order = new Order("milk", 20);

            var warehouse = new StubIWarehouse()
            {
                HasInventoryStringInt32 = (itemName, quantity) =>
                {
                    return false;
                }
            };

            order.Fill(warehouse);

            Assert.False(order.IsFilled);
        }
    }
}
