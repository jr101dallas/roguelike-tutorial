using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;

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
    }
}
