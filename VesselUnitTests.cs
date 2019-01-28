using System;
using Xunit;

namespace internassignment.Tests
{
    using internassignment;
    public class Vessel_Test
    {
        [Fact]
        public void givesCorrectName(){
            var vessel = new Vessel("Vessley Snipes","2001", "198.3");
            Assert.Equal("Vessley Snipes", vessel.GetName);
        }

        [Fact]
        public void TooOldShip(){
            Assert.Throws<OldShipException>(() => new Vessel("HMS Dualog", "1993", "13.37"));
        }

        [Fact]
        public void NotBlankOrNullName(){
            Assert.Throws<ArgumentNullException>(() => new Vessel(null, "2001", "133.7"));
            Assert.Throws<ArgumentNullException>(() => new Vessel("", "2001", "200"));
        }

	
	    [Fact]
        public void correctYearBuilt(){
            var vessel = new Vessel("MS InternShip", "2002", "201");
            Assert.Equal("2002", vessel.GetYearBuilt);
        }

        [Fact]
        public void ToStringPrints()
        {
            string expectedOut = "Vessel: Vessel name: Nemo, Year built: 2001";
            var vessel = new Vessel("Nemo", "2001", "30" );
            Assert.Equal(expectedOut, vessel.ToString());
        }

    }
}
