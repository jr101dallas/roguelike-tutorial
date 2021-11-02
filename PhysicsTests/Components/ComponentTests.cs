using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Components;
using Physics.Interfaces;

namespace PhysicsTest.Components
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
