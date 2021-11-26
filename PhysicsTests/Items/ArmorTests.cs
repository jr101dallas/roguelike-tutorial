using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Items;
using Physics.Interfaces;

namespace PhysicsTest.Components
{
    [TestClass]
    public class ArmorTests
    {
        [TestMethod]
        public void DefaultArmorIsIItem()
        {
            var armor = new Armor();
            Assert.IsTrue(armor is IItem);
        }

        [TestMethod]
        public void DefaultArmorIsIAimMods()
        {
            var armor = new Armor();
            Assert.IsTrue(armor is IDefenseMods);
        }

        [TestMethod]
        public void ArmorTotalAblationIsEight()
        {
            var armor = new Armor();
            var mods = armor.GetDefenseModifiers();
            Assert.AreEqual(8, mods.totalAblation, "Armor totalAblation isn't the expected value.");
        }

        [TestMethod]
        public void ArmorTotalArmorIsEight()
        {
            var armor = new Armor();
            var mods = armor.GetDefenseModifiers();
            Assert.AreEqual(8, mods.totalArmor, "Armor totalArmor isn't the expected value.");
        }
    }
}
