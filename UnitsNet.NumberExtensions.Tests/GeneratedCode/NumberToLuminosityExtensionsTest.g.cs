﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.NumberExtensions.NumberToLuminosity;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToLuminosityExtensionsTests
    {
        [Fact]
        public void NumberToDecawattsTest() =>
            Assert.Equal(Luminosity.FromDecawatts(2), 2.Decawatts());

        [Fact]
        public void NumberToDeciwattsTest() =>
            Assert.Equal(Luminosity.FromDeciwatts(2), 2.Deciwatts());

        [Fact]
        public void NumberToFemtowattsTest() =>
            Assert.Equal(Luminosity.FromFemtowatts(2), 2.Femtowatts());

        [Fact]
        public void NumberToGigawattsTest() =>
            Assert.Equal(Luminosity.FromGigawatts(2), 2.Gigawatts());

        [Fact]
        public void NumberToKilowattsTest() =>
            Assert.Equal(Luminosity.FromKilowatts(2), 2.Kilowatts());

        [Fact]
        public void NumberToMegawattsTest() =>
            Assert.Equal(Luminosity.FromMegawatts(2), 2.Megawatts());

        [Fact]
        public void NumberToMicrowattsTest() =>
            Assert.Equal(Luminosity.FromMicrowatts(2), 2.Microwatts());

        [Fact]
        public void NumberToMilliwattsTest() =>
            Assert.Equal(Luminosity.FromMilliwatts(2), 2.Milliwatts());

        [Fact]
        public void NumberToNanowattsTest() =>
            Assert.Equal(Luminosity.FromNanowatts(2), 2.Nanowatts());

        [Fact]
        public void NumberToPetawattsTest() =>
            Assert.Equal(Luminosity.FromPetawatts(2), 2.Petawatts());

        [Fact]
        public void NumberToPicowattsTest() =>
            Assert.Equal(Luminosity.FromPicowatts(2), 2.Picowatts());

        [Fact]
        public void NumberToSolarLuminositiesTest() =>
            Assert.Equal(Luminosity.FromSolarLuminosities(2), 2.SolarLuminosities());

        [Fact]
        public void NumberToTerawattsTest() =>
            Assert.Equal(Luminosity.FromTerawatts(2), 2.Terawatts());

        [Fact]
        public void NumberToWattsTest() =>
            Assert.Equal(Luminosity.FromWatts(2), 2.Watts());

    }
}
