using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Components;
using Physics.Interfaces;

namespace PhysicsTest.Components
{
    [TestClass]
    public class OffenseTests
    {
        [TestMethod]
        public void DefaultOffenseIsIComponent()
        {
            var off = new Offense();
            Assert.IsTrue(off is IComponent);
        }

        [TestMethod]
        public void DefaultOffenseBaseAimIsThree()
        {
            var off = new Offense();
            Assert.AreEqual(3, off.BaseAim);
        }

        [TestMethod]
        public void DefaultOffenseBaseDamageIsFive()
        {
            var off = new Offense();
            Assert.AreEqual(5, off.BaseDamage);
        }
    }
}
