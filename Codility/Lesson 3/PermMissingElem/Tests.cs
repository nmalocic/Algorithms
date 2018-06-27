using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Codility.Lesson_3.PermMissingElem
{
    public class Tests
    {
        /// <summary>
        /// This should return solution that you want to test.
        /// </summary>
        /// <returns></returns>
        private IPermMissingElem GetImplementation()
        {
            return new CaculateMissing();
        }

        [Fact]
        public void Basic_example_1()
        {
            //Arrange
            var A = new int[] { 2, 3, 1, 5 };

            var expected = 4;

            //Act
            var result = GetImplementation().solution(A);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Basic_example_2()
        {
            //Arrange
            var A = new int[] { 2 };

            var expected = 1;

            //Act
            var result = GetImplementation().solution(A);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Basic_example_3()
        {
            //Arrange
            var A = new int[] { 2, 3, 4, 5, 6, 7, 8, 9 };

            var expected = 1;

            //Act
            var result = GetImplementation().solution(A);

            //Assert
            Assert.Equal(expected, result);
        }



    }
}
