using System;
using Xunit;

namespace GettingStartedTutorials.CSharp.Testing
{
    public class ExtensionMethodsPlusFiveShould
    {
        [Fact]
        public void ReturnFiveMoreThanInput()
        {
            //Arrange
            int input = 10;
            int expectedResult = 15;

            //Act
            int actualResult = input.PlusFive();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}