using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;
using Physics.Components;

namespace PhysicsTest
{
    [TestClass]
    public class EntityFactoryTests
    {
        [TestMethod]
        public void GetEntityZeroGivesIdOne()
        {
            var ef = new EntityFactory();
            var entity = ef.GetEntity(0);
            Assert.AreEqual(1, entity.Id);
        }

        [TestMethod]
        public void GetEntityDefaultsAimComponent()
        {
            var ef = new EntityFactory();
            var entity = ef.GetEntity(0);
            if (entity.components.TryGetValue(ComponentType.Offense, out var defaultAim))
            {
                Assert.AreEqual(typeof(Physics.Components.Offense), defaultAim.GetType());
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetEntityDefaultsInventoryComponent()
        {
            var ef = new EntityFactory();
            var entity = ef.GetEntity(0);
            if (entity.components.TryGetValue(ComponentType.Inventory, out var defaultInventory))
            {
                Assert.AreEqual(typeof(Physics.Components.Inventory), defaultInventory.GetType());
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
