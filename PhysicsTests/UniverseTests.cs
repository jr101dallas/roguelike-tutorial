using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics;

namespace PhysicsTest
{
    [TestClass]
    public class UniverseTests
    {
        [TestMethod]
        public void DefaultUniverseHasZeroEntities()
        {
            var unv = new Universe();
            Assert.AreEqual(0, unv.entities.Count);
        }

        [TestMethod]
        public void DefaultUniverseLastEntityIdIsZero()
        {
            var unv = new Universe();
            Assert.AreEqual(0, unv.LastEntityId());
        }

        [TestMethod]
        public void FirstEntityHasIdOne()
        {
            var unv = new Universe();

            var ent1 = unv.GetEntity();

            Assert.AreEqual(1, ent1.Id);
        } 

        [TestMethod]
        public void FirstEntityAddsToEntitiesCount()
        {
            var unv = new Universe();

            var ent1 = unv.GetEntity();

            Assert.AreEqual(1, unv.entities.Count);
        } 

        [TestMethod]
        public void SecondEntityGivesLastEntityIdTwo()
        {
            var unv = new Universe();

            var ent1 = unv.GetEntity();
            var ent2 = unv.GetEntity();

            Assert.AreEqual(2, unv.LastEntityId());
        } 

        [TestMethod]
        public void FirstEntityRetrivedAfterSecondEntityCreated()
        {
            var unv = new Universe();

            var ent1 = unv.GetEntity();
            var ent2 = unv.GetEntity();
            var entityRetrieved = unv.entities[ent1.Id];

            Assert.AreEqual(ent1, entityRetrieved);
        } 
    }
}
