using System;
using Xunit;
using Codility.Lesson_2.CyclicRotation.Implementations;

namespace Codility.Lesson_2.CyclicRotation
{
    /// <summary>
    /// Used to test solutions for Cyclic rotation assignment.
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// This should return solution that you want to test.
        /// </summary>
        /// <returns></returns>
        private ICyclicRotation GetImplementation()
        {
            return new UsingEnumerable();
        }

        [Fact]
        public void Basic_example_1()
        {
            //Arrange
            var A = new int[] { 3, 8, 9, 7, 6 };
            var K = 3;
            var expected = new int[] { 9, 7, 6, 3, 8 };

            //Act
            var result = GetImplementation().solution(A, K);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Basic_example_2()
        {
            //Arrange
            var A = new int[] { 0, 0, 0 };
            var K = 1;
            var expected = new int[] { 0, 0, 0 };

            //Act
            var result = GetImplementation().solution(A, K);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Basic_example_3()
        {
            //Arrange
            var A = new int[] { 1, 2, 3, 4 };
            var K = 4;
            var expected = new int[] { 1, 2, 3, 4 };

            //Act
            var result = GetImplementation().solution(A, K);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
