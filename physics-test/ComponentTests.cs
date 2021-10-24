using Microsoft.VisualStudio.TestTools.UnitTesting;
using physics.Components;
using physics.Interfaces;

namespace physics_test
{
    [TestClass]
    public class ComponentTests
    {
        [TestMethod]
        public void DefaultComponentIsIComponent()
        {
            var component = new Component();
            Assert.IsTrue(component is IComponent);
        }
    }
}
