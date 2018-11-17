using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine.Models;
using static Engine.Models.Portal;

namespace EngineUnitTests
{
    [TestClass]
    public class PortalUnitTest
    {
        [TestMethod]
        public void TestPortalOppositeSide()
        {
            Assert.AreEqual(GetOpposite(Side.None), Side.None);

            Assert.AreEqual(GetOpposite(Side.North), Side.South);
            Assert.AreEqual(GetOpposite(Side.South), Side.North);

            Assert.AreEqual(GetOpposite(Side.East), Side.West);
            Assert.AreEqual(GetOpposite(Side.West), Side.East);

            Assert.AreEqual(GetOpposite(Side.North & Side.East), Side.South & Side.West);
            Assert.AreEqual(GetOpposite(Side.North & Side.West), Side.South & Side.East);

            Assert.AreEqual(GetOpposite(Side.South & Side.East), Side.North & Side.West);
            Assert.AreEqual(GetOpposite(Side.South & Side.West), Side.North & Side.East);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPortalOppositeSideFailure()
        {
            GetOpposite(Side.North | Side.South);
            GetOpposite(Side.East | Side.West);
        }
    }
}
