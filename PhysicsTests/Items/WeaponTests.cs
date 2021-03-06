using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Items;
using Physics.Interfaces;

namespace PhysicsTest.Components
{
    [TestClass]
    public class WeaponTests
    {
        [TestMethod]
        public void DefaultWeaponIsIItem()
        {
            var weapon = new Weapon();
            Assert.IsTrue(weapon is IItem);
        }

        [TestMethod]
        public void DefaultWeaponIsIAimMods()
        {
            var weapon = new Weapon();
            Assert.IsTrue(weapon is IOffenseMods);
        }

        [TestMethod]
        public void WeaponBonusAimIsFive()
        {
            var weapon = new Weapon();
            var mods = weapon.GetOffenseModifiers();
            Assert.AreEqual(5, mods.totalAim, "Weapon totalAim isn't the expected value.");
        }

        [TestMethod]
        public void WeaponBonusDamageIsFive()
        {
            var weapon = new Weapon();
            var mods = weapon.GetOffenseModifiers();
            Assert.AreEqual(5, mods.totalDamage, "Weapon totalDamage isn't the expected value.");
        }
    }
}
