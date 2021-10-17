using Microsoft.VisualStudio.TestTools.UnitTesting;
using physics;

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
    }
}
