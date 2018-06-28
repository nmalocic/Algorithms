using Xunit;
using Codility.Lesson_2.OddOccurrencesInArray.Implementations;

namespace Codility.Lesson_2.OddOccurrencesInArray
{
    public class OddOccurencesTests
    {
        /// <summary>
        /// This should return solution that you want to test.
        /// </summary>
        /// <returns></returns>
        private IOddOccurences GetImplementation()
        {
            return new BitwiseXor();
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
