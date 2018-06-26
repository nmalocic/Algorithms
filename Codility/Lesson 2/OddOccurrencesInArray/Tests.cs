using System;
using Xunit;

namespace Codility.Lesson_2.OddOccurrencesInArray
{
    public class Tests
    {
        /// <summary>
        /// This should return solution that you want to test.
        /// </summary>
        /// <returns></returns>
        private IOddOccurences GetImplementation()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Basic_example_1()
        {
            //Arrange
            var A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            
            var expected = 7;

            //Act
            var result = GetImplementation().solution(A);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
