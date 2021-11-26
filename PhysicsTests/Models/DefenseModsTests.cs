using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Models;

namespace PhysicsTest.Components
{
    [TestClass]
    public class DefenseModsTests
    {
        [TestMethod]
        public void DefaultDefenseModsHasValuesZero()
        {
            var defMod = new DefenseMods();
            Assert.AreEqual(0, defMod.totalAblation);
            Assert.AreEqual(0, defMod.totalArmor);
        }
    }
}
