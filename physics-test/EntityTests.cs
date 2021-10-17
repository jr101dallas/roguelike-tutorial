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
            Assert.AreEqual(entity.Id, 0);
        }

        [TestMethod]
        public void DefaultEntityHasZeroComponents()
        {
            var entity = new Entity();
            Assert.AreEqual(entity.components.Count, 0);
        }
    }
}
