using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Components;
using Physics.Interfaces;

namespace PhysicsTest.Components
{
    [TestClass]
    public class InventoryTests
    {
        [TestMethod]
        public void DefaultInventoryIsIComponent()
        {
            var inventory = new Inventory();
            Assert.IsTrue(inventory is IComponent);
        }

        [TestMethod]
        public void DefaultInventoryHasOneItem()
        {
            var inventory = new Inventory();
            Assert.AreEqual(1, inventory.items.Count, "Expected a single hardcoded Item in Inventory constructor.");
        }
    }
}
