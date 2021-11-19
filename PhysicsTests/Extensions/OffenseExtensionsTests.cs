using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;
using Physics.Components;
using Physics.Models;

namespace PhysicsTest
{
    [TestClass]
    public class OffenseExtensionsTests
    {
        [TestMethod]
        public void ToOffenseModsReturnsOffenseMods()
        {
            var off = new Offense();
            var offMods = off.ToOffenseMods();
            Assert.AreEqual(typeof(OffenseMods), offMods.GetType());
        }

        [TestMethod]
        public void ToOffenseModsKeepsValues()
        {
            var off = new Offense(9, 11);
            var offMods = off.ToOffenseMods();
            Assert.AreEqual(off.BaseAim, offMods.totalAim);
            Assert.AreEqual(off.BaseDamage, offMods.totalDamage);
        }
    }
}
