using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Components;
using Physics.Interfaces;

namespace PhysicsTest.Components
{
    [TestClass]
    public class DefenseTests
    {
        [TestMethod]
        public void DefaultDefenseIsIComponent()
        {
            var def = new Defense();
            Assert.IsTrue(def is IComponent);
        }

        [TestMethod]
        public void DefaultDefenseBaseHealthIsFifty()
        {
            var def = new Defense();
            Assert.AreEqual(50, def.BaseHealth);
        }

        [TestMethod]
        public void DefaultDefenseCurrentHealthIsFifty()
        {
            var def = new Defense();
            Assert.AreEqual(50, def.CurrentHealth);
        }
    }
}
