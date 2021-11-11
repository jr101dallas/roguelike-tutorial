using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;
using Physics.Components;
using Physics.Items;

namespace PhysicsTest
{
    [TestClass]
    public class TargetTests
    {
        [TestMethod]
        public void TargetEntityNotRemovedFromPlay()
        {
            var rng100 = new Random(100);            
            var unv = new Universe(rng100);
            var originEntity = unv.GetEntity();
            var targetEntity = unv.GetEntity();
            var tEntityId = targetEntity.Id;

            unv.inf.target.TargetEntity(originEntity, targetEntity);

            Assert.IsTrue(unv.entities.TryGetValue(tEntityId, out _), "Targeted Entity unexpectedly removed from play.");
        }

        [TestMethod]
        public void TargetEntityCurrentHealthIs45()
        {
            var rng100 = new Random(100);            
            var unv = new Universe(rng100);
            var originEntity = unv.GetEntity();
            var targetEntity = unv.GetEntity();
            var tEntityId = targetEntity.Id;

            unv.inf.target.TargetEntity(originEntity, targetEntity);

            unv.entities.TryGetValue(tEntityId, out var ent);
            var entity = (Entity)ent;
            var defense = (Defense)entity.components[ComponentType.Defense];
            Assert.AreEqual(45, defense.CurrentHealth);
        }

        [TestMethod]
        public void GetAimModifiersSumsAll()
        {         
            var unv = new Universe();
            var inv = new Inventory();
            //inv.items.Add(1, new Weapon()); items[1] default hardcoded to Weapon
            inv.items.Add(2, new Weapon());
            inv.items.Add(3, new Weapon());

            var aimModsTotal = unv.inf.target.GetAimModifiers(inv);

            Assert.AreEqual(15, aimModsTotal, "aimModsTotal not expected value.");
        }
    }
}
