using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;

namespace WarehouseOrdering.Tests
{
    [TestFixture]
    public class OrderRhinoTest
    {
        [Test]
        public void FillingOrderChecksTheWarehouseInventory()
        {
            Order order = new Order("milk", 20);
            IWarehouse warehouse = MockRepository.GenerateMock<IWarehouse>();
            warehouse.Expect(x => x.HasInventory("milk", 20)).Return(false);
            
            order.Fill(warehouse);

            warehouse.VerifyAllExpectations();
        }

        [Test]
        public void FillingOrderRemovesWarehouseItemsWhenSufficientStockIsAvailable()
        {
            Order order = new Order("milk", 20);
            IWarehouse warehouse = MockRepository.GenerateMock<IWarehouse>();
            warehouse.Stub(x => x.HasInventory("milk", 20)).Return(true);

            order.Fill(warehouse);

            warehouse.AssertWasCalled(x => x.Remove("milk", 20));
        }
    }
}
