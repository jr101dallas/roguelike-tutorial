using Microsoft.VisualStudio.TestTools.UnitTesting;
using physics;
using physics.Systems;

namespace physics_test
{
    [TestClass]
    public class TargetTests
    {
        [TestMethod]
        public void TargetEntityRemovedFromPlay()
        {
            var unv = new Universe();
            var originEntity = unv.GetEntity();
            var targetEntity = unv.GetEntity();
            var tEntityId = targetEntity.Id;

            var target = (Target)unv.systems[nameof(Target)];
            target.TargetEntity(unv, originEntity, targetEntity);

            Assert.IsFalse(unv.entities.TryGetValue(tEntityId, out _));
        }
    }
}
