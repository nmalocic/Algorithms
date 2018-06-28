using Xunit;
using Codility.Lesson_2.CyclicRotation.Implementations;

namespace Codility.Lesson_2.CyclicRotation
{
    /// <summary>
    /// Used to test solutions for Cyclic rotation assignment.
    /// </summary>
    public class CyclicRotationTests
    {
        [Theory]
        [InlineData(new[] {3, 8, 9, 7, 6}, 3, new[] { 9, 7, 6, 3, 8 })]
        [InlineData(new[] { 0, 0, 0 }, 1, new[] { 0, 0, 0 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
        public void UsingEnumerableTests(int[] inputArray, int offset, int[] expected)
        {
            ICyclicRotation cyclicRotation = new UsingEnumerable();

            //Act
            var result = cyclicRotation.solution(inputArray, offset);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 })]
        [InlineData(new[] { 0, 0, 0 }, 1, new[] { 0, 0, 0 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
        public void UsingLinq(int[] inputArray, int offset, int[] expected)
        {
            ICyclicRotation cyclicRotation = new UsingLinq();

            //Act
            var result = cyclicRotation.solution(inputArray, offset);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 })]
        [InlineData(new[] { 0, 0, 0 }, 1, new[] { 0, 0, 0 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
        public void UsingCalclucaltion(int[] inputArray, int offset, int[] expected)
        {
            ICyclicRotation cyclicRotation = new CalculatingNextIndex();

            //Act
            var result = cyclicRotation.solution(inputArray, offset);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
