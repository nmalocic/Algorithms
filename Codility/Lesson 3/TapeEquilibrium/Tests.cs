using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Codility.Lesson_3.TapeEquilibrium
{
    public class Tests
    {
        /// <summary>
        /// This should return solution that you want to test.
        /// </summary>
        /// <returns></returns>
        private ITapeEquilibrium GetImplementation()
        {
            return new TapeEquilibriumVersionOne();
        }

        [Fact]
        public void Basic_example_1()
        {
            //Arrange
            var A = new int[] { 3, 1, 2, 4, 3 };

            var expected = 1;

            //Act
            var result = GetImplementation().solution(A);

            //Assert
            Assert.Equal(expected, result);
        }

    }
}
