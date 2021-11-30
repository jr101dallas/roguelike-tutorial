using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Components;
using Physics.Interfaces;
using Physics.Items;

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
            Assert.AreEqual(2, inventory.items.Count, "Expected two hardcoded Items in Inventory constructor.");
        }

        [TestMethod]
        public void DefaultInventoryItemOneIsWeapon()
        {
            var inventory = new Inventory();
            var firstItem = inventory.items[1];
            Assert.AreEqual(typeof(Weapon), firstItem.GetType(), "First item wasn't Type Weapon.");
        }
    }
}
