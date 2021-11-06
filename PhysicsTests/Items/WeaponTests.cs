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
            Assert.IsTrue(weapon is IAimMods);
        }

        [TestMethod]
        public void WeaponBonusAimIsFive()
        {
            var weapon = new Weapon();
            Assert.AreEqual(5, weapon.GetAimModifiers(), "Weapon BonusAim isn't the expected value.");
        }
    }
}
