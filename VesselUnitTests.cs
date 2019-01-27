using System;
using Xunit;

namespace internassignment.Tests
{
    using internassignment;
    public class Vessel
    {
        [Fact]
        public void OldShip()
        {
            Assert.Throws<OldShipException>(() => new Vessel("HMS Dualog", "1993", "13.37"));
        }

        [Fact]
        public void NoBlankName()
        {
            Assert.Throws<ArgumentNullException>(() => new Vessel("", "2001", "200"));
        }

        [Fact]
        public void TestName()
        {
        }

        // [Fact]
        // public void TestName()
        // {
        // }


    }
}
