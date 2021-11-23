using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;
using Physics.Components;
using Physics.Items;
using Physics.Models;

namespace PhysicsTest
{
    [TestClass]
    public class OffenseModsExtensionsTests
    {
        [TestMethod]
        public void AddOffenseModsSumsValues()
        {
            var off1 = new OffenseMods(){totalAim = 18, totalDamage = 11};
            var off2 = new OffenseMods(){totalAim = 12, totalDamage = 9};
            off1.Add(off2);
            Assert.AreEqual(30, off1.totalAim);
            Assert.AreEqual(20, off1.totalDamage);
        }

        [TestMethod]
        public void AddOffenseModsDoesNotChangeRngValue()
        {
            var off1 = new OffenseMods(8);
            var off2 = new OffenseMods(11);
            off1.Add(off2);
            Assert.AreEqual(8, off1.rngValue);
        }

        [TestMethod]
        public void AddItemSumsValues()
        {
            var off1 = new OffenseMods(){totalAim = 18, totalDamage = 11};
            var item = new Weapon();
            off1.Add(item);
            Assert.AreEqual(23, off1.totalAim);
            Assert.AreEqual(16, off1.totalDamage);
        }

        [TestMethod]
        public void AddOffenseSumsValues()
        {
            var off1 = new OffenseMods(){totalAim = 18, totalDamage = 11};
            var offense = new Offense();
            off1.Add(offense);
            Assert.AreEqual(21, off1.totalAim);
            Assert.AreEqual(16, off1.totalDamage);
        }
    }
}
