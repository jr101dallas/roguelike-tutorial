using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;
using Physics.Components;

namespace PhysicsTest
{
    [TestClass]
    public class EntityExtensionsTests
    {
        [TestMethod]
        public void HasComponentTrueWhenExists()
        {
            var entity = new Entity();
            entity.components.Add(ComponentType.Inventory, new Inventory());
            Assert.IsTrue(entity.HasComponent(ComponentType.Inventory, out _));
        }

        [TestMethod]
        public void HasComponentFalseWhenAbsent()
        {
            var entity = new Entity();
            entity.components.Add(ComponentType.Inventory, new Inventory());
            Assert.IsFalse(entity.HasComponent(ComponentType.Component, out _));
        }
    }
}
