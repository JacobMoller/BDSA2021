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

        [Fact]
        public void Input1900ToConsole_False(){
            var writer = new StringWriter();
            Console.SetOut(writer);
            var input = new StringReader("1900");
            Console.SetIn(input);

            Program.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("nay", output);
        }
    }
}
