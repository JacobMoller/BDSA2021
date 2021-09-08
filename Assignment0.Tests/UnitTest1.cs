using System;
using Xunit;
using System.IO;

namespace Assignment0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Is2000ALeapYear_True()
        {
            // Act
            var output = Program.IsLeapYear(2000);

            // Assert
            Assert.True(output);
        }
    }
}
