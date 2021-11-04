using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;
using PhysicsTest.Components;

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
            if (entity.components.TryGetValue("Aim", out var defaultAim))
            {
                Assert.AreEqual(typeof(Physics.Components.Aim), defaultAim.GetType());
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
