using System;
using Xunit;

namespace Lesson1 {
    public class BinaryGapTest {

        private BinaryGap _binaryGap {get; set;}

        public BinaryGapTest() 
        {
            _binaryGap = new BinaryGap();
        }

        [Fact]
        public void Given_Number_9_Returns_2() 
        {
            int result = _binaryGap.solution(9);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Given_Number_529_Returns_4()
        {
            int result = _binaryGap.solution(529);

            Assert.Equal(4, result);
        }

        [Fact]
        public void Given_Number_20_Returns_1()
        {
            int result = _binaryGap.solution(20);

            Assert.Equal(1, result);
        }

        
        [Fact]
        public void Given_Number_32_Returns_0()
        {
            int result = _binaryGap.solution(32);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Given_Number_2147483647_Returns_0()
        {
            Assert.Equal(0, _binaryGap.solution(2147483647));
        }

        [Fact]
        public void Given_Number_1073741825_Returns_29()
        {
            Assert.Equal(29, _binaryGap.solution(1073741825));
        }
    }
}