using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Codility.Lesson_3.FrogJmp
{
    public class Tests
    {
        /// <summary>
        /// This should return solution that you want to test.
        /// </summary>
        /// <returns></returns>
        private IFrogJmp GetImplementation()
        {
            return new SimpleFrogJmp();
        }

        [Fact]
        public void Basic_example_1()
        {
            //Arrange
            var X = 10;
            var Y = 85;
            var D = 30;

            var expected = 3;

            //Act
            var result = GetImplementation().solution(X, Y, D);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Basic_example_2()
        {
            //Arrange
            var X = 1;
            var Y = 2;
            var D = 500;

            var expected = 1;

            //Act
            var result = GetImplementation().solution(X, Y, D);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Basic_example_3()
        {
            //Arrange
            var X = 1;
            var Y = 1;
            var D = 1;

            var expected = 0;

            //Act
            var result = GetImplementation().solution(X, Y, D);

            //Assert
            Assert.Equal(expected, result);
        }

    }
}
