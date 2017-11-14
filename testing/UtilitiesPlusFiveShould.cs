using System;
using Xunit;

namespace GettingStartedTutorials.CSharp.Testing
{
    public class UtilitiesPlusFiveShould
    {
        [Fact]
        public void ReturnFiveMoreThanInput()
        {
            //Arrange
            int input = 10;
            var utils = new Utilities();
            int expectedResult = 15;

            //Act
            int actualResult = utils.PlusFive(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}