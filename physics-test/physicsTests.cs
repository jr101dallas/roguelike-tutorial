using Microsoft.VisualStudio.TestTools.UnitTesting;
using physics;

namespace physics_test
{
    [TestClass]
    public class EnvironmentSettings
    {
        [TestMethod]
        public void DisplayNameIncludes()
        {
            var physics = new Program();
            var name = physics.GetGameDisplayName();
            Assert.AreEqual("Utopia: The Tutorial", name);
        }
    }
}
