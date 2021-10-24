using Microsoft.VisualStudio.TestTools.UnitTesting;
using physics;
using physics.Interfaces;

namespace physics_test
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
        
        // [TestMethod]
        // public void TargetEntityRemovedFromPlay()
        // {
        //     var originEntity = new Entity();
        //     var targetEntity = new Entity();

        //     originEntity.Target(targetEntity);

        //     Assert.IsNull(targetEntity);
        // }
    }
}
