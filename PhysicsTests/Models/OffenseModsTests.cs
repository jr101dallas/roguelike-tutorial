using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Models;

namespace PhysicsTest.Components
{
    [TestClass]
    public class OffenseModsTests
    {
        [TestMethod]
        public void DefaultOffenseModsHasValuesZero()
        {
            var offMod = new OffenseMods();
            Assert.AreEqual(0, offMod.rngValue);
            Assert.AreEqual(0, offMod.totalAim);
            Assert.AreEqual(0, offMod.totalDamage);
        }

        [TestMethod]
        public void OffenseModsConstructorSetsOnlyRng()
        {
            var offMod = new OffenseMods(86);
            Assert.AreEqual(86, offMod.rngValue);
            Assert.AreEqual(0, offMod.totalAim);
            Assert.AreEqual(0, offMod.totalDamage);
        }

        [TestMethod]
        public void CanNotSetRng()
        {
            var t = typeof(OffenseMods);
            var rngValueFieldInfo = t.GetField("rngValue", BindingFlags.Public | BindingFlags.Instance);

            Assert.IsTrue(rngValueFieldInfo.IsInitOnly);
        }
    }
}
