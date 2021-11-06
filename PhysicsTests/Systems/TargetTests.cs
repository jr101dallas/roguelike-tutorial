using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;
using Physics.Systems;

namespace PhysicsTest
{
    [TestClass]
    public class TargetTests
    {
        [TestMethod]
        public void TargetEntityRemovedFromPlay()
        {
            var rng100 = new Random(100);            
            var unv = new Universe(rng100);
            var originEntity = unv.GetEntity();
            var targetEntity = unv.GetEntity();
            var tEntityId = targetEntity.Id;

            unv.inf.target.TargetEntity(originEntity, targetEntity);

            Assert.IsFalse(unv.entities.TryGetValue(tEntityId, out _), "Targeted Entity still exists.");
        }
    }
}
