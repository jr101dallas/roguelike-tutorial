using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics.Items;
using Physics.Interfaces;

namespace PhysicsTest.Components
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void DefaultItemIsIItem()
        {
            var item = new Item();
            Assert.IsTrue(item is IItem);
        }
    }
}
