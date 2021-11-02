using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;
using Physics.Interfaces;

namespace PhysicsTest
{
    [TestClass]
    public class EntityTests
    {
        [TestMethod]
        public void DefaultEntityHasIdZero()
        {
            var entity = new Entity();
            Assert.AreEqual(0, entity.Id);
        }

        [TestMethod]
        public void DefaultEntityHasZeroComponents()
        {
            var entity = new Entity();
            Assert.AreEqual(0, entity.components.Count);
        }

        [TestMethod]
        public void DefaultEntityIsIEntity()
        {
            var component = new Entity();
            Assert.IsTrue(component is IEntity);
        }
    }
}
