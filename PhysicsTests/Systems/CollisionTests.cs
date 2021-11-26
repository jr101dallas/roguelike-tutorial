using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;
using Physics.Components;
using Physics.Models;
using Physics.Systems;

namespace PhysicsTest
{
    [TestClass]
    public class CollisionTests
    {
        [TestMethod]
        public void TargetEntityNotRemovedFromPlay()
        {
            var unv = new Universe();
            var targetEntity = unv.GetEntity();
            var tEntityId = targetEntity.Id;

            unv.inf.collision.ResolveCollision(new OffenseMods(), targetEntity);

            Assert.IsTrue(unv.entities.TryGetValue(tEntityId, out _), "Targeted Entity unexpectedly removed from play.");
        }

        [TestMethod]
        public void TargetEntityCurrentHealthIs45()
        {
            var ef = new EntityFactory();
            var targetEntity = ef.GetEntity(3);
            var collision = new Collision(new Universe());

            collision.ResolveCollision(new OffenseMods(), targetEntity);

            var defense = (Defense)targetEntity.components[ComponentType.Defense];
            Assert.AreEqual(50, defense.CurrentHealth, "Entity has unexpected CurrentHealth");
        }
    }
}
