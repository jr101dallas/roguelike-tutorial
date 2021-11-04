using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Components;
using Physics.Interfaces;

namespace PhysicsTest.Components
{
    [TestClass]
    public class AimTests
    {
        [TestMethod]
        public void DefaultAimIsIComponent()
        {
            var aim = new Aim();
            Assert.IsTrue(aim is IComponent);
        }

        [TestMethod]
        public void DefaultAimBaseAimIsFive()
        {
            var aim = new Aim();
            Assert.AreEqual(5, aim.BaseAim);
        }
    }
}
